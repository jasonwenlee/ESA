using ESA.Data;
using ESA.Models;
using ESA.Models.PageModels;
using ESA.Validator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ESA.ViewModels
{
    public class AddProcedureViewModel : BaseProcedureViewModel
    {
        public ICommand AddProcedureCommand { get; private set; } // For save procedure button click event
        public ICommand ViewAllProceduresCommand { get; private set; } // View all procedure button click event

        // Constructor 
        public AddProcedureViewModel()
        {
            _procedureValidator = new ProcedureValidator();
            _procedureRepository = App.ProcedureDatabase;
        }

        internal void AddNewProcedure(string procCategory, string name, string details)
        {
            //var validationResults = _procedureValidator.Validate(_procedure)

            if (procCategory.Equals("lacrimal"))
            {
                _procedure = new Lacrimal();
                _procedure.Name = name;
                _procedure.Details = details;
            }
            else if (procCategory.Equals("orbital"))
            {
                _procedure = new Orbital();
                _procedure.Name = name;
                _procedure.Details = details;
            }
            else if (procCategory.Equals("eyelid"))
            {
                _procedure = new Eyelid();
                _procedure.Name = name;
                _procedure.Details = details;
            }
            _procedureRepository.SaveProcedure(_procedure);
        }

        internal void AddNewSteps(string steps)
        {
            StepsModel _steps = new StepsModel();
            _steps.content = steps;
            _procedureRepository.SaveSteps(_steps, _procedure);
        }

        internal void AddNewVariations(string variations)
        {
            VariationsModel _variations = new VariationsModel();
            _variations.content = variations;
            _procedureRepository.SaveVariations(_variations, _procedure);
        }

        internal void AddKeyPoints(string keyPoints)
        {
            KeyPointsModel _keyPoints = new KeyPointsModel();
            _keyPoints.content = keyPoints;
            _procedureRepository.SaveKeyPoints(_keyPoints, _procedure);
        }

    }
}
