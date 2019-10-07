using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Text;
using ESA.Views;
using System.Reflection;

namespace ESA.Models
{
    public class Complications
    {
        public string DescPhotoText { get; set; }
        public string ImageUrl { get; set; }


        public  List<Complications> GetComplicationsList()
        {
            List<Complications> complicationView = new List<Complications>()
            {
                new Complications()
                {
                    DescPhotoText = "• Upper eyelid retraction",
                    ImageUrl = "eyeRetraction01.jpeg"
                },
                new Complications()
                {
                     DescPhotoText = "• Conjunctiva advancing anteriorly over lid margin",
                    ImageUrl = "Complication02.jpeg"
                },

                new Complications()
                {
                    DescPhotoText = "• Skin advancing posteriorly over lid margin",
                    ImageUrl = "Complication03.jpeg"
                },

                
                  new Complications()
                {
                     DescPhotoText = "• Lid margin granuloma",
                    ImageUrl = "eyeLidGranuloma04.jpg"
                },
                    new Complications()
                {
                     DescPhotoText = "• Lid margin irregularity",
                    ImageUrl = "eyeLidMarginIrregularity05.jpg"
                }
            };
            return complicationView;
        }
    }
}
