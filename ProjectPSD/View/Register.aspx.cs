using ProjectPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegistBtn_Click(object sender, EventArgs e)
        {
            string name = usernametxt.Text;
            string email = emailtxt.Text;
            string gender = gendertxt.Text;
            string pass = passtxt.Text;
            string cpass = conpasstxt.Text;

            Boolean cU = UserController.createUser(name, email, gender, pass, cpass);

            if (cU == true)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Register.aspx");
            }
        }
    }
}