using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondApi.Entities
{
    public class Employees
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }
        public string Experience { get; set; }
        
    }
    public class Mapping : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> typeBuilder)
        {
            typeBuilder.Property(p => p.Id).UseSqlServerIdentityColumn();
            typeBuilder.HasKey(p => p.Id);
            typeBuilder.Property(p => p.Name);
            typeBuilder.Property(p => p.Salary);
            typeBuilder.Property(p => p.Description);
            typeBuilder.Property(p => p.Experience);
            typeBuilder.ToTable("T_ELITE_EMPLOYEES");
          
        }
    }
}
