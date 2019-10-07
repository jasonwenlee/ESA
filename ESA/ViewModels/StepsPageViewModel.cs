using ESA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ESA.ViewModels
{
    public class StepsPageViewModel : ObservableCollection<StepsPageModel>, INotifyPropertyChanged
    {
        private bool _expanded;

        public string Title { get; set; }
        static string ShortName { get; set; }
        public bool Expanded
        {
            get { return _expanded; }
            set
            {
                if (_expanded != value)
                {
                    _expanded = value;

                    OnPropertyChanged("Expanded");
                    OnPropertyChanged("StateIcon");
                }

            }
        }
        public string StateIcon
        {
            get { return Expanded ? "expand_more.png" : "expand_less.png"; }
        }
        public int StepsItems { get; set; }
        public StepsPageViewModel(string title, bool expanded = false)
        {
            Title = title;
            Expanded = expanded;
        }
        public static ObservableCollection<StepsPageViewModel> Contents { private set; get; }
        static StepsPageViewModel()
        {
            ObservableCollection<StepsPageViewModel> Items = new ObservableCollection<StepsPageViewModel>
        {
            new StepsPageViewModel("Step1"){
            new StepsPageModel {Description = "More details about this step 1 comes here ,  and more about step1"
            }},
             new StepsPageViewModel("Step2"){
            new StepsPageModel {Description = "More details about this step2 comes here ,  and more about step 2"
            }},
            new StepsPageViewModel("Step3"){
            new StepsPageModel {Description = "More details about this step3 comes here ,  and more about step 3"
            }}





             };
            Contents = Items;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


