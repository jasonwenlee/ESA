using ESA.Models.PageModels;
using ESA.ViewModels.InfoView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ESA.ViewModels
{
    public class InfoViewModel
    {
        int taps = 0;

        public ICommand LoadReferencesCommand { get; private set; }
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });

        public ICommand RefCommand => new Command<object>((s) =>
        {
            taps++;
            Console.WriteLine("Tapped: " + taps + " " + s);
        });

        public InfoViewModel(INavigation navigation)
        {
        }

    }
}

