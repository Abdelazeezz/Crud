﻿using Demo.BLL.Interfaces;
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
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext dbContext) :base(dbContext) // Ask ClR for Creating Object Class DbContext
        {

        }
       
     
    }
}
