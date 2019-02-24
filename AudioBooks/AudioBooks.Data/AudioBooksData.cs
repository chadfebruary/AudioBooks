using AudioBooks.AudioBooksData.Interfaces;
using System;
using System.Web.Configuration;

namespace AudioBooks.Data
{
    public static class AudioBooksData
    {
        private enum UpdateStatus { Unknown, Updating, Updated, Error }
        private static UpdateStatus updateStatus = UpdateStatus.Unknown;
        private static object __locker = new object();
        //private static string entityFrameworkConnection;
        private static string directSqlConnection;

        static AudioBooksData()
        {
            if (updateStatus == UpdateStatus.Unknown)
            {
                lock (__locker)
                {
                    try
                    {
                        updateStatus = UpdateStatus.Updating;
                        string conAB = "";

                        System.Configuration.Configuration config = WebConfigurationManager.OpenWebConfiguration(null) as System.Configuration.Configuration;
                        directSqlConnection = config.ConnectionStrings.ConnectionStrings[conAB].ToString();

                        //entityFrameworkConnection =
                        //    string.Format(
                        //        "metadata=res://*/ACMModel.csdl|res://*/ACMModel.ssdl|res://*/ACMModel.msl;provider=System.Data.SqlClient;provider connection string=\"{0}\"",
                        //        directSqlConnection);

                        //DatabaseUpdater updater = new DatabaseUpdater(directSqlConnection);
                        //updateStatus = updater.ExecuteUpdates() ? UpdateStatus.Updated : UpdateStatus.Error;

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        private static IUserDao userDao;
        public static IUserDao UserDao
        {
            get
            {
                if (userDao == null)
                    userDao = new AudioBooks.AudioBooksData.DataAccess.UserDao();

                return userDao;
            }
        }
    }
}
