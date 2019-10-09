using ESA.Models.PageModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace ESA.ViewModels.InfoView
{
    class BaseInfoViewModel : INotifyPropertyChanged
    {
        public INavigation navigation;
        public ReferencesModel references;

        //public int Number
        //{
        //    get => references.Number;
        //    set
        //    {
        //        references.Number = value;
        //        NotifyPropertyChanged("Number");
        //    }
        //}

        //public string Ref
        //{
        //    get => references.Ref;
        //    set
        //    {
        //        references.Ref = value;
        //        NotifyPropertyChanged("Ref");
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
