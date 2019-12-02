using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ESA.Models.Model
{
    public class Variation
    {
        public FormattedString Content { get; set; }
        public List<RelatedProcedure> RelatedProcedures { get; set; } = null;

        internal List<Variation> GetVariations(int id)
        {
            List<Variation> varsd = new List<Variation>();
            //List<VariationsModel> vars = new List<VariationsModel>();
            FormattedString fString = new FormattedString();

            switch (id)
            {
                case 0:
                    // Tarso Hughes
                    
                    fString.Spans.Add(new Span() { Text = "Size of flap", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nWider flap may need a straighter horizonal incision without vertical relieving incisions.", Style = (Style)Application.Current.Resources["VariationContent"] });
                    fString.Spans.Add(new Span() { Text = "\nTarsoconjunctival-based or Tarsoconjunctival-Muller-based flap​.", Style = (Style)Application.Current.Resources["VariationHeader"] });
                    fString.Spans.Add(new Span() { Text = "\nConjunctiva and Mullers together allow better vascularsation of the flap.", Style = (Style)Application.Current.Resources["VariationContent"] });
                    fString.Spans.Add(new Span() { Text = "\nIf advancing Mullers, which is an eyelid retractor, there may be a higher risk of post operative eyelid retraction that advancing conjunctiva alone.", Style = (Style)Application.Current.Resources["VariationContent"] });
                    varsd.Add(new Variation() { 
                        Content = fString,
                        RelatedProcedures = new List<RelatedProcedure>()
                        {
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Tarsoconjuntival (Hughes) flap - stage II",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Tarsonconjunctical (Hughes) Flap - Stage II",
                                Id = 1
                            },
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Hewes flap",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Hewes flap",
                                Id = 2
                            }
                        }
                    });
                    break;
                case 1:
                    // Tenzel
                    
                    {
                        fString.Spans.Add(new Span() { Text = "Defects greater on the lower than upper eyelid"});
                        fString.Spans.Add(new Span() { Text = "\nAny lid defect - Lateral/Central/Medial", Style = (Style)Application.Current.Resources["VariationHeader"] });
                        fString.Spans.Add(new Span() { Text = "\nCentral to Medial", Style = (Style)Application.Current.Resources["VariationContent"] });
                        fString.Spans.Add(new Span() { Text = "\nMoving eyelid from lateral to Medial", Style = (Style)Application.Current.Resources["VariationContent"] });
                        varsd.Add(new Variation()
                        {
                            Content = fString,
                            RelatedProcedures = new List<RelatedProcedure>()
                        {
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Periosteal flaps",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Periosteal flaps",
                                Id = 2
                            },
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Direct closure",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Direct closure",
                                Id = 0
                            }
                        }
                        }); ;
                    };
                    break;
                case 2:
                    // Graft
                    
                    {
                        fString.Spans.Add(new Span() { Text = "Variations in steps", Style = (Style)Application.Current.Resources["VariationHeader"] });
                        fString.Spans.Add(new Span() { Text = "\nDonor site – upper eyelid, post auricular, supraclavicular, inner arm" , Style = (Style)Application.Current.Resources["VariationContent"] });
                        fString.Spans.Add(new Span() { Text = "\nLarge grafts – small perforations can be made into the graft to reduce the risk of haematoma collection and graft failure" , Style = (Style)Application.Current.Resources["VariationContent"] });
                        varsd.Add(new Variation()
                        {
                            Content = fString,
                            RelatedProcedures = new List<RelatedProcedure>()
                        {
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Split thickness skin graft",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Split thickness skin graft",
                                Id = 1
                            },
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Free tarsal graft",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Free tarsal graft",
                                Id = 0
                            },
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Full thickness mucosal graft",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Full thickness mucosal graft",
                                Id = 1
                            },
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Split thickness mucosal graft",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Split thickness mucosal graft",
                                Id = 0
                            },
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Hard palate mucosal graft",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Hard palate mucosal graft",
                                Id = 1
                            },
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Hewes flap",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Hewes flap",
                                Id = 0
                            },
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Nasal mucosal graft",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Nasal mucosal graft",
                                Id = 1
                            },
                            new RelatedProcedure()
                            {
                                ProcedureLink = "Ear cartilage graft",
                                Details = new Detail() { UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Ear cartilage graft",
                                Id = 0
                            },
                        }
                        });
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