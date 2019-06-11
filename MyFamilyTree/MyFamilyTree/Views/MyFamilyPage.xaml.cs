using MyFamilyTree.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFamilyTree.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFamilyPage : ContentPage
    {
        public MyFamilyPage()
        {
            InitializeComponent();
        }

        public MyFamilyPage(MyFamilyViewModel viewModel)
        : this()
        {
            BindingContext = viewModel;
        }
    }
}