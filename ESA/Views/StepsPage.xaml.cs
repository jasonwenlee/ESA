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
    public partial class StepsPage : ContentPage
    {
        public IList<Steps> Steps { get; private set; }
        public StepsPage()
        {
            InitializeComponent();

            Steps = new List<Steps>();
            Steps.Add(new Models.Steps
            {
                StepNumber = 1,
                StepText = "This is the first step this is placeholder text",
                ImageUrl = "https://i.imgur.com/Gpczz72.png"
            });

            Steps.Add(new Models.Steps
            {
                StepNumber = 2,
                StepText = "This is the second step this is placeholder text",
                ImageUrl = "https://i.imgur.com/Gpczz72.png"
            });

            Steps.Add(new Models.Steps
            {
                StepNumber = 3,
                StepText = "This is the third step this is placeholder text",
                ImageUrl = "https://i.imgur.com/Gpczz72.png"
            });

            Steps.Add(new Models.Steps
            {
                StepNumber = 4,
                StepText = "This is the fourth step this is placeholder text",
                ImageUrl = "https://i.imgur.com/Gpczz72.png"
            });

            Steps.Add(new Models.Steps
            {
                StepNumber = 5,
                StepText = "This is the fifth step this is placeholder text",
                ImageUrl = "https://i.imgur.com/Gpczz72.png"
            });

            Steps.Add(new Models.Steps
            {
                StepNumber = 6,
                StepText = "This is the sixth step this is placeholder text",
                ImageUrl = "https://i.imgur.com/Gpczz72.png"
            });

            BindingContext = this;
        }
    }
}