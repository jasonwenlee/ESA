using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ESA.Models.VideoView;
using ESA.ViewModels;

namespace ESA.Views.Desktop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPageDesktop : ContentPage
    {
        // Don't remove :)
        //Procedure holdProcedure;

        // ProcedureViewModel
        ProcedureViewModel procedureViewModel;

        public DetailsPageDesktop(int id)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            // ViewModel
            procedureViewModel = new ProcedureViewModel(id);
            BindingContext = procedureViewModel;

            // View Bindings
            stepsView.procedureViewModel = procedureViewModel;
            keyPointsView.procedureViewModel = procedureViewModel;
            variationsView.procedureViewModel = procedureViewModel;
            complicationsView.procedureViewModel = procedureViewModel;
            infoView.procedureViewModel = procedureViewModel;

            // Don't remove :)
            //holdProcedure = proc;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // VideoPlayer Source files
            ResourceVideoSource source = new ResourceVideoSource();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    source.Path = "Videos/" + procedureViewModel.Procedure.VideoSource;
                    //source.Path = "Videos/Brain_Eyes_Vid.mp4";                    
                    break;
                case Device.Android:
                    source.Path = procedureViewModel.Procedure.VideoSource;
                    //source.Path = "Brain_Eyes_Vid.mp4";
                    break;
                case Device.UWP:
                    source.Path = "Videos/" + procedureViewModel.Procedure.VideoSource;
                    //source.Path = "Videos/Brain_Eyes_Vid.mp4";
                    break;
            }

            videoPlayer.Source = source;
            videoPlayer.Play();
            videoPlayer.Position = procedureViewModel.VideoPosition;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            procedureViewModel.VideoPosition = videoPlayer.Position;
            videoPlayer.Stop();
        }

    }
}