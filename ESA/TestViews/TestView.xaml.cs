using ESA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.TestViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestView : TemplatedView
    {
        public TestView()
        {
            InitializeComponent();
            BindingContext = new AddProcedureViewModel(Navigation);
        }
    }
}