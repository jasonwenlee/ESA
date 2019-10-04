using ESA.Models;
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
    public partial class DisplayProcedureInfo : ContentPage
    {
        public DisplayProcedureInfo(Procedure proc)
        {
            InitializeComponent();
            if (proc is Lacrimal)
            {
                Lacrimal newProc = App.ProcedureDatabase.GetLacrimalName((Lacrimal)proc); 
                procedureCategoryEntry.Text = "Lacrimal";
                procedureNameEntry.Text = newProc.Name.ToString();
                procedureDetailEntry.Text = newProc.Details.ToString();
                stepsEditor.Text = newProc.Steps.content.ToString();
                variationsEditor.Text = newProc.KeyPoints.content.ToString();
                keyPointsEditor.Text = newProc.KeyPoints.content.ToString();
            }
            else if (proc is Orbital)
            {
                Orbital newProc = App.ProcedureDatabase.GetOrbitalName((Orbital)proc);
                procedureCategoryEntry.Text = "Orbital";
                procedureNameEntry.Text = newProc.Name.ToString();
                procedureDetailEntry.Text = newProc.Details.ToString();
                stepsEditor.Text = newProc.Steps.content.ToString();
                variationsEditor.Text = newProc.KeyPoints.content.ToString();
                keyPointsEditor.Text = newProc.KeyPoints.content.ToString();
            }
            else if (proc is Eyelid)
            {
                Eyelid newProc = App.ProcedureDatabase.GetEyelidName((Eyelid)proc);
                procedureCategoryEntry.Text = "Eyelid";
                procedureNameEntry.Text = newProc.Name.ToString();
                procedureDetailEntry.Text = newProc.Details.ToString();
                stepsEditor.Text = newProc.Steps.content.ToString();
                variationsEditor.Text = newProc.KeyPoints.content.ToString();
                keyPointsEditor.Text = newProc.KeyPoints.content.ToString();
            }
        }
    }
}