using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceDemo.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; }

        public Category()
        {
            Subcategories = new Collection<Subcategory>();
        }
    }
}
