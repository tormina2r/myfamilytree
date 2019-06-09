using System;
using System.Collections.Generic;
using System.Linq;
using MyFamilyTree.BusinessLogic.Profile.Models;
using MyFamilyTree.Data.UserProfile;

namespace MyFamilyTree.BusinessLogic.Profile
{
    public interface IUserProfileService
    {
        UserProfile GetCurrentUserProfile();
    }

    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileDataService _UserProfileDataService;

        public UserProfileService(IUserProfileDataService userProfileDataService)
        {
            _UserProfileDataService = userProfileDataService;
        }

        public UserProfile GetCurrentUserProfile() 
            => _UserProfileDataService.GetUserProfiles().FirstOrDefault();
    }

    public interface IUserProfileDataService
    {
        IEnumerable<UserProfile> GetUserProfiles();
    }

    public class UserProfileDataService : IUserProfileDataService
    {
        private readonly IUserProfileDal _Dal;

        public UserProfileDataService(IUserProfileDal dal)
        {
            _Dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }

        public IEnumerable<UserProfile> GetUserProfiles() => _Dal.GetUserProfiles().Select(entity => new UserProfile(entity));
    }
}
