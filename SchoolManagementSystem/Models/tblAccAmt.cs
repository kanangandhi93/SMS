//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAccAmt
    {
        public long AccAmtId { get; set; }
        public Nullable<long> AccTypeId { get; set; }
        public Nullable<long> TermId { get; set; }
        public decimal Amount { get; set; }
        public bool IsSum { get; set; }
        public Nullable<int> BrId { get; set; }
        public Nullable<long> SchoolId { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
        public virtual tblBranch tblBranch { get; set; }
        public virtual tblSchool tblSchool { get; set; }
        public virtual tblTerm tblTerm { get; set; }
    }
}
