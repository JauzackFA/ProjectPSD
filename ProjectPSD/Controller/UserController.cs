using ProjectPSD.Handler;
using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controller
{
    public class UserController
    {
        public static Boolean createUser(string name, string email, string gender, string pass, string conpass)
        {

           if (name.Equals("") || email.Equals("") || gender.Equals("") || pass.Equals("") || conpass.Equals(""))
            {
                return false;
            }
            else if (!(name.Length > 5 && name.Length < 15))
            {
                return false;
            }
            else if (!email.Contains(".com"))
            {
                return false;
            }
            else if (!(gender.Equals("Male") || gender.Equals("Female")))
            {
                return false;
            }
            else if (!pass.Equals(conpass))
            {
                return false;
            }

            UserHandler.createUser(name, email, gender, pass);
            return true;
        }


        public static User LoginUser(string name, string pass)
        {
            User user = new User();

            // Validation
            if (name.Equals("") && pass.Equals(""))
            {
                return user;
            } 
            else if (name.Equals(""))
            {
                return user;
            }
            else if (pass.Equals(""))
            {
                return user;
            }
            else
            {
                return UserHandler.LoginUser(name, pass);
            }
        }
    }
}