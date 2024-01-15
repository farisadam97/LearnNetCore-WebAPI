using Learn1.Domain.Entities;
using Learn1.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Persistance.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Learn1DBContext _context;

        public ProductRepository(Learn1DBContext context)
        {
            _context = context;   
        }

        public async Task AddAsync(Product product)
        {
            await _context.products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Product productExist = _context.products.First(c => c.Id == id);
            _context.products.Remove(productExist);
            await _context.SaveChangesAsync();
            
        }

        public async Task<List<Product>> GetAllAsync()
        {
           return await _context.products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.products.SingleAsync(x => x.Id == id); // harus return value
            //return await _context.products.SingleOrDefaultAsync(x => x.Id == id); // bisa return null
        }

        public async Task UpdateAsync(Product product)
        {

            Product productExist = _context.products.FirstOrDefault(c  => c.Id == product.Id);

            productExist.Name = product.Name;
            productExist.IsAvailable = product.IsAvailable;
            productExist.Category = product.Category;

            _context.Entry(productExist).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            
        }
    }
}
