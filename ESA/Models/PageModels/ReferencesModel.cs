﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.PageModels
{
    public class ReferencesModel
    {
        private List<ReferencesModel> refList;
        public List<ReferencesModel> RefList
        {
            get
            {
                return refList;
            }
            set
            {
                if (value != refList)
                {
                    refList = value;
                }
            }
        }

        public string details { get; set; }
        public int number { get; set; }

        public void LoadRefList()
        {
            List<ReferencesModel> referenceList = new List<ReferencesModel>()
                {
                    new ReferencesModel() {number = 1, details = "McClellan WT, Rawson AE.  Wendell L. Hughes' life and contributions to plastic surgery. Plast Reconstr Surg 2011; 128(6):765e-72e." ,
                    },
                    new ReferencesModel() {number = 2, details = "Hughes, Wendell L.  A new method for rebuilding a lower lid: report of a case.  Arch Ophthalmol 1937;17(6):1008-1017" ,
                    },
                    new ReferencesModel() {number = 3, details = "Rohrich RJ, Zbar R I. The evolution of the Hughes tarsoconjunctival flap for the lower eyelid reconstruction. B Plast Reconstr Surg 1999;104(2): 518-22" ,
                    },
                    new ReferencesModel() {number = 4, details = "Hughes, Wendell L. Reconstruction of the lids. Am J Ophthalmol 1945;28(11): 1203-1211" ,
                    },
                    new ReferencesModel() {number = 5, details = "Cies WA, Bartlett RE. Modification of the Mustardé and Hughes methods of reconstructing the lower lid.  Ann Ophthalmol 1975; 7(11):1497-1502." ,
                    },
                    new ReferencesModel() {number = 6, details = "Hughes WL. Total lower lid reconstruction: technical details. Trans Am Ophthalmol Soc1976; 74:321-9.",
                    },
                    new ReferencesModel() {number = 7, details = "McNab, AA, Martin P,  Benger R, O'Donnell B, Kourt G.  A prospective randomized study comparing division of the pedicle of modified hughes flaps at two or four weeks. Ophthalmic Plast Reconstr Surg 2001;17(5): 317-9 " ,
                    },
                    new ReferencesModel() {number = 8, details = "Leibovitch I, Selva D. Modified Hughes flap: division at 7 days. Ophthalmology. 2004;111(12):2164-2167"}
            };
            RefList = referenceList;
        }
    }
}