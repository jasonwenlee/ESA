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
    // Author: Jason Wen Lee
    // Class acts as controller for adding procedures into database. Information such as 
    // Steps, Variations, Key points, Complications, History, and References will also be 
    // added to the database.
    public class AddProcedureViewModel : BaseProcedureViewModel
    {
        public ICommand AddProcedureCommand { get; private set; } // For save procedure button click event. No use yet.
        public ICommand ViewAllProceduresCommand { get; private set; } // View all procedure button click event. No use yet.

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
                _procedureRepository.SaveProcedure(_procedure);
            }
            else if (procCategory.Equals("orbital"))
            {
                _procedure = new Orbital();
                _procedure.Name = name;
                _procedure.Details = details;
                _procedureRepository.SaveProcedure(_procedure);
            }
            else if (procCategory.Equals("eyelid"))
            {
                _procedure = new Eyelid();
                _procedure.Name = name;
                _procedure.Details = details;
                _procedureRepository.SaveProcedure(_procedure);
            }
        }

        internal void AddNewSteps(string steps)
        {
            StepsModel _steps = new StepsModel();
            if (_procedure is Lacrimal)
            {
                _steps.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)_procedure };
            }
            else if (_procedure is Orbital)
            {
                _steps.OrbitalProcedure = new List<Orbital> { (Orbital)_procedure };
            }
            else if (_procedure is Eyelid)
            {
                _steps.EyelidProcedure = new List<Eyelid> { (Eyelid)_procedure };
            }
            _steps.content = steps;
            _procedureRepository.SaveSteps(_steps);
        }

        internal void AddNewVariations(string variations)
        {
            VariationsModel _variations = new VariationsModel();
            if (_procedure is Lacrimal)
            {
                _variations.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)_procedure };
            }
            else if (_procedure is Orbital)
            {
                _variations.OrbitalProcedure = new List<Orbital> { (Orbital)_procedure };
            }
            else if (_procedure is Eyelid)
            {
                _variations.EyelidProcedure = new List<Eyelid> { (Eyelid)_procedure };
            }
            _variations.content = variations;
            _procedureRepository.SaveVariations(_variations);
        }

        internal void AddKeyPoints(string keyPoints)
        {
            KeyPointsModel _keyPoints = new KeyPointsModel();
            if (_procedure is Lacrimal)
            {
                _keyPoints.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)_procedure };
            }
            else if (_procedure is Orbital)
            {
                _keyPoints.OrbitalProcedure = new List<Orbital> { (Orbital)_procedure };
            }
            else if (_procedure is Eyelid)
            {
                _keyPoints.EyelidProcedure = new List<Eyelid> { (Eyelid)_procedure };
            }
            _keyPoints.content = keyPoints;
            _procedureRepository.SaveKeyPoints(_keyPoints);
        }

        internal void AddComplications(string keyPoints)
        {
            ComplicationsModel _complications = new ComplicationsModel();
            if (_procedure is Lacrimal)
            {
                _complications.LacrimalProcedure = (Lacrimal)_procedure;
            }
            else if (_procedure is Orbital)
            {
                _complications.OrbitalProcedure = (Orbital)_procedure;
            }
            else if (_procedure is Eyelid)
            {
                _complications.EyelidProcedure = (Eyelid)_procedure;
            }
            _complications.content = keyPoints;
            _procedureRepository.SaveComplications(_complications);
        }

        internal void AddHistory(string keyPoints)
        {
            HistoryModel _history = new HistoryModel();
            if (_procedure is Lacrimal)
            {
                _history.LacrimalProcedure = (Lacrimal)_procedure;
            }
            else if (_procedure is Orbital)
            {
                _history.OrbitalProcedure = (Orbital)_procedure;
            }
            else if (_procedure is Eyelid)
            {
                _history.EyelidProcedure = (Eyelid)_procedure;
            }
            _history.content = keyPoints;
            _procedureRepository.SaveHistory(_history);
        }
        internal void AddReferences(string keyPoints)
        {
            ReferencesModel _references = new ReferencesModel();
            if (_procedure is Lacrimal)
            {
                _references.LacrimalProcedure = (Lacrimal)_procedure;
            }
            else if (_procedure is Orbital)
            {
                _references.OrbitalProcedure = (Orbital)_procedure;
            }
            else if (_procedure is Eyelid)
            {
                _references.EyelidProcedure = (Eyelid)_procedure;
            }
            _references.content = keyPoints;
            _procedureRepository.SaveReferences(_references);
        }

    }
}
