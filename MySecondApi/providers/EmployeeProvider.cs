using Microsoft.EntityFrameworkCore;
using MySecondApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondApi.providers
{
    public class EmployeeProvider:DbContext
    {
        public virtual DbSet<Employees> GetEmployees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-4DVSS1G\SQLEXPRESS;initial catalog=EMPLOYEES;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Mapping()); 
        }
    }
    
}
