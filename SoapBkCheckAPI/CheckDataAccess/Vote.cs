//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vote
    {
        public System.Guid VoteId { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public Nullable<System.Guid> ProductId { get; set; }
        public Nullable<int> Value { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}