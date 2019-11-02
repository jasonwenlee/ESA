using ESA.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    public class ProcedureViewModel
    {
        public Procedure Procedure { get; set; }
        public List<Procedure> ProcedureNames { get; set; }

        public ProcedureViewModel(int id)
        {
            ProcedureNames = new Procedure().GetProcedureNames();
            Procedure = new Procedure().GetProcedure(id);
        }

        public Procedure GetProcedure(int id)
        {
            Procedure = new Procedure().GetProcedure(id);
            return Procedure;
        }
    }
}
