using ESA.MarkupExtensions;
using ESA.Models;
using ESA.Models.VideoView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        // Don't remove :)
        //Procedure holdProcedure;
        bool VideoControlsVisible = false;
        bool ControlsAreCollapsed = false;

        public DetailsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            //Device.StartTimer(TimeSpan.FromMilliseconds(2000), () =>
            //{
            //    //UpdateStatus?.Invoke(this, EventArgs.Empty);
            //    //return true;
            //});

            StepsView view = new StepsView();
            view.LoadStepsView();
            contentRow.Children.Clear();
            contentRow.Children.Add(view);

            // Don't remove :)
            //holdProcedure = proc;
        }

        private void StepPage_Instance_Appearing(object sender, EventArgs e)
        {
            base.OnAppearing();

            // Video Player
            videoPlayerRow.Height = this.Width * 0.57;

            ResourceVideoSource source = new ResourceVideoSource();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    source.Path = "Videos/eye_surgery.mp4";
                    //source.Path = "Videos/Brain_Eyes_Vid.mp4";                    
                    break;
                case Device.Android:
                    source.Path = "eye_surgery.mp4";
                    //source.Path = "Brain_Eyes_Vid.mp4";
                    break;
                case Device.UWP:
                    source.Path = "Videos/eye_surgery.mp4";
                    //source.Path = "Videos/Brain_Eyes_Vid.mp4";
                    break;
            }

            videoPlayer.Source = source;

            contentRow.Children.Add(new StepsView());
        }

        private void StepsBtn_Clicked(object sender, EventArgs e)
        {
            IList<View> content = contentRow.Children;
            if (!(content.First() == null || content.First() is StepsView))
            {
                refreshIcons("step", content.First().GetType().Name);
                StepsView view = new StepsView();
                view.LoadStepsView();
                content.Clear();
                content.Add(view);
                AdjustViews(sender);
            }
        }

        private void KeyPointsBtn_Clicked(object sender, EventArgs e)
        {
            IList<View> content = contentRow.Children;
            if (!(content.First() == null || content.First() is KeyPointsView))
            {
                refreshIcons("keyp", content.First().GetType().Name);
                content.Clear();
                content.Add(new KeyPointsView());
                AdjustViews(sender);
            }
        }

        private void VariationsBtn_Clicked(object sender, EventArgs e)
        {
            IList<View> content = contentRow.Children;
            if (!(content.First() == null || content.First() is VariationsView))
            {
                refreshIcons("vari", content.First().GetType().Name);
                content.Clear();
                content.Add(new VariationsView());
                AdjustViews(sender);
            }
        }

        private void ComplicationsBtn_Clicked(object sender, EventArgs e)
        {
            IList<View> content = contentRow.Children;
            if (!(content.First() == null || content.First() is ComplicationsView))
            {
                refreshIcons("comp", content.First().GetType().Name);
                content.Clear();
                content.Add(new ComplicationsView());
                AdjustViews(sender);
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
                content.Add(new InfoView());
                AdjustViews(sender);
            }
        }

        private void refreshIcons(string page, string prevView)
        {
            switch (prevView)
            {
                case "StepsView":
                    StepsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.steps_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    StepsLbl.TextColor = Color.Gray;
                    break;
                case "KeyPointsView":
                    KeyPointsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.keypoints_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    KeyPointsLbl.TextColor = Color.Gray;
                    break;
                case "VariationsView":
                    VariationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.variations_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    VariationsLbl.TextColor = Color.Gray;
                    break;
                case "ComplicationsView":
                    ComplicationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.complications_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    ComplicationsLbl.TextColor = Color.Gray;
                    break;
                case "InfoView":
                    InfoBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.info_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    InfoLbl.TextColor = Color.Gray;
                    break;
            }

            switch (page)
            {
                case "step":
                    StepsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.steps_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    StepsLbl.TextColor = Color.FromHex("#3399FF");
                    break;
                case "keyp":
                    KeyPointsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.keypoints_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    KeyPointsLbl.TextColor = Color.FromHex("#3399FF");
                    break;
                case "vari":
                    VariationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.variations_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    VariationsLbl.TextColor = Color.FromHex("#3399FF");
                    break;
                case "comp":
                    ComplicationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.complications_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    ComplicationsLbl.TextColor = Color.FromHex("#3399FF");
                    break;
                case "info":
                    InfoBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.book_icon_light_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    InfoLbl.TextColor = Color.FromHex("#3399FF");
                    break;
            }
        }

        private async void AdjustViews(object sender)
        {
            uint animationSpeed = 1000;
            double collapsableHeight = 42;
            double videoDeltaY = (-videoPlayer.Height);
            double videoAspectHeight = Width * 0.57;


            PlayButtonAnimation(sender);
            if (!ControlsAreCollapsed) // Keep Expanded
            {
                //Collapsable
                collapsablePlayer.IsVisible = false;

            }
            else // Keep Collapsed
            {
                Rectangle videoCollapsedLocation = new Rectangle(collapsableHeight, 0, collapsableHeight * 1.77778, collapsableHeight);
                videoPlayer.LayoutTo(videoCollapsedLocation, animationSpeed, Easing.Linear);
                VideoControls.FadeTo(0, animationSpeed, Easing.Linear);
                VideoControls.TranslateTo(0, -videoAspectHeight, animationSpeed, Easing.Linear);
                // Video Player

                // Scroll View
                Rectangle scrollViewCollapseLocation = new Rectangle(scrollView.X, collapsableHeight, scrollView.Width, scrollView.Height + (videoAspectHeight - collapsableHeight));
                scrollView.LayoutTo(scrollViewCollapseLocation, animationSpeed, Easing.Linear);
                //Collapsable
                collapsablePlayer.IsVisible = true;
                collapsablePlayer.HeightRequest = collapsableHeight;
                collapsablePlayer.FadeTo(0, 0, null);
                await collapsablePlayer.FadeTo(1, animationSpeed, Easing.Linear);
                ControlsAreCollapsed = true;
                // Video Player

            }
        }

        private void Back_Button_Clicked(object sender, EventArgs e)
        {
            PlayButtonAnimation(sender);
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            PlayButtonAnimation(sender);
            await Navigation.PopAsync();
        }

        private void ShareButton_Clicked(object sender, EventArgs e)
        {
            PlayButtonAnimation(sender);
        }

        private void FavouriteButton_Clicked(object sender, EventArgs e)
        {
            PlayButtonAnimation(sender);
        }

        private async void CollapseButton_Clicked(object sender, EventArgs e)
        {
            uint animationSpeed = 500;
            double newControlHeight = 42;
            double videoDeltaY = (-videoPlayer.Height);
            double videoAspectHeight = Width * 0.57;
            Rectangle scrollViewCollapseLocation = new Rectangle(scrollView.X, newControlHeight, scrollView.Width, scrollView.Height + (videoPlayer.Height - newControlHeight));
            Rectangle videoCollapsedLocation = new Rectangle(newControlHeight, 0, newControlHeight * 1.77778, newControlHeight);

            PlayButtonAnimation(sender);
            if (ControlsAreCollapsed) // Expand
            {
                // Video Player

                Rectangle videoExpandLocation = new Rectangle(0, 0, Width, videoAspectHeight);
                videoPlayer.LayoutTo(videoExpandLocation, animationSpeed, Easing.Linear);
                VideoControls.FadeTo(1, animationSpeed, Easing.Linear);
                VideoControls.TranslateTo(0, 0, animationSpeed, Easing.Linear);
                //Collapsable
                collapsablePlayer.IsVisible = false;
                collapsablePlayer.FadeTo(0, animationSpeed, Easing.Linear);
                ControlsAreCollapsed = false;
                // Scroll View
                Rectangle scrollViewExpandLocation = new Rectangle(scrollView.X, videoAspectHeight, scrollView.Width, scrollView.Height - videoAspectHeight + newControlHeight);
                await scrollView.LayoutTo(scrollViewExpandLocation, animationSpeed, Easing.Linear);

            }
            else // Collapse
            {
                // Scroll View
                scrollView.LayoutTo(scrollViewCollapseLocation, animationSpeed, Easing.Linear);
                //Collapsable
                collapsablePlayer.IsVisible = true;
                collapsablePlayer.HeightRequest = newControlHeight;
                collapsablePlayer.FadeTo(0, 0, null);
                collapsablePlayer.FadeTo(1, animationSpeed, Easing.Linear);
                ControlsAreCollapsed = true;
                // Video Player
                videoPlayer.LayoutTo(videoCollapsedLocation, animationSpeed, Easing.Linear);
                VideoControls.FadeTo(0, animationSpeed, Easing.Linear);
                await VideoControls.TranslateTo(0, videoDeltaY, animationSpeed, Easing.Linear);
            }
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

        }

        private void StepForwardButton_Clicked(object sender, EventArgs e)
        {
            videoPlayer.Position = videoPlayer.Position.Add(TimeSpan.FromSeconds(10));
        }

        private void StepBackwardsButton_Clicked(object sender, EventArgs e)
        {
            videoPlayer.Position = videoPlayer.Position.Add(TimeSpan.FromSeconds(-10));
        }

        private void VideoSlider_DragStarted(object sender, EventArgs e)
        {
            videoPlayer.Pause();
            PlayPauseButton.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.play.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
        }

        private void VideoSlider_DragCompleted(object sender, EventArgs e)
        {
            videoPlayer.Play();
            PlayPauseButton.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.pause.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
        }

        private void EnlargeButton_Clicked(object sender, EventArgs e)
        {
            videoPlayer.IsVisible = false;
            VideoControls.TranslateTo(0, ((videoPlayer.Height) - 42), 0, null);
            scrollView.IsVisible = false;

            videoPlayer.IsVisible = true;
            VideoControls.IsVisible = true;
            scrollView.IsVisible = true;
        }

        private async void VideoControls_Tapped(object sender, EventArgs e)
        {
            if (VideoControlsVisible)
            {
                await VideoControls.FadeTo(0, 500, Easing.Linear);
                VideoControlsVisible = false;
                SetVideoButtons();
            }
            else
            {
                await VideoControls.FadeTo(100, 0, Easing.Linear);
                VideoControlsVisible = true;
                SetVideoButtons();
            }
        }
        private void VideoPlayer_Tapped(object sender, EventArgs e)
        {
            VideoControls.IsVisible = true;
            VideoControlsVisible = true;
        }

        public void SetVideoButtons()
        {
            BackButton.IsEnabled = VideoControlsVisible;
            ShareButton.IsEnabled = VideoControlsVisible;
            FavouriteButton.IsEnabled = VideoControlsVisible;
            CollapseButton.IsEnabled = VideoControlsVisible;
            StepBackwardsButton.IsEnabled = VideoControlsVisible;
            PlayPauseButton.IsEnabled = VideoControlsVisible;
            StepForwardButton.IsEnabled = VideoControlsVisible;
            VideoSlider.IsEnabled = VideoControlsVisible;
            EnlargeButton.IsEnabled = VideoControlsVisible;
        }
        public async void PlayButtonAnimation(object sender)
        {
            await ((View)sender).FadeTo(0.5, 150, Easing.CubicInOut);
            await ((View)sender).FadeTo(1, 150, Easing.CubicInOut);
        }
    }
}