//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int rating_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> idem { get; set; }
        public Nullable<System.DateTime> rating_datecreate { get; set; }
        public Nullable<int> rating_sum { get; set; }
        public string rating_title { get; set; }
        public string rating_like { get; set; }
        public string rating_improve { get; set; }
        public Nullable<int> rating_ltpl { get; set; }
        public Nullable<int> rating_dthh { get; set; }
        public Nullable<int> rating_sqtdnv { get; set; }
        public Nullable<int> rating_vhct { get; set; }
        public Nullable<int> rating_vplv { get; set; }
        public Nullable<bool> rating_intro { get; set; }
        public Nullable<bool> rating_level { get; set; }
        public string rating_satisfied { get; set; }
        public string rating_unsatisfied { get; set; }
    
        public virtual User User { get; set; }
    }
}
