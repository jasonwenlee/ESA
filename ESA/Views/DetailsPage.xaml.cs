using ESA.MarkupExtensions;
using ESA.Models;
using ESA.Models.VideoView;
using ESA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//ios
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        // Don't remove :)
        //Procedure holdProcedure;

        // ProcedureViewModel
        ProcedureViewModel procedureViewModel;

        // Video Control bools
        private bool videoControlsVisible = true;
        private bool controlsAreCollapsed = false;

        // Video Controls Fade Timer
        Timer fadeTimer = new Timer();

        // Video Player Animation Variables
        double collapsableHeight;
        double playerHeight;
        Rectangle playerExpandLocation;
        Rectangle scrollViewExpandLocation;
        Rectangle scrollViewCollapseLocation;
        Rectangle playerCollapseLocation;

        public DetailsPage(int id)
        {
            //ios
            if (Device.RuntimePlatform == Device.iOS)
            {
                var safeInsets = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
                safeInsets.Top = 24;
            }
            

            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            // View Models
            procedureViewModel = new ProcedureViewModel(id);
            BindingContext = procedureViewModel;

            // Fade Timer
            fadeTimer.Interval = 2000;
            fadeTimer.Elapsed += (s, e) =>
            {
                Device.BeginInvokeOnMainThread(() => { VideoControls_Tapped(s, e); });
            };
            fadeTimer.Enabled = true;
            fadeTimer.Start();

            // Content Row
            StepsView view = new StepsView(procedureViewModel);
            contentRow.Children.Clear();
            contentRow.Children.Add(view);
            contentRow.LayoutChanged += (s, e) =>
            {
                UpdateVideoPlayerLayout();
            };
            // Don't remove :)
            //holdProcedure = proc;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            ResourceVideoSource source = new ResourceVideoSource();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    source.Path = "Videos/" + procedureViewModel.Procedure.VideoSource;
                    //source.Path = "Videos/Brain_Eyes_Vid.mp4";                    
                    break;
                case Device.Android:
                    source.Path = procedureViewModel.Procedure.VideoSource;
                    //source.Path = "Brain_Eyes_Vid.mp4";
                    break;
                case Device.UWP:
                    source.Path = "Videos/" + procedureViewModel.Procedure.VideoSource;
                    //source.Path = "Videos/Brain_Eyes_Vid.mp4";
                    break;
            }

            videoPlayer.Source = source;

            videoPlayer.Play();
            videoPlayer.Position = procedureViewModel.VideoPosition;
            playPauseButton.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.pause.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            procedureViewModel.VideoPosition = videoPlayer.Position;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            // Video Player
            videoPlayerRow.Height = this.Width * 0.57;
            UpdatePlayPauseButton();

            // Video Player Animation Variables
            collapsableHeight = 42;
            playerHeight = Width * 0.57;
            playerExpandLocation = new Rectangle(0, 0, Width, playerHeight);
            scrollViewExpandLocation = new Rectangle(scrollView.X, playerHeight, scrollView.Width, Height - playerHeight- footer.Height);
            scrollViewCollapseLocation = new Rectangle(scrollView.X, collapsableHeight, scrollView.Width, scrollView.Height + (videoPlayer.Height - collapsableHeight));
            playerCollapseLocation = new Rectangle(collapsableHeight, 0, collapsableHeight * 1.77778, collapsableHeight);
        }

        public async void AdjustViews()
        {
            uint animationSpeed = 500;

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            if (!controlsAreCollapsed) // Keep Expanded
            {
                //Collapsable
                collapsablePlayer.IsVisible = false;

            }
            else // Keep Collapsed
            {
                // Video Player
                videoPlayer.LayoutTo(playerCollapseLocation, animationSpeed, Easing.Linear);
                // Controls
                videoControls.FadeTo(0, animationSpeed, Easing.Linear);
                videoControls.TranslateTo(0, (-videoPlayer.Height), animationSpeed, Easing.Linear);
                videoControls.IsVisible = false;
                // Scroll View
                scrollView.LayoutTo(scrollViewCollapseLocation, animationSpeed, Easing.Linear);
                //Collapsable
                collapsablePlayer.IsVisible = true;
                collapsablePlayer.HeightRequest = collapsableHeight;
                collapsablePlayer.FadeTo(0, 0, null);
                await collapsablePlayer.FadeTo(1, animationSpeed, Easing.Linear);
            }
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }


        private void UpdateVideoPlayerLayout()
        {
            if (controlsAreCollapsed)
            {
                // Video player
                videoPlayer.Layout(playerCollapseLocation);
                // Controls
                videoControls.TranslationY = -playerHeight;
                // Scroll view
                scrollView.Layout(scrollViewCollapseLocation);
                // Collapsable
                collapsablePlayer.IsVisible = true;
            }
            else
            {
                // Collapsable
                collapsablePlayer.IsVisible = false;
                // Video player
                videoPlayer.Layout(playerExpandLocation);
                // Controls
                videoControls.TranslationY = 0;
                // Scroll view
                scrollView.Layout(scrollViewExpandLocation);
            }
        }

        private void playerCollapse()
        {
            // Scroll View
            scrollView.LayoutTo(scrollViewCollapseLocation, 500, Easing.Linear);
            //Collapsable
            collapsablePlayer.IsVisible = true;
            collapsablePlayer.HeightRequest = collapsableHeight;
            collapsablePlayer.FadeTo(0, 0, null);
            collapsablePlayer.FadeTo(1, 500, Easing.Linear);
            controlsAreCollapsed = true;
            // Video Player
            videoPlayer.LayoutTo(playerCollapseLocation, 500, Easing.Linear);
            // controls
            videoControls.FadeTo(0, 500, Easing.Linear);
            videoControls.TranslateTo(0, (-videoPlayer.Height), 500, Easing.Linear);
            scrollView.Layout(scrollViewCollapseLocation);

        }

        private void playerExpand()
        {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            // Video Player
            videoPlayer.IsVisible = true;
            videoPlayer.LayoutTo(playerExpandLocation, 500, Easing.Linear);
            // Video Controls
            videoControls.FadeTo(1, 500, Easing.Linear);
            videoControls.TranslateTo(0, 0, 500, Easing.Linear);
            videoControls.IsVisible = true;
            //Collapsable
            collapsablePlayer.IsVisible = false;
            collapsablePlayer.FadeTo(0, 500, Easing.Linear);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            controlsAreCollapsed = false;
            // Scroll View

            scrollView.LayoutTo(scrollViewExpandLocation, 500, Easing.Linear);
            scrollView.Layout(scrollViewExpandLocation);
            // Set Video Player new position

        }
        public async void PlayButtonAnimation(object sender)
        {
            await ((View)sender).FadeTo(0.5, 150, Easing.CubicInOut);
            await ((View)sender).FadeTo(1, 150, Easing.CubicInOut);
        }

        private void PlayPauseButton_Clicked(object sender, EventArgs e)
        {
            ImageButton btn = ((ImageButton)sender);
            PlayButtonAnimation(btn);
            if (videoPlayer.Status == VideoStatus.Playing)
            {
                videoPlayer.Pause();
                btn.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.play.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            }
            else if (videoPlayer.Status == VideoStatus.Paused)
            {
                videoPlayer.Play();
                btn.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.pause.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            }

            ResetFadeTimer();
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            PlayButtonAnimation(sender);
            await Navigation.PopAsync();
        }

        //private void ShareButton_Clicked(object sender, EventArgs e)
        //{
        //    PlayButtonAnimation(sender);

        //ResetFadeTimer();
        //}

        //private void FavouriteButton_Clicked(object sender, EventArgs e)
        //{
        //    PlayButtonAnimation(sender);

        //ResetFadeTimer();
        //}

        private void CollapseButton_Clicked(object sender, EventArgs e)
        {
            PlayButtonAnimation(sender);
            if (controlsAreCollapsed)
            {
                playerExpand();

            }
            else
            {
                playerCollapse();
            }

            UpdatePlayPauseButton();
            ResetFadeTimer();
        }

        private void StepForwardButton_Clicked(object sender, EventArgs e)
        {
            videoPlayer.Position = videoPlayer.Position.Add(TimeSpan.FromSeconds(10));

            ResetFadeTimer();
        }

        private void StepBackwardsButton_Clicked(object sender, EventArgs e)
        {
            videoPlayer.Position = videoPlayer.Position.Add(TimeSpan.FromSeconds(-10));

            ResetFadeTimer();
        }

        private void VideoSlider_DragStarted(object sender, EventArgs e)
        {
            videoPlayer.Pause();
            playPauseButton.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.play.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            ResetFadeTimer();
        }

        private void VideoSlider_DragCompleted(object sender, EventArgs e)
        {
            videoPlayer.Play();
            playPauseButton.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.pause.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            ResetFadeTimer();
        }

        private void EnlargeButton_Clicked(object sender, EventArgs e)
        {
            // TODO: remove detailViewModel
            videoPlayer.Stop();
            procedureViewModel.VideoPosition = videoPlayer.Position;
            procedureViewModel.VideoIsProcedure = true;
            procedureViewModel.VideoName = procedureViewModel.Procedure.VideoSource;
            Navigation.PushAsync(new VideoPage(procedureViewModel));
        }

        private async void VideoControls_Tapped(object sender, EventArgs e)
        {
            if (videoControlsVisible)
            {
                await videoControls.FadeTo(0, 500, Easing.Linear);
                videoControlsVisible = false;
                UpdateVideoControls();

                fadeTimer.Stop();
            }
            else
            {
                await videoControls.FadeTo(100, 0, Easing.Linear);
                videoControlsVisible = true;
                UpdateVideoControls();

                fadeTimer.Start();
            }

        }

        private void ResetFadeTimer()
        {
            fadeTimer.Stop();
            fadeTimer.Start();
        }

        public void UpdateVideoControls()
        {
            backButton.IsEnabled = videoControlsVisible;
            //ShareButton.IsEnabled = VideoControlsVisible;
            //FavouriteButton.IsEnabled = VideoControlsVisible;
            collapseButton.IsEnabled = videoControlsVisible;
            stepBackwardsButton.IsEnabled = videoControlsVisible;
            playPauseButton.IsEnabled = videoControlsVisible;
            stepForwardButton.IsEnabled = videoControlsVisible;
            videoSlider.IsEnabled = videoControlsVisible;
            enlargeButton.IsEnabled = videoControlsVisible;
        }
        private void UpdatePlayPauseButton()
        {
            ImageButton playButton;
            // Select the right play/pause button
            if (controlsAreCollapsed)
                playButton = playPauseCollapsedButton;
            else
                playButton = playPauseButton;
            // Select the right image
            if (videoPlayer.Status == VideoStatus.Paused)
                playButton.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.play.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            else
                playButton.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.pause.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);


        }
        // FOOTER

        /**
         * FooterBtn_Clicked
         * Description: Method updates icons and interchanges the current view with the selected view.
         */
        private void StepsBtn_Clicked(object sender, EventArgs e)
        {
            IList<View> content = contentRow.Children;
            if (!(content.First() == null || content.First() is StepsView))
            {
                refreshIcons("step", content.First().GetType().Name);
                content.Clear();
                content.Add(new StepsView(procedureViewModel));

                PlayButtonAnimation(sender);
                AdjustViews();
            }
        }

        private void KeyPointsBtn_Clicked(object sender, EventArgs e)
        {
            IList<View> content = contentRow.Children;
            if (!(content.First() == null || content.First() is KeyPointsView))
            {
                refreshIcons("keyp", content.First().GetType().Name);
                content.Clear();
                content.Add(new KeyPointsView(procedureViewModel));

                PlayButtonAnimation(sender);
                AdjustViews();
            }
        }

        private void VariationsBtn_Clicked(object sender, EventArgs e)
        {
            IList<View> content = contentRow.Children;
            if (!(content.First() == null || content.First() is VariationsView))
            {
                refreshIcons("vari", content.First().GetType().Name);
                content.Clear();
                content.Add(new VariationsView(procedureViewModel));

                PlayButtonAnimation(sender);
                AdjustViews();
            }
        }

        private void ComplicationsBtn_Clicked(object sender, EventArgs e)
        {
            IList<View> content = contentRow.Children;
            if (!(content.First() == null || content.First() is ComplicationsView))
            {
                refreshIcons("comp", content.First().GetType().Name);
                content.Clear();
                content.Add(new ComplicationsView(procedureViewModel));

                PlayButtonAnimation(sender);
                AdjustViews();
                playerCollapse();
            }
        }

        private void InfoBtn_Clicked(object sender, EventArgs e)
        {
            IList<View> content = contentRow.Children;
            if (!(content.First() == null || content.First() is InfoView))
            {
                refreshIcons("info", content.First().GetType().Name);
                content.Clear();
                // Don't remove :)
                //contentRow.Children.Add(new InfoView(holdProcedure));
                content.Add(new InfoView(procedureViewModel));

                PlayButtonAnimation(sender);
                AdjustViews();
                playerCollapse();
            }
        }

        private void refreshIcons(string page, string prevView)
        {
            switch (prevView)
            {
                case "StepsView":
                    stepsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.steps_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    stepsLbl.TextColor = Color.Gray;
                    break;
                case "KeyPointsView":
                    keyPointsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.keypoints_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    keyPointsLbl.TextColor = Color.Gray;
                    break;
                case "VariationsView":
                    variationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.variations_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    VariationsLbl.TextColor = Color.Gray;
                    break;
                case "ComplicationsView":
                    complicationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.complications_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    complicationsLbl.TextColor = Color.Gray;
                    break;
                case "InfoView":
                    infoBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.info_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    infoLbl.TextColor = Color.Gray;
                    break;
            }

            switch (page)
            {
                case "step":
                    stepsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.steps_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    stepsLbl.TextColor = Color.FromHex("#3399FF");
                    break;
                case "keyp":
                    keyPointsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.keypoints_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    keyPointsLbl.TextColor = Color.FromHex("#3399FF");
                    break;
                case "vari":
                    variationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.variations_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    VariationsLbl.TextColor = Color.FromHex("#3399FF");
                    break;
                case "comp":
                    complicationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.complications_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    complicationsLbl.TextColor = Color.FromHex("#3399FF");
                    break;
                case "info":
                    infoBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.book_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    infoLbl.TextColor = Color.FromHex("#3399FF");
                    break;
            }
        }
    }
}