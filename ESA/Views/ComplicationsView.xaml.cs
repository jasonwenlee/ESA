using ESA.Models.Model;
using ESA.Models.CustomRenderers;
using ESA.ViewModels;
using ESA.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComplicationsView : ContentView
    {
        public DetailsViewModel procedureViewModel;

        public ComplicationsView(DetailsViewModel pvm)
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