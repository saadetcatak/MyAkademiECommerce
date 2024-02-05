using MyAkademiECommerce.Basket.Dtos;

namespace MyAkademiECommerce.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasketTotalAsync(string UserID);
        Task SaveBasket(BasketTotalDto basketTotalDto);
        Task DeleteBasket(string UserID);
    }
}
