using ESA.Models.CustomRenderers;
using ESA.Models.Model;
using ESA.ViewModels;
using ESA.Views.Desktop;
using System;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VariationsView : ContentView
    {
        public ProcedureViewModel procedureViewModel;

        public VariationsView() { InitializeComponent(); }

        public VariationsView(ProcedureViewModel viewModel)
        {
            InitializeComponent();
            procedureViewModel = viewModel;
            BindingContext = procedureViewModel;
        }

        private void RelatedProcedureButton_Tapped(object sender, EventArgs e)
        {
            switch (Device.Idiom)
            {
                case TargetIdiom.Desktop:
                    Navigation.PushAsync(new DetailsPageDesktop(1));
                    break;
                case TargetIdiom.Phone:
                    Navigation.PushAsync(new DetailsPage(1));
                    break;
                case TargetIdiom.Tablet:
                    break;
            }
        }

        private void RelatedProcedureButton_Clicked(object sender, EventArgs e)
        {
            Variation variation = procedureViewModel.Procedure.Variations[0];
            int procedureId = variation.RelatedProcedures.First(rp => rp.ProcedureLink == ((CustomButton)sender).Text).Id;
            Navigation.PushAsync(new DetailsPage(procedureId));
        }
    }
}