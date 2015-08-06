using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CouponWebSite.Models;

namespace CouponWebSite
{
    public partial class CreateBusinessAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            Business b = new Business();
            b.Name = txt_name.Text;
            b.Address = txt_Address.Text;
            b.City = txt_city.Text;
            b.Description = txt_description.Text;
            b.Long = Convert.ToDouble(txt_long.Text);
            b.Lat = Convert.ToDouble(txt_Lat.Text);

            couponsEntities ce = new couponsEntities();
            ce.Businesses.Add(b);



        }
    }
}