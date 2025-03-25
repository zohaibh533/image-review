using System;

namespace ImageReview.Logic
{
    public class SystemUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }


        public SystemUser()
        {
            ID = 0;
            UserType = UserName = Password = "";
        }

        public SystemUser(int id, string userName, string userType, string password)
        {
            ID = id;
            UserName = userName;
            Password = password;
            UserType = userType;
        }
    }
}
