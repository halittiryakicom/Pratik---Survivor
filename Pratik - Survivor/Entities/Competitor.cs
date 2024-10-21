using System.ComponentModel.DataAnnotations.Schema;

namespace Pratik___Survivor.Models
{
    public class Competitor:BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
