using Autofac;
using MyFamilyTree.Presentation.Views;
using Xamarin.Forms;

namespace MyFamilyTree.IOC
{
    public class NavigationService : INavigationService
    {
        public void PushAsync<TPage>()
            where TPage: Page
        {
            var instance = ServiceContainer.Instance.Resolve<TPage>();

            var navigationPage = Application.Current.MainPage as NavigationPage;
            if (navigationPage != null)
                navigationPage.Navigation.PushAsync(instance);
            else
                Application.Current.MainPage = new NavigationPage(instance);
        }
    }
}