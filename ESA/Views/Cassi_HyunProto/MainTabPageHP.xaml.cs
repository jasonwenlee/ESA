using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace ESA.Views.Cassi_HyunProto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabPageHP : Xamarin.Forms.TabbedPage
    {
        public MainTabPageHP()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(value: ToolbarPlacement.Bottom);
            //For Vimeo Link
            BindingContext = this;
        }
        private async void mainPageVideo1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VideoPageHP());
        }

        private async void mainPageVideo2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VideoPageHP());
        }
        private async void AboutUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPageHP());
        }

        //For Vimeo Link
        private void Vimeo_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://vimeo.com/user41762925"));
        }
    }
}