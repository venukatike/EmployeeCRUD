using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPOST.EmployeeApi.Application.Interfaces;
using RPOST.EmployeeApi.Domain.Entities;
using RPOST.EmployeeApi.Domain.Interfaces;

namespace RPOST.EmployeeApi.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _product;
        public ProductService(IProductRepo product)
        {
            _product = product;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _product.GetAll();
        }

        public async Task AddProduct(Product product)
        {
           await _product.AddProduct(product);
        }
    }
}
