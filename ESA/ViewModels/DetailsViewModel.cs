using ESA.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.ViewModels
{
    public class DetailsViewModel
    {
        public Procedure Procedure { get; set; }
        public List<Procedure> ProcedureNames { get; set; }

        //VideoPlayer
        public TimeSpan VideoPosition { get; set; }
        public string VideoName { get; set; }
        public bool VideoIsProcedure { get; set; }

        public DetailsViewModel(Procedure proc)
        {
            //Procedure = new Procedure().GetProcedure(id);
            Procedure = proc;
            GetNumberOfSteps(proc);
            VideoPosition = TimeSpan.Zero;
            VideoName = "Brain_Eyes_Vid.mp4";
            VideoIsProcedure = true;
        }

        public Procedure GetProcedure(int id)
        {
            //Procedure = new Procedure().GetProcedure(id);
            //return Procedure;
            return null;
        }

        public void GetNumberOfSteps(Procedure proc)
        {
            int stepNo = 1;
            List<int> newList = new List<int>();
            foreach (var step in proc.Steps)
            {
                step.Number = stepNo;
                stepNo++;
            }
        }
    }
}
