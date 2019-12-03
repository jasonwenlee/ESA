using ESA.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    public class MainViewModel
    {
        public List<Procedure> ProcedureNames;
        public List<Person> People;

        public MainViewModel()
        {
            People = new Person().GetPeople();
        }
    }
}
