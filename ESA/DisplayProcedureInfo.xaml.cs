using ESA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayProcedureInfo : ContentPage
    {
        public DisplayProcedureInfo(Procedure proc)
        {
            InitializeComponent();
            if (proc is Lacrimal)
            {
                Lacrimal newProc = (Lacrimal)proc;
                procedureCategoryEntry.Text = newProc.ID.ToString();
                procedureNameEntry.Text = newProc.Name.ToString();
                procedureDetailEntry.Text = newProc.Details.ToString();
            }
            else if (proc is Orbital)
            {

            }
            else if (proc is Eyelid)
            {

            }
        }

        //public DisplayProcedureInfo(Procedure proc)
        //{
        //    if (proc is Lacrimal)
        //    {
        //        Lacrimal newProc = (Lacrimal)proc;
        //        procedureCategoryEntry.Text = newProc.ID.ToString();
        //        procedureNameEntry.Text = newProc.Name.ToString();
        //        procedureDetailEntry.Text = newProc.Details.ToString();
        //    }
        //    else if (proc is Orbital)
        //    {

        //    }
        //    else if (proc is Eyelid)
        //    {

        //    }
        //}
    }
}