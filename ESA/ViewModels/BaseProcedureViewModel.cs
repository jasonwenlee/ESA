using ESA.Data;
using ESA.Models;
using ESA.Models.PageModels;
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

        public StepsModel Steps
        {
            get => _procedure.Steps;
            set
            {
                _procedure.Steps = value;
                NotifyPropertyChanged("Steps");
            }
        }

        public KeyPointsModel KeyPoints
        {
            get => _procedure.KeyPoints;
            set
            {
                _procedure.KeyPoints = value;
                NotifyPropertyChanged("KeyPoints");
            }
        }

        public VariationsModel Variations
        {
            get => _procedure.Variations;
            set
            {
                _procedure.Variations = value;
                NotifyPropertyChanged("Variations");
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
