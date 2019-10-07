using ESA.Data;
using ESA.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace ESA.ViewModels
{
    // Author: Wen Loong Lee
    // This base class will be used by inherited by classes
    // that add or list procedures

    public class BaseProcedureViewModel : INotifyPropertyChanged
    {
        public Procedure _procedure;
        public IProcedureRepository _procedureRepository; // To access Procedure Table
        public IValidator _procedureValidator;
        public INavigation _navigation;

        public string Category
        {
            get => _procedure.Category;
            set
            {
                _procedure.Category = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Name
        {
            get => _procedure.Name;
            set
            {
                _procedure.Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Details
        {
            get => _procedure.Details;
            set
            {
                _procedure.Details = value;
                NotifyPropertyChanged("Details");
            }
        }

        public string Steps
        {
            get => _procedure.Steps;
            set
            {
                _procedure.Steps = value;
                NotifyPropertyChanged("Steps");
            }
        }

        public string KeyPoints
        {
            get => _procedure.KeyPoints;
            set
            {
                _procedure.KeyPoints = value;
                NotifyPropertyChanged("KeyPoints");
            }
        }

        public string Variations
        {
            get => _procedure.Variations;
            set
            {
                _procedure.Variations = value;
                NotifyPropertyChanged("Variations");
            }
        }

        public string Complications
        {
            get => _procedure.Complications;
            set
            {
                _procedure.Complications = value;
                NotifyPropertyChanged("Complications");
            }
        }

        public string History
        {
            get => _procedure.History;
            set
            {
                _procedure.History = value;
                NotifyPropertyChanged("History");
            }
        }

        public string References
        {
            get => _procedure.References;
            set
            {
                _procedure.References = value;
                NotifyPropertyChanged("References");
            }
        }

        List<Procedure> _procedureList;
        public List<Procedure> ProcedureList
        {
            get => _procedureList;
            set
            {
                _procedureList = value;
                NotifyPropertyChanged("ProcedureList");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
