using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.PageModels
{
    [Table("Steps")]
    public class StepsModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string content { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Eyelid> EyelidProcedure { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Lacrimal> LacrimalProcedure { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Orbital> OrbitalProcedure { get; set; }
    }
}
