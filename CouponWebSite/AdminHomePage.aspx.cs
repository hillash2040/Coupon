using CouponWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.CouponFactory;

namespace CouponWebSite
{
    public partial class AdminHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateCouponAdmin.aspx");
        }
 

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateBusinessAdmin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditCoupon.aspx");
        }





    }
}