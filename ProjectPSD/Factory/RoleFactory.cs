using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class RoleFactory
    {
        public static Role createRole(string name)
        {
            Role role = new Role();
            role.RoleName = name;

            return role;
        }
    }
}