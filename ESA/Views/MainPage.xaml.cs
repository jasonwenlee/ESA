using ESA.Models.Model;
using ESA.ViewModels;
using ESA.Views;
using System;
using System.ComponentModel;
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
            BindingContext = mainViewModel;
            ProcedureListView.ItemsSource = mainViewModel.ProcedureNames;
            ClinicalListView.ItemsSource = mainViewModel.ProcedureNames;
            //ExampleListView.ItemsSource = mainViewModel.ExampleProcedureNames;
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

        private async void MainListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            Procedure p = ((Procedure)(ProcedureListView.SelectedItem));
            await Navigation.PushAsync(new DetailsPage(p.Id));
            ((ListView)sender).SelectedItem = null;
        }

        private async void AboutUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage(mainViewModel));
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriesPage());
        }

        private async void Database_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateProcedure());
        }

        private async void ProceduresButton_Clicked(object sender, EventArgs e)
        {
            ClinicalGrid.IsVisible = false;
            ProcedureGrid.IsVisible = true;

            // update activeButtonBox
            Rectangle rectangle = ProceduresButton.Bounds;
            rectangle.Width -= 4;
            rectangle.Height -= 4;
            rectangle.Y += 2;
            rectangle.X += 2;
            await activeButtonBox.LayoutTo(rectangle, 500, Easing.CubicInOut);
        }

        private async void ClinicalScenariosButton_Clicked(object sender, EventArgs e)
        {
            ProcedureGrid.IsVisible = false;
            ClinicalGrid.IsVisible = true;

            // update activeButtonBox
            Rectangle rectangle = ClinicalScenariosButton.Bounds;
            rectangle.Width -= 2;
            rectangle.Height -= 4;
            rectangle.Y += 2;
            await activeButtonBox.LayoutTo(rectangle, 500, Easing.CubicInOut);
        }
    }
}
