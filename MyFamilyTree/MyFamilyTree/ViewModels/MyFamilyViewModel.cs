using System.Collections.Generic;

namespace MyFamilyTree.ViewModels
{
    public class MyFamilyViewModel
    {
        public string FamilyName => "Andersen";
        public IList<FamilyMemberViewModel> FamilyMembers => new List<FamilyMemberViewModel>
        {
            new FamilyMemberViewModel("Lisa"),
            new FamilyMemberViewModel("Herman"),
            new FamilyMemberViewModel("Hennie"),
        };
    }

    public class FamilyMemberViewModel
    {
        public FamilyMemberViewModel(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}