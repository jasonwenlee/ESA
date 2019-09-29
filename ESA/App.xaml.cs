using ESA.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    public partial class App : Application
    {
        // Initialises the database for video and procedures. 
        private static string videoDB { get; } = "videoDB.sqlite";
        private static string procedureDB { get; } = "procedureDB.sqlite";
        static VideoRepository vidDataBase;
        static ProcedureRepository procDataBase;
        public static IVideoRepository VideoDatabase
        {
            get
            {
                if (vidDataBase == null)
                {
                    vidDataBase = new VideoRepository(videoDB);
                }
                return vidDataBase;
            }
        }
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
            MainPage = new NavigationPage(new CreateProcedure());
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
