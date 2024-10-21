namespace Pratik___Survivor.Models
{
    public class Category
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
    }
}
