using ESA.Models;
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

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayProcedureInfo : ContentPage
    {
        LoadProcedureViewModel LoadProcVM;

        public DisplayProcedureInfo(Procedure proc)
        {
            InitializeComponent();
            LoadProcVM = new LoadProcedureViewModel();
            LoadChosenProcedure(proc);
        }

        private void LoadChosenProcedure(Procedure proc)
        {
            Procedure loaded = LoadProcVM.LoadProcedureByName(proc);
            procedureNameEntry.Text = loaded.Name.ToString();
            procedureDetailEntry.Text = loaded.Details.ToString();
            stepsEditor.Text = loaded.Steps.content.ToString();
            variationsEditor.Text = loaded.Variations.content.ToString();
            keyPointsEditor.Text = loaded.KeyPoints.content.ToString();
            complicationsEditor.Text = loaded.Complications.content.ToString();
            historyEditor.Text = loaded.History.content.ToString();
            referencesEditor.Text = loaded.References.content.ToString();
        }
    }
}