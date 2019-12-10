using System;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {

        private bool videoControlsVisible = true;
        // Video Controls Fade Timer
        Timer fadeTimer = new Timer();

        public ImagePage(ImageSource imageSource)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            image.Source = imageSource;

            // Fade Timer
            fadeTimer.Interval = 2000;
            fadeTimer.Elapsed += (s, e) =>
            {
                Device.BeginInvokeOnMainThread(() => { VideoControls_Tapped(s, e); });
            };
            fadeTimer.Enabled = true;
            fadeTimer.Start();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            image.WidthRequest = width;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            PlayButtonAnimation(sender);
            await Navigation.PopAsync();
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
        }

        public async void PlayButtonAnimation(object sender)
        {
            await ((View)sender).FadeTo(0.5, 150, Easing.CubicInOut);
            await ((View)sender).FadeTo(1, 150, Easing.CubicInOut);
        }
    }
}