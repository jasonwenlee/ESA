using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ESA.Views;

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
                    new VariationPageModel() { Name = "Tarsoconjunctival Hughes Flap – Stage 2" , VariationImage = "C:/Dhammika/StepsPage2/ESA/ESA/Resources/variationImage1.png"},
                     new VariationPageModel() { Name = "Sliding Tarsoconjunctival Flap Reconstruction" , VariationImage = "ESA.Resources.variationImage2.png"},
                        new VariationPageModel() { Name = "Fornix Reconstruction with Omnigen" , VariationImage = "variationImage3.png"},
                           new VariationPageModel() { Name = "Nasofacial sulcus island Pedicle (V to Y) Flap" , VariationImage = "C:/Dhammika/StepsPage2/ESA/ESA/Resources/variationImage4.png"}
                };
                return variationView;
            }

        }

    }
    

