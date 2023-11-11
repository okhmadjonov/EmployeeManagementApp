﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Domain.Entity;

namespace EmployeesManagement.Context.DataContext
{
    public  class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options): base(options) { }
        
            
       
        

       public  DbSet<Employee> Employees { get; set; }


    }
}
