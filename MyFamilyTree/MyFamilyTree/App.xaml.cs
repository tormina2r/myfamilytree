using Autofac;
using MyFamilyTree.IOC;
using MyFamilyTree.Presentation.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyFamilyTree
{
    public partial class App
    {

        public App()
        {
            InitializeComponent();

            var mainPage = ServiceContainer.Instance.Resolve<MainPage>();

            MainPage = new NavigationPage(mainPage);
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
