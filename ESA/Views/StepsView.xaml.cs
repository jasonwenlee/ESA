//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace ESA
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class StepsView : ContentView
//    {
//        public StepsView()
//        {
//            InitializeComponent();
//        }
//    }
//}


//using ESA.Models;
//using ESA.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace ESA
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class StepsView : ContentView
//    {
//        private ObservableCollection<StepsPageViewModel> getContents;
//        private ObservableCollection<StepsPageViewModel> _expandedContent;
//        public StepsView()
//        {
//            InitializeComponent();

//            //          BindingContext = new StepsPageViewModel();
//            getContents = StepsPageViewModel.Contents;
//            UpdateListContent();
//        }
//        private void HeaderTapped(object sender, EventArgs args)
//        {
//            int ListselectedIndex = _expandedContent.IndexOf(
//                ((StepsPageViewModel)((Button)sender).CommandParameter));
//            getContents[ListselectedIndex].Expanded = !getContents[ListselectedIndex].Expanded;

//            UpdateListContent();
//        }
//        private void UpdateListContent()

//        {
//            _expandedContent = new ObservableCollection<StepsPageViewModel>();
//            foreach (StepsPageViewModel group in getContents)
//            {
//                StepsPageViewModel steps = new StepsPageViewModel(group.Title, group.Expanded);
//                steps.StepsItems = group.Count;
//                if (group.Expanded)
//                {
//                    foreach (StepsPageModel step in group)
//                    {
//                        steps.Add(step);
//                    }
//                }
//                _expandedContent.Add(steps);
//            }
//            MyListView.ItemsSource = _expandedContent;
//        }
//    }
//}


using ESA.Models;
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
        public StepsViewModel viewModel;
        public int currentStep;

        public StepsView()
        {
            InitializeComponent();
            viewModel = new StepsViewModel();
            currentStep = 1;
            BindingContext = viewModel.Steps;
        }

        public void LoadStepsView()
        {
            foreach (Step step in viewModel.Steps)
            {
                StackLayout StepLayout = new StackLayout();
                StackLayout ContentLayout = new StackLayout();
                Label NumberLbl = new Label();
                Label ContentLbl = new Label();
                // Number
                NumberLbl.Text = step.Number.ToString();
                NumberLbl.Style = (Style)Resources["StepNumber"];
                // Content
                ContentLbl.Text = step.Content;
                ContentLbl.Style = (Style)Resources["StepContent"];
                if (step.Number == currentStep)
                {
                    NumberLbl.TextColor = Color.Black;
                    ContentLbl.TextColor = Color.Black;
                }

                ContentLayout.Orientation = StackOrientation.Horizontal;

                ContentLayout.Children.Add(NumberLbl);
                ContentLayout.Children.Add(ContentLbl);
                // Tap Event Handler
                var tapRecognizer = new TapGestureRecognizer();
                tapRecognizer.Tapped += StepsContent_TapEventHandler;
                ContentLayout.GestureRecognizers.Add(tapRecognizer);

                StepLayout.Children.Add(ContentLayout);
                // Diagram
                if (step.Diagram != null)
                {
                    ImageButton diagramThumbnail = new ImageButton();
                    diagramThumbnail.Source = step.Diagram.Thumbnail;
                    diagramThumbnail.Style = (Style)Resources["StepDiagram"];
                    diagramThumbnail.Clicked += DiagramThumbnail_Clicked; ;

                    CustomButton seeMoreBtn = new CustomButton();
                    seeMoreBtn.Text = "See Diagram";
                    seeMoreBtn.Style = (Style)Resources["DiagramText"];
                    seeMoreBtn.Clicked += SeeMoreBtn_Clicked;

                    StepLayout.Children.Add(seeMoreBtn);
                    StepLayout.Children.Add(diagramThumbnail);
                }
                // Add to view
                Content.Children.Add(StepLayout);
            }
        }

        private void StepsContent_TapEventHandler(object sender, EventArgs e)
        {
            // get the current step
            Step prevStep = viewModel.Steps.First(s => s.Number == this.currentStep);

            // get the step clicked
            Step currStep = viewModel.Steps.First(s => s.Number == int.Parse(((Label)((StackLayout)sender).Children.First()).Text));
            this.currentStep = currStep.Number;

            // Set the previous step labels to gray
            StackLayout prevStepLayout = ((StackLayout)Content.Children.ElementAt(prevStep.Number - 1));
            StackLayout prevStepContentLayout = ((StackLayout)prevStepLayout.Children.First());
            ((Label)prevStepContentLayout.Children.First()).TextColor = Color.FromHex("#BDBDBD");
            ((Label)prevStepContentLayout.Children.Last()).TextColor = Color.FromHex("#BDBDBD");

            // set the current step labels to white
            StackLayout currentStepLayout = ((StackLayout)Content.Children.ElementAt(currStep.Number - 1));
            StackLayout currentStepContentLayout = ((StackLayout)currentStepLayout.Children.First());
            ((Label)currentStepContentLayout.Children.First()).TextColor = Color.Black;
            ((Label)currentStepContentLayout.Children.Last()).TextColor = Color.Black;

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
            Navigation.PushAsync(new VideoPage());
        }
    }
}