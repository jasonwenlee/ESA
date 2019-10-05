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
        public override int ID { get; set; }

        [ForeignKey(typeof(StepsModel))]
        public int StepsID_FK { get; set; }
        [ForeignKey(typeof(VariationsModel))]
        public int VariationsID_FK { get; set; }
        [ForeignKey(typeof(KeyPointsModel))]
        public int KeyPointsID_FK { get; set; }
        [ForeignKey(typeof(ComplicationsModel))]
        public int ComplicationsID_FK { get; set; }
        [ForeignKey(typeof(HistoryModel))]
        public int HistoryID_FK { get; set; }
        [ForeignKey(typeof(ReferencesModel))]
        public int ReferencesID_FK { get; set; }

        public override string Name { get; set; }
        public override string Details { get; set; }

        [ManyToOne]
        public override StepsModel Steps { get; set; }
        [ManyToOne]
        public override VariationsModel Variations { get; set; }
        [ManyToOne]
        public override KeyPointsModel KeyPoints { get; set; }
        [OneToOne]
        public override ComplicationsModel Complications { get; set; }
        [OneToOne]
        public override HistoryModel History { get; set; }
        [OneToOne]
        public override ReferencesModel References { get; set; }
    }
}
