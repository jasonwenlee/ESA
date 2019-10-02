using ESA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ESA
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AboutUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void Video_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VideoPage());
        }

        private async void Lacrimal_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriesPage());
        }
        private async void Orbital_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriesPage());
        }

        private async void Eyelid_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriesPage());
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriesPage());
        }
    }
}
