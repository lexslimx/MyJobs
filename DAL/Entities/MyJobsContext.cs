using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace DAL.Entities
{
    public class MyJobsContext : DbContext
    {
        public MyJobsContext(DbContextOptions<MyJobsContext> options) :
            base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}