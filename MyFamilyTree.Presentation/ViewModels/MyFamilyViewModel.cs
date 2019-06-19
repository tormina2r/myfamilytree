using MyFamilyTree.Presentation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFamilyTree.ViewModels
{
    public class MyFamilyViewModel : INotifyPropertyChanged
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
            new FamilyMemberViewModel{Name = "Lisa Pettersen", Relation = "Partner", Image="lisa" },
            new FamilyMemberViewModel{Name = "Herman Andersen", Relation = "Son"},
            new FamilyMemberViewModel{Name = "Hennie Andersen", Relation = "Daughter"},
            new FamilyMemberViewModel{Name = "Gunn Andersen", Relation = "Mother", Image="mamma"},
            new FamilyMemberViewModel{Name = "Tor Øystein Aas Andersen", Relation = "Father", Image="pappa"},
            new FamilyMemberViewModel{Name = "Rikke Søfteland (født Andersen)", Relation = "Sister", Image="rikke"},
        };

        public ICommand NavigateToPersonDetailPage { get; }

        public FamilyMemberViewModel SelectedItem
        {
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
        public string Image { get; set; }
    }
}