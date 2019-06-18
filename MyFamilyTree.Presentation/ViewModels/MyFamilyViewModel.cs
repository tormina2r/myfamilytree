using MyFamilyTree.Presentation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFamilyTree.ViewModels
{
    public class MyFamilyViewModel: INotifyPropertyChanged
    {
        private readonly INavigationService _NavigationService;
        private FamilyMemberViewModel _SelectedItem;

        public event PropertyChangedEventHandler PropertyChanged;

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

        public FamilyMemberViewModel SelectedItem {
            get
            {
                return _SelectedItem;
            }
            set
            {
                if (value == _SelectedItem)
                    return;

                _SelectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));

                _NavigationService.PushAsync<PersonDetailPage>();
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class FamilyMemberViewModel
    {
        public string Name { get; set; }
        public string Relation { get; set; }
    }
}