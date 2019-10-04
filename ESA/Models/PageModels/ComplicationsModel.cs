using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.PageModels
{
    [Table("Complications")]
    public class ComplicationsModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string content { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Eyelid EyelidProcedure { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Lacrimal LacrimalProcedure { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Orbital OrbitalProcedure { get; set; }
    }
}
