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
        public List<string> RelatedProcedures { get; set; }

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
                        RelatedProcedures = new List<string>() { "Tarsonconjunctival Flap - Satge 2", "Hewes flap" }
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
                        RelatedProcedures = new List<string>() { "Periosteal flaps", "Direct closure" }
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
                        RelatedProcedures = new List<string>() { "Split thickness skin graft", "Free tarsal graft", "Full thickness mucosal graft", "Split thickness mucosal graft", "Hard palate mucosal graft", "Nasal mucosal graft", "Ear cartilage graft", "Alloderm" }
                    };
                    break;
            }

            return p;
        }

        internal List<int> GetProcedureIds()
        {
            return new List<int>() { 0, 1, 2 };
        }
    }
}
