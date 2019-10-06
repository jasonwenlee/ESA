using ESA.Models.PageModels;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    [Table("Orbital")]
    // Class for orbital procedure. This inherits from Procedure superclass.
    public class Orbital : Procedure
    {
        [PrimaryKey, AutoIncrement]
        public override int ID { get; set; }
        public override string Category { get; set; }
        public override string Name { get; set; }
        public override string Details { get; set; }
        public override string Steps { get; set; }
        public override string Variations { get; set; }
        public override string KeyPoints { get; set; }
        public override string Complications { get; set; }
        public override string History { get; set; }
        public override string References { get; set; }
    }
}
