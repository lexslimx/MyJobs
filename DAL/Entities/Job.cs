using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }

        public virtual Person Person { get; set; }
        public int PersonId { get; set; }
    }
}