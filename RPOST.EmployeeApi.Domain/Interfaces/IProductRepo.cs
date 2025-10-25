using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Domain.Interfaces
{
    public interface IProductRepo
    {
        Task<List<Product>> GetAll();
        Task AddProduct(Product practiceTable);
    }
}
