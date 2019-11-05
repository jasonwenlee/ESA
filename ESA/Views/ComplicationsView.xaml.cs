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
        public ProcedureViewModel procedureViewModel;
        public DetailViewModel detailViewModel;
      //  public StepsViewModel viewModel;
        public int currentStep;



        public ComplicationsView(DetailViewModel dvm, ProcedureViewModel pvm)
        {
            InitializeComponent();

            detailViewModel = dvm;
            procedureViewModel = pvm;
            BindingContext = procedureViewModel.Procedure;
           


        }
    }

      

       
    }
