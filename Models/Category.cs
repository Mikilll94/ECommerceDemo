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

        public ICollection<Product> Products { get; set; }
        public ICollection<Subcategory> Subcategories { get; set; }

        public Category()
        {
            Products = new Collection<Product>();
            Subcategories = new Collection<Subcategory>();
        }
    }
}
