using ESA.Models;
using ESA.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProcedureType : ContentPage
    {
        string procedureCategory;

        public ProcedureType()
        {
            InitializeComponent();
        }

        private void ProcedureCategoryEntry_Completed(object sender, EventArgs e)
        {
            procedureCategory = ((Entry)sender).Text; //cast sender to access the properties of the Entry
            if (procedureCategory.ToLower().Equals("lacrimal")
                || procedureCategory.ToLower().Equals("orbital")
                || procedureCategory.ToLower().Equals("eyelid"))
            {
                addInformationButton.IsEnabled = true;
            }
            else
            {
                addInformationButton.IsEnabled = false;
            }
        }

        private void ProcedureNameEntry_Completed(object sender, EventArgs e)
        {
        }

        private void ProcedureDetailEntry_Completed(object sender, EventArgs e)
        {
        }

        private async void AddInformationButton_Clicked(object sender, EventArgs e)
        {
            if (procedureNameEntry.Text == null || procedureDetailEntry.Text == null)
            {
                await DisplayAlert("Alert", "Empty fields", "OK");
                return;
            }

            if (procedureCategory.ToLower().Equals("lacrimal"))
            {
                Lacrimal newLacrimalProcedure = new Lacrimal();
                StepsModel newSteps = new StepsModel();
                newLacrimalProcedure.Name = procedureNameEntry.Text;
                newLacrimalProcedure.Details = procedureDetailEntry.Text;
                newSteps.content = stepsEditor.Text;
                App.ProcedureDatabase.SaveStepsAsync(newSteps, newLacrimalProcedure);

                App.ProcedureDatabase.SaveProcedureAsync(newLacrimalProcedure);
                await DisplayAlert("Cool", "Please proceed", "OK");
            }
            else if (procedureCategory.ToLower().Equals("orbital"))
            {
                Orbital newOrbitalProcedure = new Orbital();
                StepsModel newSteps = new StepsModel();
                newOrbitalProcedure.Name = procedureNameEntry.Text;
                newOrbitalProcedure.Details = procedureDetailEntry.Text;
                newSteps.content = stepsEditor.Text;
                App.ProcedureDatabase.SaveStepsAsync(newSteps, newOrbitalProcedure);

                App.ProcedureDatabase.SaveProcedureAsync(newOrbitalProcedure);
                await DisplayAlert("Cool", "Please proceed", "OK");
            }
            else if (procedureCategory.ToLower().Equals("eyelid"))
            {
                Eyelid newEyelidProcedure = new Eyelid();
                StepsModel newSteps = new StepsModel();
                newEyelidProcedure.Name = procedureNameEntry.Text;
                newEyelidProcedure.Details = procedureDetailEntry.Text;
                newSteps.content = stepsEditor.Text;
                App.ProcedureDatabase.SaveStepsAsync(newSteps, newEyelidProcedure);

                App.ProcedureDatabase.SaveProcedureAsync(newEyelidProcedure);
                await DisplayAlert("Cool", "Please proceed", "OK");
            }
            //await Navigation.PushAsync(new ProcedureInformation());
        }

        private void StepsEditor_Completed(object sender, EventArgs e)
        {

        }
    }
}