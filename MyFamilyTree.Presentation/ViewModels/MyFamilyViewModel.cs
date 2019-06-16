using MyFamilyTree.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFamilyTree.ViewModels
{
    public class MyFamilyViewModel
    {
        private readonly INavigationService _NavigationService;

        public MyFamilyViewModel()
        {

        }

        public MyFamilyViewModel(INavigationService navigationService)
        {
            _NavigationService = navigationService;

            NavigateToPersonDetailPage = new Command(NavigateToPersonDetailPageAction);
        }

        private void NavigateToPersonDetailPageAction()
        {
            _NavigationService.PushAsync<PersonDetailPage>();
        }

        public string FamilyName => "Andersen";
        public IList<FamilyMemberViewModel> FamilyMembers => new List<FamilyMemberViewModel>
        {
            new FamilyMemberViewModel{Name = "Lisa", Relation = "Samboer" },
            new FamilyMemberViewModel{Name = "Herman", Relation = "Sønn"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
            new FamilyMemberViewModel{Name = "Hennie", Relation = "Datter"},
        };        

        public ICommand NavigateToPersonDetailPage { get; }
    }

    public class FamilyMemberViewModel
    {
        public string Name { get; set; }
        public string Relation { get; set; }
    }
}