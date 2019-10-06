using ESA.Data;
using ESA.Models;
using ESA.Models.PageModels;
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
    // added to the database.
    public class AddProcedureViewModel : BaseProcedureViewModel
    {
        public ICommand AddProcedureCommand { get; private set; } // For save procedure button click event. No use yet.
        public ICommand ViewAllProceduresCommand { get; private set; } // View all procedure button click event. No use yet.

        // Constructor 
        public AddProcedureViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _procedureValidator = new ProcedureValidator();
            _procedureRepository = App.ProcedureDatabase;
            _procedure = new Lacrimal();
            AddProcedureCommand = new Command(async () => await AddAllInformation());
        }

        async Task AddAllInformation()
        {
            var validationResults = _procedureValidator.Validate(_procedure);
            if (validationResults.IsValid)
            {
                AddNewProcedure(_procedure.Category);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Add Procedure", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }

        internal void AddNewProcedure(string Category)
        {
            if (Category.Equals("lacrimal"))
            {
                _procedure = (Lacrimal)_procedure;
                _procedureRepository.SaveProcedure(_procedure);
            }
            else if (Category.Equals("orbital"))
            {
                _procedure = (Orbital)_procedure;
                _procedureRepository.SaveProcedure(_procedure);
            }
            else if (Category.Equals("eyelid"))
            {
                _procedure = (Eyelid)_procedure;
                _procedureRepository.SaveProcedure(_procedure);
            }
        }
    }
}
