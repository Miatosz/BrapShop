using BrapShop.Data.models;

namespace BrapShop.Data.Services
{
    public class ProductService
    {
        private readonly AppIdentityDbContext _dbContext;

        public ProductService(AppIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public List<Product> GetProductsByCategory(Guid ProductCategoryID)
            => _dbContext.Products.Where(x => x.SubCategory.ID == ProductCategoryID).ToList();
        
        public Product? GetProductByID(Guid id)
            => _dbContext.Products.Find(id);

        public List<Product> GetLatestProducts()
            => _dbContext.Products.OrderByDescending(x => x.DateAdded).Take(3).ToList();

        public List<Product> GetBestSellers()
            => _dbContext.Products.OrderByDescending(x => x.AlreadySold).Take(3).ToList();

    }
}
