﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelRatingAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelRatingEntities : DbContext
    {
        public HotelRatingEntities()
            : base("name=HotelRatingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BestOftheHotel> BestOftheHotels { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<HotelRating> HotelRatings { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
    }
}
