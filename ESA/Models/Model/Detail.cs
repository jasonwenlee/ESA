using System;
using System.Collections.Generic;

namespace ESA.Models.Model
{
    public class Detail
    {
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
        public DateTime UploadDate { get; set; }
        public int ViewCount { get; set; }
        public Person Author { get; set; }

        internal Detail GetDetails(int id)
        {
            List<Person> people = new Person().GetPeople();
            List<Detail> detailsList = new List<Detail>()
            {
                // Hughes Flap part I
                new Detail()
                {
                    Description = "This narrated video demonstrates the tarsoconjunctival (Hughes) flap for reconstruction of large defects of the lower eyelid, that most commonly occur after lower lid tumour excision.",
                    Categories = new Category().GetCategories(id),
                    UploadDate = DateTime.Parse("2016/01/06"),
                    ViewCount = 634,
                    Author = people[0]
                },
                // Tenzel
                new Detail()
                {
                    Description = "This narrated video demonstrates the semicircular Tenzel advancement flap for the reconstruction of a full thickness defect by the recruitment of lateral tissues to the lateral canthus as to allow medial mobilization of the eyelid and direct wound closure.",
                    Categories = new Category().GetCategories(id),
                    UploadDate = DateTime.Parse("2019/06/27"),
                    ViewCount = 5385,
                    Author = people[1]
                },
                // Full thickness skin graft
                new Detail()
                {
                    Description = "This narrated video demonstrates the use of Dermabond glue to secure a full thickness skin graft that is being used to correct cicatricial lower lid ectropion. The video briefly demonstrates lower lid tightening although this is seen in more detail in other videos on www.eyesurgeryvideos.net and then examines in detail how to use Dermabond instead of sutures, to secure the graft",
                    Categories = new Category().GetCategories(id),
                    UploadDate = DateTime.Parse("2015/10/27"),
                    ViewCount = 810,
                    Author = people[2]
                }
            };

            return detailsList[id];
        }
    }
}