using ESA.Models.Model;
using ESA.ViewModels;

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
            LoadProcVM = new LoadProcedureViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!LoadProcVM.IsDataLoaded)
            {
                LoadProcVM.LoadAllProcedureList();
                LoadProcVM.LoadLacrimalList();
                LoadProcVM.LoadOrbitalList();
                LoadProcVM.LoadEyelidList();
            }
            allList.ItemsSource = LoadProcVM.AllProcedures;
            lacrimalList.ItemsSource = LoadProcVM.LacrimalProcedures;
            orbitalList.ItemsSource = LoadProcVM.OrbitalProcedures;
            eyelidList.ItemsSource = LoadProcVM.EyelidProcedures;
        }

        private async void List_ItemTapped(object sender, ItemTappedEventArgs e)
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
                allList.SelectedItem = null;

                //if (tappedItem is Lacrimal)
                //{
                //    lacrimalList.SelectedItem = null;
                //}
                //else if (tappedItem is Orbital)
                //{
                //    orbitalList.SelectedItem = null;
                //}
                //else if (tappedItem is Eyelid)
                //{
                //    eyelidList.SelectedItem = null;
                //}
            }

        }
    }
}