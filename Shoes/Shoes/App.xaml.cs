using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Shoes
{
    public partial class App : Application
    {
        public static double ScreenWidth { get; set; }
        public static double ScreenHeight { get; set; }
        public App()
        {
            InitializeComponent();
            var nav = new NavigationPage(new MainPage());
            nav.BarTextColor = Color.White;
            MainPage = nav;
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
