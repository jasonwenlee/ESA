using ESA.MarkupExtensions;
using ESA.Models.CustomRenderers;
using ESA.Models.Model;
using ESA.ViewModels;
using ESA.Views;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepsView : ContentView
    {
        public ProcedureViewModel procedureViewModel;

        public StepsView(ProcedureViewModel pvm)
        {
            InitializeComponent();

            procedureViewModel = pvm;
            BindingContext = procedureViewModel.Procedure;
        }

        private void DropdownContent_Tapped(object sender, EventArgs e)
        {
            // get first step using the number text associated with layout content
            Step chosenStep = procedureViewModel.Procedure.Steps.First(s => s.Number == int.Parse(((Label)((StackLayout)sender).Children.First()).Text));
            // get the expandable view
            ExtExpandableView extExpandableView = (ExtExpandableView)((StackLayout)((StackLayout)sender).Parent).Parent;
            // get the arrow image
            Image arrow = ((Image)((StackLayout)sender).Children.Last());
            // set expanded to chosen step has diagram
            if (chosenStep.HasDiagram)
            {
                extExpandableView.IsExpanded = !extExpandableView.IsExpanded;
                extExpandableView.ForceUpdateSize();

                if (extExpandableView.IsExpanded)
                {
                    arrow.RotateTo(180, 200, Easing.CubicInOut);
                }
                else
                {
                    arrow.RotateTo(0, 200, Easing.CubicInOut);
                }

            }
        }

        private void DiagramThumbnail_Clicked(object sender, EventArgs e)
        {
            procedureViewModel.VideoName = "Brain_Eyes_Vid.mp4";
            procedureViewModel.VideoIsProcedure = false;
            Navigation.PushAsync(new VideoPage(procedureViewModel));
            //source.Path = "eye_surgery.mp4";
            //source.Path = "Brain_Eyes_Vid.mp4";
        }

        private void RelatedProcedureButton_Clicked(object sender, EventArgs e)
        {
            int procedureId = procedureViewModel.Procedure.Steps.First(s => s.Number == int.Parse(((Label)((StackLayout)((StackLayout)((CustomButton)sender).Parent).Children.First()).Children.First()).Text)).RelatedProcedure.Id;
            Navigation.PushAsync(new DetailsPage(procedureId));
        }
    }
}