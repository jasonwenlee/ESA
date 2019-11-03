using ESA.MarkupExtensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace ESA.Models.Model
{
    public class Complication
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public ImageSource Image { get; set; }

        internal List<Complication> GetComplications(int id)
        {
            List<Complication> complicationsList = new List<Complication>()
            {
                // Tarso
              
                    new Complication()
                    {   Number=1,
                        Name = "Upper eyelid retraction",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    { Number=2,
                        Name = "Skin advancing posteriorly over lid margin",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.SkinAdvancingOver.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {    Number=3,
                        Name = "Lid margin granuloma",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    { Number=4,
                        Name = "Lid margin irregularity",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginIrregularity.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    { Number=5,
                        Name = "Conjunctiva advancing anteriorly over lid margin",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    }
                };
            // Tenzel
            new List<Complication>()
                {
                    new Complication()
                    {   Number=1,
                        Name = "Ectropion",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    { Number=2,
                        Name = "Pyogenic Granuloma",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.SkinAdvancingOver.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    {  Number=3,
                        Name = "Symblepharon",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    { Number=4,
                        Name = "Marginal Notching",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginIrregularity.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    }
                };
                // Graft
                new List<Complication>()
                {
                    new Complication()
                    { Number=1,
                        Name = "Wound Dehiscence",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    },
                    new Complication()
                    { Number=2,
                        Name = "Wound Haematoma",
                        Image = ImageSource.FromResource("ESA.Resources.Complications.SkinAdvancingOver.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                    }
                
            };

            return complicationsList; 
        }
    }
}