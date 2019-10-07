using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyPointsView : ContentView
    {
        public KeyPointsView()
        {
            InitializeComponent();
        }

        private void ProcedureLink_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailsPage());
        }
    }
}