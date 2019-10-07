using ESA.Models;
using ESA.Validator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    // Author: Jason Wen Lee
    // Class acts as controller for updating procedures in database. Information such as 
    // Steps, Variations, Key points, Complications, History, and References will also be 
    // updated in database.

    public class UpdateProcedureViewModel : BaseProcedureViewModel
    {
        public UpdateProcedureViewModel()
        {
            _procedureValidator = new ProcedureValidator();
            _procedureRepository = App.ProcedureDatabase;
        }

        //internal void UpdateExistingProcedure(Procedure proc, string name, string details)
        //{
        //    //var validationResults = _procedureValidator.Validate(_procedure)

        //    if (proc is Lacrimal)
        //    {
        //        _procedure = proc;
        //        _procedure.Name = name;
        //        _procedure.Details = details;
        //        _procedureRepository.UpdateProcedure(_procedure);
        //    }
        //    else if (proc is Orbital)
        //    {
        //        _procedure = proc;
        //        _procedure.Name = name;
        //        _procedure.Details = details;
        //        _procedureRepository.UpdateProcedure(_procedure);
        //    }
        //    else if (proc is Eyelid)
        //    {
        //        _procedure = proc;
        //        _procedure.Name = name;
        //        _procedure.Details = details;
        //        _procedureRepository.UpdateProcedure(_procedure);
        //    }
        //}

        //internal void UpdateExistingSteps(StepsModel _steps,  string steps)
        //{
        //    if (_steps.ID != 0)
        //    {
        //        if (_procedure is Lacrimal)
        //        {
        //            _steps.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)_procedure };
        //        }
        //        else if (_procedure is Orbital)
        //        {
        //            _steps.OrbitalProcedure = new List<Orbital> { (Orbital)_procedure };
        //        }
        //        else if (_procedure is Eyelid)
        //        {
        //            _steps.EyelidProcedure = new List<Eyelid> { (Eyelid)_procedure };
        //        }
        //    }
        //    _steps.content = steps;
        //    _procedureRepository.UpdateSteps(_steps);
        //}

        //internal void UpdateExistingVariations(VariationsModel _variations, string variations)
        //{
        //    if (_variations.ID != 0)
        //    {
        //        if (_procedure is Lacrimal)
        //        {
        //            _variations.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)_procedure };
        //        }
        //        else if (_procedure is Orbital)
        //        {
        //            _variations.OrbitalProcedure = new List<Orbital> { (Orbital)_procedure };
        //        }
        //        else if (_procedure is Eyelid)
        //        {
        //            _variations.EyelidProcedure = new List<Eyelid> { (Eyelid)_procedure };
        //        }
        //    }
        //    _variations.content = variations;
        //    _procedureRepository.UpdateVariations(_variations);
        //}

        //internal void UpdateExistingKeyPoints(KeyPointsModel _keyPoints, string keyPoints)
        //{
        //    if (_keyPoints.ID != 0)
        //    {
        //        if (_procedure is Lacrimal)
        //        {
        //            _keyPoints.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)_procedure };
        //        }
        //        else if (_procedure is Orbital)
        //        {
        //            _keyPoints.OrbitalProcedure = new List<Orbital> { (Orbital)_procedure };
        //        }
        //        else if (_procedure is Eyelid)
        //        {
        //            _keyPoints.EyelidProcedure = new List<Eyelid> { (Eyelid)_procedure };
        //        }
        //    }
        //    _keyPoints.content = keyPoints;
        //    _procedureRepository.UpdateKeyPoints(_keyPoints);
        //}

        //internal void UpdateExistingComplications(ComplicationsModel _complications, string complications)
        //{
        //    if (_complications.ID != 0)
        //    {
        //        if (_procedure is Lacrimal)
        //        {
        //            _complications.LacrimalProcedure = (Lacrimal)_procedure;
        //        }
        //        else if (_procedure is Orbital)
        //        {
        //            _complications.OrbitalProcedure = (Orbital)_procedure;
        //        }
        //        else if (_procedure is Eyelid)
        //        {
        //            _complications.EyelidProcedure = (Eyelid)_procedure;
        //        }
        //    }
        //    _complications.content = complications;
        //    _procedureRepository.UpdateComplications(_complications);
        //}

        //internal void UpdateExistingHistory(HistoryModel _history, string history)
        //{
        //    if (_history.ID != 0)
        //    {
        //        if (_procedure is Lacrimal)
        //        {
        //            _history.LacrimalProcedure = (Lacrimal)_procedure;
        //        }
        //        else if (_procedure is Orbital)
        //        {
        //            _history.OrbitalProcedure = (Orbital)_procedure;
        //        }
        //        else if (_procedure is Eyelid)
        //        {
        //            _history.EyelidProcedure = (Eyelid)_procedure;
        //        }
        //    }
        //    _history.content = history;
        //    _procedureRepository.SaveHistory(_history);
        //}

        //internal void UpdateExistingReferences(ReferencesModel _references, string references)
        //{
        //    if (_references.ID != 0)
        //    {
        //        if (_procedure is Lacrimal)
        //        {
        //            _references.LacrimalProcedure = (Lacrimal)_procedure;
        //        }
        //        else if (_procedure is Orbital)
        //        {
        //            _references.OrbitalProcedure = (Orbital)_procedure;
        //        }
        //        else if (_procedure is Eyelid)
        //        {
        //            _references.EyelidProcedure = (Eyelid)_procedure;
        //        }
        //    }
        //    _references.content = references;
        //    _procedureRepository.SaveReferences(_references);
        //}

    }
}
