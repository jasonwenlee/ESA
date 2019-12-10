using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
        }

        private void Lacrimal_Clicked(object sender, EventArgs e)
        {
            if (LacrimalSubCat.IsVisible == false)
            {
                LacrimalSubCat.IsVisible = true;
            }
            else if (LacrimalSubCat.IsVisible == true)
            {
                LacrimalSubCat.IsVisible = false;
            }
        }

        private void Eyelid_Clicked(object sender, EventArgs e)
        {
            if (EyelidSubCat.IsVisible == false)
            {
                EyelidSubCat.IsVisible = true;
            }
            else if (EyelidSubCat.IsVisible == true)
            {
                EyelidSubCat.IsVisible = false;
            }
        }

        private void Orbital_Clicked(object sender, EventArgs e)
        {
            if (OrbitalSubCat.IsVisible == false)
            {
                OrbitalSubCat.IsVisible = true;
            }
            else if (OrbitalSubCat.IsVisible == true)
            {
                OrbitalSubCat.IsVisible = false;
            }
        }
    }
}