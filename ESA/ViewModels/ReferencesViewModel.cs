using ESA.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    public class ReferencesViewModel
    {
        public List<ReferencesModel> RefList { get; set; }


        public ReferencesViewModel()
        {

            RefList = new ReferencesModel().GetReferences();
        }
    }
}
