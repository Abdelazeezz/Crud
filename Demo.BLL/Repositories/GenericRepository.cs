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
    public class GenericRepository<T> : IGenericRepository<T> where T : ModelBase
    {
        private protected readonly AppDbContext _dbContext; // Reference Type => Null
        public GenericRepository(AppDbContext dbContext) 
        {
           
            _dbContext = dbContext;

        }

        public async Task Add(T entity)
        {
     
           await _dbContext.AddAsync(entity); // EF Core 3.1 Feature
       

        }
        public void Update(T entity)
        {
            //_dbContext.Set<T>().Update(entity);
            _dbContext.Update(entity);
          //  return _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            //_dbContext.Set<T>().Remove(entity);
            _dbContext.Remove(entity);
            //return _dbContext.SaveChanges();

        }

        public async Task<T> Get(int id)
        {
            ///var T = _dbContext.Ts.Local.Where(D => D.Id == id).FirstOrDefault();             
            ///if(T is null)
            ///  T = _dbContext.Ts.Where(D => D.Id == id).FirstOrDefault();           
            ///return T;

            //  return _dbContext.Ts.Find(id);
            return await _dbContext.FindAsync<T>(id);
            // return _dbContext.Ts.Find(1,10);

        }

        public async Task<IEnumerable<T>> GetAll()
        {
            if (typeof(T) == typeof(Employee))
            
                return  (IEnumerable<T>)await _dbContext.Employees.Include(E => E.Department).AsNoTracking().ToListAsync();
            
            else
                return await _dbContext.Set<T>().AsNoTracking().ToListAsync(); // To Work Immediate Excution

        }

    }
}
