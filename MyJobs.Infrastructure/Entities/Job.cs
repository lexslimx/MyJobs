using System.ComponentModel.DataAnnotations.Schema;

namespace MyJobs.Infrastructure.Entities
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public int Distance { get; set; }

        public virtual Person Person { get; set; }
        public int PersonId { get; set; }
    }
}