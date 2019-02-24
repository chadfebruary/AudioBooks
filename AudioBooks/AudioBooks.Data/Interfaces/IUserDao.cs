using System;
using System.Collections.Generic;

namespace AudioBooks.AudioBooksData.Interfaces
{
    public interface IUserDao
    {
        //Shared.Models.SearchResults<Shared.Models.User> FindBy(string searchCriteria, int displayStart, int recordsPerPage, int orderField, string sortDir);
        Shared.Models.User GetByUserName(string Username);
        //Shared.Models.User GetByEmailAddress(string emailAddress);
        //void UpdateUserLastActivity(string emailAddress);
        //Shared.Models.Response SetUserPassword(string UserName, string oldPassword, string newPassword);
        //Shared.Models.Response CreateUserAndAccount(Shared.Models.User value);
        //Shared.Models.Response ResetUserPassword(string UserName, string Password);

        //string Delete(string Username);

        //void UpdateUserFailedPasswordAttempt(string UserName);

        //string Approve(string UserName);

        //bool GetSubscribtionStatus(string Subscription, Guid UserId);
        //Shared.Models.Response SetSubscription(string Subscription, bool Subscribe, Guid UserId);
        //List<string> GetAllEmailsBySubscribtion(string Subscription);
    }
}
