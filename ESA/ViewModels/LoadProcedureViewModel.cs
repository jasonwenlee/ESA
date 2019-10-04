using ESA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ESA.ViewModels
{
    public class LoadProcedureViewModel : BaseProcedureViewModel
    {
        // Property for procedures are set to private
        private ObservableCollection<Procedure> _lacrimalProcedures;
        private ObservableCollection<Procedure> _orbitalProcedures;
        private ObservableCollection<Procedure> _eyelidProcedures;

        public bool IsDataLoaded { get; private set; }

        public LoadProcedureViewModel()
        {
            _procedureRepository = App.ProcedureDatabase;
        }

        // Getter for procedures. Procedures are only set in this class.
        public ObservableCollection<Procedure> LacrimalProcedures
        {
            get
            {
                return _lacrimalProcedures;
            }
            set
            {
                if (value != _lacrimalProcedures)
                {
                    _lacrimalProcedures = value;
                }
            }
        }
        public ObservableCollection<Procedure> OrbitalProcedures
        {
            get
            {
                return _orbitalProcedures;
            }
            set
            {
                if (value != _orbitalProcedures)
                {
                    _orbitalProcedures = value;
                }
            }
        }
        public ObservableCollection<Procedure> EyelidProcedures
        {
            get
            {
                return _eyelidProcedures;
            }
            set
            {
                if (value != _eyelidProcedures)
                {
                    _eyelidProcedures = value;
                }
            }
        }

        public void LoadLacrimalData()
        {
            LacrimalProcedures = new ObservableCollection<Procedure>(_procedureRepository.GetListLacrimalProcedures());
            IsDataLoaded = true;
        }

        public void LoadOrbitalData()
        {
            OrbitalProcedures = new ObservableCollection<Procedure>(_procedureRepository.GetListOrbitalProcedures());
            IsDataLoaded = true;
        }

        public void LoadEyelidData()
        {
            EyelidProcedures = new ObservableCollection<Procedure>(_procedureRepository.GetListEyelidProcedures());
            IsDataLoaded = true;
        }

        // public async void LoadLacrimalByName(string name)
        // public async void LoadOrbitalByName(string name)
        // public async void LoadEyelidByName(string name)

    }
}
