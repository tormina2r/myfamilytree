using System.Collections.Generic;
using System.Windows.Input;

namespace MyFamilyTree.ViewModels
{
    public class MyFamilyViewModel
    {
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
    }

    public class FamilyMemberViewModel
    {
        public string Name { get; set; }
        public string Relation { get; set; }
    }
}