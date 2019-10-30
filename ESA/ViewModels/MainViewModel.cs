using ESA.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    public class MainViewModel
    {
        public List<int> Procedures = new List<int>();
        public MainViewModel()
        {
            Procedures = new Procedure().GetProcedureIds();
        }
    }
}
