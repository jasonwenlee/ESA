using ESA.Models;
using ESA.Models.PageModels;
using ESA.ViewModels;
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
        private AddProcedureViewModel AddProcVM;

        public ProcedureType()
        {
            InitializeComponent();
            AddProcVM = new AddProcedureViewModel();
        }

        private void ProcedureCategoryEntry_Completed(object sender, EventArgs e)
        {
            procedureCategory = ((Entry)sender).Text; //cast sender to access the properties of the Entry

            if (procedureCategory.ToLower().Equals("lacrimal")
                || procedureCategory.ToLower().Equals("orbital")
                || procedureCategory.ToLower().Equals("eyelid"))
            {
                addInformationButtonMVVM.IsEnabled = true;
            }
            else
            {
                addInformationButtonMVVM.IsEnabled = false;
            }
        }

        private async void AddInformationButtonMVVM_Clicked(object sender, EventArgs e)
        {
            if (procedureNameEntry.Text == null || procedureDetailEntry.Text == null)
            {
                await DisplayAlert("Alert", "Empty fields", "OK");
                return;
            }
            try
            {
                AddProcVM.AddNewProcedure(procedureCategory.ToLower(), procedureNameEntry.Text, procedureDetailEntry.Text);
                AddProcVM.AddNewSteps(stepsEditor.Text);
                AddProcVM.AddKeyPoints(keyPointsEditor.Text);
                AddProcVM.AddNewVariations(variationsEditor.Text);
            }
            catch (Exception)
            {
                await DisplayAlert("Error", "Oh no error", "OK");
            }
            await DisplayAlert("Cool", "Please proceed", "OK");
        }

        private async void StepsEditor_Completed(object sender, EventArgs e)
        {
            Editor steps = (Editor)sender;
            List<string> existingProcedure = new List<string>();
            existingProcedure.Add("Tarsoconjunctival flap");
            existingProcedure.Add("Hewes Flap");

            foreach (string word in existingProcedure)
            {
                if (steps.Text.Contains(word))
                {
                    steps.Text = steps.Text.Replace("Tarsoconjunctival flap", word);
                    //steps.Text.Replace(steps.Text.ToString(), "hello");
                    await DisplayAlert("Alert", "Found existing procedure" + stepsEditor.Text.IndexOf(word), "OK");
                }
            }
        }

        private void VariationsEditor_Completed(object sender, EventArgs e)
        {
            Editor variations = (Editor)sender;
        }

        private void KeyPointsEditor_Completed(object sender, EventArgs e)
        {
            Editor keyPoints = (Editor)sender;

        }

        private void ProcedureNameEntry_Completed(object sender, EventArgs e)
        {

        }

        private void ProcedureDetailEntry_Completed(object sender, EventArgs e)
        {

        }

        private async void AddInformationButton_Clicked(object sender, EventArgs e)
        {
            StepsModel newSteps = new StepsModel();
            KeyPointsModel newKeyPoints = new KeyPointsModel();
            VariationsModel newVariations = new VariationsModel();

            if (procedureNameEntry.Text == null || procedureDetailEntry.Text == null)
            {
                await DisplayAlert("Alert", "Empty fields", "OK");
                return;
            }

            if (procedureCategory.ToLower().Equals("lacrimal"))
            {
                Lacrimal newLacrimalProcedure = new Lacrimal();

                newLacrimalProcedure.Name = procedureNameEntry.Text;
                newLacrimalProcedure.Details = procedureDetailEntry.Text;
                newSteps.content = stepsEditor.Text;
                newKeyPoints.content = keyPointsEditor.Text;
                newVariations.content = variationsEditor.Text;

                App.ProcedureDatabase.SaveProcedure(newLacrimalProcedure);
                App.ProcedureDatabase.SaveSteps(newSteps, newLacrimalProcedure);
                App.ProcedureDatabase.SaveVariations(newVariations, newLacrimalProcedure);
                App.ProcedureDatabase.SaveKeyPoints(newKeyPoints, newLacrimalProcedure);

                await DisplayAlert("Cool", "Please proceed", "OK");
            }
            else if (procedureCategory.ToLower().Equals("orbital"))
            {
                Orbital newOrbitalProcedure = new Orbital();

                newOrbitalProcedure.Name = procedureNameEntry.Text;
                newOrbitalProcedure.Details = procedureDetailEntry.Text;
                newSteps.content = stepsEditor.Text;
                newKeyPoints.content = keyPointsEditor.Text;
                newVariations.content = variationsEditor.Text;

                App.ProcedureDatabase.SaveProcedure(newOrbitalProcedure);
                App.ProcedureDatabase.SaveSteps(newSteps, newOrbitalProcedure);
                App.ProcedureDatabase.SaveVariations(newVariations, newOrbitalProcedure);
                App.ProcedureDatabase.SaveKeyPoints(newKeyPoints, newOrbitalProcedure);
                await DisplayAlert("Cool", "Please proceed", "OK");
            }
            else if (procedureCategory.ToLower().Equals("eyelid"))
            {
                Eyelid newEyelidProcedure = new Eyelid();

                newEyelidProcedure.Name = procedureNameEntry.Text;
                newEyelidProcedure.Details = procedureDetailEntry.Text;
                newSteps.content = stepsEditor.Text;
                newKeyPoints.content = keyPointsEditor.Text;
                newVariations.content = variationsEditor.Text;

                App.ProcedureDatabase.SaveProcedure(newEyelidProcedure);
                App.ProcedureDatabase.SaveSteps(newSteps, newEyelidProcedure);
                App.ProcedureDatabase.SaveVariations(newVariations, newEyelidProcedure);
                App.ProcedureDatabase.SaveKeyPoints(newKeyPoints, newEyelidProcedure);
                await DisplayAlert("Cool", "Please proceed", "OK");
            }
            //await Navigation.PushAsync(new ProcedureInformation());
        }


    }
}