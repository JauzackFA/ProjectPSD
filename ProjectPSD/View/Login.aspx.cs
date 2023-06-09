using ProjectPSD.Controller;
using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProjectPSD.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

            }


        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string pass = passtxt.Text;

            User user = new User();
            user = UserController.LoginUser(name, pass);

            /*
            HttpCookie cookie = new HttpCookie("UserData");

            cookie["UserName"] = user.UserName;
            cookie["UserPass"] = user.UserPassword;
            cookie.Expires = DateTime.Now.AddDays(2);

            Response.Cookies.Add(cookie);

            Session["UserRole"] = user.Role;
            */
            if (!nametxt.Text.Equals("") || !passtxt.Text.Equals(""))
            {
                Response.Redirect("Home.aspx");

                if (user == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}