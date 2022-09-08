using Basket.WebApi.Models;

namespace Basket.WebApi.Repositories;

public interface IBasketRepository
{
    Task<ShoppingCart?> GetBasket(string userName);

    Task<ShoppingCart?> UpdateBasket(ShoppingCart basket);

    Task DeleteBasket(string userName);
}