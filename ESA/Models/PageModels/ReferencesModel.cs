using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.PageModels
{
    public class ReferencesModel
    {
        public int Number { get; set; }
        public string RefDetails { get; set; }
        public string RefLink { get; set; }
        public string HistoryDetails { get; set; }





        //     public void LoadRefList()
        public List<ReferencesModel> GetReferences()
        {

            List<ReferencesModel> referenceList = new List<ReferencesModel>()
                {
                    new ReferencesModel() {Number = 1, RefDetails = "McClellan WT, Rawson AE.  Wendell L. Hughes' life and contributions to plastic surgery. Plast Reconstr Surg 2011; 128(6):765e-72e." ,
                    HistoryDetails = "Dr Wendel Hughes, an ophthalmologist who contributed to the field of oculoplastic surgery, published his first paper on tarsoconjunctival flaps in 1937." 
                    },
                    new ReferencesModel() {Number = 2, RefDetails = "Hughes, Wendell L.  A new method for rebuilding a lower lid: report of a case.  Arch Ophthalmol 1937;17(6):1008-1017" ,
                    HistoryDetails = " Further modifications to the technique by Hughes and others occurred throughout subsequent decades." 
                    },
                    new ReferencesModel() {Number = 3, RefDetails = "Rohrich RJ, Zbar R I. The evolution of the Hughes tarsoconjunctival flap for the lower eyelid reconstruction. B Plast Reconstr Surg 1999;104(2): 518-22" ,
                    HistoryDetails = " Significant developments included using full-thickness skin grafting of the tarsoconjunctival flap, sparing of the marginal upper lid tarsus, and removal of the levator muscle complex from the tarsoconjunctival flap. This led to the reduction in upper lid complications, such as upper lid retraction, entropion, and trichiasis. Traditionally, flap division occurred 3 to 4 months after the initial stage.Currently the standard time to flap division is frequently 2 weeks, but can be carried out from 7 days with good outcome."
                    },
                    new ReferencesModel() {Number = 4, RefDetails = "Hughes, Wendell L. Reconstruction of the lids. Am J Ophthalmol 1945;28(11): 1203-1211" ,
                    },
                    new ReferencesModel() {Number = 5, RefDetails = "Cies WA, Bartlett RE. Modification of the Mustardé and Hughes methods of reconstructing the lower lid.  Ann Ophthalmol 1975; 7(11):1497-1502." ,
                    },
                    new ReferencesModel() {Number = 6, RefDetails = "Hughes WL. Total lower lid reconstruction: technical details. Trans Am Ophthalmol Soc1976; 74:321-9.",
                    },
                    new ReferencesModel() {Number = 7, RefDetails = "McNab, AA, Martin P,  Benger R, O'Donnell B, Kourt G.  A prospective randomized study comparing division of the pedicle of modified hughes flaps at two or four weeks. Ophthalmic Plast Reconstr Surg 2001;17(5): 317-9 " ,
                    },
                    new ReferencesModel() {Number = 8, RefDetails = "Leibovitch I, Selva D. Modified Hughes flap: division at 7 days. Ophthalmology. 2004;111(12):2164-2167"}
            };
            return referenceList;
        }

    }
}
