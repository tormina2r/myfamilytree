using Autofac;
using DryIoc;
using MyFamilyTree.IOC2;
using Xamarin.Forms.Xaml;
using MyFamilyTree.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyFamilyTree
{
    public partial class App
    {

        public App()
        {
            InitializeComponent();

            RegisterDependencies();

            //var mainPage = ServiceContainer.Instance.Resolve<MainPage>();
            var container = ServiceContainer.GetInstance(builder => builder.RegisterType<MainPage>());
            var mainPage = container.Resolve<MainPage>();

            MainPage = mainPage;
        }

        private static void RegisterDependencies()
        {
            //ServiceContainer.Instance.Register<MainPage>();
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
