using ESA.Models;
using ESA.UWP.WebView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_UWP))]
namespace ESA.UWP.WebView
{
    public class BaseUrl_UWP : IBaseUrl
    {
        public string Get()
        {
            return "ms-appx-web:///";
        }
    }
}