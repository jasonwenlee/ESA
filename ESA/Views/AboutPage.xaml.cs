using ESA.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        MainViewModel mainViewModel;
        public AboutPage(MainViewModel mvm)
        {
            InitializeComponent();
            mainViewModel = mvm;
            BindingContext = mainViewModel;
            ListViewAbout.ItemsSource = mainViewModel.People;
        }
    }
}