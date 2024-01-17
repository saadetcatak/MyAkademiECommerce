using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync();
        Task<T> CreateAsync();
        Task<T> UpdateAsync();
        Task<T> DeleteAsync();
        Task<List<T>> GetOrdersByFilter(Expression<Func<T, bool>> filter);
    }
}
