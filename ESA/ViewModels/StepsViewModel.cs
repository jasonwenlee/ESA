using ESA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    public class StepsViewModel
    {
        public List<Step> Steps { get; set; }

        public StepsViewModel()
        {
            Steps = new Step().GetSteps();
        }
    }
}
