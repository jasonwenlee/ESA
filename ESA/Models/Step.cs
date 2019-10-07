using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    public class Step
    {
        public int Number { get; set; }
        public string Content { get; set; }
        public Diagram Diagram { get; set; }
        //public double TimeStamp { get; set; }

        public List<Step> GetSteps()
        {
            List<Diagram> diagrams = new Diagram().GetDiagrams();
            return new List<Step>()
            {
                new Step() { Number = 1, Content = "Pass a 4-0 silk traction suture through the grey line to evert the upper eyelid over a Desmarres retractor.", Diagram = null },
                new Step() { Number = 2, Content = "Assess width of lower lid defect by stretching the remaining lower lid edges centrally using forceps.", Diagram = null },
                new Step() { Number = 3, Content = "Mark the horizontal incision line 4mm above the lid margin, following the curve of the lid margin.", Diagram = null },
                new Step() { Number = 4, Content = "Make a full thickness cut through the conjunctiva and the tarsus at the incision line with a no 15 Bard Parker blade.", Diagram = null },
                new Step() { Number = 5, Content = "Make two vertical relieving incisions at the ends of the horizontal incision line (unless a full width flap is required, where the relieving incisions are not needed)", Diagram = null },
                new Step() { Number = 6, Content = "Raise the tarsus from the overlying orbicularis using Westcott spring. ", Diagram = null },
                new Step() { Number = 7, Content = "For Tarsonconjunctival-based flap: Dissect in plane between conjunctiva and Muller.", Diagram = diagrams[0] },
                new Step() { Number = 8, Content = "For Tarsonconjunctival-Muller-based flap: Dissect in plane between Mullers and lavator.", Diagram = diagrams[1] },
                new Step() { Number = 9, Content = "Continue to dissect superiorly up to the white line.", Diagram = null },
                new Step() { Number = 10, Content = "Mobilise the tarsonconjunctival flap into the lower lid defect.", Diagram = null },
                new Step() { Number = 11, Content = "Suture each corner of the tarsal edges of the flap into the corresponding corners of the lower lid tarsus with partial thickness, interrupted vicryl 6-0 sutures.", Diagram = diagrams[2] },
                new Step() { Number = 12, Content = "Suture the inferior edge of the tarsal flap to the lower lid conjunctival edge with continuous vicryl 6-0 suture.", Diagram = null },
                new Step() { Number = 13, Content = "Anterior lamella can be constructed using an advancement flap or free skin graft.", Diagram = null },
                new Step() { Number = 14, Content = "Pressure Pad.", Diagram = null },
                new Step() { Number = 15, Content = "The flap is divided in a secondary procedure; see Tarsoconjuntival flap - stage 2", Diagram = null }
            };
        }
    }
}
