using ESA.MarkupExtensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace ESA.Models
{
    public class Complications
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ImageSource Image { get; set; }


        public List<Complications> GetComplicationsList()
        {
            List<Complications> complicationView = new List<Complications>()
            {
                new Complications()
                {
                    Name = "Upper eyelid retraction",
                    Description = "Upper eyelid retraction is a common finding in patients with Graves’ ophthalmopathy. Early in the course of Graves’ disease, eyelid malposition may result from increased sympathetic activity.With chronicity, the eyelid retractors(levator palpebrae superioris and Müllers muscle) become hypertrophic, eventually fibrotic, and adherent to orbital tissues.",
                    Image = ImageSource.FromResource("ESA.Resources.eyelidMarginIrregularity.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                },
                new Complications()
                {
                    Name = "Lid margin irregularity",
                    Description = "Upper eyelid retraction is a common finding in patients with Graves’ ophthalmopathy. Early in the course of Graves’ disease, eyelid malposition may result from increased sympathetic activity.With chronicity, the eyelid retractors(levator palpebrae superioris and Müllers muscle) become hypertrophic, eventually fibrotic, and adherent to orbital tissues.",
                    Image = ImageSource.FromResource("ESA.Resources.eyelidMarginIrregularity.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                },

                new Complications()
                {
                    Name = "Skin advancing posteriorly over lid margin",
                    Description = "Upper eyelid retraction is a common finding in patients with Graves’ ophthalmopathy. Early in the course of Graves’ disease, eyelid malposition may result from increased sympathetic activity.With chronicity, the eyelid retractors(levator palpebrae superioris and Müllers muscle) become hypertrophic, eventually fibrotic, and adherent to orbital tissues.",
                    Image = ImageSource.FromResource("ESA.Resources.Complication03.jpeg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                },

                new Complications()
                {
                    Name = "Lid margin granuloma",
                    Description = "Upper eyelid retraction is a common finding in patients with Graves’ ophthalmopathy. Early in the course of Graves’ disease, eyelid malposition may result from increased sympathetic activity.With chronicity, the eyelid retractors(levator palpebrae superioris and Müllers muscle) become hypertrophic, eventually fibrotic, and adherent to orbital tissues.",
                    Image = ImageSource.FromResource("ESA.Resources.eyeLidGranuloma.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                },
                new Complications()
                {
                    Name = "Lid margin irregularity",
                    Description = "Upper eyelid retraction is a common finding in patients with Graves’ ophthalmopathy. Early in the course of Graves’ disease, eyelid malposition may result from increased sympathetic activity.With chronicity, the eyelid retractors(levator palpebrae superioris and Müllers muscle) become hypertrophic, eventually fibrotic, and adherent to orbital tissues.",
                    Image = ImageSource.FromResource("ESA.Resources.Complication01.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                }
            };
            return complicationView;
        }
    }
}