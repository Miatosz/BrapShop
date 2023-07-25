using BrapShop.Data.models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using BrapShop.Data.Repositories;
using BrapShop.Data.Interfaces;

namespace BrapShop.Data.Services
{
    public class CartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IUserRepository _userRepository;

        public CartService(ICartRepository cartRepo, IUserRepository userRepo)
        {
            _cartRepository = cartRepo;
            _userRepository = userRepo;
        }

        public void AddToCart(Product product, string userId)
        {            
            CartItem cartItem = new CartItem()
            {
                ItemId = new Guid(),
                ProductId = product.ID,
                Product = product
            };

            var cartId = _userRepository.GetUserById(userId).Cart.ID.ToString();

            _cartRepository.AddCartItemToCart(cartItem, cartId);
            //TODO: koszyk wywala po refreszu na stronce - w bazce pozostaje

        }
    }
}
