using ESA.Models;
using ESA.ViewModels;
using ESA.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        LoadProcedureViewModel loadOneProc;
        Procedure testEye;

        public MainPage()
        {
            InitializeComponent();
            // Test for only one eyelid procedure. Will change/remove when more procedures are added.
            // This procedure loads after mainpage is initialised.
            loadOneProc = new LoadProcedureViewModel();
            loadOneProc.LoadEyelidList();
            ObservableCollection<Procedure> eyes = loadOneProc.EyelidProcedures;
            foreach (var eyeProc in eyes)
            {
                if (eyeProc.Name.Equals(testProc.Text))
                {
                    testEye = loadOneProc.LoadProcedureByName(eyeProc);
                }
            }
        }

        private void StepsPageBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailsPage(testEye));
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

        private async void Database_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateProcedure());
        }
    }
}
