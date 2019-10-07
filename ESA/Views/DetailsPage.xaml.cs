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

        public DetailsPage()
        {
            InitializeComponent();
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
                    // source.Path = "Videos/eye_surgery.mp4";
                    source.Path = "Videos/Brain_Eyes_Vid.mp4";                    
                    break;
                case Device.Android:
                    // source.Path = "eye_surgery.mp4";
                    source.Path = "Brain_Eyes_Vid.mp4";
                    break;
                case Device.UWP:
                    // source.Path = "Videos/eye_surgery.mp4";
                    source.Path = "Videos/Brain_Eyes_Vid.mp4";
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
                content.Clear();
                content.Add(new StepsView());
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
        }
    }
}