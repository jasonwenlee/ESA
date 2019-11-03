using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Text;
using ESA.Views;
using System.Reflection;

namespace ESA.Models
{
    public class ComplicationsModel
    {
        public string DescPhotoText { get; set; }
        
        public string ImageUrl { get; set; }


        public  List<ComplicationsModel> GetComplicationsList()
        {
            List<ComplicationsModel> complicationView = new List<ComplicationsModel>()
            {
                new ComplicationsModel()
                {
                    DescPhotoText = "1. Upper eyelid retraction666666",
                    ImageUrl = "eyeRetraction01.jpeg"
                },
                new ComplicationsModel()
                {
                     DescPhotoText = "2. Conjunctiva advancing anteriorly over lid margin",
                    ImageUrl = "Complication02.jpeg"
                },

                new ComplicationsModel()
                {
                    DescPhotoText = "3. Skin advancing posteriorly over lid margin",
                    ImageUrl = "Complication03.jpeg"
                },

                
                  new ComplicationsModel()
                {
                     DescPhotoText = "4. Lid margin granuloma",
                    ImageUrl = "eyeLidGranuloma04.jpg"
                },
                    new ComplicationsModel()
                {
                     DescPhotoText = "5. Lid margin irregularity",
                    ImageUrl = "eyeLidMarginIrregularity05.jpg"
                }
            };
            return complicationView;
        }
    }
}
