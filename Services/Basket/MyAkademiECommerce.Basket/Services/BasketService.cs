using MyAkademiECommerce.Basket.Dtos;

namespace MyAkademiECommerce.Basket.Services
{
    public class BasketService : IBasketService
    {
        
        public Task DeleteBasket(string UserID)
        {
            throw new NotImplementedException();
        }

        public Task<BasketTotalDto> GetBasketTotalAsync(string UserID)
        {
            throw new NotImplementedException();
        }

        public Task SaveBasket(BasketTotalDto basketTotalDto)
        {
            throw new NotImplementedException();
        }
    }
}
