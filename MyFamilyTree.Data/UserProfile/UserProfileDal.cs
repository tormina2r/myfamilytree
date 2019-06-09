using System.Collections.Generic;

namespace MyFamilyTree.Data.UserProfile
{
    public class UserProfileDal : IUserProfileDal
    {
        public IEnumerable<UserProfileEntity> GetUserProfiles()
        {
            yield return new UserProfileEntity
            {
                EmailAddress = "thorandre.andersen@gmail.com",
                FamilyName = "Andersen"
            };
        }
    }
}