using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.Models;

namespace CouponWebSite
{
    public partial class EditBusinesses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CurrentUserType"].Equals("3")) //BusinessManager
            {
                string bm_Id = (string)Session["CurrentUserName"];
                SqlDataSource1.SelectCommand += "Where BusinessManager=" + bm_Id;
            }
        }

        protected void submit_edit_Click(object sender, EventArgs e)
        {
            couponsEntities ce = new couponsEntities();
            Business b = ce.Businesses.Find(Int32.Parse(Label6.Text.Substring(3)));
            b.Name = txt_Name.Text;
            b.Description = txt_Description.Text;
            b.Address = txt_Address.Text;
            b.City = txt_City.Text;
            editBusinessDiv.Visible = false;
            ce.Entry(b).State = System.Data.Entity.EntityState.Modified; //check!!!!
            ce.SaveChanges();

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
                editBusiness(id);
            }
        }

        private void editBusiness(int businessID)
        {
            couponsEntities ce = new couponsEntities();
            Business b = ce.Businesses.Find(businessID);
            txt_Name.Text = b.Name;
            txt_Address.Text = b.Address;
            txt_City.Text = b.City;
            txt_Description.Text = b.Description;
            editBusinessDiv.Visible = true;

        }
    }
}