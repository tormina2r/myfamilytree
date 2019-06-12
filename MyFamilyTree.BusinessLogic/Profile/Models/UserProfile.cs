using MyFamilyTree.Data.UserProfile;

namespace MyFamilyTree.BusinessLogic.Profile.Models
{
    public class UserProfile
    {
        private readonly IUserProfileEntity _Entity;

        public UserProfile(IUserProfileEntity entity)
        {
            _Entity = entity;
        }

        public string EmailAddress { get; }
        public string FamilyName { get; }
    }
}