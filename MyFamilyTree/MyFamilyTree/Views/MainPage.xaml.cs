using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFamilyTree.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage(MyFamilyPage myFamilyPage, SearchPage searchPage, ProfilePage profilePage)
        {
            InitializeComponent();

            Children.Add(myFamilyPage);
            Children.Add(searchPage);
            Children.Add(profilePage);
        }
    }
}