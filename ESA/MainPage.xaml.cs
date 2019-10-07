using ESA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ESA
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void StepsPageBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailsPage());
        }

        private async void AboutUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void Video_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VideoPage());
        }

        private void Search_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Search functionality to be added in the 2nd phase of the project", "OK");
        }

        // REC: When all the procedures are properly available, it will not be possible to navigate
        // to the Details Page. This method is just to make the user awar of clicking the right spot.
        private void Lacrimal_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new LacrimalPage()); // REC: The LacrimalPage has no use anymore. Left just i case...
            DisplayAlert("Alert", "Make sure to use 'Click here' to open the list of procedures", "OK");
        }

        // REC: Atm the below method works to call the only Hughes procedure that we have, however once
        // we add more procedures, the "Object" Procedure with the right information should be called.
        // More Details @ Xamarin.Forms Guide "Responding to item selection" p.1059.
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailsPage());
        }
    }
}
