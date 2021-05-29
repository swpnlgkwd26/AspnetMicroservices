using Basket.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Repository
{
   public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string userName);// Return Basket for specific user
        Task<ShoppingCart> UpdateBasket(ShoppingCart basket); // Update the Existing basket
        Task DeleteBasket(string userName);// Deletes the Basket
    }
}
