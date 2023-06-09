using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class UserFactory
    {
        public static User createUser(string name, string email, string gender, string password, int roleid)
        {
            User user = new User();

            user.UserName = name;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserPassword = password;
            user.RoleID = roleid;

            return user;
        }
    }
}