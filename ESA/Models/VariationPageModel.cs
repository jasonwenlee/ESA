using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Text;
using ESA.Views;
using System.Reflection;

namespace ESA.Models
{
    public class VariationPageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Info { get; set; }

         public string VariationImage { get; set; }


        public List<VariationPageModel> GetVariationList()

        {

            List<VariationPageModel> variationView = new List<VariationPageModel>()
                {
                    new VariationPageModel() { Name = "Tarsoconjunctival Hughes Flap – Stage 2" , Details = "Narrated division of the Stage 2 Hughes Tarsonconjunctival flap.",
                      VariationImage = "variationImage1.png", Info = "10th March 2016 - 1,213 Views"}, 
         //              VariationImage = ImageSource.FromResource("ESA.Resources.variationimage1.png", typeof(MarkupExtensions.ImageResourceExtension).GetTypeInfo().Assembly) },
                     new VariationPageModel() { Name = "Sliding Tarsoconjunctival Flap Reconstruction" , Details = "Narrated demonstration: post tumour reconstruction of upper eyelid using sliding.",
                         VariationImage = "variationImage2.png", Info = "14th November 2017 - 5,217 Views"}, 
                        new VariationPageModel() { Name = "Fornix Reconstruction with Omnigen" , Details = "Narrated reconstruction of inferior fornix using Ominigen.",
                            VariationImage = "variationImage3.png", Info = "11th June 2019 - 109 Views"},
                           new VariationPageModel() { Name = "Nasofacial sulcus island Pedicle (V to Y) Flap" , Details = "Narrated advancement flap for reconstruction in periocular region.",
                               VariationImage = "variationImage4.png", Info = "Uploaded 27th October 2019 - 309 Views"}
                };
            return variationView;
        }

    }

    }
    

