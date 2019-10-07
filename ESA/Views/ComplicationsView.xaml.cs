using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESA.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComplicationsView : ContentView
    {

        public IList<Complications> Complications { get; set; }
        public ComplicationsView()
        {
            InitializeComponent();

            Complications = new List<Complications>();
           
            Complications.Add(new Models.Complications

            {
                DescPhotoText = "• Upper eyelid retraction",
                ImageUrl = "ESA.Resources.Complication01.jpeg"


            });
            Complications.Add(new Models.Complications

            {
                DescPhotoText = "• Conjunctiva advancing anteriorly over lid margin",
                ImageUrl = "ESA.Resources.Complication02.jpeg"


            });
            Complications.Add(new Models.Complications

            {
                DescPhotoText = "• Skin advancing posteriorly over lid margin​",
                ImageUrl = "ESA.Resources.Complication03.jpeg"


            });

            Complications.Add(new Models.Complications

            {
                DescPhotoText = "• Lid margin granuloma ​",
                ImageUrl = "ESA.Resources.Complication04.jpeg"


            });

            Complications.Add(new Models.Complications

            {
                DescPhotoText = "• Lid margin irregularity ​ ​",
                ImageUrl = "ESA.Resources.Complication05.jpeg"


            });


            BindingContext = this;

        }

       
    }
}