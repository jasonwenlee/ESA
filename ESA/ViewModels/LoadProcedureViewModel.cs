using ESA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ESA.ViewModels
{
    // Author: Jason Wen Lee
    public class LoadProcedureViewModel : BaseProcedureViewModel
    {
        // Property for procedures are set to private
        private ObservableCollection<Procedure> _lacrimalProcedures;
        private ObservableCollection<Procedure> _orbitalProcedures;
        private ObservableCollection<Procedure> _eyelidProcedures;
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

        public bool IsDataLoaded { get; private set; }

        // Constructor
        public LoadProcedureViewModel()
        {
            _procedureRepository = App.ProcedureDatabase;
        }

        public void LoadLacrimalList()
        {
            LacrimalProcedures = new ObservableCollection<Procedure>(_procedureRepository.GetListLacrimalProcedures());
            IsDataLoaded = true;
        }

        public void LoadOrbitalList()
        {
            OrbitalProcedures = new ObservableCollection<Procedure>(_procedureRepository.GetListOrbitalProcedures());
            IsDataLoaded = true;
        }

        public void LoadEyelidList()
        {
            EyelidProcedures = new ObservableCollection<Procedure>(_procedureRepository.GetListEyelidProcedures());
            IsDataLoaded = true;
        }

        public Procedure LoadProcedureByName(Procedure proc)
        {
            if (proc is Lacrimal)
            {
                return _procedureRepository.GetLacrimalByName((Lacrimal)proc);
            }
            else if (proc is Orbital)
            {
                return _procedureRepository.GetOrbitalByName((Orbital)proc);
            }
            else if (proc is Eyelid)
            {
                return _procedureRepository.GetEyelidByName((Eyelid)proc);
            }
            return null;
        }

        public Procedure LoadProcedureByID(Procedure procedureType, int ID)
        {
            if (procedureType is Lacrimal)
            {
                return _procedureRepository.GetLacrimalByID(ID);
            }
            else if (procedureType is Orbital)
            {
                return _procedureRepository.GetOrbitalByID(ID);
            }
            else if (procedureType is Eyelid)
            {
                return _procedureRepository.GetEyelidByID(ID);
            }
            return null;
        }
    }
}
