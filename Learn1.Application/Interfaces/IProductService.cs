using Learn1.Application.DTOs;
using Learn1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Interfaces
{
    public interface IProductService
    {
        public Task<List<ProductDto>> GetAllAsync();
        public Task<ProductDto> GetByIdAsync(int id);
        public Task<int> AddAsync(ProductPostDto productPostDto);
        public Task UpdateAsync(ProductDto productDto);
        public Task DeleteAsync(int id);
    }
}
