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
        private AddProcedureViewModel AddProcVM;
        Procedure test;

        public ProcedureType()
        {
            InitializeComponent();
            BindingContext = new AddProcedureViewModel(Navigation);
        }


        //private async void AddInformationButtonMVVM_Clicked(object sender, EventArgs e)
        //{
        //    if (procedureNameEntry.Text == null || procedureDetailEntry.Text == null)
        //    {
        //        await DisplayAlert("Alert", "Empty fields", "OK");
        //        return;
        //    }

        //    if (procedureCategoryEntry.Text.ToLower().Equals("lacrimal")
        //        || procedureCategoryEntry.Text.ToLower().Equals("orbital")
        //        || procedureCategoryEntry.Text.ToLower().Equals("eyelid"))
        //    {
        //        AddProcVM.AddNewProcedure(procedureCategoryEntry.Text.ToLower(), procedureNameEntry.Text, procedureDetailEntry.Text);
        //        AddProcVM.AddNewSteps(stepsEditor.Text);
        //        AddProcVM.AddKeyPoints(keyPointsEditor.Text);
        //        AddProcVM.AddNewVariations(variationsEditor.Text);
        //        AddProcVM.AddComplications(complicationsEditor.Text);
        //        AddProcVM.AddHistory(historyEditor.Text);
        //        AddProcVM.AddReferences(referencesEditor.Text);
        //        await DisplayAlert("Cool", "Please proceed", "OK");
        //        await Navigation.PopAsync();
        //    }
        //}


    }
}