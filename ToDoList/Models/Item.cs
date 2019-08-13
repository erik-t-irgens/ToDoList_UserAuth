using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ToDoList.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public DateTime Deadline { get; set; }

        public ICollection<CategoryItem> Categories { get; }

        public virtual ApplicationUser User { get; set; }

        public Item()
        {
            this.Categories = new HashSet<CategoryItem>();
            this.Completed = false;
        }
    }
}