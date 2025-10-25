using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();

        Task AddProduct(Product practiceTable);
    }
}
