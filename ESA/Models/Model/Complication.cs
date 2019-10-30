using ESA.MarkupExtensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace ESA.Models.Model
{
    public class Complication
    {
        public string Name { get; set; }
        public ImageSource Image { get; set; }

        internal List<Complication> GetComplications(int id)
        {
            List<List<Complication>> complicationsList = new List<List<Complication>>()
            {
                // Tarso
                new List<Complication>()
                {
                    new Complication()
                    {
                        Name = "Upper eyelid retraction",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {
                        Name = "Skin advancing posteriorly over lid margin",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.SkinAdvancingOver.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {
                        Name = "Lid margin granuloma",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {
                        Name = "Lid margin irregularity",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginIrregularity.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {
                        Name = "Conjunctiva advancing anteriorly over lid margin",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    }
                },
                // Tenzel
                new List<Complication>()
                {
                    new Complication()
                    {
                        Name = "Ectropion",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {
                        Name = "Pyogenic Granuloma",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.SkinAdvancingOver.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {
                        Name = "Symblepharon",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {
                        Name = "Marginal Notching",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginIrregularity.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    }
                },
                // Graft
                new List<Complication>()
                {
                    new Complication()
                    {
                        Name = "Wound Dehiscence",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {
                        Name = "Wound Haematoma",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.SkinAdvancingOver.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    }
                }
            };

            return complicationsList[id]; 
        }
    }
}