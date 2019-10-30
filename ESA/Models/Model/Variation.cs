using System;
using System.Collections.Generic;

namespace ESA.Models.Model
{
    public class Variation
    {
        public string Body { get; set; }
        public int Importance { get; set; }

        internal List<Variation> GetVariations(int id)
        {
            List<List<Variation>> variationsList = new List<List<Variation>>()
            {
                // Tarso
                new List<Variation>()
                {
                    new Variation()
                    {
                        Body = "Size of Flap:",
                        Importance = 1
                    },
                    new Variation()
                    {
                        Body = "Wider flap may need a straighter horizonal incision without vertical relieving incisions​",
                        Importance = 2
                    },
                    new Variation()
                    {
                        Body = "Tarsoconjunctival-based or Tarsoconjunctival-Muller-based flap​",
                        Importance = 1
                    },
                    new Variation()
                    {
                        Body = "Conjunctiva and Mullers together allow better vascularsation of the flap​",
                        Importance = 2
                    },
                    new Variation()
                    {
                        Body = "If advancing Mullers, which is an eyelid retractor, there may be a higher risk of post operative eyelid retraction than advancing conjunctiva alone​",
                        Importance = 2
                    }
                },

                // Tenzel
                new List<Variation>()
                {
                    new Variation()
                    {
                        Body = "Defects greater on the lower than upper eyelid​",
                        Importance = 1
                    },
                    new Variation()
                    {
                        Body = "Any lid defect – Lateral/Central/Medial",
                        Importance = 1
                    },
                    new Variation()
                    {
                        Body = "Central to Medial",
                        Importance = 2
                    },
                    new Variation()
                    {
                        Body = "Moving eyelid from lateral to medial​",
                        Importance = 1
                    }
                },

                // Graft
                new List<Variation>()
                {
                    new Variation()
                    {
                        Body = "Donor site – upper eyelid, post auricular, supraclavicular, inner arm​",
                        Importance = 1
                    },
                    new Variation()
                    {
                        Body = "Large grafts – small perforations can be made into the graft to reduce the risk of haematoma collection and graft failure​",
                        Importance = 1
                    }
                }
            };

            return variationsList[id];
        }
    }
}