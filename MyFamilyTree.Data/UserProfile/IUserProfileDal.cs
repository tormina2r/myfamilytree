using System.Collections.Generic;

namespace MyFamilyTree.Data.UserProfile
{
    public interface IUserProfileDal
    {
        IEnumerable<UserProfileEntity> GetUserProfiles();
    }
}