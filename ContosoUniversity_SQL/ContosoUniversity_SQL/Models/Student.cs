using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        //public int ID { get; set; }

        //[Required]
        //[StringLength(50, MinimumLength = 2)]
        //public string? LastName { get; set; }
        //[StringLength(50)]
        //public string? FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get
        //    {
        //        return LastName + ", " + FirstMidName;
        //    }
        //}
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}