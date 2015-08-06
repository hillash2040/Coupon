using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.Models;

namespace CouponWebSite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Check For Cookies:
            HttpCookieCollection cookieCollection = Request.Cookies;

            HttpCookie cookie = cookieCollection["CouponCookie"];

            if (cookie != null)
            {
                string uName = cookie["UserName"];
                string lastEntered = cookie["LastEntered"];
                string uType = cookie["UserType"];
                if (uName != null)
                {
                    Session["CurrentUserName"] = uName;
                    Session["LastEntered"] = lastEntered;
                    Session["CurrentUserType"] = uType;
                    cookie["LastEntered"] = DateTime.Now.ToString();
                    Response.Cookies.Add(cookie);
                    if (uType.Equals("1")) //Admin
                        Response.Redirect("~/AdminHomePage.aspx");
                    else if (uType.Equals("3")) //Business Manager
                        Response.Redirect("~/BusinessManagerHomePage.aspx");
                    else 
                        Response.Redirect("HomePage.aspx");
                }      



            }
            else //No Such Cookie. Guests area
            {

                //Populate the GridView:
                couponsEntities bse = new couponsEntities();
                List<Coupon> lst = bse.Coupons.ToList();
                List<Coupon> lst_newCoupons = new List<Coupon>();
                foreach (Coupon c in lst)
                {
                    string cName = c.Name;
                    double price = c.DiscountPrice;

                    if (price < 100) //add to cheap list
                    {
                        lst_newCoupons.Add(c);
                    }
                }

                NewBooks.DataSource = lst_newCoupons;

                NewBooks.AutoGenerateColumns = false;
                NewBooks.DataBind();


            }


        }
    }
}