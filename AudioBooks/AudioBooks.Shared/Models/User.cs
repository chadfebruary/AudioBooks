using System;
using System.Collections.Generic;

namespace AudioBooks.Shared.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public List<string> Roles { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsApproved { get; set; }
        public int FailedPasswordAttemtCount { get; set; }
        public string ECMUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public bool RememberMe { get; set; }
    }
}
