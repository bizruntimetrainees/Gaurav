using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_CodeFirstModel.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("gaurav")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}