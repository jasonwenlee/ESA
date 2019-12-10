using ESA.MarkupExtensions;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace ESA.Models.Model
{
    public class Person
    {
        public string PersonName { get; set; }
        public string ShortDesc { get; set; }
        public ImageSource Image { get; set; }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>()
            {
                new Person(){
                PersonName ="Dr Valerie Juniat MSc FRCOphth",
                ShortDesc ="Valerie is an Oculoplastics Fellow working under Professor Selva at the Royal Adelaide Hospital. She completed her Ophthalmology training in South-East England. Valerie has a passion for teaching and worked as a Clinical Teaching Fellow with a special interest in Oculoplastics at Moorfields Eye Hospital. ",
                Image = ImageSource.FromResource("ESA.Resources.People.valerie.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly) },
                new Person(){
                PersonName ="Dr Saul Rajak PhD FRCOphth",
                ShortDesc ="Saul is a consultant oculoplastic, orbital and lacrimal surgeon at Brighton and Sussex University Hospital, UK. Saul underwent his Ophthalmology training in London and Sussex and completed oculoplastic fellowships in Brighton, UK and Adelaide, Australia. Saul also spent four years studying trachoma in Ethiopia through the London School of Hygiene and Tropical Medicine. He was awarded his PhD for this work and continues to be very active in this field. Saul passion for teaching and in particular the use of video for surgical training led to the development of this website and it’s sister site EyeSurgeryVideos.net which is a major oculoplastic video based surgical training site used by surgeons around the world. ",
                Image = ImageSource.FromResource("ESA.Resources.People.saul.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly) },
                new Person(){
                PersonName ="Professor Dinesh Selva DHCS FRANZCO",
                ShortDesc ="Dinesh has been the Foundation Chair of Ophthalmology & Visual Sciences at the University of Adelaide, Australia since 2004. Dinesh underwent Ophthalmology training in Adelaide before completing Fellowships in Oculoplastic, Lacrimal & Orbital Surgery at the University of British Columbia, Vancouver, Canada and Moorfields Eye Hospital, London. He has an international reputation in the field of Oculoplastic, Lacrimal & Orbital Surgery. He has published over 400 peer-reviewed papers and book chapters and is a regularly invited speaker around the world. He jointly runs the internationally renowned oculoplastics fellowship at the Royal Adelaide Hospital in which he has trained numerous oculoplastic surgeons from all over the world. ",
                Image = ImageSource.FromResource("ESA.Resources.People.dinesh.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly) },
                new Person(){
                PersonName ="Dr Garry Davis FRANZCO",
                ShortDesc ="Garry is a consultant oculoplastic, orbital and lacrimal surgeon at The Royal Adelaide Hospital, Australia. He undertook ophthalmology training in Adelaide, and completed Fellowships in oculoplastics, orbital and lacrimal surgery at The Bristol Eye Hospital, UK and Moorfields Eye Hospital, UK. Garry has a strong interest in oculoplastic surgery teaching; he jointly runs the internationally renowned oculoplastics fellowship at the Royal Adelaide Hospital and has also conducted training in several South East Asian Countries as a visiting ophthalmologist for Sight For All. As well as having a busy oculoplastic practice in Adelaide, Garry has also done regular eyecare trips to the Aboriginal communities in the APY lands for over twenty years. ",
                Image = ImageSource.FromResource("ESA.Resources.People.garry.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly) },
                new Person(){
                PersonName ="Dr Akihide Watanabe MD PhD",
                ShortDesc ="Akihide is an assistant professor of Department of Ophthalmology, Kyoto Prefectural University of Medicine, Japan. Akihide underwent his Ophthalmology training in Kyoto and completed oculoplastic fellowships at Seirei Hamamatsu Hospital, Japan. Akihide also studied as short term oculoplastic fellow in 2011 & 2013 in Adelaide, Australia. ",
                Image = ImageSource.FromResource("ESA.Resources.People.akihide.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly) },
                new Person(){
                PersonName ="Adelaide Advanced Applications",
                ShortDesc ="Adelaide Advanced Applications is a Multicultural and Multinational team of software developers based in the beautiful city of Adelaide, Australia. 3A has a passion for learning, and applying that knowledge on innovative and meaningful applications. We love programming! Transforming ideas into reality through technology. ",
                Image = ImageSource.FromResource("ESA.Resources.3A.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)}

            };
            return people;
        }

    }
}