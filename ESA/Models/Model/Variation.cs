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
                    
                    {
                        FormattedString gString = new FormattedString();
                        gString.Spans.Add(new Span() { Text = "Defects greater on the lower than upper eyelid"});
                        varsd.Add(new Variation() { Content = gString });

                        gString = new FormattedString();
                        gString.Spans.Add(new Span() { Text = "Any lid defect - Lateral/Central/Medial", Style = (Style)Application.Current.Resources["VariationHeader"] });
                        gString.Spans.Add(new Span() { Text = "\nCentral to Medial", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                        varsd.Add(new Variation() { Content = gString });

                        gString = new FormattedString();
                        gString.Spans.Add(new Span() { Text = "Moving eyelid from lateral to Medial"});
                        varsd.Add(new Variation() { Content = gString });
                    };
                    break;
                case 2:
                    // Graft
                    
                    {
                        FormattedString hString = new FormattedString();
                        hString.Spans.Add(new Span() { Text = "Variations in steps", Style = (Style)Application.Current.Resources["VariationHeader"] });
                        hString.Spans.Add(new Span() { Text = "\nDonor site – upper eyelid, post auricular, supraclavicular, inner arm" , Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                        hString.Spans.Add(new Span() { Text = "\nLarge grafts – small perforations can be made into the graft to reduce the risk of haematoma collection and graft failure" , Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                        varsd.Add(new Variation() { Content = hString });
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