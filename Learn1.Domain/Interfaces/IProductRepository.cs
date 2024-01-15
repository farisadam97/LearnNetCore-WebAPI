using Learn1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Domain.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(int id);
        public Task AddAsync(Product product);
        public Task UpdateAsync(Product product);
        public Task DeleteAsync(int id);
    }
}
