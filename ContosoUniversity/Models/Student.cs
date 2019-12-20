using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(20, ErrorMessage = "The last name must be less than 20 characters"), Required, DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(20, ErrorMessage = "The first name must be less than 20 characters"), Required, DisplayName("First Name")]
        [Column("FirstMidName")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       
        [DisplayName("Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }

        }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}