using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrapShop.Data;
using BrapShop.Data.models;

namespace BrapShop.Shared
{
    public class IndexModel : PageModel
    {
        private readonly BrapShop.Data.AppIdentityDbContext _context;

        public IndexModel(BrapShop.Data.AppIdentityDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
