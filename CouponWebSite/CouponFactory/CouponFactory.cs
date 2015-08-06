using CouponWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouponWebSite.CouponFactory
{
    public class CouponFactory
    {
        //A Factory Pattren for creating customized coupons like regular coupons and social network coupons

        public Coupon makeNewCoupon(string CouponType)
        {

            //Coupon newCoupon = null;

            if (CouponType.Equals("Regular")) //regular
            {

                
                return new RegularCoupon();

            }
            else

                if (CouponType.Equals("Social Network")) //Social Network
                {

                    
                    return new SocialNetworkCoupon();

                }

                else return null;

        }

    }
}