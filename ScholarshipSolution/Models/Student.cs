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
    using System.ComponentModel;
    using System.Web;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.StudentCourseResults = new HashSet<StudentCourseResult>();
            this.StudentExpertises = new HashSet<StudentExpertise>();
            this.StudentInterests = new HashSet<StudentInterest>();
            this.StudentMessages = new HashSet<StudentMessage>();
            this.StudentResearchPapers = new HashSet<StudentResearchPaper>();
            this.StudentScholarships = new HashSet<StudentScholarship>();
        }
    
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DisplayName("Upload File")]
        public string StudentPicture { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
        public string Department { get; set; }
        public string Session { get; set; }
        public int Year { get; set; }
        public Nullable<int> Semester { get; set; }
        public string Email { get; set; }
        public double AverageGrade { get; set; }
        public double CompletedCredit { get; set; }
        public string ExtracurricularActivities { get; set; }
        public string Blog { get; set; }
        public string Reference { get; set; }
        public byte[] Picture { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentCourseResult> StudentCourseResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentExpertise> StudentExpertises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentInterest> StudentInterests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentMessage> StudentMessages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentResearchPaper> StudentResearchPapers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentScholarship> StudentScholarships { get; set; }
    }
}