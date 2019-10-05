using ESA.Models;
using ESA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListProcedures : ContentPage
    {
        private LoadProcedureViewModel LoadProcVM;

        public ListProcedures()
        {
            InitializeComponent();
            if (!LoadProcVM.IsDataLoaded)
            {
                LoadProcVM.LoadLacrimalList();
                LoadProcVM.LoadOrbitalList();
                LoadProcVM.LoadEyelidList();
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadProcVM = new LoadProcedureViewModel();
            lacrimalList.ItemsSource = LoadProcVM.LacrimalProcedures;
            orbitalList.ItemsSource = LoadProcVM.OrbitalProcedures;
            eyelidList.ItemsSource = LoadProcVM.EyelidProcedures;
        }

        private async void LacrimalList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (sender == null)
            {
                await DisplayAlert("No item", "Null", "ok");
                return;
            }
            else
            {
                Procedure tappedItem = (Procedure)((ListView)sender).SelectedItem;
                await Navigation.PushAsync(new DisplayProcedureInfo(tappedItem));
            }
        }

        private async void OrbitalList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (sender == null)
            {
                await DisplayAlert("No item", "Null", "ok");
                return;
            }
            else
            {
                Procedure tappedItem = (Procedure)((ListView)sender).SelectedItem;
                await Navigation.PushAsync(new DisplayProcedureInfo(tappedItem));
            }
        }

        private async void EyelidList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (sender == null)
            {
                await DisplayAlert("No item", "Null", "ok");
                return;
            }
            else
            {
                Procedure tappedItem = (Procedure)((ListView)sender).SelectedItem;
                await Navigation.PushAsync(new DisplayProcedureInfo(tappedItem));
            }
        }
    }
}