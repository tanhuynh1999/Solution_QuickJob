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
    
    public partial class Bill
    {
        public int bill_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<System.DateTime> bill_datecreate { get; set; }
        public Nullable<int> bill_sum { get; set; }
        public Nullable<bool> bill_active { get; set; }
        public Nullable<System.DateTime> bill_dealine { get; set; }
        public Nullable<int> pakege_id { get; set; }
        public string bill_key { get; set; }
        public string bill_orderid { get; set; }
    
        public virtual Pakage Pakage { get; set; }
        public virtual User User { get; set; }
    }
}
