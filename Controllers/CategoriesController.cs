using AutoMapper;
using ECommerceDemo.Controllers.Resources;
using ECommerceDemo.Data;
using ECommerceDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceDemo.Controllers
{
    public class CategoriesController
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoriesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/categories")]
        public async Task<IEnumerable<CategoryResource>> GetCategories()
        {
            var categories = await _context.Categories.Include(c => c.Subcategories).ToListAsync();
            return _mapper.Map<List<Category>,List<CategoryResource>>(categories);
        }
    }
}
