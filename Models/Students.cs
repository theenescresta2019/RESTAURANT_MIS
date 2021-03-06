//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RESTAURANT_MIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students()
        {
            this.Notices = new HashSet<Notices>();
        }
    
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SubjectId { get; set; }
        public string Email { get; set; }
        public int SectionId { get; set; }
        public int SemesterId { get; set; }
        public int CourseId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }
    
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notices> Notices { get; set; }
        public virtual Section Section { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}
