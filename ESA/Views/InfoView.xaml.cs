using ESA.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoView : ContentView
    {
        public DetailsViewModel procedureViewModel;

        public InfoView(DetailsViewModel pvm)
        {
            InitializeComponent();

            procedureViewModel = pvm;
            BindingContext = procedureViewModel.Procedure;
        }

        private async void HistoryButton_Clicked(object sender, EventArgs e)
        {
            ReferenceGrid.IsVisible = false;
            HistoryGrid.IsVisible = true;

            // update activeButtonBox
            Rectangle rectangle = historyButton.Bounds;
            rectangle.Width -= 4;
            rectangle.Height -= 4;
            rectangle.Y += 2;
            rectangle.X += 2;
            await activeButtonBox.LayoutTo(rectangle, 500, Easing.CubicInOut);

        }

        private async void ReferencesButton_Clicked(object sender, EventArgs e)
        {
            HistoryGrid.IsVisible = false;
            ReferenceGrid.IsVisible = true;

            // update activeButtonBox
            Rectangle rectangle = referencesButton.Bounds;
            rectangle.Width -= 2;
            rectangle.Height -= 4;
            rectangle.Y += 2;
            await activeButtonBox.LayoutTo(rectangle, 500, Easing.CubicInOut);
        }

        private void ExternalLink_Tapped(object sender, EventArgs e)
        {
            //Grid2.IsVisible = true;
            //Grid1.IsVisible = false;
        }

        private void HistoryReference_Tapped(object sender, EventArgs e)
        {
            ReferencesButton_Clicked(sender, e);
        }
      
    }
}