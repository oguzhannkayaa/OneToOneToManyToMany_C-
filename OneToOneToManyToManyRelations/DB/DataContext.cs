using Microsoft.EntityFrameworkCore;
using OneToOneToManyToManyRelations.Fluent_API.OneToOne;
using System.Collections.Generic;

namespace OneToOneToManyToManyRelations.DB
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }

        //Model'lerin (entity) veri tabanında generate edilecek yapılarının konfigurasyonları bu fonksiyon içerisinde konfigure edilir
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one to one starts
            //    modelBuilder.Entity<EmployeeAddress>()
            //        .HasKey(c => c.Id);

            //    modelBuilder.Entity<Employee>()
            //        .HasOne(c => c.EmployeeAddress)
            //        .WithOne(c => c.Employee)
            //        .HasForeignKey<EmployeeAddress>(c => c.Id);
            // one to one ends

            // one to many
            //
            //modelBuilder.Entity<Employee>()
            //    .HasOne(c => c.Department)
            //    .WithMany(d => d.Employees)

        }

    }
}
