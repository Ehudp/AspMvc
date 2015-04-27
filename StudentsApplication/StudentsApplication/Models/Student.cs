using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsApplication.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Address")]        
        public string Address { get; set; }
        [Display(Name="Age")]
        [Range(10,80)]
        public int Age { get; set; }
        [Display(Name = "Start Learen")]
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}