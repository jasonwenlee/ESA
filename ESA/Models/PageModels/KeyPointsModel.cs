using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.PageModels
{
    public class KeyPointsModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string content { get; set; }
    }
}
