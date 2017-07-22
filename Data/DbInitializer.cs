using ECommerceDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceDemo.Data
{
    public class DbInitializer
    {
        private readonly ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            var categories = new List<Category>
            {
                new Category { Name = "Antyki i Sztuka" },
                new Category { Name = "Gry" },
                new Category { Name = "Instrumenty" }
            };

            foreach (var category in categories)
            {
                if (!_context.Categories.Any(c => c.Name == category.Name ))
                {
                    _context.Categories.Add(category);
                }
            }

            var subcategories = new List<Subcategory>
            {
                new Subcategory { Name = "Antyki", Category = categories.Single( c => c.Name == "Antyki i Sztuka" ) },
                new Subcategory { Name = "Ceramika", Category = categories.Single( c => c.Name == "Antyki i Sztuka" ) },
                new Subcategory { Name = "Oświetlenie", Category = categories.Single( c => c.Name == "Antyki i Sztuka" ) },
                new Subcategory { Name = "Platery, posrebarzane i inne", Category = categories.Single( c => c.Name == "Antyki i Sztuka" ) },

                new Subcategory { Name = "Gadżety", Category = categories.Single( c => c.Name == "Gry" ) },
                new Subcategory { Name = "Gry na konsole", Category = categories.Single( c => c.Name == "Gry" ) },
                new Subcategory { Name = "Towarzyskie", Category = categories.Single( c => c.Name == "Gry" ) },

                new Subcategory { Name = "Gitary i akcesoria", Category = categories.Single( c => c.Name == "Instrumenty" ) },
                new Subcategory { Name = "Dla dzieci", Category = categories.Single( c => c.Name == "Instrumenty" ) },
                new Subcategory { Name = "Hybrydowe", Category = categories.Single( c => c.Name == "Instrumenty" ) },
                new Subcategory { Name = "Procesory, Efekty i preampy", Category = categories.Single( c => c.Name == "Instrumenty" ) },
            };

            foreach (var subcategory in subcategories)
            {
                if (!_context.Subcategories.Any(c => c.Name == subcategory.Name))
                {
                    _context.Subcategories.Add(subcategory);
                }
            }

            _context.SaveChanges();
        }
    }
}
