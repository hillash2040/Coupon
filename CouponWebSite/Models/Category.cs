//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CouponWebSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Coupons = new HashSet<Coupon>();
            this.Users = new HashSet<User>();
            this.Businesses = new HashSet<Business>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }
    }
}