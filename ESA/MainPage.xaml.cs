using ESA.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ESA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            var source = new HtmlWebViewSource
            {
                BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
                Html = "<html>" +
                        "<body style = 'background: #252020;'>" +
                            "<iframe width = " + (int)Width + " height = " + (int)Height / 2 + " src = 'https://www.youtube.com/embed/crhjjPjzknk?&autoplay=1' frameborder = '0' allow = 'accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></ iframe>" +
                        "</ body>" +
                       "</ html >"
            };

            browser.Source = source;
        }
    }
}