using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
<<<<<<< HEAD
using Xamarin.Forms;
using System.Text;
using ESA.Views;
using System.Reflection;
=======
using System.Text;
using ESA.Views;
>>>>>>> 02dfbfbaf2c2eb6ccb1906750facd2baf29c3e8e

namespace ESA.Models
{
    public class VariationPageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
<<<<<<< HEAD
         public string VariationImage { get; set; }
=======
        public string VariationImage { get; set; }
>>>>>>> 02dfbfbaf2c2eb6ccb1906750facd2baf29c3e8e

        public List<VariationPageModel> GetVariationList()

        {
<<<<<<< HEAD
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
=======
                List<VariationPageModel> variationView = new List<VariationPageModel>()
                {
                    new VariationPageModel() { Name = "Tarsoconjunctival Hughes Flap – Stage 2" , VariationImage = "C:/Dhammika/StepsPage2/ESA/ESA/Resources/variationImage1.png"},
                     new VariationPageModel() { Name = "Sliding Tarsoconjunctival Flap Reconstruction" , VariationImage = "ESA.Resources.variationImage2.png"},
                        new VariationPageModel() { Name = "Fornix Reconstruction with Omnigen" , VariationImage = "variationImage3.png"},
                           new VariationPageModel() { Name = "Nasofacial sulcus island Pedicle (V to Y) Flap" , VariationImage = "C:/Dhammika/StepsPage2/ESA/ESA/Resources/variationImage4.png"}
                };
                return variationView;
            }

        }
>>>>>>> 02dfbfbaf2c2eb6ccb1906750facd2baf29c3e8e

    }
    

