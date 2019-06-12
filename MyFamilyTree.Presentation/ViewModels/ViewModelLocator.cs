namespace MyFamilyTree.ViewModels
{
    public static class ViewModelLocator
    {
        private static MyFamilyViewModel _myFamilyViewModel;

        public static MyFamilyViewModel MyFamilyViewModel 
            => _myFamilyViewModel ?? (_myFamilyViewModel = new MyFamilyViewModel());
    }
}
