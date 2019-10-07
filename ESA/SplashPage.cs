using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms; // REC: Needed for extending as a ContentPage


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
                Source = "sqEye.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);
            this.BackgroundColor = Color.FromHex("#429de3");
            this.Content = sub;
        }

        // REC: Below method used to scale image and also Navigating to Main Page after it is loaded.
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            await splashImage.ScaleTo(1.5, 1000); // REC: Setting up the initial size of the Icon. 
            await splashImage.ScaleTo(0.8, 1000, Easing.Linear); // REC: Animation effect: reducing image
            await splashImage.ScaleTo(3.5, 1000, Easing.Linear); // REC: Animation effect: augmenting image

            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
