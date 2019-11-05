using ESA.Models.Model;
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
        List<Procedure> GetListLacrimalProcedures();
        List<Procedure> GetListOrbitalProcedures();
        List<Procedure> GetListEyelidProcedures();
        Procedure GetLacrimalByID(int id);
        Procedure GetLacrimalByName(Procedure name);
        Procedure GetOrbitalByID(int id);
        Procedure GetOrbitalByName(Procedure name);
        Procedure GetEyelidByID(int id);
        Procedure GetEyelidByName(Procedure id);

        // For saving
        int SaveProcedure(Procedure item);

        // For updating
        int UpdateProcedure(Procedure item);

        int DeleteProcedure(Procedure item);
    }
}
