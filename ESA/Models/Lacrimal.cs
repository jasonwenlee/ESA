using ESA.Models.PageModels;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    [Table("Lacrimal")]
    // Class for lacrimal procedure. This inherits from Procedure superclass.
    public class Lacrimal : Procedure
    {
        [PrimaryKey, AutoIncrement]
        public new int ID { get; set; }
        public new string Category { get; set; }
        public new string Name { get; set; }
        public new string Details { get; set; }
        public new string Steps { get; set; }
        public new string Variations { get; set; }
        public new string KeyPoints { get; set; }
        public new string Complications { get; set; }
        public new string History { get; set; }
        public new string References { get; set; }
    }
}

