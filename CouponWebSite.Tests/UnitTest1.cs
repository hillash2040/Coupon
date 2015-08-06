using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CouponWebSite.Recommandation_System;
using CouponWebSite.CouponFactory;
using CouponWebSite.Models;
using System.Collections.Generic;
using System.Linq;

namespace CouponWebSite.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckRecByPreference()
        {
           couponsEntities ce = new couponsEntities();

            List<Coupon> lst;
            ByPreference bl= new ByPreference("Shopping");
            lst = bl.findCoupons();
            List<Coupon> compareList = ce.Coupons.ToList();
            foreach(Coupon c in compareList)
            {
                if (!c.Category.Name.Equals("Shopping"))
                {
                    compareList.Remove(c);
                }
            }

            int a = 3;
            
            
            Assert.IsTrue(compareList.Count == lst.Count);
            
            
        }

        [TestMethod]
        public void CheckRecByLocation()
        {
            couponsEntities ce = new couponsEntities();
            List<Coupon> lst = new List<Coupon>();
            ByPreference bl = new ByPreference("Shopping");
            lst = bl.findCoupons();
            List<Coupon> compareList = ce.Coupons.ToList();
            foreach (Coupon c in compareList)
            {
                if (!c.Category.Name.Equals("Shopping"))
                {
                    compareList.Remove(c);
                }
            }


            Assert.IsTrue(compareList.Count == lst.Count); //check
        }

        [TestMethod]
        public void CheckRecByCombination()
        {
            couponsEntities ce = new couponsEntities();
            List<Coupon> lst = new List<Coupon>();
            ByPreference bl = new ByPreference("Shopping");
            lst = bl.findCoupons();
            List<Coupon> compareList = ce.Coupons.ToList();
            foreach (Coupon c in compareList)
            {
                if (!c.Category.Name.Equals("Shopping"))
                {
                    compareList.Remove(c);
                }
            }


            Assert.IsTrue(compareList.Count == lst.Count);

        }
        [TestMethod]
        public void CreateSocialNetworkCoupon()
        {
            CouponFactory.CouponFactory cf = new CouponFactory.CouponFactory();
            Coupon sn = cf.makeNewCoupon("Social Network");
            Assert.IsNotNull(sn);
            
        }


        [TestMethod]
        public void CreateRegularCoupon()
        {
            CouponFactory.CouponFactory cf = new CouponFactory.CouponFactory();
            Coupon sn = cf.makeNewCoupon("Regular");
            Assert.IsNotNull(sn);
        }
    }
}
