using MyFamilyTree.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFamilyTree.Presentation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyFamilyPage : ContentPage
	{
		public MyFamilyPage (MyFamilyViewModel viewModel)
		{
			InitializeComponent ();

            BindingContext = viewModel;
		}        
    }
}