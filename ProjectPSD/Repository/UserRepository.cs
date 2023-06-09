using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repository
{
    public class UserRepository
    {

        static DatabaseEntities db = new DatabaseEntities();

        public static void createUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User LoginUser(string name, string pass)
        {
            User user = (from u in db.Users where name.Equals(u.UserName) && pass.Equals(u.UserPassword) select u).FirstOrDefault();

            return user;
        }

    }
}