using Demo.BLL.Interfaces;
using Demo.DAL.Data;
using Demo.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext dbContext):base(dbContext) // Ask ClR To Create Object From Class DbContext
        {

        }

        public IQueryable<Employee> GetEmployeeByAddress(string address)
        {
            return _dbContext.Employees.Where(E => E.Address.ToLower().Contains(address.ToLower() ) );
        }

        public IQueryable<Employee> SearchEmployee(string name)
        => _dbContext.Employees.Where(E => E.Name.ToLower().Contains(name)).Include(E=>E.Department);
    }
}
