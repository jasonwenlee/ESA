using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views.Cassi_HyunProto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageHP : ContentPage
    {
        public MainPageHP()
        {
            InitializeComponent();

            //Background color
            SetValue(NavigationPage.BarBackgroundColorProperty, Color.ForestGreen);
        }

        //Change to POP async/change navigation?
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
    }
}