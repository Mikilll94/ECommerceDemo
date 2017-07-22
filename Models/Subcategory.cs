﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceDemo.Models
{
    [Table("Subcategories")]
    public class Subcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Subcategory()
        {
            Products = new Collection<Product>();
        }
    }
}
