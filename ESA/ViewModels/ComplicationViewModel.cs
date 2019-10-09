﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ESA.Models;
using ESA.Views;

namespace ESA.ViewModels
{
   public class ComplicationViewModel
    {
        public List<Complications> ComplicationList { get; set; }

        public ComplicationViewModel()
        {
            ComplicationList = new Complications().GetComplicationsList();
        }

       
    }
}