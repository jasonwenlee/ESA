using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.Model
{
    public class Variation
    {
        public string Content { get; set; }

        internal List<Variation> GetVariations(int id)
        {
            List<Variation> varsd = new List<Variation>();
            //List<VariationsModel> vars = new List<VariationsModel>();

            switch (id)
            {
                case 0:
                    // Tarso Hughes
                    varsd = new List<Variation>()
                    {
                        new Variation() { Content = "Variations in steps" },
                        new Variation() { Content = "Size of flap" },
                        new Variation() { Content = "Wider flap may need a straighter horizonal incision without vertical relieving incisions."},
                        new Variation() { Content = "Tarsoconjunctival-based or Tarsoconjunctival-Muller-based flap​."},
                        new Variation() { Content = "Conjunctiva and Mullers together allow better vascularsation of the flap."},
                        new Variation() { Content = "If advancing Mullers, which is an eyelid retractor, there may be a higher risk of post operative eyelid retraction that advancing conjunctiva alone."},
                    };   
                    break;
                case 1:
                    // Tenzel
                    varsd = new List<Variation>()
                    {
                        new Variation() { Content = "Defects greater on the lower than upper eyelid" },
                        new Variation() { Content = "Any lid defect - Lateral/Central/Medial"},
                        new Variation() { Content = "Central to Medial"},
                        new Variation() { Content = "Moving eyelid from lateral to Medial"},
                    };
                    break;
                case 2:
                    // Graft
                    varsd = new List<Variation>()
                    {
                        new Variation() { Content = "Variations in steps" },
                        new Variation() { Content = "Donor site – upper eyelid, post auricular, supraclavicular, inner arm"},
                        new Variation() { Content = "Large grafts – small perforations can be made into the graft to reduce the risk of haematoma collection and graft failure"},
                        
                    };
                    break;




            }
            
            //    // Tarso
            //    new List<Variation>()
            //    {
            //        new Variation()
            //        {
            //            Body = "Size of Flap:",
            //            Importance = 1
            //        },
            //        new Variation()
            //        {
            //            Body = "Wider flap may need a straighter horizonal incision without vertical relieving incisions​",
            //            Importance = 2
            //        },
            //        new Variation()
            //        {
            //            Body = "Tarsoconjunctival-based or Tarsoconjunctival-Muller-based flap​",
            //            Importance = 1
            //        },
            //        new Variation()
            //        {
            //            Body = "Conjunctiva and Mullers together allow better vascularsation of the flap​",
            //            Importance = 2
            //        },
            //        new Variation()
            //        {
            //            Body = "If advancing Mullers, which is an eyelid retractor, there may be a higher risk of post operative eyelid retraction than advancing conjunctiva alone​",
            //            Importance = 2
            //        }
            //    },

            //    // Tenzel
            //    new List<Variation>()
            //    {
            //        new Variation()
            //        {
            //            Body = "Defects greater on the lower than upper eyelid​",
            //            Importance = 1
            //        },
            //        new Variation()
            //        {
            //            Body = "Any lid defect – Lateral/Central/Medial",
            //            Importance = 1
            //        },
            //        new Variation()
            //        {
            //            Body = "Central to Medial",
            //            Importance = 2
            //        },
            //        new Variation()
            //        {
            //            Body = "Moving eyelid from lateral to medial​",
            //            Importance = 1
            //        }
            //    },

            //    // Graft
            //    new List<Variation>()
            //    {
            //        new Variation()
            //        {
            //            Body = "Donor site – upper eyelid, post auricular, supraclavicular, inner arm​",
            //            Importance = 1
            //        },
            //        new Variation()
            //        {
            //            Body = "Large grafts – small perforations can be made into the graft to reduce the risk of haematoma collection and graft failure​",
            //            Importance = 1
            //        }
            //    }
            //};

            return varsd;
        }
    }
}