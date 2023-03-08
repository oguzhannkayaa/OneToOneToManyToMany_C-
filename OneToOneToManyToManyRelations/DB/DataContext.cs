using Microsoft.EntityFrameworkCore;
using OneToOneToManyToManyRelations.Models;
using System.Collections.Generic;

namespace OneToOneToManyToManyRelations.DB
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDA> EmployeesDA { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<EmployeeAddressDA> EmployeeAddressesDA { get; set; }

    }
}
