using AutoMapper;
using Dapper;
using MyAkademiECommerce.Discount.Context;
using MyAkademiECommerce.Discount.Dtos;
using MyAkademiECommerce.Discount.Models;

namespace MyAkademiECommerce.Discount.Services
{
    public class DiscountService:IDiscountService
    {
        private readonly DapperContext _context;
       

        public DiscountService(DapperContext context)
        {
            _context = context;
            
        }

        public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            string query = "insert into Coupones (Code,Rate,IsActive,ValidDate) values (@code,@rate,@isActive,@validDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createCouponDto.Code);
            parameters.Add("@rate", createCouponDto.Rate);
            parameters.Add("@isActive", true);
            parameters.Add("@validDate", DateTime.Now.AddDays(10));
            using(var connection=_context.CreateConnection()) 
            { 
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteCouponAsync(int id)
        {
            string query = "Delete From Coupones Where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@couponID", id);
            using(var connection=_context.CreateConnection()) 
            {
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async Task<ResultCouponDto> GetCouponById(int id)
        {
           string query= "Select*From  Coupones where CouponID=@couponID"; 
            var parameters = new DynamicParameters();
            parameters.Add("@couponID", id);
            using (var connection=_context.CreateConnection())
            {
                var values=await connection.QueryFirstOrDefaultAsync<ResultCouponDto>(query,parameters);
                return values;
            }
        }

        public async Task<List<ResultCouponDto>> GetResultCouponAsync()
        {
            string query = "Select*From Coupones";
            using (var connection=_context.CreateConnection()) 
            {
                var values = await connection.QueryAsync<ResultCouponDto>(query);
                return values.ToList();
            }
        }

        public async Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
        {
            string query = "Update Coupones Set Code=@code,Rate=@rate,IsActive=@isActive,ValidDate=@validDate where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@code", updateCouponDto.Code);
            parameters.Add("@rate", updateCouponDto.Rate);
            parameters.Add("@isActive", updateCouponDto.IsActive);
            parameters.Add("@validDate", updateCouponDto.ValidDate);
            parameters.Add("@couponID", updateCouponDto.CouponID);
            using(var connection=_context.CreateConnection()) 
            { 
                await connection.ExecuteAsync(query,parameters);
            }

        }
    }
}
