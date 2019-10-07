using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    // Lacrimal, Orbital, and Eyelid are types of procedures so
    // they will inherit from Procedure class.
    // This might make searching for all procedures easier. Not sure.
    // Will change or remove if need to :)

    public class Procedure
    {
        // Add more properties or methods
        public int ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Steps { get; set; }
        public string KeyPoints { get; set; }
        public string Variations { get; set; }
        public string Complications { get; set; }
        public string History { get; set; }
        public string References { get; set; }
    }
}
