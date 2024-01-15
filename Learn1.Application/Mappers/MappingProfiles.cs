using AutoMapper;
using Learn1.Application.DTOs;
using Learn1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Application.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Product
            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductPostDto, Product>();
        }
    }
}
