using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceDemo.Models
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? SubCategoryId { get; set; }

        public Subcategory Subcategory { get; set; }
    }
}
