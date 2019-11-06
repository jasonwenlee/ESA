using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ESA.Models.Model
{
    public class Variation
    {
        public FormattedString Content { get; set; }

        internal List<Variation> GetVariations(int id)
        {
            List<Variation> varsd = new List<Variation>();
            //List<VariationsModel> vars = new List<VariationsModel>();

            switch (id)
            {
                case 0:
                    // Tarso Hughes
                    FormattedString fString = new FormattedString();
                    fString.Spans.Add(new Span() { Text = "Size of flap", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nWider flap may need a straighter horizonal incision without vertical relieving incisions.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                    varsd.Add(new Variation() { Content = fString });

                    fString = new FormattedString();
                    fString.Spans.Add(new Span() { Text = "Tarsoconjunctival-based or Tarsoconjunctival-Muller-based flap​.", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nConjunctiva and Mullers together allow better vascularsation of the flap.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nIf advancing Mullers, which is an eyelid retractor, there may be a higher risk of post operative eyelid retraction that advancing conjunctiva alone.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                    varsd.Add(new Variation() { Content = fString });
  
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