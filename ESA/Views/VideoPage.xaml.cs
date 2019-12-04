using ESA.MarkupExtensions;
using ESA.Models.VideoView;
using ESA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPage : ContentPage
    {
        DetailsViewModel procedureViewModel;
        private bool videoControlsVisible = true;

        // Video Controls Fade Timer
        Timer fadeTimer = new Timer();

        public VideoPage(DetailsViewModel dvm)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            procedureViewModel = dvm;
            string videoName = procedureViewModel.VideoName;

            ResourceVideoSource source = new ResourceVideoSource();
            UriVideoSource uriSource = new UriVideoSource();
            uriSource.Uri = procedureViewModel.Procedure.VideoSource;

            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        // source.Path = "Videos/eye_surgery.mp4";
            //        source.Path = "Videos/" + videoName;
            //        break;
            //    case Device.Android:
            //        // source.Path = "eye_surgery.mp4";
            //        source.Path = videoName;
            //        break;
            //    case Device.UWP:
            //        // source.Path = "Videos/eye_surgery.mp4";
            //        source.Path = "Videos/" + videoName;
            //        break;
            //}
            player.Source = uriSource;

            // Fade Timer
            fadeTimer.Interval = 2000;
            fadeTimer.Elapsed += (s, e) =>
            {
                Device.BeginInvokeOnMainThread(() => { VideoControls_Tapped(s, e); });
            };
            fadeTimer.Enabled = true;
            fadeTimer.Start();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (procedureViewModel.VideoIsProcedure)
                player.Position = procedureViewModel.VideoPosition;
            else
                player.Position = TimeSpan.Zero;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (procedureViewModel.VideoIsProcedure)
                procedureViewModel.VideoPosition = player.Position;
        }
        // VIDEO PLAYER
        public async void PlayButtonAnimation(object sender)
        {
            await ((View)sender).FadeTo(0.5, 150, Easing.CubicInOut);
            await ((View)sender).FadeTo(1, 150, Easing.CubicInOut);
        }

        private void PlayPauseButton_Clicked(object sender, EventArgs e)
        {
            ImageButton btn = ((ImageButton)sender);
            PlayButtonAnimation(btn);
            if (player.Status == VideoStatus.Playing)
            {
                player.Pause();
                btn.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.play.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            }
            else if (player.Status == VideoStatus.Paused)
            {
                player.Play();
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

        private void StepForwardButton_Clicked(object sender, EventArgs e)
        {
            player.Position = player.Position.Add(TimeSpan.FromSeconds(10));

            ResetFadeTimer();
        }

        private void StepBackwardsButton_Clicked(object sender, EventArgs e)
        {
            player.Position = player.Position.Add(TimeSpan.FromSeconds(-10));

            ResetFadeTimer();
        }

        private void VideoSlider_DragStarted(object sender, EventArgs e)
        {
            player.Pause();
            playPauseButton.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.play.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            ResetFadeTimer();
        }

        private void VideoSlider_DragCompleted(object sender, EventArgs e)
        {
            player.Play();
            playPauseButton.Source = ImageSource.FromResource("ESA.Resources.VideoPlayer.pause.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            ResetFadeTimer();
        }

        private void EnlargeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
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
            //backButton.IsEnabled = videoControlsVisible;
            //ShareButton.IsEnabled = VideoControlsVisible;
            //FavouriteButton.IsEnabled = VideoControlsVisible;
            //collapseButton.IsEnabled = videoControlsVisible;
            stepBackwardsButton.IsEnabled = videoControlsVisible;
            playPauseButton.IsEnabled = videoControlsVisible;
            stepForwardButton.IsEnabled = videoControlsVisible;
            videoSlider.IsEnabled = videoControlsVisible;
            enlargeButton.IsEnabled = videoControlsVisible;
        }
    }
}