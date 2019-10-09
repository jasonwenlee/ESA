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
                    DescPhotoText = "1. Upper eyelid retraction",
                    ImageUrl = "eyeRetraction01.jpeg"
                },
                new Complications()
                {
                     DescPhotoText = "2. Conjunctiva advancing anteriorly over lid margin",
                    ImageUrl = "Complication02.jpeg"
                },

                new Complications()
                {
                    DescPhotoText = "3. Skin advancing posteriorly over lid margin",
                    ImageUrl = "Complication03.jpeg"
                },

                
                  new Complications()
                {
                     DescPhotoText = "4. Lid margin granuloma",
                    ImageUrl = "eyeLidGranuloma04.jpg"
                },
                    new Complications()
                {
                     DescPhotoText = "5. Lid margin irregularity",
                    ImageUrl = "eyeLidMarginIrregularity05.jpg"
                }
            };
            return complicationView;
        }
    }
}
