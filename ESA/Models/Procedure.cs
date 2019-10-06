using ESA.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    // Lacrimal, Orbital, and Eyelid are types of procedures so
    // they will inherit from Procedure class.
    // This might make searching for all procedures easier. Not sure.
    // Will change or remove if need to :)

    public abstract class Procedure
    {
        // Add more properties or methods
        public abstract int ID { get; set; }
        public abstract string Category { get; set; }
        public abstract string Name { get; set; }
        public abstract string Details { get; set; }
        public abstract string Steps { get; set; }
        public abstract string KeyPoints { get; set; }
        public abstract string Variations { get; set; }
        public abstract string Complications { get; set; }
        public abstract string History { get; set; }
        public abstract string References { get; set; }
    }
}
