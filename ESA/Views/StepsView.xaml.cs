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

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepsView : ContentView
    {
        public ProcedureViewModel procedureViewModel;
        public DetailViewModel detailViewModel;
        public StepsViewModel viewModel;
        public int currentStep;

        public StepsView(DetailViewModel dvm, ProcedureViewModel pvm)
        {
            InitializeComponent();
            detailViewModel  = dvm;
            procedureViewModel = pvm;
            BindingContext = procedureViewModel.Procedure;
            currentStep = 1;
        }

        private void StepsContent_TapEventHandler(object sender, EventArgs e)
        {
            // get the current step
            Step prevStep = procedureViewModel.Procedure.Steps.First(s => s.Number == this.currentStep);
            // get the step clicked
            Step currStep = procedureViewModel.Procedure.Steps.First(s => s.Number == int.Parse(((Label)((StackLayout)sender).Children.First()).Text));
            this.currentStep = currStep.Number;

            // Set the previous step labels to gray
            StackLayout prevStepLayout = ((StackLayout)stepsFlexLayout.Children.ElementAt(prevStep.Number - 1));
            StackLayout prevStepContentLayout = ((StackLayout)prevStepLayout.Children.First());
            ((Label)prevStepContentLayout.Children.First()).TextColor = Color.FromHex("#3f3f3f");
            ((Label)prevStepContentLayout.Children.ElementAt(1)).TextColor = Color.FromHex("#3f3f3f");

            // set the current step labels to white
            StackLayout currStepLayout = ((StackLayout)stepsFlexLayout.Children.ElementAt(currStep.Number - 1));
            StackLayout currentStepContentLayout = ((StackLayout)currStepLayout.Children.First());
            ((Label)currentStepContentLayout.Children.First()).TextColor = Color.FromHex("#00BF9D");
            ((Label)currentStepContentLayout.Children.ElementAt(1)).TextColor = Color.FromHex("#00BF9D");

            // Diagram drop down
            if (currStep.HasDiagram)
            {
                ImageButton btn = ((ImageButton)currStepLayout.Children.Last());
                bool visibility = true;

                if (btn.IsVisible)
                {
                    // Rotate expandable icon
                    currentStepContentLayout.Children.Last().RotateTo(0, 500, Easing.CubicInOut);
                    visibility = false;
                    
                }
                else
                {
                    // Rotate expandable icon
                    currentStepContentLayout.Children.Last().RotateTo(-180, 500, Easing.CubicInOut);
                }
                

                btn.IsVisible = visibility;
            }

        

            

            // Move Video transport position

        }

        private void SeeMoreBtn_Clicked(object sender, EventArgs e)
        {
            ImageButton thumbnail = ((ImageButton)((StackLayout)((CustomButton)sender).Parent).Children.Last());
            bool visibility = true;
            string btnText = "See Less";

            // if thumbnail is visible
            if (thumbnail.IsVisible)
            {
                visibility = false;
                btnText = "See Diagram";
            }
            thumbnail.IsVisible = visibility;
            ((CustomButton)sender).Text = btnText;
        }

        private void DiagramThumbnail_Clicked(object sender, EventArgs e)
        {
            detailViewModel.videoName = "Brain_Eyes_Vid.mp4";
            detailViewModel.videoIsProcedure = false;
            Navigation.PushAsync(new VideoPage(detailViewModel));
            //source.Path = "eye_surgery.mp4";
            //source.Path = "Brain_Eyes_Vid.mp4";
        }
    }
}