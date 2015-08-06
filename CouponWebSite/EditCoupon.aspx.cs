using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.Models;


namespace CouponWebSite
{
    public partial class EditCoupon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string uType = (string)Session["CurrentUserType"];
                if (uType.Equals("3")) //BusinessManager
                {
                    string bm_Id = (string)Session["CurrentUserName"];
                    //int i = 34;
                    //char c = (char)i;
                    string command = @"SELECT Coupon.ID, Coupon.Name, Coupon.Description, Coupon.LastUseDate, Coupon.DiscountPrice FROM Business INNER JOIN Coupon ON Business.ID = Coupon.BusinessID Where Business.BusinessManager=" + "'" + bm_Id + "'";
                    SqlDataSource1.SelectCommand = command;
                }
            }
 
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                //gets the index of the row
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                TableCell cell = selectedRow.Cells[0]; //CouponID
                int id = Convert.ToInt32(cell.Text);
                editCoupon(id);
               // Session["EditedCouponId"] = id;
            }
            /*
        else if (e.CommandName=="Delete")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedRow = GridView1.Rows[index];
            TableCell cell = selectedRow.Cells[0]; //CouponID
            int id = Convert.ToInt32(cell.Text);
            couponsEntities ce = new couponsEntities();
            ce.Coupons.Remove(ce.Coupons.Find(id));
                
        }
             */
        }


        private void editCoupon(int couponID)
        {
            couponsEntities ce = new couponsEntities();
            Coupon c = ce.Coupons.Find(couponID);
            txt_Name.Text = c.Name;
            txt_Type.Text = Convert.ToString(c.Type);
            txt_OriginalPrice.Text = Convert.ToString(c.OriginalPrice);
            txt_DiscountPrice.Text = Convert.ToString(c.DiscountPrice);
            txt_Description.Text = c.Description;
            Label8.Text += couponID;
            editCouponDiv.Visible = true;
            
        }

        protected void submit_edit_Click(object sender, EventArgs e)
        {
            couponsEntities ce = new couponsEntities();
            Coupon c = ce.Coupons.Find(Int32.Parse(Label8.Text.Substring(3)));
            c.Name = txt_Name.Text;
            c.Type = Convert.ToInt32(txt_Type.Text);
            c.OriginalPrice = Convert.ToInt32(txt_OriginalPrice.Text);
            c.DiscountPrice = Convert.ToInt32(txt_DiscountPrice.Text);
            c.Description = txt_Description.Text;
            editCouponDiv.Visible = false;
            ce.Entry(c).State = System.Data.Entity.EntityState.Modified; //check!!!!
            ce.SaveChanges();

        }


    }
}