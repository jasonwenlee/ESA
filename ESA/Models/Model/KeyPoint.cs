using System;
using System.Collections.Generic;

namespace ESA.Models.Model
{
    public class KeyPoint
    {
        public string Point { get; set; }
        public int Importance { get; set; }
        public bool HasDiagram { get; set; }
        public Model.Diagram Diagram { get; set; }
        public int RelatedProcedure { get; set; }

        internal List<KeyPoint> GetKeyPoints(int id)
        {
            List<Model.Diagram> diagrams = new Model.Diagram().GetDiagrams(id);
            List<KeyPoint> keyPoints = new List<KeyPoint>();

            switch (id)
            {
                case 0:
                    // Tarso
                    keyPoints = new List<KeyPoint>()
                    {
                        new KeyPoint()
                        {
                            Point = "Specific Considerations",
                            Importance = 1,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Only eye: this technique creates a bridging flap that obscures the patient’s vision before the flap is divided in the second stage.  This may not be suited for patients if it affects their only seeing eye.",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Second procedure for division of Hughes flap requires the patient to return to the operating theatre, which may not be practical or possible if the patient has other comorbidities: see Tarsoconjunctival flap – stage 2",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = 2
                        },
                        new KeyPoint()
                        {
                            Point = "Tips/Pitfalls",
                            Importance = 1,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Dissection",
                            Importance = 2,
                            HasDiagram = true,
                            Diagram = diagrams[0],
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "It is easier to dissect conjunctiva and Mullers rather than just dissecting conjunctiva alone​",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Dissecting superiorly up to white line ensures that the flap is completely free and can be mobilised into the defect without tension​",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Suture",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Suture the flap to the lid defect under tension",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Allow a small amount of skin recession",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                    };
                    break;
                case 1:
                    // Tenzel
                    keyPoints = new List<KeyPoint>()
                    {
                        new KeyPoint()
                        {
                            Point = "Make a perpendicular incision from the lateral commissure through the obicularis  - as this skin muscle flap will form the basis of the new lid margin it is important to keep it uniform",
                            Importance = 1,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        }
                    };
                    break;
                case 2:
                    // Graft
                    keyPoints = new List<KeyPoint>()
                    {
                        new KeyPoint()
                        {
                            Point = "Tips/Pitfalls",
                            Importance = 1,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Donor Site",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Counsel patients about risk of scarring to donor sites and possible asymmetry if upper eyelid skin is removed​",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Donor site epidermis regenerates from the immigration of epithelial cells originating in hair follicle shafts and adnexal structures left in the dermis.  Dermis never regenerates.​",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Full thickness skin grafts (FTSG) require suturing or split skin graft as there are no remaining epithelial structures to provide re-epithelialisation, while split thickness skin grafts (STSG) can heal spontaneously​",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Donor graft​",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "FTSG have the greatest sensory return because of a greater availability of neurilemmal sheaths. ",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Hair follicles are also transferred with a FTSG, while the chances of transferring hair follicles in STSG increases the thicker the graft (and the more dermis with hair follicles are incorporated). ",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Suture the flap to the lid defect under tension",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Thin grafts look more cosmetically acceptable than bulky grafts​",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "The graft should be sized to cover the defect – it is better to trim down a graft than to produce one that is too small relative to the defect​​",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Suitable like-for-like harvest locations depend on on the colour, texture, vascularity, dermis thickness, and donor site morbidity.​​",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Grafts can be taken from anywhere in the body, although grafts taken from above the clavicle provide a superior colour match to the face.",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Common donor sites for STSG are buttocks, thigh, abdominal wall, and scalp.​",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Skin grafts require a vascular bed and will seldom take in exposed bone, cartilage or tendon without its periosteum, perichondrium or paratenon.  An exception is good take of skin grafts inside the orbit despite periosteal removal",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Success of skin grafting (known as ‘take’):",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Depends on the graft’s ability to receive nutrients and subsequently vascular ingrowth from recipient bed.",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Take occurs in three phases;",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "First phase (plasmatic imbibition) – 24-48 hours after grafting: fibrin layer forms when graft is placed on recipient bed, binding graft to the bed.  Absorption of nutrients into graft occur by capillary action from recipient bed.",
                            Importance = 4,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Second phase (inosculation) – 48-72 hours after grafting: recipient and donor end capillaries are aligned. Outgrowth of capillary buds from recipient area to unite with those on deep surface of graft​",
                            Importance = 4,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Third phase (revascularsation) – graft is revascularised through the capillaries​:",
                            Importance = 4,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Distance to be travelled by capillary beds in order to link up a new vascular network therefore needs to be as short as possible.  The smaller the distance, the more likely the graft is to bridge.  Close contact between skin graft and recipient bed is essential and the graft has to lie immobile on the bed until it is firmly attached.​",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Healing",
                            Importance = 2,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Primary contraction is the immediate recoil of freshly harvested grafts as a result of the elastin in the dermis. The more dermis the graft has, the more primary the contraction that will be experienced. ",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Secondary contracture involves contraction of a healed graft and is probably a result of myofibroblast activity.",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "A full-thickness skin graft contracts more on initial harvest (primary contraction) but less on healing (secondary contracture) than a split-thickness skin graft.",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "The thinner the split-thickness skin graft, the greater the secondary contracture.",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "FTSG therefore remains virtually at its original size; STSG tends to contract​",
                            Importance = 3,
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        }
                    };
                    break;
            }

            return keyPoints;
        }
    }
}