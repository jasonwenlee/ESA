using ESA.Models;
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
        public IList<VariationPageModel> VariationPageModels { get; set; }
        //    VariationPageViewModel vm;
        public VariationsView()
        {
            InitializeComponent();
            VariationPageModels = new List<VariationPageModel>();

            VariationPageModels.Add(new Models.VariationPageModel

            {
                Title = "• Upper eyelid retraction",
                Details = "ESA.Resources.Complication01.jpeg"


            });
            VariationPageModels.Add(new Models.VariationPageModel

            {
                Title = "• Conjunctiva advancing anteriorly over lid margin",
                Details = "ESA.Resources.Complication02.jpeg"


            });
            VariationPageModels.Add(new Models.VariationPageModel

            {
                Title = "• Skin advancing posteriorly over lid margin​",
                Details = "ESA.Resources.Complication03.jpeg"


            });

            VariationPageModels.Add(new Models.VariationPageModel

            {
                Title = "• Lid margin granuloma ​",
                Details = "ESA.Resources.Complication04.jpeg"


            });

            
            BindingContext = this;

        }
        //BindingContext = new VariationPageViewModel();
        //          vm = new VariationPageViewModel();

        //       VariationList.ItemsSource = vm.VariationsView;

        //        BindingContext = vm;
    }

        //ListView HeaderList = new ListView()
        //{
        //    Header = "Related Procedure",
        //    Footer = "Footer"
        //};
    
}