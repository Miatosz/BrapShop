using BrapShop.Data.Interfaces;
using BrapShop.Data.models;
using Microsoft.EntityFrameworkCore;

namespace BrapShop.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppIdentityDbContext _dbContext;

        public UserRepository(AppIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ApplicationUser GetUserById(string id)
        {
            return _dbContext.Users.Include(c => c.Cart).FirstOrDefault(x => x.Id == id);
        }
    }
}
