using ESA.MarkupExtensions;
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
        public DetailsPage()
        {
            InitializeComponent();
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
                    break;
                case Device.Android:
                    source.Path = "eye_surgery.mp4";
                    break;
                case Device.UWP:
                    source.Path = "Videos/eye_surgery.mp4";
                    break;
            }

            videoPlayer.Source = source;

            contentRow.Children.Add(new StepsView());
        }

        private void StepsBtn_Clicked(object sender, EventArgs e)
        {
            if (!(contentRow.Children.First() == null || contentRow.Children.First() is StepsView))
            {
                contentRow.Children.Clear();
                contentRow.Children.Add(new StepsView());
                refreshIcons("steps");
            }
        }

        private void KeyPointsBtn_Clicked(object sender, EventArgs e)
        {
            if (!(contentRow.Children.First() == null || contentRow.Children.First() is KeyPointsView))
            {
                contentRow.Children.Clear();
                contentRow.Children.Add(new KeyPointsView());
                refreshIcons("keyp");
            }
        }

        private void VariationsBtn_Clicked(object sender, EventArgs e)
        {
            if (!(contentRow.Children.First() == null || contentRow.Children.First() is VariationsView))
            {
                contentRow.Children.Clear();
                contentRow.Children.Add(new VariationsView());
                refreshIcons("vari");
            }
        }

        private void ComplicationsBtn_Clicked(object sender, EventArgs e)
        {
            if (!(contentRow.Children.First() == null || contentRow.Children.First() is ComplicationsView))
            {
                contentRow.Children.Clear();
                contentRow.Children.Add(new ComplicationsView());
                refreshIcons("comp");
            }
        }

        private void InfoBtn_Clicked(object sender, EventArgs e)
        {
            if (!(contentRow.Children.First() == null || contentRow.Children.First() is InfoView))
            {
                contentRow.Children.Clear();
                contentRow.Children.Add(new InfoView());
                refreshIcons("info");
            }
        }

        // Definetly no the best way to do this but for no it gets the point across
        private void refreshIcons(string page)
        {
            StepsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.steps_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            StepsLbl.TextColor = Color.Gray;
            KeyPointsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.keypoints_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            KeyPointsLbl.TextColor = Color.Gray;
            VariationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.variations_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            VariationsLbl.TextColor = Color.Gray;
            ComplicationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.complications_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            ComplicationsLbl.TextColor = Color.Gray;
            InfoBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.info_icon.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            InfoLbl.TextColor = Color.Gray;

            switch (page)
            {
                case "steps":
                    StepsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.steps_icon_dark_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    StepsLbl.TextColor = Color.White;
                    break;
                case "keyp":
                    KeyPointsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.keypoints_icon_dark_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    KeyPointsLbl.TextColor = Color.White;
                    break;
                case "vari":
                    VariationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.variations_icon_dark_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    VariationsLbl.TextColor = Color.White;
                    break;
                case "comp":
                    ComplicationsBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.complications_icon_dark_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    ComplicationsLbl.TextColor = Color.White;
                    break;
                case "info":
                    InfoBtn.Source = ImageSource.FromResource("ESA.Resources.Icons.info_icon_dark_active.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                    InfoLbl.TextColor = Color.White;
                    break;
            }

            StepsBtn.HeightRequest = 35;
            KeyPointsBtn.HeightRequest = 35;
            VariationsBtn.HeightRequest = 35;
            ComplicationsBtn.HeightRequest = 35;
            InfoBtn.HeightRequest = 35;

        }
    }
}