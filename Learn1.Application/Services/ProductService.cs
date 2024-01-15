using AutoMapper;
using Learn1.Application.DTOs;
using Learn1.Application.Interfaces;
using Learn1.Domain.Entities;
using Learn1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<int> AddAsync(ProductPostDto productDto)
        {
            // convert dto to entity
            Product product = _mapper.Map<ProductPostDto, Product>(productDto);

            // add values
            await _productRepository.AddAsync(product);
            return product.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            List<Product> products = await _productRepository.GetAllAsync();
            // convert entity to dto
            List<ProductDto> result = _mapper.Map<List<Product>, List<ProductDto>>(products);
            return result;
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            Product product = await _productRepository.GetByIdAsync(id);

            // convert from entity to dto
            ProductDto productDto = _mapper.Map<Product,ProductDto>(product);
            return productDto;
        }

        public async Task UpdateAsync(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            await _productRepository.UpdateAsync(product);
        }
    }
}
