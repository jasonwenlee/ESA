﻿using ESA.Models;
using ESA.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ESA.Data
{
    // Author: Jason Wen Lee
    // This is the interface for procedure repository
    public interface IProcedureRepository
    {
        // For loading
        List<Lacrimal> GetListLacrimalProcedures();
        List<Orbital> GetListOrbitalProcedures();
        List<Eyelid> GetListEyelidProcedures();
        Lacrimal GetLacrimalByID(int id);
        Lacrimal GetLacrimalByName(Lacrimal name);
        Orbital GetOrbitalByID(int id);
        Orbital GetOrbitalByName(Orbital name);
        Eyelid GetEyelidByID(int id);
        Eyelid GetEyelidByName(Eyelid id);

        // For saving
        int SaveProcedure(Procedure item);
        void SaveSteps(StepsModel steps);
        void SaveVariations(VariationsModel steps);
        void SaveKeyPoints(KeyPointsModel steps);
        void SaveComplications(ComplicationsModel steps);
        void SaveHistory(HistoryModel steps);
        void SaveReferences(ReferencesModel steps);

        // For updating
        int UpdateProcedure(Procedure item);
        void UpdateSteps(StepsModel steps);
        void UpdateVariations(VariationsModel steps);
        void UpdateKeyPoints(KeyPointsModel steps);
        void UpdateComplications(ComplicationsModel steps);
        void UpdateHistory(HistoryModel steps);
        void UpdateReferences(ReferencesModel steps);

        int DeleteProcedure(Procedure item);
    }
}