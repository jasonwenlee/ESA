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
    public partial class ProcedureInformation : ContentPage
    {
        public ProcedureInformation()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            lacrimalList.ItemsSource = App.ProcedureDatabase.GetListLacrimalProceduresAsync();
            orbitalList.ItemsSource = App.ProcedureDatabase.GetListOrbitalProceduresAsync();
            eyelidList.ItemsSource = App.ProcedureDatabase.GetListEyelidProceduresAsync();
        }
    }
}