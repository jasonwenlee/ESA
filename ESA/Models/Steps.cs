using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    public class Steps
    {
        public int StepNumber { get; set; }

        public string StepText { get; set; }

        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return StepText;
        }
    }
}
