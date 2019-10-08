using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ESA.Models;
using ESA.Views;

namespace ESA.ViewModels
{
   public class VariationPageViewModel
    {
        //      public ObservableCollection<VariationPageModel> VariationList { get; set; }
      
        public List<VariationsModel> VariationList { get; set; }
       

        public VariationPageViewModel()
        {
            VariationList = new VariationsModel().GetVariationList();
           
        }

    }
}
