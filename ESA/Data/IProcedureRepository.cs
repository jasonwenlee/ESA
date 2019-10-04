using ESA.Models;
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
        List<Lacrimal> GetListLacrimalProcedures();
        List<Orbital> GetListOrbitalProcedures();
        List<Eyelid> GetListEyelidProcedures();
        Lacrimal GetLacrimalByID(int id);
        Lacrimal GetLacrimalByName(Lacrimal name);
        Orbital GetOrbitalByID(int id);
        Orbital GetOrbitalByName(Orbital name);
        Eyelid GetEyelidByID(int id);
        Eyelid GetEyelidByName(Eyelid id);

        int SaveProcedure(Procedure item);
        int SaveSteps(StepsModel steps, Procedure proc);
        int SaveVariations(VariationsModel steps, Procedure proc);
        int SaveKeyPoints(KeyPointsModel steps, Procedure proc);
        int SaveComplications(ComplicationsModel steps, Procedure proc);
        int SaveHistory(HistoryModel steps, Procedure proc);
        int SaveReferences(ReferencesModel steps, Procedure proc);
        int DeleteProcedure(Procedure item);
    }
}
