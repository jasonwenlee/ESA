using ESA.Models;
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
        public VariationsView(ProcedureViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void RelatedProcedureButton_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailsPage(1));
        }
    }
}