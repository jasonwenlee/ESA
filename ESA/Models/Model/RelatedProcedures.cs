using ESA.MarkupExtensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace ESA.Models.Model
{
    public class RelatedProcedures
    {
        public string ProcedureName { get; set; }
        public ImageSource Thumbnail { get; set; }

        internal List<RelatedProcedures> GetRelatedProcedures(int id)
        {
            List<RelatedProcedures> relatedProcedures = new List<RelatedProcedures>();

            switch (id)
            {
                case 0:
                    relatedProcedures = new List<RelatedProcedures>()
                    {
                        new RelatedProcedures()
                        {
                            ProcedureName = "Tarsoconjunctival (Hughes) Flap - Stage 2",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                        },
                        new RelatedProcedures()
                        {
                            ProcedureName = "Hewes Flap",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                        }
                    };
                    break;
                case 1:
                    relatedProcedures = new List<RelatedProcedures>()
                    {
                        new RelatedProcedures()
                        {
                            ProcedureName = "Periosteal flaps",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                        },
                        new RelatedProcedures()
                        {
                            ProcedureName = "Direct closure",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                        }
                    };
                    break;
                case 2:
                    relatedProcedures = new List<RelatedProcedures>()
                    {
                        new RelatedProcedures()
                        {
                            ProcedureName = "Split thickness skin graft",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                        },
                        new RelatedProcedures()
                        {
                            ProcedureName = "Free tarsal graft",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                        },
                        new RelatedProcedures()
                        {
                            ProcedureName = "Full thickness mucosal graft",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                        }
                    };
                    break;
            }

            return relatedProcedures;
        }
    }
}