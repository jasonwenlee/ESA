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
    public partial class AboutPageHP : ContentPage
    {

        public AboutPageHP()
        {
            InitializeComponent();
        }
        private void Saul_ReadMore(object sender, EventArgs e)
        {
            popupImageView.IsVisible = true;
        }

        private async void BackToAbout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPageHP());
        }
    }
}