using ESA.MarkupExtensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace ESA.Models.Model
{
    public class RelatedProcedure
    {
        public string ProcedureName { get; set; }
        public ImageSource Thumbnail { get; set; }
        public Detail Details { get; set; }
        public string ProcedureLink { get; set; } = null;

        internal List<RelatedProcedure> GetRelatedProcedures(int id)
        {
            List<RelatedProcedure> relatedProcedures = new List<RelatedProcedure>();

            switch (id)
            {
                case 0:
                    relatedProcedures = new List<RelatedProcedure>()
                    {
                        new RelatedProcedure()
                        {
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Variations.Thumbnail1.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            ProcedureName = "Tarsoconjunctival (Hughes) Flap - Stage 2",
                            Details = new Detail()
                            {
                                Description = "",
                                UploadDate = DateTime.Parse("2015,09,28"),
                                ViewCount = 532
                            }
                        },
                        new RelatedProcedure()
                        {
                            ProcedureName = "Hewes Flap",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Variations.Thumbnail2.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            Details = new Detail()
                            {
                                Description = "",
                                UploadDate = DateTime.Parse("2015,09,28"),
                                ViewCount = 532
                            }
                        }
                    };
                    break;
                case 1:
                    relatedProcedures = new List<RelatedProcedure>()
                    {
                        new RelatedProcedure()
                        {
                            ProcedureName = "Periosteal flaps",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Variations.Thumbnail1.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            Details = new Detail()
                            {
                                Description = "",
                                UploadDate = DateTime.Parse("2015,09,28"),
                                ViewCount = 532
                            }
                        },
                        new RelatedProcedure()
                        {
                            ProcedureName = "Direct closure",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Variations.Thumbnail2.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            Details = new Detail()
                            {
                                Description = "",
                                UploadDate = DateTime.Parse("2015,09,28"),
                                ViewCount = 532
                            }
                        }
                    };
                    break;
                case 2:
                    relatedProcedures = new List<RelatedProcedure>()
                    {
                        new RelatedProcedure()
                        {
                            ProcedureName = "Split thickness skin graft",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Variations.Thumbnail1.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            Details = new Detail()
                            {
                                Description = "",
                                UploadDate = DateTime.Parse("2015,09,28"),
                                ViewCount = 532
                            }
                        },
                        new RelatedProcedure()
                        {
                            ProcedureName = "Free tarsal graft",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Variations.Thumbnail2.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            Details = new Detail()
                            {
                                Description = "",
                                UploadDate = DateTime.Parse("2015,09,28"),
                                ViewCount = 532
                            }
                        },
                        new RelatedProcedure()
                        {
                            ProcedureName = "Full thickness mucosal graft",
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Variations.Thumbnail3.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            Details = new Detail()
                            {
                                Description = "",
                                UploadDate = DateTime.Parse("2015,09,28"),
                                ViewCount = 532
                            }
                        }
                    };
                    break;
            }

            return relatedProcedures;
        }
    }
}