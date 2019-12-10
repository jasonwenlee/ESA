using ESA.Models.Model;
using System.Collections.Generic;

namespace ESA.ViewModels
{
    public class MainViewModel
    {
        public List<Procedure> ProcedureNames;
        public List<Person> People;

        public MainViewModel()
        {
            ProcedureNames = new Procedure().GetProcedureNames();
            People = new Person().GetPeople();
        }
    }
}
