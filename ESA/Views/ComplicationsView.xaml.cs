using ESA.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComplicationsView : ContentView
    {
        public ProcedureViewModel procedureViewModel;

        public ComplicationsView(ProcedureViewModel pvm)
        {
            InitializeComponent();

            procedureViewModel = pvm;
            BindingContext = procedureViewModel.Procedure;
        }

        private void ComplicationImage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImagePage(((ImageButton)sender).Source));
        }
    }
}