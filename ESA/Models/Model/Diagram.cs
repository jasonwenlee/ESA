using ESA.MarkupExtensions;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace ESA.Models.Model
{
    public class Diagram
    {
        public ImageSource Thumbnail { get; set; }
        public string VideoSource { get; set; }

        public List<Diagram> GetDiagrams(int id)
        {

            List<Diagram> diagrams = new List<Diagram>();

            switch (id)
            {
                case 0:
                    // Tarso
                    diagrams = new List<Diagram>()
                    {
                        new Diagram()
                        {
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Diagrams.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            VideoSource = "eye_surgery.mp4"
                        },
                        new Diagram()
                        {
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Diagrams.history.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            VideoSource = "eye_surgery.mp4"
                        },
                        new Diagram()
                        {
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Diagrams.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            VideoSource = "eye_surgery.mp4"
                        }
                    };
                    break;

                case 1:
                    // Tezel
                    diagrams = new List<Diagram>()
                    {
                        new Diagram()
                        {
                            Thumbnail = ImageSource.FromResource("ESA.Resources.Diagrams.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                            VideoSource = "Brain_Eyes_Vid.mp4"
                        }
                    };
                    break;

                case 2:
                    // Graft
                    diagrams = new List<Diagram>() { };
                    break;

            }

            return diagrams;
        }
    }
}
