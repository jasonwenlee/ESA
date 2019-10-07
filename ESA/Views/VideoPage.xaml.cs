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
    public partial class VideoPage : ContentPage
    {
        public VideoPage()
        {
            InitializeComponent();

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
        }
    }
}