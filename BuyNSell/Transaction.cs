//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuyNSell
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TID { get; set; }
        public int customer_UID { get; set; }
        public int owner_UID { get; set; }
        public int PID { get; set; }
        public decimal price { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual Property Property { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
