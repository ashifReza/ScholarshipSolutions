//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScholarshipSolution.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentResearchPaper
    {
        public int DOI { get; set; }
        public string Title { get; set; }
        public Nullable<int> StudentID { get; set; }
        public int PageNO { get; set; }
        public string Volume { get; set; }
        public System.DateTime PublicationDate { get; set; }
        public string Publisher { get; set; }
        public Nullable<int> Citation { get; set; }
        public string Link { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
