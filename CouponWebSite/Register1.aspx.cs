using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.Models;


namespace CouponWebSite
{
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
 
            }
        }

        protected void btnClick_RegisterUser(object sender, EventArgs e)
        {           
            string userName = UserName.Text;
            string email = Email.Text;
            string password = Password.Text;

            User c = new User();            
            c.UserName = userName;
            c.Email = email;
            c.Password = password;

            couponsEntities ce = new couponsEntities();
            List<User> lst = ce.Users.ToList();
            bool found = false;
            foreach (User u in lst)
            {
                if (u.UserName.Equals(userName)) //if the database already have a client with the same userName
                {
                    lbl_userExsits.Text = "UserName Already Exists";
                    lbl_userExsits.Visible = true;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                c.UserType = 2;
                ce.Users.Add(c);
                ce.SaveChanges();
                //Redirect to login Page
                Response.Redirect("Login1.aspx");
            }
        }
    }
}