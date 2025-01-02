using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHousingProject.Entities;

namespace InfrastructureLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private StockDbContext _context;
        public ProductRepository(StockDbContext context)
        {
            _context = context;
        }

        public ProductsEntity Create(string name, char dimensions)
        {
            ProductsEntity product = new ProductsEntity()
            { ProductName = name, Dimensions = dimensions };
            _context.Add(product);
            _context.SaveChanges();
            return product;


        }

        public List<ProductsEntity> GetAllProduct()
        {
            return _context.Products.OrderBy(x => x.ProductID).ToList();
        }

        ProductsEntity IProductRepository.Create(string name, int dimensions)
        {
            throw new NotImplementedException();
        }
    }
}