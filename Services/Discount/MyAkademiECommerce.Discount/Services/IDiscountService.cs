using MyAkademiECommerce.Discount.Dtos;

namespace MyAkademiECommerce.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultCouponDto>> GetResultCouponAsync();
        Task CreateCouponAsync(CreateCouponDto createCouponDto);
        Task DeleteCouponAsync(int id);
        Task UpdateCouponAsync(UpdateCouponDto updateCouponDto);
        Task<ResultCouponDto> GetCouponById(int id);
    }
}
