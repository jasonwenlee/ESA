using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyPointsView : ContentView
    {

        public ICommand ClickCommand => new Command<string>(OpenBrowser);
       
        public KeyPointsView()
        {
            InitializeComponent();
            BindingContext = this;

        }
        void OpenBrowser(string url)
        {
            Device.OpenUri(new Uri(url));
        }
    }
}