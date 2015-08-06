using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.Models;

namespace CouponWebSite
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_logIn_Click(object sender, EventArgs e)
        {
            string user = UserName.Text;
            string pass = Password.Text;
            //Regular Way:

            couponsEntities ce = new couponsEntities();
            List<User> lst = ce.Users.ToList();
            foreach (User c in lst)
            {
                if (c.UserName.Equals(user))
                {
                    if (c.Password.Equals(pass))
                    {

                        HttpCookie cookie = Request.Cookies["CouponCookie"];
                        if (cookie == null)
                        {
                            cookie = new HttpCookie("CouponCookie");
                            cookie.Expires = DateTime.Now.AddYears(3);
                            cookie.Values.Add("UserName", c.UserName);
                            cookie.Values.Add("LastEntered", DateTime.Now.ToString());
                            cookie.Values.Add("UserType", c.UserType.ToString());
                        }
                        else
                        {
                            cookie["UserName"] = c.UserName;
                            cookie["LastEntered"] = DateTime.Now.ToString();
                            cookie["UserType"] = c.UserType.ToString();
                        }
                        Response.Cookies.Add(cookie);

                        //Set Session Current User
                        Session["CurrentUserName"] = user;
                        Session["LastEntered"] = DateTime.Now.ToString();
                        Session["CurrentUserType"] = c.UserType.ToString();

                        //Check If admin

                        if ((int)c.UserType == 1)//Move to Admin HomePage
                        {
                            Response.Redirect("~/AdminHomePage.aspx");
                        }
                        else if ((int)c.UserType == 3) // business manager
                        {
                            Response.Redirect("~/BusinessManagerHomePage.aspx");
                        }
                        else //Regular User
                        {
                            string to = "HomePage.aspx?userName=" + user;
                            Response.Redirect(to);
                        }
                    }
                }
            }

            //UserName or password Incorrect
            lbl_wrongDetails.Text = "Username or password incorrect";
            lbl_wrongDetails.Visible = true;
        }

    }
}