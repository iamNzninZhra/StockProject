using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IProductRepository

    {
        public ProductsEntity Create(string name, int dimensions);
        public List<ProductsEntity> GetAllProduct();

    }
}