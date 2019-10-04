using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.PageModels
{
    [Table("References")]
    public class ReferencesModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string content { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public List<Eyelid> EyelidProcedure { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public List<Lacrimal> LacrimalProcedure { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public List<Orbital> OrbitalProcedure { get; set; }
    }
}
