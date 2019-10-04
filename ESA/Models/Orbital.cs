using ESA.Models.PageModels;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    // Class for orbital procedure. This inherits from Procedure superclass.
    public class Orbital : Procedure
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(StepsModel))]
        public int StepsID_FK { get; set; }
        [ForeignKey(typeof(VariationsModel))]
        public int VariationsID_FK { get; set; }
        [ForeignKey(typeof(KeyPointsModel))]
        public int KeyPointsID_FK { get; set; }

        public override string Name { get; set; }
        public override string Details { get; set; }

        [ManyToOne]
        public override StepsModel Steps { get; set; }
        [ManyToOne]
        public override VariationsModel Variations { get; set; }
        [ManyToOne]
        public override KeyPointsModel KeyPoints { get; set; }
    }
}
