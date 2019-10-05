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
        public abstract string Name { get; set; }
        public abstract string Details { get; set; }
        public abstract StepsModel Steps { get; set; }
        public abstract KeyPointsModel KeyPoints { get; set; }
        public abstract VariationsModel Variations { get; set; }
        public abstract ComplicationsModel Complications { get; set; }
        public abstract HistoryModel History { get; set; }
        public abstract ReferencesModel References { get; set; }
    }
}
