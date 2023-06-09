using ProjectPSD.Factory;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handler
{
    public class UserHandler
    {

        public static void createUser(string name, string email, string gender, string pass)
        {
            int rolemember = 3;
            User user = UserFactory.createUser(name, email, gender, pass, rolemember);

            UserRepository.createUser(user);
        }

        public static User LoginUser(string name, string pass)
        {

            return UserRepository.LoginUser(name, pass);
        }

    }
}