using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAPI.Services
{
    public static class UserService
    {
        public static User GetUserLogin(string UserName, string Password)
        {
            User UserResult = Statics.Statics.Users.FirstOrDefault(User =>
                User.UserName.Equals(UserName) &&
                User.Password.Equals(Password));

            return UserResult;
        }

        public static User GetUserById(string UserName)
        {
            User UserResult = Statics.Statics.Users.FirstOrDefault(User =>
                User.UserName.Equals(UserName));

            return UserResult;
        }
    }

}