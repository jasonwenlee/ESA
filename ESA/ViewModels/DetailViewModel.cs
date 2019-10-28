using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    public class DetailViewModel
    {
        public TimeSpan videoPosition { get; set; }
        public string videoName { get; set; }
        public bool videoIsProcedure { get; set; }

        public DetailViewModel()
        {
            videoPosition = TimeSpan.Zero;
            videoName = "Brain_Eyes_Vid.mp4";
            videoIsProcedure = true;
        }
    }
}
