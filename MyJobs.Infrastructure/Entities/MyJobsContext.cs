using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using System.Linq;

namespace MyJobs.Infrastructure.Entities
{
    public class MyJobsContext : DbContext
    {
        public MyJobsContext(DbContextOptions<MyJobsContext> options) :
            base(options)
        {
            //if(Database.GetPendingMigrations().ToList().Count > 0){
            //    Database.Migrate();
            //}
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}