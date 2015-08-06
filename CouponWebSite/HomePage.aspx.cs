using CouponWebSite.Recommandation_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.Models;


namespace CouponWebSite
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            


            
        }

        //Sets User Favorite category
        protected void btn_CategorySelected_Click(object sender, EventArgs e)
        {
            string categoryID = DropDownList1.SelectedValue;
            string categoryName = DropDownList1.SelectedItem.Text;
            //Need to update user cateogry in database



            Session["FavoriteCategory"] = categoryName;

            
            
        }
         


        //Shows all the reccomndation according to the reccomandation system
        protected void btn_ShowRecommandation_Click(object sender, EventArgs e)
        {
            couponsEntities ce = new couponsEntities();
            IRecommandation recSys = (IRecommandation)Session["RecommandationSystem"];
            List<Coupon> recommandedCoupons = recSys.findCoupons();
            MyCoupons.DataSource = recommandedCoupons;
            MyCoupons.DataBind();
            



        }

        //Sets new Reccomandatin Method to the user
        /*
        protected void btn_SetRecommandation_Click(object sender, EventArgs e)
        {
            string longt = userLongitude.Text;
            string lat = userLatitude.Text;
            string rec = CheckBoxList2.SelectedValue;
            switch(rec)
            {
                case "Location":
                    {
                        IRecommandation loc = new ByLocation();
                        
                        Session["RecommandationSystem"] = new ByLocation();

                        break;
                    }

                case "Category":
                    {                        
                        Session["RecommandationSystem"] = new ByPreference((string)Session["FavoriteCategory"]);
                        break;
                    }
                case "Combined":
                    {
                        Session["RecommandationSystem"] = new ByCombination((string)Session["FavoriteCategory"]);
                        break;
                    }
            }


        }
         */

        private void  setReccomndation()
        {
            string longt = userLongitude.Text;
            string lat = userLatitude.Text;
            Session["Lat"] = lat;
            Session["Long"] = longt;
            string rec = CheckBoxList2.SelectedValue;
            switch(rec)
            {
                case "Location":
                    {
                        //IRecommandation loc = new ByLocation(Convert.ToDouble(longt),Convert.ToDouble(lat));

                        Session["RecommandationSystem"] = new ByLocation(Convert.ToDouble(longt), Convert.ToDouble(lat));

                        break;
                    }

                case "Category":
                    {                        
                        Session["RecommandationSystem"] = new ByPreference((string)Session["FavoriteCategory"]);
                        break;
                    }
                case "Combined":
                    {
                        Session["RecommandationSystem"] = new ByCombination((string)Session["FavoriteCategory"], Convert.ToDouble(longt), Convert.ToDouble(lat));
                        break;
                    }
            }


        }

        protected void createSocialCoupon_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateCouponUser.aspx");
        }

        protected void btn_SetRecommandation_Click(object sender, EventArgs e)
        {
            setReccomndation();
        }
    }
}