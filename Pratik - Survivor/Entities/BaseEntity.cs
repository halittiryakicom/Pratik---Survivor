﻿namespace Pratik___Survivor.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
