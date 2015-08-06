using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.Models;
using CouponWebSite.CouponFactory;
namespace CouponWebSite
{
    public partial class CreateCouponAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"].Equals("3"))
            {
                SqlDataSource1.SelectCommand +="Where BusinessManager="+Session["CurrentUserName"];
               // business_dropDownList.Visible = false;
            }
        }

        protected void createCoupon_Click(object sender, EventArgs e)
        {
            //Create Coupon according to its type
            Coupon newCoupon;
            CouponFactory.CouponFactory cf = new CouponFactory.CouponFactory();
            string type = couponType_dropDownList.SelectedValue;
            if (type.Equals("Social Network"))
                newCoupon = cf.makeNewCoupon(type);
            else
                newCoupon = cf.makeNewCoupon("Regular");

            //Retreive other information and save it in the database

            //From Hilla
            int disPrice = Int32.Parse(dis_price.Text);
            newCoupon.DiscountPrice = disPrice;
            int orgPrice = Int32.Parse(org_price.Text);
            newCoupon.OriginalPrice = orgPrice;
            string desc = description.Text;
            newCoupon.Description = desc;
            //category
            int categoryid = Int32.Parse(category_dropDownList.SelectedValue);
            newCoupon.CategoryID = categoryid;
            string name = name_txt.Text;
            newCoupon.Name = name;
            int busID = Int32.Parse(business_dropDownList.SelectedValue);
            DateTime lastUse = DateTime.Parse(last_Use.Text);
            newCoupon.LastUseDate = lastUse;
            couponsEntities ce = new couponsEntities();
            newCoupon.BusinessID = busID;
            ce.Coupons.Add(newCoupon);
            ce.SaveChanges();
            
        }
    }
}