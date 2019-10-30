using ESA.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    public class ProcedureViewModel
    {
        public Procedure Procedure { get; set; }

        public ProcedureViewModel(int id)
        {
            Procedure = new Procedure().GetProcedure(id);
        }
    }
}
