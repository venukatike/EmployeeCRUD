using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPOST.EmployeeApi.Data.Data;
using RPOST.EmployeeApi.Domain.Entities;
using RPOST.EmployeeApi.Domain.Interfaces;

namespace RPOST.EmployeeApi.Data.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext db;
        public ProductRepo(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<List<Product>> GetAll()
        {
      
               var u= await db.PracticeTables.ToListAsync();

            return u;
        }

        public async Task AddProduct(Product practiceTable)
        {
            db.PracticeTables.Add(practiceTable);
            await db.SaveChangesAsync();
        }
    }
}
