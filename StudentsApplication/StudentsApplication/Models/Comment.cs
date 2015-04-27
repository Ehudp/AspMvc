using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsApplication.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
           [Display(Name = "Student")]
        public int StudentId { get; set; }
        
    [Display(Name="Comment")]
    [StringLength(255,MinimumLength=10)]
        public string Body { get; set; }

        public virtual Student Student { get; set; }
    }
}   