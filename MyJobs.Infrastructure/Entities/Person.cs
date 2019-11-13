using System.Collections.Generic;

namespace MyJobs.Infrastructure.Entities
{
    public class Person
    {
        public Person()
        {
            Jobs = new HashSet<Job>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}