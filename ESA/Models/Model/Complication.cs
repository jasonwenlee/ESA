using ESA.Converter;
using ESA.MarkupExtensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace ESA.Models.Model
{
    public class Complication
    {
        #region json
        [JsonProperty("$id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public int JsonId { get; set; }
        [JsonProperty("procedure", NullValueHandling = NullValueHandling.Ignore)]
        public Procedure Procedure { get; set; }
        [JsonProperty("procedureID", NullValueHandling = NullValueHandling.Ignore)]
        public int ProcedureId { get; set; }
        [JsonProperty("complicationID", NullValueHandling = NullValueHandling.Ignore)]
        public int ComplicationId { get; set; }
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplicationName { get; set; }
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageFilePath { get; set; }
        #endregion

        public int Number { get; set; }
        
        public string Name { get; set; }
        public ImageSource Image { get; set; }

        #region OldHardCoded
        //internal List<Complication> GetComplications(int id)
        //{
        //    List<Complication> complications = new List<Complication>();
        //    switch (id)
        //    {
        //        case 0:
        //            complications = new List<Complication>()
        //            {
        //                new Complication()
        //                {
        //                    Number = 1,
        //                    Name = "Upper eyelid retraction",
        //                    Image = ImageSource.FromResource("ESA.Resources.Complications.UpperEyelidRetraction.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                },
        //                new Complication()
        //                {
        //                    Number = 2,
        //                    Name = "Skin advancing posteriorly over lid margin",
        //                    Image = ImageSource.FromResource("ESA.Resources.Complications.SkinAdvancingOver.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                },
        //                new Complication()
        //                {
        //                    Number = 3,
        //                    Name = "Lid margin granuloma",
        //                    Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                },
        //                new Complication()
        //                {
        //                    Number = 4,
        //                    Name = "Lid margin irregularity",
        //                    Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginIrregularity.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                },
        //                new Complication()
        //                {
        //                    Number = 5,
        //                    Name = "Conjunctiva advancing anteriorly over lid margin",
        //                    Image = ImageSource.FromResource("ESA.Resources.Complications.UpperEyelidRetraction.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                }
        //            };
        //            break;
        //        case 1:
        //            // Tenzel
        //            complications = new List<Complication>()
        //                {
        //                    new Complication()
        //                    {   Number=1,
        //                        Name = "Ectropion",
        //                        Image = ImageSource.FromResource("ESA.Resources.Complications.UpperEyelidRetraction.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                    },
        //                    new Complication()
        //                    { Number=2,
        //                        Name = "Pyogenic Granuloma",
        //                        Image = ImageSource.FromResource("ESA.Resources.Complications.SkinAdvancingOver.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                    },
        //                    new Complication()
        //                    {  Number=3,
        //                        Name = "Symblepharon",
        //                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                    },
        //                    new Complication()
        //                    { Number=4,
        //                        Name = "Marginal Notching",
        //                        Image = ImageSource.FromResource("ESA.Resources.Complications.LidMarginIrregularity.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                    }
        //                };
        //            break;

        //        case 2:
        //            // Graft
        //            complications = new List<Complication>()
        //            {
        //                new Complication()
        //                { Number=1,
        //                    Name = "Wound Dehiscence",
        //                    Image = ImageSource.FromResource("ESA.Resources.Complications.WoundDehiscence.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                },
        //                new Complication()
        //                { Number=2,
        //                    Name = "Wound Haematoma",
        //                    Image = ImageSource.FromResource("ESA.Resources.Complications.WoundHaematoma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
        //                }
        //             };
        //            break;
        //    }


        //    return complications;
        //}
        #endregion

    }
}