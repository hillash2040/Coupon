using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.CouponFactory;
using CouponWebSite.Models;

namespace CouponWebSite
{
    public partial class CreateCouponUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_coupon_Click(object sender, EventArgs e)
        {
            CouponFactory.CouponFactory cf = new CouponFactory.CouponFactory();
            Coupon newCoupon = cf.makeNewCoupon("Social Network");
            //retrieve all data and save to database


        }
    }
}