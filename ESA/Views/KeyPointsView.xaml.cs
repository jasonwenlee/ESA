
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
    public partial class KeyPointsView : ContentView
    {
        public ProcedureViewModel procedureViewModel;
        public DetailViewModel detailViewModel;
        public StepsViewModel viewModel;
        public int currentStep;


        public KeyPointsView(DetailViewModel dvm, ProcedureViewModel pvm)
        {
            InitializeComponent();
            detailViewModel = dvm;
            procedureViewModel = pvm;
            BindingContext = procedureViewModel.Procedure;
            currentStep = 1;


        }

        private void KeyPointsContent_TapEventHandler(object sender, EventArgs e)
        {
            // get the current step
            KeyPoint prevStep = procedureViewModel.Procedure.KeyPoints.First(s => s.Importance == this.currentStep);
            // get the step clicked
            KeyPoint currStep = procedureViewModel.Procedure.KeyPoints.First(s => s.Importance == int.Parse(((Label)((StackLayout)sender).Children.First()).Text));
            this.currentStep = currStep.Importance;

            // Set the previous step labels to gray
            StackLayout prevStepLayout = ((StackLayout)stepsFlexLayout.Children.ElementAt(prevStep.Importance - 1));
            StackLayout prevStepContentLayout = ((StackLayout)prevStepLayout.Children.First());
            ((Label)prevStepContentLayout.Children.First()).TextColor = Color.FromHex("#3f3f3f");
            ((Label)prevStepContentLayout.Children.ElementAt(1)).TextColor = Color.FromHex("#3f3f3f");

            // set the current step labels to green
            StackLayout currStepLayout = ((StackLayout)stepsFlexLayout.Children.ElementAt(currStep.Importance - 1));
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



          
        }

     

        private void DiagramThumbnail_Clicked(object sender, EventArgs e)
        {
            detailViewModel.videoName = "Brain_Eyes_Vid.mp4";
            detailViewModel.videoIsProcedure = false;
            Navigation.PushAsync(new VideoPage(detailViewModel));
         
        }
    }
}