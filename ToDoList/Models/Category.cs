using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryItem> Items { get; set; }

        public Category()
        {
            this.Items = new HashSet<CategoryItem>();
        }
    }
}