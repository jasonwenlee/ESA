using ESA.Data;
using ESA.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    public partial class App : Application
    {
        public AddProcedureViewModel AddProcVM = new AddProcedureViewModel();
        // Initialises the database for video and procedures. 
        private static string procedureDB { get; } = "procedureDB.sqlite";
        static ProcedureRepository procDataBase;
        public static IProcedureRepository ProcedureDatabase
        {
            get
            {
                if (procDataBase == null)
                {
                    procDataBase = new ProcedureRepository(procedureDB);
                }
                return procDataBase;
            }
        }

        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            MainPage = new NavigationPage(new SplashPage()); // REC: Using the SplashPage.cs as the initial page.
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
