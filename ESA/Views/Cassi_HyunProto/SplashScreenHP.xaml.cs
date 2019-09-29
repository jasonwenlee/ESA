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
    public partial class SplashScreenHP : ContentPage
    {
        public SplashScreenHP()
        {
            InitializeComponent();
            Splash();
        }

        //navigate to main page
        private async void Splash()
        {
            Navigation.InsertPageBefore(new MainTabPageHP(), Navigation.NavigationStack[0]);
            await Navigation.PopToRootAsync(false);
        }
    }
}
