using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.Model
{
    public class Procedure
    {
        public int Id { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string VideoSource { get; set; }
        public Detail Details { get; set; }
        public List<Step> Steps { get; set; }
        public List<KeyPoint> KeyPoints { get; set; }
        public List<Variation> Variations { get; set; }
        public List<Complication> Complications { get; set; }
        public List<History> History { get; set; }
        public List<Reference> References { get; set; }
        public List<RelatedProcedure> RelatedProcedures { get; set; }

        public Procedure GetProcedure(int id)
        {
            Procedure p = new Procedure();
            switch (id)
            {
                case 0:
                    // Tarso hughes flap
                    p = new Procedure()
                    {
                        Id = 0,
                        LongName = "Tarsonconjunctival (Hughes) Flap - Stage I",
                        ShortName = "Hughes Flap - Stage I",
                        VideoSource = "eye_surgery.mp4",
                        Details = new Detail().GetDetails(id),
                        Steps = new Step().GetSteps(id),
                        KeyPoints = new KeyPoint().GetKeyPoints(id),
                        Variations = new Variation().GetVariations(id),
                        Complications = new Complication().GetComplications(id),
                        History = new History().GetHistory(id),
                        References = new Reference().GetReferences(id),
                        RelatedProcedures = new RelatedProcedure().GetRelatedProcedures(id)
                    };
                    break;

                case 1:
                    // Tenzel
                    p = new Procedure()
                    {
                        Id = 1,
                        LongName = "Semicircular (Tenzel) advancement Flap using Lateral Recruitment",
                        ShortName = "Tenzel Flap",
                        VideoSource = "Brain_Eyes_Vid.mp4",
                        Details = new Detail().GetDetails(id),
                        Steps = new Step().GetSteps(id),
                        KeyPoints = new KeyPoint().GetKeyPoints(id),
                        Variations = new Variation().GetVariations(id),
                        Complications = new Complication().GetComplications(id),
                        History = new History().GetHistory(id),
                        References = new Reference().GetReferences(id),
                        RelatedProcedures = new RelatedProcedure().GetRelatedProcedures(id)
        };
                    break;

                case 2:
                    // Full thickness Skin graft
                    p = new Procedure()
                    {
                        Id = 2,
                        LongName = "Full Thickness Skin Graft securred with Dermabond glue",
                        ShortName = "FT Skin Graft",
                        VideoSource = "eye_surgery.mp4",
                        Details = new Detail().GetDetails(id),
                        Steps = new Step().GetSteps(id),
                        KeyPoints = new KeyPoint().GetKeyPoints(id),
                        Variations = new Variation().GetVariations(id),
                        Complications = new Complication().GetComplications(id),
                        History = new History().GetHistory(id),
                        References = new Reference().GetReferences(id),
                        RelatedProcedures = new RelatedProcedure().GetRelatedProcedures(id)
        };
                    break;
            }

            return p;
        }

        internal List<Procedure> GetProcedureNames()
        {
            return new List<Procedure>(){
                new Procedure(){
                    Id = 0,
                    LongName = "Tarsonconjunctival (Hughes) Flap - Stage I",
                    ShortName = "Hughes Flap - Stage I",
                    Details = new Detail()
                    {
                        Author = new Person(){ PersonName = "Dr Valerie Juniat" },
                        UploadDate = DateTime.Parse("2016/01/06"),
                        ViewCount = 634
                    }
                },

                new Procedure(){
                    Id = 1,
                    LongName = "Semicircular (Tenzel) advancement Flap using Lateral Recruitment",
                    ShortName = "Tenzel Flap",
                    Details = new Detail()
                    {
                        Author = new Person(){ PersonName = "Dr Saul Rajak" },
                        UploadDate = DateTime.Parse("2019/06/27"),
                        ViewCount = 5385
                    }
                },

                new Procedure(){
                    Id = 2,
                    LongName = "Full Thickness Skin Graft securred with Dermabond glue",
                    ShortName = "FT Skin Graft",
                    Details = new Detail()
                    {
                        Author = new Person(){ PersonName = "Professor Dinesh Selva" },
                        UploadDate = DateTime.Parse("2015/10/27"),
                        ViewCount = 810
                    }
                },
                // add additional procedures here
                                new Procedure(){
                    Id = -1,
                    LongName = "Lower lid island flap - Nasofacial sulcus",
                    ShortName = "Lower lid island",
                    Details = new Detail()
                    {
                        Author = new Person(){ PersonName = "Dr Valerie Juniat" },
                        UploadDate = DateTime.Parse("2016/01/06"),
                        ViewCount = 634
                    }
                },

                new Procedure(){
                    Id = -1,
                    LongName = "Propeller flap, Tarsal graft, Periosteal flap",
                    ShortName = "Propeller, Tarsal...",
                    Details = new Detail()
                    {
                        Author = new Person(){ PersonName = "Dr Saul Rajak" },
                        UploadDate = DateTime.Parse("2019/06/27"),
                        ViewCount = 5385
                    }
                },

                new Procedure(){
                    Id = -1,
                    LongName = "Lateral canthotomy and inferior cantholysis",
                    ShortName = "Lateral cantho...",
                    Details = new Detail()
                    {
                        Author = new Person(){ PersonName = "Professor Dinesh Selva" },
                        UploadDate = DateTime.Parse("2015/10/27"),
                        ViewCount = 810
                    }
                },
                new Procedure(){
                    Id = -1,
                    LongName = "Direct closure / wedge excision",
                    ShortName = "Direct closure",
                    Details = new Detail()
                    {
                        Author = new Person(){ PersonName = "Dr Valerie Juniat" },
                        UploadDate = DateTime.Parse("2016/01/06"),
                        ViewCount = 634
                    }
                },

                new Procedure(){
                    Id = -1,
                    LongName = "Sliding tarsonconjunctival flap",
                    ShortName = "Sliding tarsocon...",
                    Details = new Detail()
                    {
                        Author = new Person(){ PersonName = "Dr Saul Rajak" },
                        UploadDate = DateTime.Parse("2019/06/27"),
                        ViewCount = 5385
                    }
                },

                new Procedure(){
                    Id = -1,
                    LongName = "Full thickness eyelid composite graft",
                    ShortName = "Composite graft",
                    Details = new Detail()
                    {
                        Author = new Person(){ PersonName = "Professor Dinesh Selva" },
                        UploadDate = DateTime.Parse("2015/10/27"),
                        ViewCount = 810
                    }
                }
            };
        }
    }
}
