using ESA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    public class PersonViewModel
    {
        public List<Person> People { get; set; }

        public PersonViewModel()
        {
            People = new Person().GetPeople();
        }
    }
}
