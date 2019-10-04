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

        private async void ProcedureCategoryEntry_Completed(object sender, EventArgs e)
        {
            Entry steps = (Entry)sender;

            procedureCategory = steps.Text; //cast sender to access the properties of the Entry

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
                AddProcVM.AddComplications(complicationsEditor.Text);
                AddProcVM.AddHistory(historyEditor.Text);
                AddProcVM.AddReferences(referencesEditor.Text);
            }
            catch (Exception)
            {
                //await DisplayAlert("Error", "Oh no! Error", "OK");
            }
            await DisplayAlert("Cool", "Please proceed", "OK");
        }

        private async void StepsEditor_Completed(object sender, EventArgs e)
        {
            //Editor steps = (Editor)sender;
            //List<string> existingProcedure = new List<string>();
            //existingProcedure.Add("Tarsoconjunctival flap");
            //existingProcedure.Add("Hewes Flap");

            //foreach (string word in existingProcedure)
            //{
            //    if (steps.Text.Contains(word))
            //    {
            //        steps.Text = steps.Text.Replace("Tarsoconjunctival flap", word);
            //        //steps.Text.Replace(steps.Text.ToString(), "hello");
            //        await DisplayAlert("Alert", "Found existing procedure" + stepsEditor.Text.IndexOf(word), "OK");
            //    }
            //}
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
        private void ComplicationsEditor_Completed(object sender, EventArgs e)
        {

        }
        private void HistoryEditor_Completed(object sender, EventArgs e)
        {

        }
        private void ReferencesEditor_Completed(object sender, EventArgs e)
        {

        }
    }
}