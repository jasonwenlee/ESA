using ESA.Models.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        private ObservableCollection<Procedure> _allProcedures;

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
        public ObservableCollection<Procedure> AllProcedures
        {
            get
            {
                return _allProcedures;
            }
            set
            {
                if (value != _eyelidProcedures)
                {
                    _allProcedures = value;
                }
            }
        }


        public bool IsDataLoaded { get; private set; }

        // Constructor
        public LoadProcedureViewModel()
        {
            _procedureRepository = App.ProcedureDatabase;
        }

        public void LoadAllProcedureList()
        {
            LoadLacrimalList();
            LoadOrbitalList();
            LoadEyelidList();
            var shadowCopy = new ObservableCollection<Procedure>(LacrimalProcedures.Concat(OrbitalProcedures).Concat(EyelidProcedures));
            AllProcedures = shadowCopy;
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
            if (proc is Procedure)
            {
                return _procedureRepository.GetLacrimalByName((Procedure)proc);
            }
            else if (proc is Procedure)
            {
                return _procedureRepository.GetOrbitalByName((Procedure)proc);
            }
            else if (proc is Procedure)
            {
                return _procedureRepository.GetEyelidByName((Procedure)proc);
            }
            return null;
        }
        public Procedure LoadProcedureByID(Procedure procedureType, int ID)
        {
            if (procedureType is Procedure)
            {
                return _procedureRepository.GetLacrimalByID(ID);
            }
            else if (procedureType is Procedure)
            {
                return _procedureRepository.GetOrbitalByID(ID);
            }
            else if (procedureType is Procedure)
            {
                return _procedureRepository.GetEyelidByID(ID);
            }
            return null;
        }
    }
}
