
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
            KeyPoint prevStep = procedureViewModel.Procedure.KeyPoints.ElementAt(this.currentStep);
            // get the step clicked
            KeyPoint currStep = (KeyPoint)((StackLayout)sender).BindingContext;
            this.currentStep = currStep.Number;

            // get the current point layout
            StackLayout currPointLayout = ((StackLayout)pointsLayout.Children.ElementAt(currStep.Number));
            StackLayout currentPointContentLayout = ((StackLayout)currPointLayout.Children.First());

            // Diagram drop down
            if (currStep.HasDiagram)
            {
                ImageButton btn = ((ImageButton)currPointLayout.Children.Last());
                bool visibility = true;

                if (btn.IsVisible)
                {
                    // Rotate expandable icon
                    currentPointContentLayout.Children.Last().RotateTo(0, 500, Easing.CubicInOut);
                    visibility = false;
                }
                else
                {
                    // Rotate expandable icon
                    currentPointContentLayout.Children.Last().RotateTo(-180, 500, Easing.CubicInOut);
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