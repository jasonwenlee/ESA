using ESA.Models;
using ESA.ViewModels;
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
    public partial class InfoView : ContentView
    {
        private readonly bool historyOpen;
        private readonly bool referenceOpen;
        Procedure extractInfo;

        public InfoView(Procedure getProcInfo)
        {
            InitializeComponent();
            extractInfo = getProcInfo;
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
                if (extractInfo == null)
                {
                    historyEditor.Text = "Empty";
                    return;
                }
                historyEditor.Text = extractInfo.History.content.ToString();

            }
            else if (historyView.IsVisible == true)
            {
                historyView.IsVisible = false;
            }
        }

        private void ReferencesButton_Clicked(object sender, EventArgs e)
        {
            if (referencesView.IsVisible == false)
            {
                referencesView.IsVisible = true;
                if (!historyOpen)
                {
                    historyView.IsVisible = false;
                }
                if (extractInfo == null)
                {
                    referencesEditor.Text = "Empty";
                    return;
                }
                referencesEditor.Text = extractInfo.References.content.ToString();

            }
            else if (referencesView.IsVisible == true)
            {
                referencesView.IsVisible = false;
            }
        }
    }
}