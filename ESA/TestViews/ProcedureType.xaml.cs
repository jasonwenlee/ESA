using ESA.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProcedureType : ContentPage
    {
        public ProcedureType()
        {
            InitializeComponent();
            BindingContext = new AddProcedureViewModel(Navigation);
        }
    }
}