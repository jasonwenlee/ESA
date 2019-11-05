using ESA.Models.Model;
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
    // Author: Jason Wen Lee
    // Class for displaying information from loaded procedure.
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayProcedureInfo : ContentPage
    {
        LoadProcedureViewModel LoadProcVM;
        UpdateProcedureViewModel UpdateProcedureVM;

        public DisplayProcedureInfo(Procedure proc)
        {
            InitializeComponent();
            LoadProcVM = new LoadProcedureViewModel();
            UpdateProcedureVM = new UpdateProcedureViewModel();
            LoadChosenProcedure(proc);
        }

        private void LoadChosenProcedure(Procedure proc)
        {
            //BindingContext = LoadProcVM.LoadProcedureByName(proc);
        }

        private void EditButton_Clicked(object sender, EventArgs e)
        {
            procedureNameEntry.IsReadOnly = false;
            procedureDetailEntry.IsReadOnly = false;
            stepsEditor.IsReadOnly = false;
            variationsEditor.IsReadOnly = false;
            keyPointsEditor.IsReadOnly = false;
            complicationsEditor.IsReadOnly = false;
            historyEditor.IsReadOnly = false;
            referencesEditor.IsReadOnly = false;
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            //UpdateProcedureVM.UpdateExistingProcedure(loadedProcedure, procedureNameEntry.Text, procedureDetailEntry.Text);
            //UpdateProcedureVM.UpdateExistingSteps(loadedProcedure.Steps, stepsEditor.Text);
            //UpdateProcedureVM.UpdateExistingVariations(loadedProcedure.Variations, variationsEditor.Text);
            //UpdateProcedureVM.UpdateExistingKeyPoints(loadedProcedure.KeyPoints, keyPointsEditor.Text);
            //UpdateProcedureVM.UpdateExistingComplications(loadedProcedure.Complications, complicationsEditor.Text);
            //UpdateProcedureVM.UpdateExistingHistory(loadedProcedure.History, historyEditor.Text);
            //UpdateProcedureVM.UpdateExistingReferences(loadedProcedure.References, referencesEditor.Text);
        }
    }
}