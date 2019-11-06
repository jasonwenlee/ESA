﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.Model
{
    public class Step
    {
        public int Number { get; set; }
        public string Content { get; set; }
        public bool HasDiagram { get; set; }
        public Diagram Diagram { get; set; } = null;
        public RelatedProcedure RelatedProcedure { get; set; } = null;
        public bool HasRelatedProcedure { get; set; }
        //public double TimeStamp { get; set; }

        internal List<Step> GetSteps(int id)
        {
            List<Diagram> diagrams = new Model.Diagram().GetDiagrams(id);
            List<Step> steps = new List<Step>();

            switch (id)
            {
                case 0:
                    // Tarso Hughes
                    steps = new List<Step>()
                    {
                        new Step() { Number = 1, Content = "Pass a 4-0 silk traction suture through the grey line to evert the upper eyelid over a Desmarres retractor."},
                        new Step() { Number = 2, Content = "Assess width of lower lid defect by stretching the remaining lower lid edges centrally using forceps."},
                        new Step() { Number = 3, Content = "Mark the horizontal incision line 4mm above the lid margin, following the curve of the lid margin." },
                        new Step() { Number = 4, Content = "Make a full thickness cut through the conjunctiva and the tarsus at the incision line with a no 15 Bard Parker blade." },
                        new Step() { Number = 5, Content = "Make two vertical relieving incisions at the ends of the horizontal incision line (unless a full width flap is required, where the relieving incisions are not needed)" },
                        new Step() { Number = 6, Content = "Raise the tarsus from the overlying orbicularis using Westcott spring. " },
                        new Step() { Number = 7, Content = "For Tarsonconjunctival-based flap: Dissect in plane between conjunctiva and Muller.", Diagram = diagrams[0] },
                        new Step() { Number = 8, Content = "For Tarsonconjunctival-Muller-based flap: Dissect in plane between Mullers and lavator.", Diagram = diagrams[1] },
                        new Step() { Number = 9, Content = "Continue to dissect superiorly up to the white line." },
                        new Step() { Number = 10, Content = "Mobilise the tarsonconjunctival flap into the lower lid defect." },
                        new Step() { Number = 11, Content = "Suture each corner of the tarsal edges of the flap into the corresponding corners of the lower lid tarsus with partial thickness, interrupted vicryl 6-0 sutures.", Diagram = diagrams[2] },
                        new Step() { Number = 12, Content = "Suture the inferior edge of the tarsal flap to the lower lid conjunctival edge with continuous vicryl 6-0 suture." },
                        new Step() { Number = 13, Content = "Anterior lamella can be constructed using an advancement flap or free skin graft." },
                        new Step() { Number = 14, Content = "Pressure Pad." },
                        new Step() { Number = 15, Content = "The flap is divided in a secondary procedure;", RelatedProcedure = new RelatedProcedure()
                            {
                                ProcedureLink = "See Tarsoconjuntival (Hughes) flap - stage II",
                                Details = new Detail(){ UploadDate = DateTime.Parse("2015/09/24"), ViewCount = 467 },
                                ProcedureName = "Tarsonconjunctical (Hughes) Flap - Stage II",
                                Id = 1
                            }
                        }
                    };
                    break;
                case 1:
                    // Tenzel
                    steps = new List<Step>()
                    {
                        new Step() { Number = 1, Content = "Mark the Tenzel flap - An upward curve (or or downward curve if upper lid defect) from lateral commissure in a line of the curvature of the lid, extending beyond the lateral orbital rim as far laterally as the lateral aspect of the brow​" },
                        new Step() { Number = 2, Content = "Local anaesthetic, antiseptic preparation and drape" },
                        new Step() { Number = 3, Content = "Skin incision along marked." },
                        new Step() { Number = 4, Content = "Perpendicular incision from the lateral commissure through the obicularis (this skin muscle flap will form the basis of the new lid margin so keep uniform)​." },
                        new Step() { Number = 5, Content = "Cut the inferior limb of the lateral canthal tendon (LCT) - this can be performed beneath the flap and one can dissect the anterior lamella off the inferior limb of the LCT to perform this and avoid damaging the obicularis." },
                        new Step() { Number = 6, Content = "Divide the lateral attachments of the orbital septum." },
                        new Step() { Number = 7, Content = "Dissect in a sub-obicularis plane within the margins of the lateral orbital rim and within the sub-cutaneous tissue lateral to orbital rim​." },
                        new Step() { Number = 8, Content = "Divide inferiorly until the tension/traction on the flap is released sufficiently​." },
                        new Step() { Number = 9, Content = "Incise the conjunctiva inferior to tarsus to release traction (as necessary)." },
                        new Step() { Number = 10, Content = "Close the primary defect with interrupted with 6-0 vicryl: Tarsus to tarsus (or MCT), gray line and skin – see direct closure video", Diagram = diagrams[0] },
                        new Step() { Number = 11, Content = "Place a deep suture to raise the cheek through the obicularis to anchor to the periosteum above the level of the MCT using a 4-0 vicryl or monocryl​." },
                        new Step() { Number = 12, Content = "Reform canthal angle by suturing the inferior obicularis of the flap to upper limb of the LCT or gray line with 6-0 vicryl​" },
                        new Step() { Number = 13, Content = "Close the skin with 6.0 vicryl​" },
                        new Step() { Number = 14, Content = "lace a pad/dressing over the eye for 24 hours​" }
                    };
                    break;
                case 2:
                    // FTS Graft
                    steps = new List<Step>()
                    {
                        new Step() { Number = 1, Content = "Measure the size of the defect​." },
                        new Step() { Number = 2, Content = "Mark the skin graft donor site​." },
                        new Step() { Number = 3, Content = "Incise the donor area with a D blade​." },
                        new Step() { Number = 4, Content = "Excise the donor area as thinly as possible with Westcott spring scissors." },
                        new Step() { Number = 5, Content = "Close the donor site with continuous absorbable or non-absorbable sutures." },
                        new Step() { Number = 6, Content = "Remove excess subcutaneous tissue from the graft using spring scissors." },
                        new Step() { Number = 7, Content = "Tailor the graft to fit the defect​." },
                        new Step() { Number = 8, Content = "Place graft over defect​." },
                        new Step() { Number = 9, Content = "Suture graft into defect with interrupted absorbable sutures​." },
                        new Step() { Number = 10, Content = "Graft can be placed on tension with a Frost suture and/or packed with a moist dressing for 48 hours​" }
                    };
                    break;
            }


            foreach (Step step in steps)
            {
                step.HasDiagram = false;
                step.HasRelatedProcedure = false;
                if (step.Diagram != null)
                {
                    step.HasDiagram = true;
                }
                if (step.RelatedProcedure != null)
                {
                    step.HasRelatedProcedure = true;
                }
            }

            return steps;
        }
    }
}