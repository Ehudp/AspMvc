using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentsApplication.Models
{
    public class StudentsDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}