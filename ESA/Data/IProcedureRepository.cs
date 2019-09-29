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
        List<Lacrimal> GetListLacrimalProceduresAsync();
        List<Orbital> GetListOrbitalProceduresAsync();
        List<Eyelid> GetListEyelidProceduresAsync();
        Lacrimal GetLacrimalProcedureAsync(int id);
        Lacrimal GetLacrimalNameAsync(string name);
        Orbital GetOrbitalProcedureAsync(int id);
        Eyelid GetEyelidProcedureAsync(int id);
        int SaveProcedureAsync(Procedure item);
        int SaveStepsAsync(StepsModel steps, Procedure proc);
        int DeleteProcedureAsync(Procedure item);
    }
}
