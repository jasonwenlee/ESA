using ESA.ViewModels;

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