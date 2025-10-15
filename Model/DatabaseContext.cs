using lab5.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Model
{
    public class DatabaseContext : DbContext 
    { 
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
    {
    }
        public DbSet<Student> Students {  get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

    }
}
