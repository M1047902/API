//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class BestOftheHotel
    {
        public int ID { get; set; }
        public int HotelID { get; set; }
        public int MenuItemID { get; set; }
        public int NoofSuggenstions { get; set; }
    
        public virtual MenuItem MenuItem { get; set; }
    }
}
