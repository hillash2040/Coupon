using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CouponWebSite.Models;

namespace CouponWebSite.Recommandation_System
{
    interface IRecommandation
    {
        string getType(); //returns the type of the reccomandation (Prefereces, Location etc)
        List<Coupon> findCoupons(); //Invoked when the user presses View Reccomandation.. //Change to Coupon DataType



    }
    
    public class ByLocation : IRecommandation
    {
        double longt, lat;
        public ByLocation(double longt, double lat)
        {
            if (longt == null || lat == null)
            {
                this.longt = 0;
                this.lat = 0;
            }
            else
            {
                this.longt = longt;
                this.lat = lat;
            }
        }

        public  void setLocation(double longt, double lat)
        {
            this.longt = longt;
            this.lat = lat;
        }


        public string getType()
        {
            return "By Location";
        }


        public List<Coupon> findCoupons()
        {
            List<Coupon> ans = new List<Coupon>();

            couponsEntities ce = new couponsEntities();

            List<Coupon> couponList = ce.Coupons.ToList();

            foreach (Coupon c in couponList)
            {           
                    //check distance from user to the coupon business

                    double longDiff = (double)c.Business.Long - longt;
                    double latDiff = (double)c.Business.Lat - lat;
                    double distance = Math.Sqrt(longDiff + latDiff);

                    if (distance < 10) //change 10
                        ans.Add(c);
            }            

            return ans;
        }




    }
     


    public class ByPreference : IRecommandation
    {
        string myPreference;

        

        public ByPreference(string preference)
        {
            myPreference=preference;
        }




        public string getType()
        {
            return "By Preference";
        }



        public List<Coupon> findCoupons()
        {
            List<Coupon> ans = new List<Coupon>();

            couponsEntities ce = new couponsEntities();

            List<Coupon> couponList = ce.Coupons.ToList();

            foreach (Coupon c in couponList)
            {
                if (c.Category.Name.Equals(myPreference))
                    ans.Add(c);
            }        

            return ans;

        
         
        }




    }

    public class ByCombination : IRecommandation
    {
        double longt, lat;

        string myPreference;

        public ByCombination(string preference, double longt, double lat)
        {
            myPreference=preference;
            if (longt == null || lat == null)
            {
                this.longt = 0;
                this.lat = 0;
            }
            else
            {
                this.longt = longt;
                this.lat = lat;
            }
        }

        public void setLocation(double longt, double lat)
        {
            this.longt = longt;
            this.lat = lat;
        }

        public string getType()
        {
            return "By Combination";
        }


        public List<Coupon> findCoupons()
        {
            List<Coupon> ans = new List<Coupon>();

            couponsEntities ce = new couponsEntities();

            List<Coupon> couponList = ce.Coupons.ToList();

            foreach (Coupon c in couponList)
            {
                if (c.Category.Name.Equals(myPreference)) //category match
                {
                    //check distance from user to the coupon business

                    double longDiff = (double)c.Business.Long-longt;
                    double latDiff = (double)c.Business.Lat-lat;
                    double distance = Math.Sqrt(longDiff+latDiff);

                    if (distance<10) //change 10
                        ans.Add(c);                    
                }              
                
            }

            return ans;
        }


    

    }
}
