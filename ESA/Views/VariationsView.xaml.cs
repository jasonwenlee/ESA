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
        //    VariationPageViewModel vm;
        public VariationsView()
        {
            InitializeComponent();
            BindingContext = new VariationPageViewModel();
            //          vm = new VariationPageViewModel();

            //       VariationList.ItemsSource = vm.VariationsView;

            //        BindingContext = vm;
        }

        ListView HeaderList = new ListView()
        {
            Header = "Related Procedure",
            Footer = "Footer"
        };

    }
}