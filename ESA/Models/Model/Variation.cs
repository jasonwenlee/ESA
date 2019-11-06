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
            List<Variation> variationsList = new List<Variation>();
            switch (id)
            {
                case 0:
                    // Tarso Hughes
                    FormattedString fString = new FormattedString();
                    fString.Spans.Add(new Span() { Text = "Size of flap", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nWider flap may need a straighter horizonal incision without vertical relieving incisions.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                    variationsList.Add(new Variation() { Content = fString });

                    fString = new FormattedString();
                    fString.Spans.Add(new Span() { Text = "Tarsoconjunctival-based or Tarsoconjunctival-Muller-based flap​.", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nConjunctiva and Mullers together allow better vascularsation of the flap.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nIf advancing Mullers, which is an eyelid retractor, there may be a higher risk of post operative eyelid retraction that advancing conjunctiva alone.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                    variationsList.Add(new Variation() { Content = fString });
  
                    break;
                case 1:
                    // Tenzel
                    fString = new FormattedString();
                    fString.Spans.Add(new Span() { Text = "Defects greater on the lower than upper eyelid.", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nAny lid defect - Lateral/Central/Medial", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nCentral to Medial", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nMoving eyelid from lateral to Medial", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    variationsList.Add(new Variation() { Content = fString });

                    break;
                case 2:
                    // Graft
                    fString = new FormattedString();
                    fString.Spans.Add(new Span() { Text = "Variations in steps.", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nDonor site – upper eyelid, post auricular, supraclavicular, inner arm.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nLarge grafts – small perforations can be made into the graft to reduce the risk of haematoma collection and graft failure.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
                    variationsList.Add(new Variation() { Content = fString });

                    break;
            }
            return variationsList;
        }
    }
}