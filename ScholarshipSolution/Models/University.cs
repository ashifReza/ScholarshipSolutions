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

    public partial class University
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public University()
        {
            this.Professors = new HashSet<Professor>();
            this.Scholarships = new HashSet<Scholarship>();
        }
    
        public int UniID { get; set; }
        public string UniName { get; set; }
        public Nullable<double> UniRating { get; set; }
        [DisplayName("Upload File")]
        public string UniPicture { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Professor> Professors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scholarship> Scholarships { get; set; }
    }
}
