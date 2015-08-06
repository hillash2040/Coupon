using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouponWebSite
{
    public partial class BusinessManagerHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //present all of his businesses and 
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateCouponAdmin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateBusinessAdmin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditCoupon.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditBusinesses.aspx");
        }
    }
}