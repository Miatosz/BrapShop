using BrapShop.Data.models;
using Microsoft.EntityFrameworkCore;

namespace BrapShop.Data.Services
{
    public class CategoryService
    {
        private readonly AppIdentityDbContext _dbContext;

        public CategoryService(AppIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Category> GetCategories()
            => _dbContext.Categories.Include(x => x.SubCategory).ToList();
    }
}
