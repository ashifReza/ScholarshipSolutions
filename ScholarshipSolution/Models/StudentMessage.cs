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
    
    public partial class StudentMessage
    {
        public int MessageId { get; set; }
        public int StudentId { get; set; }
        public string TextMessage { get; set; }
        public int ProfId { get; set; }
    
        public virtual Professor Professor { get; set; }
        public virtual Student Student { get; set; }
    }
}
