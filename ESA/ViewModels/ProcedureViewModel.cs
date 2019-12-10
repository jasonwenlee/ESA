using ESA.Models.Model;
using System;
using System.Collections.Generic;

namespace ESA.ViewModels
{
    public class ProcedureViewModel
    {
        public Procedure Procedure { get; set; }
        public List<Procedure> ProcedureNames { get; set; }

        //VideoPlayer
        public TimeSpan VideoPosition { get; set; }
        public string VideoName { get; set; }
        public bool VideoIsProcedure { get; set; }

        public ProcedureViewModel(int id)
        {
            Procedure = new Procedure().GetProcedure(id);

            VideoPosition = TimeSpan.Zero;
            VideoName = "Brain_Eyes_Vid.mp4";
            VideoIsProcedure = true;
        }

        public Procedure GetProcedure(int id)
        {
            Procedure = new Procedure().GetProcedure(id);
            return Procedure;
        }
    }
}
