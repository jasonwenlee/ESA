using ESA.Models;
using ESA.Models.CustomRenderers;
using ESA.Models.Model;
using ESA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VariationsView : ContentView
    {
        ProcedureViewModel procedureViewModel;
        public VariationsView(ProcedureViewModel viewModel)
        {
            InitializeComponent();
            procedureViewModel = viewModel;
            BindingContext = procedureViewModel;
        }

        private void RelatedProcedureButton_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailsPage(1));
        }

        private void RelatedProcedureButton_Clicked(object sender, EventArgs e)
        {
            Variation variation = procedureViewModel.Procedure.Variations[0];
            int procedureId = variation.RelatedProcedures.First(rp => rp.ProcedureLink == ((CustomButton)sender).Text).Id;
            Navigation.PushAsync(new DetailsPage(procedureId));
        }
    }
}