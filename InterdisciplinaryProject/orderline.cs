//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterdisciplinaryProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderline
    {
        public int orderLineID { get; set; }
        public int quantity { get; set; }
        public Nullable<int> lineitemid { get; set; }
        public Nullable<int> reservationid { get; set; }
    
        public virtual lineitem lineitem { get; set; }
        public virtual reservation reservation { get; set; }
    }
}
