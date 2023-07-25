using BrapShop.Data.Interfaces;
using BrapShop.Data.models;
using Microsoft.EntityFrameworkCore;

namespace BrapShop.Data.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly AppIdentityDbContext _dbContext;

        public CartRepository(AppIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCartItemToCart(CartItem cartItem, string cartId)
        {
            var cart = _dbContext.Carts.First(c => c.ID.ToString() == cartId);
            if (cart.CartItems.Any(c => c.ProductId == cartItem.ProductId))
            {
                //cart.CartItems.Find(c => c.ItemId == cartItem.ItemId).Quantity += 1;
                cart.CartItems.First(c => c.ProductId == cartItem.ProductId).Quantity += 1;
                _dbContext.SaveChanges();
            }
            else
            {
                cart.CartItems.Add(cartItem);
                _dbContext.SaveChanges();
            }            
        }

        public Cart GetCartByUserID(string id)
        {
            var users = _dbContext.Users.Include(c => c.Cart);
            return users.First(c => c.Id == id).Cart;
        }
    }
}
