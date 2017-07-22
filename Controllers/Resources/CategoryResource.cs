using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ECommerceDemo.Controllers.Resources
{
    public class CategoryResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductResource> Products { get; set; }
        public ICollection<SubcategoryResource> Subcategories { get; set; }

        public CategoryResource()
        {
            Products = new Collection<ProductResource>();
            Subcategories = new Collection<SubcategoryResource>();
        }
    }
}
