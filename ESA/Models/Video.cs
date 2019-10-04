using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    public class Video
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string URL { get; set; }
    }
}
