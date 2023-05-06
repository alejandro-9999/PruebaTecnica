using System;
namespace RESTAPI.Model
{
    public class User
    {
        public string userName { set; get; }
        public string email { set; get; }
        public string password { set; get; }


        public User(string userName, string email, string password)
        {
            this.userName = userName;
            this.email = email;
            this.password = password;
        }
    }
}
