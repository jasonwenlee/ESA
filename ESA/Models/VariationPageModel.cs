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

         public string VariationImage { get; set; }


        public List<VariationPageModel> GetVariationList()

        {

            List<VariationPageModel> variationView = new List<VariationPageModel>()
                {
                    new VariationPageModel() { Name = "Tarsoconjunctival Hughes Flap – Stage 2" , Details = "Narrated division of the Stage 2 Hughes Tarsonconjunctival flap  10th March 2016 - 1,213 Views",
                      VariationImage = "variationImage1.png"}, 
         //              VariationImage = ImageSource.FromResource("ESA.Resources.variationimage1.png", typeof(MarkupExtensions.ImageResourceExtension).GetTypeInfo().Assembly) },
                     new VariationPageModel() { Name = "Sliding Tarsoconjunctival Flap Reconstruction" , Details = "Narrated demonstration: post tumour reconstruction of upper eyelid using sliding Uploaded 14th November 2017 - 5,217 Views",
                         VariationImage = "variationImage2.png"}, 
                        new VariationPageModel() { Name = "Fornix Reconstruction with Omnigen" , Details = "Narrated reconstruction of inferior fornix using Ominigen Uploaded 11th June 2019 - 109 Views",
                            VariationImage = "variationImage3.png"},
                           new VariationPageModel() { Name = "Nasofacial sulcus island Pedicle (V to Y) Flap" , Details = "Narrated advancement flap for reconstruction in periocular region Uploaded 27th October 2019 - 309 Views",
                               VariationImage = "variationImage4.png"}
                };
            return variationView;
        }

    }

    }
    

