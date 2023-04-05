using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Dashboard_Project.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace blazorTestApp.Server.Controllers
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeachersClasses>().HasKey( x => new {x.TeacherID, x.ClassID });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admins> Admins {get; set;}
        public DbSet<Executives> Executives {get; set;}
        public DbSet<Teachers> Teachers {get; set;}
        public DbSet<CLasses> Classes {get; set;}
        public DbSet<Students> Students {get; set;}
        public DbSet<Subjects> Subjects {get; set;}
        public DbSet<TeachersClasses> TeachersClasses {get; set;}
        public DbSet<Grades> Grades {get; set;}
    }
}