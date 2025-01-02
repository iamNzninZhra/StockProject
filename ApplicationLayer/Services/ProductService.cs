//using ApplicationLayer.Dtos;
using ApplicationLayer.DTOs;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class ProductService
    {
      readonly IProductRepository repo;

        public ProductService(IProductRepository _repo)
        {
            repo = _repo;
        }

        public ProductsEntity Create(CreateProductDTO item)
        {
            return repo.Create(item.ProductName, item.Dimensions);
        }
        public List<ProductsEntity> GetAllProduct()
        {
            return repo.GetAllProduct();
        }

    }
}