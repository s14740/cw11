using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Configurations;

namespace cw11.Models
{
    public class PeopleDbContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Studies> Studies { get; set; }

        public PeopleDbContext() { }

        public PeopleDbContext(DbContextOptions options)
        :base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudiesEfConfiguration());

            
        }

    }
}
