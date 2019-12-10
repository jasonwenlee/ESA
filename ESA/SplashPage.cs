using Xamarin.Forms; // REC: Neede for extending as a ContentPage


// REC: Reference: https://www.youtube.com/watch?v=y8ce7OyAgYU

namespace ESA
{
    class SplashPage : ContentPage
    {
        Image splashImage;

        // Constructor: Definig the Page's Layout.  
        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false); // REC: To keep the Navigation Bar Hidden.

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                //Source = "sqEye.png", // REC: Substitution of original "squared" eye.
                Source = "circeye_v3.png", // REC: Circular eye
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            // AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);
            // this.BackgroundColor = Color.FromHex("#429de3"); //Original blue color.
            this.BackgroundColor = Color.FromHex("#000000"); // Black color requested by Valerie.
            this.Content = sub;
        }

        // REC: Below method used to scale image and also Navigating to Main Page after it is loaded.
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1.0, 800); // REC: Setting up the initial eye image (size,time 1000 = 1 sec). 
            // await splashImage.ScaleTo(0.8, 200, Easing.Linear); // REC: Animation effect: reducing image. Eliminated to avoid "bouncing".
            await splashImage.ScaleTo(2.5, 1000, Easing.CubicInOut); // REC: final state (size,time). CubicInOut = Natural looking choice. 
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
