using System.Collections.Generic;

namespace ESA.Models
{
    public class Person
    {
        public string PersonName { get; set; }
        public string ShortDesc { get; set; }
        public string ImageUrl { get; set; }

        // REC: Need to declare the image property (below)
        public string Image { get; set; }

        public List<Person> GetPeople()
        {
            // REC: Statements below are a Potential solution if pulling images from different platforms becomes an issue.
            //var solution = new Xamarin.Forms.Image();
            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //    case Device.Android:
            //        solution.Source = ImageSource.FromFile("Saul.png");
            //        break;
            //    case Device.UWP:
            //        solution.Source = ImageSource.FromFile("Assets/Images/Saul.png");
            //        break;
            //}


            List<Person> people = new List<Person>()
            {
                // REC: Below commented out statements are useful when bringing the images fgrom URLs.
                //new Person(){ PersonName="Dr Saul Rajak PhD FRCOphth", ShortDesc="Saul is a consultant oculoplastic, orbital and lacrimal surgeon at Brighton and Sussex University Hospital, UK. Saul underwent his Ophthalmology training in London and Sussex and completed oculoplastic fellowships in Brighton, UK and Adelaide, Australia. Saul also spent four years studying trachoma in Ethiopia through the London School of Hygiene and Tropical Medicine. He was awarded his PhD for this work and continues to be very active in this field. Saul passion for teaching and in particular the use of video for surgical training led to the development of this website and it’s sister site EyeSurgeryVideos.net which is a major oculoplastic video based surgical training site used by surgeons around the world. ",
                //ImageUrl="https://oculoplastic.eyesurgeryvideos.net/wp-content/uploads/2018/06/saul.jpg"},
                //new Person(){ PersonName="Professor Dinesh Selva DHCS FRANZCO", ShortDesc="Dinesh has been the Foundation Chair of Ophthalmology & Visual Sciences at the University of Adelaide, Australia since 2004. Dinesh underwent Ophthalmology training in Adelaide before completing Fellowships in Oculoplastic, Lacrimal & Orbital Surgery at the University of British Columbia, Vancouver, Canada and Moorfields Eye Hospital, London. He has an international reputation in the field of Oculoplastic, Lacrimal & Orbital Surgery. He has published over 400 peer-reviewed papers and book chapters and is a regularly invited speaker around the world. He jointly runs the internationally renowned oculoplastics fellowship at the Royal Adelaide Hospital in which he has trained numerous oculoplastic surgeons from all over the world. ",
                //ImageUrl="https://oculoplastic.eyesurgeryvideos.net/wp-content/uploads/2015/11/selva1.png"},
                //new Person(){ PersonName="Dr Garry Davis FRANZCO", ShortDesc="Garry is a consultant oculoplastic, orbital and lacrimal surgeon at The Royal Adelaide Hospital, Australia. He undertook ophthalmology training in Adelaide, and completed Fellowships in oculoplastics, orbital and lacrimal surgery at The Bristol Eye Hospital, UK and Moorfields Eye Hospital, UK. Garry has a strong interest in oculoplastic surgery teaching; he jointly runs the internationally renowned oculoplastics fellowship at the Royal Adelaide Hospital and has also conducted training in several South East Asian Countries as a visiting ophthalmologist for Sight For All. As well as having a busy oculoplastic practice in Adelaide, Garry has also done regular eyecare trips to the Aboriginal communities in the APY lands for over twenty years. ",
                //ImageUrl="https://oculoplastic.eyesurgeryvideos.net/wp-content/uploads/2015/11/gary2.png"},
                //new Person(){ PersonName="Dr Akihide Watanabe MD PhD", ShortDesc="Akihide is an assistant professor of Department of Ophthalmology, Kyoto Prefectural University of Medicine, Japan. Akihide underwent his Ophthalmology training in Kyoto and completed oculoplastic fellowships at Seirei Hamamatsu Hospital, Japan. Akihide also studied as short term oculoplastic fellow in 2011 & 2013 in Adelaide, Australia. ",
                //ImageUrl="https://oculoplastic.eyesurgeryvideos.net/wp-content/uploads/2015/11/akihide.jpg"}

                // REC: Below statements to be used when embbeding.
                new Person(){ PersonName="Dr Saul Rajak PhD FRCOphth", ShortDesc="Saul is a consultant oculoplastic, orbital and lacrimal surgeon at Brighton and Sussex University Hospital, UK. Saul underwent his Ophthalmology training in London and Sussex and completed oculoplastic fellowships in Brighton, UK and Adelaide, Australia. Saul also spent four years studying trachoma in Ethiopia through the London School of Hygiene and Tropical Medicine. He was awarded his PhD for this work and continues to be very active in this field. Saul passion for teaching and in particular the use of video for surgical training led to the development of this website and it’s sister site EyeSurgeryVideos.net which is a major oculoplastic video based surgical training site used by surgeons around the world. ",
                Image = "Saul.PNG"},
                new Person(){ PersonName="Professor Dinesh Selva DHCS FRANZCO", ShortDesc="Dinesh has been the Foundation Chair of Ophthalmology & Visual Sciences at the University of Adelaide, Australia since 2004. Dinesh underwent Ophthalmology training in Adelaide before completing Fellowships in Oculoplastic, Lacrimal & Orbital Surgery at the University of British Columbia, Vancouver, Canada and Moorfields Eye Hospital, London. He has an international reputation in the field of Oculoplastic, Lacrimal & Orbital Surgery. He has published over 400 peer-reviewed papers and book chapters and is a regularly invited speaker around the world. He jointly runs the internationally renowned oculoplastics fellowship at the Royal Adelaide Hospital in which he has trained numerous oculoplastic surgeons from all over the world. ",
                Image = "Dinesh.PNG" },
                //do the image thing for Dinesh    
                new Person(){ PersonName="Dr Garry Davis FRANZCO", ShortDesc="Garry is a consultant oculoplastic, orbital and lacrimal surgeon at The Royal Adelaide Hospital, Australia. He undertook ophthalmology training in Adelaide, and completed Fellowships in oculoplastics, orbital and lacrimal surgery at The Bristol Eye Hospital, UK and Moorfields Eye Hospital, UK. Garry has a strong interest in oculoplastic surgery teaching; he jointly runs the internationally renowned oculoplastics fellowship at the Royal Adelaide Hospital and has also conducted training in several South East Asian Countries as a visiting ophthalmologist for Sight For All. As well as having a busy oculoplastic practice in Adelaide, Garry has also done regular eyecare trips to the Aboriginal communities in the APY lands for over twenty years. ",
                Image = "Garry.PNG"},
                //do the image thing for Garry    
                new Person(){ PersonName="Dr Akihide Watanabe MD PhD", ShortDesc="Akihide is an assistant professor of Department of Ophthalmology, Kyoto Prefectural University of Medicine, Japan. Akihide underwent his Ophthalmology training in Kyoto and completed oculoplastic fellowships at Seirei Hamamatsu Hospital, Japan. Akihide also studied as short term oculoplastic fellow in 2011 & 2013 in Adelaide, Australia. ",
                Image = "Akihide.PNG"},
                //do the image thing for Akihide
                new Person(){ PersonName="Dr. Valerie Juniat", ShortDesc="Details for Valerie pending. ",
                Image = "VJ.png"},
                //do the image thing for Valerie
                new Person(){ PersonName="iVision", ShortDesc="iVision is a Multicultural and Multinational team of Developers -all living in the beautiful city of Adelaide Australia-, who enjoy learning and applying our knowledge for creating meaningful Applications which contribute to reach innovative, faster, easier and better ways of doing things. We just love programming and seeing how our coding magic helps transforming improvement ideas into reality through technology.",
                Image = "iV.png"}
                //do the image thing for our Logo
            };
            return people;
        }
    }
}
