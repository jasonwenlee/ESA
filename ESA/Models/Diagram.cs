using ESA.MarkupExtensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace ESA.Models
{
    public class Diagram
    {
        public ImageSource Thumbnail { get; set; }
        public string VideoSource { get; set; }

        public List<Diagram> GetDiagrams()
        {
            return new List<Diagram>()
            {
                new Diagram()
                {
                    Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                    VideoSource = "eye_suregry.mp4"
                },
                new Diagram()
                {
                    Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                    VideoSource = "eye_suregry.mp4"
                },
                new Diagram()
                {
                    Thumbnail = ImageSource.FromResource("ESA.Resources.diagram.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                    VideoSource = "eye_suregry.mp4"
                }
            };
        }
    }
}
