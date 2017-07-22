using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceDemo.Controllers.Resources
{
    public class SubcategoryResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductResource> Products { get; set; }

        public SubcategoryResource()
        {
            Products = new Collection<ProductResource>();
        }
    }
}
