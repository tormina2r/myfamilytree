using Xamarin.Forms;

namespace MyFamilyTree.Presentation.Views
{
    public interface INavigationService
    {
        void PushAsync<TPage>() where TPage: Page;        
    }
}