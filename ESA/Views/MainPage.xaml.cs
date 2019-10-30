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
        // Don't remove:)
        //LoadProcedureViewModel loadOneProc;
        //Procedure testEye;

        MainViewModel mainViewModel;

        public MainPage()
        {
            InitializeComponent();
            // Test for only one eyelid procedure. Will change/remove when more procedures are added.
            // This procedure loads after mainpage is initialised.
            // Don't remove:)
            //loadOneProc = new LoadProcedureViewModel();

            // MainViewModel
            mainViewModel = new MainViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Don't remove:)
            //loadOneProc.LoadEyelidList();
            //ObservableCollection<Procedure> eyes = loadOneProc.EyelidProcedures;
            //foreach (var eyeProc in eyes)
            //{
            //    // testProc is name of label
            //    if (eyeProc.Name.Equals(testProc.Text))
            //    {
            //        testEye = loadOneProc.LoadProcedureByName(eyeProc);
            //    }
            //}
        }

        private void StepsPageBtn_Clicked(object sender, EventArgs e)
        {
            // Don't think this is a good idea to push object from page to another. Don't remove :)
            //Navigation.PushAsync(new DetailsPage(testEye));
            int i = new Random().Next(0, 3);
            Navigation.PushAsync(new DetailsPage(mainViewModel.Procedures[i]));
        }

        private async void AboutUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private void Video_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new VideoPage("eye_surgery.mp4", TimeSpan.Zero));
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
