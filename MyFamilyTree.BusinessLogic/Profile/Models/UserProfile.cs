using MyFamilyTree.Data.UserProfile;

namespace MyFamilyTree.BusinessLogic.Profile.Models
{
    public class UserProfile
    {
        private readonly UserProfileEntity _Entity;

        public UserProfile(UserProfileEntity entity)
        {
            _Entity = entity;
        }

        public string EmailAddress { get; }
        public string FamilyName { get; }
    }
}