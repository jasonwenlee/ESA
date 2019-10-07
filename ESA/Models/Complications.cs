using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    public class Complications
    {
        public string DescPhotoText { get; set; }
        public string ImageUrl { get; set; }



        public override string ToString()
        {
            return DescPhotoText;
        }
    }
}
