using BrapShop.Data.models;

namespace BrapShop.Data.Interfaces
{
    public interface ICartRepository
    {
        Cart GetCartByUserID(string id);
        void AddCartItemToCart(CartItem cartItem, string cartId);
    }
}
