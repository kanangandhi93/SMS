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
    
    public partial class tblExam
    {
        public long ExamId { get; set; }
        public string ExamName { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<long> StdId { get; set; }
        public Nullable<int> BrId { get; set; }
        public Nullable<long> SchoolId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<long> SubjectId { get; set; }
        public Nullable<long> TermId { get; set; }
    
        public virtual tblBranch tblBranch { get; set; }
        public virtual tblSchool tblSchool { get; set; }
        public virtual tblStd tblStd { get; set; }
        public virtual tblSubject tblSubject { get; set; }
        public virtual tblTerm tblTerm { get; set; }
    }
}
