using ESA.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ESA.ViewModels
{
    public class InfoViewModel
    {
        private INavigation navigation;
        public ICommand LoadReferencesCommand { get; private set; }
        public ICommand ClickCommand => new Command<string>((url) => {
                                                                        Device.OpenUri(new System.Uri(url));
                                                                     });
        private ReferencesModel references;

        public InfoViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            references = new ReferencesModel();
            LoadReferencesCommand = new Command(async () => await LoadReferences());
        }

        //private Task LoadReferences()
        //{
        //    StackLayout StepLayout = new StackLayout();
        //    StackLayout ContentLayout = new StackLayout();
        //    Label NumberLbl = new Label();
        //    Label ContentLbl = new Label();
        //    foreach (var reference in references.RefList)
        //    {
                
        //    }
        //}

        public void LoadStepsView()
        {
            StackLayout StepLayout = new StackLayout();
            StackLayout ContentLayout = new StackLayout();
            Label NumberLbl = new Label();
            Label ContentLbl = new Label();
            //foreach (Object step in viewModel.Steps)
            //{

            // Number
            //NumberLbl.Text = step.Number.ToString();
            //NumberLbl.Style = (Style)Resources["StepNumber"];
            // Content
            //ContentLbl.Text = step.Content;
            //ContentLbl.Style = (Style)Resources["StepContent"];
            //if (step.Number == currentStep)
            //{
            //    NumberLbl.TextColor = Color.White;
            //    ContentLbl.TextColor = Color.White;
            //}

            ContentLayout.Orientation = StackOrientation.Horizontal;

            ContentLayout.Children.Add(NumberLbl);
            ContentLayout.Children.Add(ContentLbl);
            // Tap Event Handler
            var tapRecognizer = new TapGestureRecognizer();
            //tapRecognizer.Tapped += StepsContent_TapEventHandler;
            ContentLayout.GestureRecognizers.Add(tapRecognizer);

            StepLayout.Children.Add(ContentLayout);
            // Diagram
            //if (step.Diagram != null)
            //{
            ImageButton diagramThumbnail = new ImageButton();
            //diagramThumbnail.Source = step.Diagram.Thumbnail;
            //diagramThumbnail.Style = (Style)Resources["StepDiagram"];
            //diagramThumbnail.Clicked += DiagramThumbnail_Clicked; ;

            //CustomButton seeMoreBtn = new CustomButton();
            //seeMoreBtn.Text = "See Diagram";
            //seeMoreBtn.Style = (Style)Resources["DiagramText"];
            //seeMoreBtn.Clicked += SeeMoreBtn_Clicked;

            //StepLayout.Children.Add(seeMoreBtn);
            StepLayout.Children.Add(diagramThumbnail);
            //}
            // Add to view
            //Content.Children.Add(StepLayout);
        }
    }

}
}
