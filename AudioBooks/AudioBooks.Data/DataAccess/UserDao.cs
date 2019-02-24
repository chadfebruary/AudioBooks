using AudioBooks.AudioBooksData.Interfaces;
using Dapper;
using System.Linq;

namespace AudioBooks.AudioBooksData.DataAccess
{
    public class UserDao : IUserDao
    {
        public Shared.Models.User GetByUserName(string username)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Username", username);

            return SQLHelper.QuerySP<Shared.Models.User>("", parameters, null, null, true).FirstOrDefault();
        }
    }
}
