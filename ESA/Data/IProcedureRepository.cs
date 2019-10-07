using ESA.Models;
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

        // For updating
        int UpdateProcedure(Procedure item);

        int DeleteProcedure(Procedure item);
    }
}
