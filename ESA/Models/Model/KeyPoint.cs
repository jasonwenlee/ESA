using System;
using System.Collections.Generic;

namespace ESA.Models.Model
{
    public class KeyPoint
    {
        public string Point { get; set; }
        public string Importance { get; set; }
        public bool HasDiagram { get; set; }
        public int Number { get; set; }
        public Diagram Diagram { get; set; }
        public int RelatedProcedure { get; set; }

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
                            Point = "Specific Considerations",
                            Importance = "KeyPoint1",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 0,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Only eye: this technique creates a bridging flap that obscures the patient’s vision before the flap is divided in the second stage.  This may not be suited for patients if it affects their only seeing eye.",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 1,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Second procedure for division of Hughes flap requires the patient to return to the operating theatre, which may not be practical or possible if the patient has other comorbidities: see Tarsoconjunctival flap – stage 2",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 2,
                            RelatedProcedure = 2
                        },
                        new KeyPoint()
                        {
                            Point = "Tips/Pitfalls",
                            Importance = "KeyPoint1",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 3,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Dissection",
                            Importance = "KeyPoint2",
                            HasDiagram = true,
                            Diagram = diagrams[0],
                            Number = 4,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "It is easier to dissect conjunctiva and Mullers rather than just dissecting conjunctiva alone​",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 5,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Dissecting superiorly up to white line ensures that the flap is completely free and can be mobilised into the defect without tension​",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 6,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Suture",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 7,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Suture the flap to the lid defect under tension",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 8,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Allow a small amount of skin recession",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 9,
                            RelatedProcedure = -1
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
                            Importance = "KeyPoint1",
                            HasDiagram = false,
                            Diagram = null,
                            RelatedProcedure = -1
                        }
                    };
                    break;
                case 2:
                    // Graft
                    keyPointsList = new List<KeyPoint>()
                    {
                        new KeyPoint()
                        {
                            Point = "Tips/Pitfalls",
                            Importance = "KeyPoint1",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 0,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Donor Site",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 1,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Counsel patients about risk of scarring to donor sites and possible asymmetry if upper eyelid skin is removed​",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 2,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Donor site epidermis regenerates from the immigration of epithelial cells originating in hair follicle shafts and adnexal structures left in the dermis.  Dermis never regenerates.​",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 3,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Full thickness skin grafts (FTSG) require suturing or split skin graft as there are no remaining epithelial structures to provide re-epithelialisation, while split thickness skin grafts (STSG) can heal spontaneously​",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 4,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Donor graft​",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 5,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "FTSG have the greatest sensory return because of a greater availability of neurilemmal sheaths. ",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 6,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Hair follicles are also transferred with a FTSG, while the chances of transferring hair follicles in STSG increases the thicker the graft (and the more dermis with hair follicles are incorporated). ",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 7,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Suture the flap to the lid defect under tension",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 8,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Thin grafts look more cosmetically acceptable than bulky grafts​",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 9,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "The graft should be sized to cover the defect – it is better to trim down a graft than to produce one that is too small relative to the defect​​",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 10,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Suitable like-for-like harvest locations depend on on the colour, texture, vascularity, dermis thickness, and donor site morbidity.​​",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 11,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Grafts can be taken from anywhere in the body, although grafts taken from above the clavicle provide a superior colour match to the face.",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 12,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Common donor sites for STSG are buttocks, thigh, abdominal wall, and scalp.​",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 13,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Skin grafts require a vascular bed and will seldom take in exposed bone, cartilage or tendon without its periosteum, perichondrium or paratenon.  An exception is good take of skin grafts inside the orbit despite periosteal removal",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 14,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Success of skin grafting (known as ‘take’):",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 15,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Depends on the graft’s ability to receive nutrients and subsequently vascular ingrowth from recipient bed.",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 16,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Take occurs in three phases;",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 17,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "First phase (plasmatic imbibition) – 24-48 hours after grafting: fibrin layer forms when graft is placed on recipient bed, binding graft to the bed.  Absorption of nutrients into graft occur by capillary action from recipient bed.",
                            Importance = "KeyPoint4",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 18,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Second phase (inosculation) – 48-72 hours after grafting: recipient and donor end capillaries are aligned. Outgrowth of capillary buds from recipient area to unite with those on deep surface of graft​",
                            Importance = "KeyPoint4",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 19,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Third phase (revascularsation) – graft is revascularised through the capillaries​:",
                            Importance = "KeyPoint4",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 20,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Distance to be travelled by capillary beds in order to link up a new vascular network therefore needs to be as short as possible.  The smaller the distance, the more likely the graft is to bridge.  Close contact between skin graft and recipient bed is essential and the graft has to lie immobile on the bed until it is firmly attached.​",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 21,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Healing",
                            Importance = "KeyPoint2",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 22,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Primary contraction is the immediate recoil of freshly harvested grafts as a result of the elastin in the dermis. The more dermis the graft has, the more primary the contraction that will be experienced. ",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 23,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "Secondary contracture involves contraction of a healed graft and is probably a result of myofibroblast activity.",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 24,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "A full-thickness skin graft contracts more on initial harvest (primary contraction) but less on healing (secondary contracture) than a split-thickness skin graft.",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 25,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "The thinner the split-thickness skin graft, the greater the secondary contracture.",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 26,
                            RelatedProcedure = -1
                        },
                        new KeyPoint()
                        {
                            Point = "FTSG therefore remains virtually at its original size; STSG tends to contract​",
                            Importance = "KeyPoint3",
                            HasDiagram = false,
                            Diagram = null,
                            Number = 27,
                            RelatedProcedure = -1
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
//    internal List<KeyPoint> GetKeyPoints(int id)
//    {
//        List<Diagram> diagrams = new Diagram().GetDiagrams(id);
//        List<KeyPoint> keyPointsList = new List<KeyPoint>();
//        FormattedString fString = new FormattedString();

//        switch (id)
//        {
//            case 0:
//                // Tarso
//                fString = new FormattedString();
//                fString.Spans.Add(new Span() { Text = "Specific Considerations:", Style = (Style)Application.Current.Resources["VariationHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nOnly eye: this technique creates a bridging flap that obscures the patient’s vision before the flap is divided in the second stage.  This may not be suited for patients if it affects their only seeing eye.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nSecond procedure for division of Hughes flap requires the patient to return to the operating theatre, which may not be practical or possible if the patient has other comorbidities:", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                keyPointsList.Add(new KeyPoint() { Point = fString, RelatedProcedure = 2, Number = 0 });

//                fString = new FormattedString();
//                fString.Spans.Add(new Span() { Text = "Tips and Pitfalls", Style = (Style)Application.Current.Resources["VariationHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nDissection", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                keyPointsList.Add(new KeyPoint() { Point = fString, Diagram = diagrams[0], HasDiagram = true, Number = 1 });

//                fString = new FormattedString();
//                fString.Spans.Add(new Span() { Text = "It is easier to dissect conjunctiva and Mullers rather than just dissecting conjunctiva alone​", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nDissecting superiorly up to white line ensures that the flap is completely free and can be mobilised into the defect without tension​.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nSuture:", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nSuture the flap to the lid defect under tension.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nAllow a small amount of skin recession.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                keyPointsList.Add(new KeyPoint() { Point = fString, Number = 2 });
//                break;
//            case 1:
//                // Tenzel
//                fString = new FormattedString();
//                fString.Spans.Add(new Span() { Text = "Make a perpendicular incision from the lateral commissure through the obicularis  - as this skin muscle flap will form the basis of the new lid margin it is important to keep it uniform", Style = (Style)Application.Current.Resources["VariationHeader"] });
//                keyPointsList.Add(new KeyPoint() { Point = fString, Number = 0 });
//                break;
//            case 2:
//                // Graft
//                fString = new FormattedString();
//                fString.Spans.Add(new Span() { Text = "Tips/Pitfalls​", Style = (Style)Application.Current.Resources["VariationHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nDonor Site", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nCounsel patients about risk of scarring to donor sites and possible asymmetry if upper eyelid skin is removed", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nDonor site epidermis regenerates from the immigration of epithelial cells originating in hair follicle shafts and adnexal structures left in the dermis.  Dermis never regenerates.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nFull thickness skin grafts (FTSG) require suturing or split skin graft as there are no remaining epithelial structures to provide re-epithelialisation, while split thickness skin grafts (STSG) can heal spontaneously.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                keyPointsList.Add(new KeyPoint() { Point = fString, Number = 0 });

//                fString = new FormattedString();
//                fString.Spans.Add(new Span() { Text = "Donor Graft", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nFTSG have the greatest sensory return because of a greater availability of neurilemmal sheaths.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nHair follicles are also transferred with a FTSG, while the chances of transferring hair follicles in STSG increases the thicker the graft (and the more dermis with hair follicles are incorporated).", Style = (Style)Application.Current.Resources["VariationContent"] });
//                keyPointsList.Add(new KeyPoint() { Point = fString, Number = 1 });

//                fString = new FormattedString();
//                fString.Spans.Add(new Span() { Text = "Thin grafts look more cosmetically acceptable than bulky grafts.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nThe graft should be sized to cover the defect – it is better to trim down a graft than to produce one that is too small relative to the defect.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nSuitable like-for-like harvest locations depend on on the colour, texture, vascularity, dermis thickness, and donor site morbidity.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nGrafts can be taken from anywhere in the body, although grafts taken from above the clavicle provide a superior colour match to the face.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nCommon donor sites for STSG are buttocks, thigh, abdominal wall, and scalp.​", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nSkin grafts require a vascular bed and will seldom take in exposed bone, cartilage or tendon without its periosteum, perichondrium or paratenon.  An exception is good take of skin grafts inside the orbit despite periosteal removal.", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                keyPointsList.Add(new KeyPoint() { Point = fString, Number = 2 });

//                fString = new FormattedString();
//                fString.Spans.Add(new Span() { Text = "Success of skin grafting (known as ‘take’)", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "\nDepends on the graft’s ability to receive nutrients and subsequently vascular ingrowth from recipient bed.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nTake occurs in three phases:", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nFirst phase (plasmatic imbibition) – 24-48 hours after grafting: fibrin layer forms when graft is placed on recipient bed, binding graft to the bed.  Absorption of nutrients into graft occur by capillary action from recipient bed.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nSecond phase (inosculation) – 48-72 hours after grafting: recipient and donor end capillaries are aligned. Outgrowth of capillary buds from recipient area to unite with those on deep surface of graft.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nThird phase (revascularsation) – graft is revascularised through the capillaries​.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "\nDistance to be travelled by capillary beds in order to link up a new vascular network therefore needs to be as short as possible.The smaller the distance, the more likely the graft is to bridge.  Close contact between skin graft and recipient bed is essential and the graft has to lie immobile on the bed until it is firmly attached.​", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                keyPointsList.Add(new KeyPoint() { Point = fString, Number = 3 });

//                fString = new FormattedString();
//                fString.Spans.Add(new Span() { Text = "Healing", Style = (Style)Application.Current.Resources["VariationSubHeader"] });
//                fString.Spans.Add(new Span() { Text = "Primary contraction is the immediate recoil of freshly harvested grafts as a result of the elastin in the dermis. The more dermis the graft has, the more primary the contraction that will be experienced.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "Secondary contracture involves contraction of a healed graft and is probably a result of myofibroblast activity.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "A full-thickness skin graft contracts more on initial harvest (primary contraction) but less on healing (secondary contracture) than a split-thickness skin graft.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "The thinner the split-thickness skin graft, the greater the secondary contracture.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                fString.Spans.Add(new Span() { Text = "FTSG therefore remains virtually at its original size; STSG tends to contract​.", Style = (Style)Application.Current.Resources["VariationContent"] });
//                keyPointsList.Add(new KeyPoint() { Point = fString, Number = 1 });

//                break;
//        }

//        foreach (KeyPoint keyp in keyPointsList)
//        {
//            keyp.HasDiagram = false;
//            if (keyp.Diagram != null)
//            {
//                keyp.HasDiagram = true;
//            }
//        }

//        return keyPointsList;
//    }
//}
}