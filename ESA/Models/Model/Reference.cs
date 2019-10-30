using System;
using System.Collections.Generic;

namespace ESA.Models.Model
{
    public class Reference
    {
        public int Number { get; set; }
        public string Body { get; set; }

        internal List<Reference> GetReferences(int id)
        {
            List<Reference> references = new List<Reference>();
            switch(id)
            {
                case 0:
                    // Tarso
                    references = new List<Reference>()
                    {
                        new Reference()
                        {
                            Number = 1,
                            Body = "McClellan WT, Rawson AE.  Wendell L. Hughes' life and contributions to plastic surgery. Plast Reconstr Surg 2011; 128(6):765e-72e."
                        },
                        new Reference()
                        {
                            Number = 2,
                            Body = "Hughes, Wendell L.  A new method for rebuilding a lower lid: report of a case.  Arch Ophthalmol 1937;17(6):1008-1017"
                        },
                        new Reference()
                        {
                            Number = 3,
                            Body = "Rohrich RJ, Zbar R I. The evolution of the Hughes tarsoconjunctival flap for the lower eyelid reconstruction. B Plast Reconstr Surg 1999;104(2): 518-22​"
                        },
                        new Reference()
                        {
                            Number = 4,
                            Body = "Hughes, Wendell L. Reconstruction of the lids. Am J Ophthalmol 1945;28(11): 1203-1211"
                        },
                        new Reference()
                        {
                            Number = 5,
                            Body = "Hughes, Wendell L. Reconstruction of the lids. Am J Ophthalmol 1945;28(11): 1203-1211"
                        },
                        new Reference()
                        {
                            Number = 6,
                            Body = "Hughes WL. Total lower lid reconstruction: technical details. Trans Am Ophthalmol Soc1976; 74:321-9"
                        },
                        new Reference()
                        {
                            Number = 7,
                            Body = "McNab, AA, Martin P,  Benger R, O'Donnell B, Kourt G.  A prospective randomized study comparing division of the pedicle of modified hughes flaps at two or four weeks. Ophthalmic Plast Reconstr Surg 2001;17(5): 317-9"
                        },
                        new Reference()
                        {
                            Number = 8,
                            Body = "Leibovitch I, Selva D. Modified Hughes flap: division at 7 days. Ophthalmology. 2004;111(12):2164-2167​"
                        }
                    };
                    break;

                case 1:
                    // Tenzel
                    references = new List<Reference>()
                    {
                        new Reference()
                        {
                            Number = 1,
                            Body = "Tenzel RR, Stewart WB. Eyelid Reconstruction by the Semicircle Flap Technique. Ophthalmology 1978; 85: 1164-69​"
                        }
                    };
                    break;

                case 2:
                    // Graft
                    references = new List<Reference>()
                    {
                        new Reference()
                        {
                            Number = 1,
                            Body = "Wolfe JR. A new method of performing plastic operations. British Medical Journal1875;ii:360​"
                        },
                        new Reference()
                        {
                            Number = 2,
                            Body = "Lawson G. Case of skin-grafting. Lancet1870;ii:567​"
                        },
                        new Reference()
                        {
                            Number = 3,
                            Body = "Lawson G. On the transplantation of portions of skin for the closure of large granulating surfaces. Medical Times Gazette1870;II:631"
                        },
                        new Reference()
                        {
                            Number = 4,
                            Body = "Le Fort.  Blepharoplastie par un lambeau completement detache du bras et reporte a la face.  Bull Soc Chir Paris 1872;1:39​"
                        },
                        new Reference()
                        {
                            Number = 5,
                            Body = "Hauben DJ, Baruchin A, Mahler D. On the history of the free skin graft. Annals of Plastic Surgery 1982;IX:242–6​"
                        },
                        new Reference()
                        {
                            Number = 6,
                            Body = "Krause F.  Ueber die transplantation grosser ungestielter hautlappen.  Verhandl Deutsch Ges Chir 1893;22:46​"
                        },
                        new Reference()
                        {
                            Number = 7,
                            Body = "Tyers AG & Collin JRO (2001): Colour atlas of ophthalmic plastic surgery. Oxford: Butterworth Heinemann 28–29."
                        },
                        new Reference()
                        {
                            Number = 8,
                            Body = "Divine RD, Anderson RL. Techniques in eyelid wound closure.  Ophthalmic Surg 1982;13(4):283-7.​"
                        },
                        new Reference()
                        {
                            Number = 9,
                            Body = "Rathore DS, Chickadasarahilli S, Crossman R, Mehta P, Ahluwalia HS. Full thickness skin grafts in periocular reconstructions: long-term outcomes. Ophthalmic Plast Reconstr Surg 2014;30(6):517-20​​"
                        },
                        new Reference()
                        {
                            Number = 10,
                            Body = "Jackson CM, Nguyen M, Mancini R. Use of Cyanoacrylate Glue Casting for Stabilization of Periocular Skin Grafts and Flaps. Ophthalmic Plast Reconstr Surg 2017;33(3):218-220​​"
                        },
                        new Reference()
                        {
                            Number = 11,
                            Body = "McGregor AD & McGregor IA.  Free skin grafts, In: McGregor AD (ed) & McGregor IA (ed). Fundamental techniques of plastic surgery and their surgical applications.  10th edition.  Churchill Livingstone.  2000. Pg 39-63.​​"
                        },
                        new Reference()
                        {
                            Number = 12,
                            Body = "Thorne CH.  Techniques and principles in plastic surgery, In: Thorne CH (ed-in-chief).  Grabb and Smith’s plastic surgery. 7th edition. Lippincott Williams & Wilkins. 2014. Pg 1-12.​"
                        }
                    };
                    break;
            }

            return references;
        }
    }
}