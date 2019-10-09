using ESA.Data;
using ESA.Models;
using ESA.Validator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ESA.ViewModels
{
    // Author: Jason Wen Lee
    // Class acts as controller for adding procedures into database. Information such as 
    // Steps, Variations, Key points, Complications, History, and References will also be 
    // added to the database based on procedure category.
    public class AddProcedureViewModel : BaseProcedureViewModel
    {
        public ICommand AddProcedureCommand { get; private set; } // For save procedure button click event
        public ICommand ViewAllProceduresCommand { get; private set; } // View all procedure button click event. No use yet.

        // Constructor 
        public AddProcedureViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _procedureValidator = new ProcedureValidator();
            _procedureRepository = App.ProcedureDatabase;
            _procedure = new Procedure();
            AddProcedureCommand = new Command(async () => await ValidateInformation());
        }

        async Task ValidateInformation()
        {
            // Validate properties in procedure
            var validationResults = _procedureValidator.Validate(_procedure);
            if (validationResults.IsValid)
            {
                CategoriseProcedure(_procedure.Category);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error!", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }

        internal void CategoriseProcedure(string Category)
        {
            if (Category.ToLower().Trim().Equals("lacrimal"))
            {
                Lacrimal thisProcedure = new Lacrimal();
                if (_procedure.ID == 0)
                {
                    thisProcedure.Category = _procedure.Category;
                    thisProcedure.Name = _procedure.Name;
                    thisProcedure.Details = _procedure.Details;
                    thisProcedure.Steps = _procedure.Steps;
                    thisProcedure.Variations = _procedure.Variations;
                    thisProcedure.KeyPoints = _procedure.KeyPoints;
                    thisProcedure.Complications = _procedure.Complications;
                    thisProcedure.History = _procedure.History;
                    thisProcedure.References = _procedure.References;
                    _procedureRepository.SaveProcedure(thisProcedure);
                }
            }
            else if (Category.ToLower().Trim().Equals("orbital"))
            {
                Orbital thisProcedure = new Orbital();
                if (_procedure.ID == 0)
                {
                    thisProcedure.Category = _procedure.Category;
                    thisProcedure.Name = _procedure.Name;
                    thisProcedure.Details = _procedure.Details;
                    thisProcedure.Steps = _procedure.Steps;
                    thisProcedure.Variations = _procedure.Variations;
                    thisProcedure.KeyPoints = _procedure.KeyPoints;
                    thisProcedure.Complications = _procedure.Complications;
                    thisProcedure.History = _procedure.History;
                    thisProcedure.References = _procedure.References;
                    _procedureRepository.SaveProcedure(thisProcedure);
                }
            }
            else if (Category.ToLower().Trim().Equals("eyelid"))
            {
                Eyelid thisProcedure = new Eyelid();
                if (_procedure.ID == 0)
                {
                    thisProcedure.Category = _procedure.Category;
                    thisProcedure.Name = _procedure.Name;
                    thisProcedure.Details = _procedure.Details;
                    thisProcedure.Steps = _procedure.Steps;
                    thisProcedure.Variations = _procedure.Variations;
                    thisProcedure.KeyPoints = _procedure.KeyPoints;
                    thisProcedure.Complications = _procedure.Complications;
                    thisProcedure.History = _procedure.History;
                    thisProcedure.References = _procedure.References;
                    _procedureRepository.SaveProcedure(thisProcedure);
                }
            }
        }
    }
}
