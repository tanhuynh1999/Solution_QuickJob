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
    
    public partial class ViewCv
    {
        public int view_id { get; set; }
        public Nullable<int> view_view { get; set; }
        public Nullable<int> cv_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<System.DateTime> view_dateupdate { get; set; }
    
        public virtual Cv Cv { get; set; }
        public virtual User User { get; set; }
    }
}
