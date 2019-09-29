using ESA.Models.PageModels;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    [Table("Eyelid")]
    // Class for eyelid procedure. This inherits from Procedure superclass.
    public class Eyelid : Procedure
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(StepsModel))]
        public int StepsID_FK { get; set; }

        public override string Name { get; set; }
        public override string Details { get; set; }

        [ManyToOne]
        public StepsModel Steps { get; set; }
    }
}
