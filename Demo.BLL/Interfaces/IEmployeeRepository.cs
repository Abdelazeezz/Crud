﻿using Demo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IEmployeeRepository :IGenericRepository<Employee>
    {
        IQueryable<Employee> GetEmployeeByAddress(string address);
        IQueryable<Employee> SearchEmployee(string name);
    }
}
