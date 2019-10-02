using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ESA.Models;


namespace ESA.ViewModels
{
   public class TasoconjuctivalFlapStepsViewModel
    {
        public ObservableCollection<MyListModel> MyListCollector
        { get; set; }
     

        public TasoconjuctivalFlapStepsViewModel()
        {

            MyListCollector = new ObservableCollection<MyListModel>()
            {
                new MyListModel { id=1, Steps="Step 1", StepsDetails="fdgdg sddgdg sdg" },
                 new MyListModel() { id=2, Steps="Step 2", StepsDetails="dgdgdg dvdg vdvd" }

            };
        }
    }
}
