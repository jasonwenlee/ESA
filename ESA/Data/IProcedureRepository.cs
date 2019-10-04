using ESA.Models;
using ESA.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ESA.Data
{
    // Author: Wen Loong Lee, Rodrigo Echeverria

    // This is the interface for procedure repository
    public interface IProcedureRepository
    {
        List<Lacrimal> GetListLacrimalProcedures();
        List<Orbital> GetListOrbitalProcedures();
        List<Eyelid> GetListEyelidProcedures();
        Lacrimal GetLacrimalProcedure(int id);
        Lacrimal GetLacrimalName(Lacrimal name);
        Orbital GetOrbitalProcedure(int id);
        Orbital GetOrbitalName(Orbital name);
        Eyelid GetEyelidProcedure(int id);
        Eyelid GetEyelidName(Eyelid id);

        int SaveProcedure(Procedure item);
        int SaveSteps(StepsModel steps, Procedure proc);
        int SaveVariations(VariationsModel steps, Procedure proc);
        int SaveKeyPoints(KeyPointsModel steps, Procedure proc);
        int DeleteProcedure(Procedure item);
    }
}
