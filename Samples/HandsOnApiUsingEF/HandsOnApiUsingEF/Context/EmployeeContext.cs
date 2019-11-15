using HandsOnApiUsingEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnApiUsingEF.Context
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server =DESKTOP-64P1ILH\KANI;Database=EmployeeNewDB;Trusted_Connection=True;");

        //}
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}
