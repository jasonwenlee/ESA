using System;
using System.Collections.Generic;

namespace ESA.Models.Model
{
    public class KeyPoint
    {
        public string Point { get; set; }
        public string PointBold { get; set; }
        public bool HasDiagram { get; set; }
        public int Number { get; set; }
        public Diagram Diagram { get; set; }
        public RelatedProcedure RelatedProcedure { get; set; }
        public bool HasRelatedProcedure { get; set; } = false;

        internal List<KeyPoint> GetKeyPoints(int id)
        {
            List<Diagram> diagrams = new Diagram().GetDiagrams(id);
            List<KeyPoint> keyPointsList = new List<KeyPoint>();

            switch (id)
            {
                case 0:
                    // Tarso
                    keyPointsList = new List<KeyPoint>()
                    {
                        new KeyPoint()
                        {
                            PointBold = "Specific Considerations",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 0,
                        },
                        new KeyPoint()
                        {
                            Point = "Only eye: this technique creates a bridging flap that obscures the patient’s vision before the flap is divided in the second stage.  This may not be suited for patients if it affects their only seeing eye.",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 1,
                        },
                        new KeyPoint()
                        {
                            Point = "Second procedure for division of Hughes flap requires the patient to return to the operating theatre, which may not be practical or possible if the patient has other comorbidities:",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 2,
                            RelatedProcedure = new RelatedProcedure(){ Id = 1, ProcedureName = "Tarsoconjunctival (Hughes) flap – Stage II", ProcedureLink = "see Tarsoconjunctival (Hughes) flap – Stage II"},
                            HasRelatedProcedure = true
                        },
                        new KeyPoint()
                        {
                            PointBold = "Tips/Pitfalls",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 3,
                        },
                        new KeyPoint()
                        {
                            PointBold = "Dissection",
                            HasDiagram = true,
                            Diagram = diagrams[0],
                            Number = 4,
                        },
                        new KeyPoint()
                        {
                            Point = "It is easier to dissect conjunctiva and Mullers rather than just dissecting conjunctiva alone​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 5,
                        },
                        new KeyPoint()
                        {
                            Point = "Dissecting superiorly up to white line ensures that the flap is completely free and can be mobilised into the defect without tension​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 6,
                        },
                        new KeyPoint()
                        {
                            PointBold = "Suture",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 7,
                        },
                        new KeyPoint()
                        {
                            Point = "Suture the flap to the lid defect under tension",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 8,
                        },
                        new KeyPoint()
                        {
                            Point = "Allow a small amount of skin recession",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 9,
                        },
                    };
                    break;
                case 1:
                    // Tenzel
                    keyPointsList = new List<KeyPoint>()
                    {
                        new KeyPoint()
                        {
                            Point = "Make a perpendicular incision from the lateral commissure through the obicularis  - as this skin muscle flap will form the basis of the new lid margin it is important to keep it uniform",
                            HasDiagram = false,
                            Diagram = null,
                        }
                    };
                    break;
                case 2:
                    // Graft
                    keyPointsList = new List<KeyPoint>()
                    {
                        new KeyPoint()
                        {
                            PointBold = "Tips/Pitfalls",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 0,
                        },
                        new KeyPoint()
                        {
                            PointBold = "Donor Site",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 1,
                        },
                        new KeyPoint()
                        {
                            Point = "Counsel patients about risk of scarring to donor sites and possible asymmetry if upper eyelid skin is removed​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 2,
                        },
                        new KeyPoint()
                        {
                            Point = "Donor site epidermis regenerates from the immigration of epithelial cells originating in hair follicle shafts and adnexal structures left in the dermis.  Dermis never regenerates.​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 3,
                        },
                        new KeyPoint()
                        {
                            Point = "Full thickness skin grafts (FTSG) require suturing or split skin graft as there are no remaining epithelial structures to provide re-epithelialisation, while split thickness skin grafts (STSG) can heal spontaneously​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 4,
                        },
                        new KeyPoint()
                        {
                            PointBold = "Donor graft​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 5,
                        },
                        new KeyPoint()
                        {
                            Point = "FTSG have the greatest sensory return because of a greater availability of neurilemmal sheaths. ",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 6,
                        },
                        new KeyPoint()
                        {
                            Point = "Hair follicles are also transferred with a FTSG, while the chances of transferring hair follicles in STSG increases the thicker the graft (and the more dermis with hair follicles are incorporated). ",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 7,
                        },
                        new KeyPoint()
                        {
                            Point = "Suture the flap to the lid defect under tension",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 8,
                        },
                        new KeyPoint()
                        {
                            Point = "Thin grafts look more cosmetically acceptable than bulky grafts​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 9,
                        },
                        new KeyPoint()
                        {
                            Point = "The graft should be sized to cover the defect – it is better to trim down a graft than to produce one that is too small relative to the defect​​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 10,
                        },
                        new KeyPoint()
                        {
                            Point = "Suitable like-for-like harvest locations depend on on the colour, texture, vascularity, dermis thickness, and donor site morbidity.​​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 11,
                        },
                        new KeyPoint()
                        {
                            Point = "Grafts can be taken from anywhere in the body, although grafts taken from above the clavicle provide a superior colour match to the face.",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 12,
                        },
                        new KeyPoint()
                        {
                            Point = "Common donor sites for STSG are buttocks, thigh, abdominal wall, and scalp.​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 13,
                        },
                        new KeyPoint()
                        {
                            Point = "Skin grafts require a vascular bed and will seldom take in exposed bone, cartilage or tendon without its periosteum, perichondrium or paratenon.  An exception is good take of skin grafts inside the orbit despite periosteal removal",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 14,
                        },
                        new KeyPoint()
                        {
                            Point = "Success of skin grafting (known as ‘take’):",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 15,
                        },
                        new KeyPoint()
                        {
                            Point = "Depends on the graft’s ability to receive nutrients and subsequently vascular ingrowth from recipient bed.",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 16,
                        },
                        new KeyPoint()
                        {
                            Point = "Take occurs in three phases;",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 17,
                        },
                        new KeyPoint()
                        {
                            Point = "First phase (plasmatic imbibition) – 24-48 hours after grafting: fibrin layer forms when graft is placed on recipient bed, binding graft to the bed.  Absorption of nutrients into graft occur by capillary action from recipient bed.",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 18,
                        },
                        new KeyPoint()
                        {
                            Point = "Second phase (inosculation) – 48-72 hours after grafting: recipient and donor end capillaries are aligned. Outgrowth of capillary buds from recipient area to unite with those on deep surface of graft​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 19,
                        },
                        new KeyPoint()
                        {
                            Point = "Third phase (revascularsation) – graft is revascularised through the capillaries​:",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 20,
                        },
                        new KeyPoint()
                        {
                            Point = "Distance to be travelled by capillary beds in order to link up a new vascular network therefore needs to be as short as possible.  The smaller the distance, the more likely the graft is to bridge.  Close contact between skin graft and recipient bed is essential and the graft has to lie immobile on the bed until it is firmly attached.​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 21,
                        },
                        new KeyPoint()
                        {
                            PointBold = "Healing",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 22,
                        },
                        new KeyPoint()
                        {
                            Point = "Primary contraction is the immediate recoil of freshly harvested grafts as a result of the elastin in the dermis. The more dermis the graft has, the more primary the contraction that will be experienced. ",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 23,
                        },
                        new KeyPoint()
                        {
                            Point = "Secondary contracture involves contraction of a healed graft and is probably a result of myofibroblast activity.",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 24,
                        },
                        new KeyPoint()
                        {
                            Point = "A full-thickness skin graft contracts more on initial harvest (primary contraction) but less on healing (secondary contracture) than a split-thickness skin graft.",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 25,
                        },
                        new KeyPoint()
                        {
                            Point = "The thinner the split-thickness skin graft, the greater the secondary contracture.",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 26,
                        },
                        new KeyPoint()
                        {
                            Point = "FTSG therefore remains virtually at its original size; STSG tends to contract​",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 27,
                        }
                    };
                    break;
            }

            foreach (KeyPoint keyp in keyPointsList)
            {
                keyp.HasDiagram = false;
                if (keyp.Diagram != null)
                {
                    keyp.HasDiagram = true;
                }
            }

            return keyPointsList;
        }
    }
}