using ESA.Models;
using ESA.Models.PageModels;
using ESA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoView : ContentView
    {
        private readonly bool historyOpen;
        private readonly bool referenceOpen;

        private ReferencesModel referenceList;
        private Editor storeReferencesEditor;

        public InfoView()
        {
            InitializeComponent();
            referenceList = new ReferencesModel();
            referenceList.LoadRefList();
            BindingContext = new InfoViewModel(Navigation);
        }

        private void HistoryButton_Clicked(object sender, EventArgs e)
        {

            if (historyView.IsVisible == false)
            {
                historyView.IsVisible = true;
                if (!referenceOpen)
                {
                    referencesView.IsVisible = false;
                }
                //if (extractInfo == null)
                //{
                //    historyEditor.Text = "Empty";
                //    return;
                //}
            }
            else if (historyView.IsVisible == true)
            {
                historyView.IsVisible = false;
            }
        }

        private void ReferencesButton_Clicked(object sender, EventArgs e)
        {
            if (storeReferencesEditor == null)
            {
                PrintRefToEditor();
            }
            if (referencesView.IsVisible == false)
            {
                referencesView.IsVisible = true;
                if (!historyOpen)
                {
                    historyView.IsVisible = false;
                }
            }
            else if (referencesView.IsVisible == true)
            {
                referencesView.IsVisible = false;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (storeReferencesEditor == null)
            {
                PrintRefToEditor();
            }
            if (historyView.IsVisible)
            {
                referencesView.IsVisible = true;
                historyView.IsVisible = false;
            }
        }

        private void PrintRefToEditor()
        {
            foreach (var item in referenceList.RefList)
            {
                referencesEditor.Text = referencesEditor.Text + item.number + " " + item.details + "\n\n";
                storeReferencesEditor = referencesEditor;
            }
        }
    }
}

//historyEditor.Text = "Dr Wendel Hughes, an ophthalmologist who contributed to the field of oculoplastic surgery, published his first paper on tarsoconjunctival flaps in 1937.1,2\n" +
//    "\nFurther modifications to the technique by Hughes and others occurred throughout subsequent decades. 3 - 6 Significant developments included using full-thickness skin grafting of the tarsoconjunctival flap, " +
//    "sparing of the marginal upper lid tarsus, and removal of the levator muscle complex from the tarsoconjunctival flap.This led to the reduction in upper lid complications, such as upper lid retraction, entropion, and trichiasis.\n" +
//    "\nTraditionally, flap division occurred 3 to 4 months after the initial stage.Currently the standard time to flap division is frequently 2 weeks,  but can be carried out from 7 days with good outcome.7,8";


//referencesEditor.Text = "McClellan WT, Rawson AE.  Wendell L. Hughes' life and contributions to plastic surgery. Plast Reconstr Surg 2011; 128(6):765e-72e.\n" +
//    "\nHughes, Wendell L.  A new method for rebuilding a lower lid: report of a case.  Arch Ophthalmol 1937; 17(6):1008 - 1017\n" +
//    "\nRohrich RJ, Zbar R I. The evolution of the Hughes tarsoconjunctival flap for the lower eyelid reconstruction.B Plast Reconstr Surg 1999; 104(2): 518 - 22\n" +
//    "\nHughes, Wendell L. Reconstruction of the lids. Am J Ophthalmol 1945; 28(11): 1203 - 1211\n" +
//    "\nCies WA, Bartlett RE.Modification of the Mustardé and Hughes methods of reconstructing the lower lid.  Ann Ophthalmol 1975; 7(11):1497 - 1502.\n" +
//    "\nHughes WL. Total lower lid reconstruction: technical details. Trans Am Ophthalmol Soc1976; 74:321 - 9.\n" +
//    "\nMcNab, AA, Martin P, Benger R, O'Donnell B, Kourt G.  A prospective randomized study comparing division of the pedicle of modified hughes flaps at two or four weeks. Ophthalmic Plast Reconstr Surg 2001;17(5): 317-9\n" +
//    "\nLeibovitch I, Selva D.Modified Hughes flap: division at 7 days.Ophthalmology. 2004; 111(12):2164 - 2167\n";