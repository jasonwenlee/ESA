using ESA.Models.VideoView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            PlayerRow.Height = this.Width * 0.57;

            ResourceVideoSource source = new ResourceVideoSource();
            switch(Device.RuntimePlatform)
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
        }


    }
}