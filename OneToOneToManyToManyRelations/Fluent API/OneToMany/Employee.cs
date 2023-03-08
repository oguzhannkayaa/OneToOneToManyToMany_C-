using System.ComponentModel.DataAnnotations.Schema;

namespace OneToOneToManyToManyRelations.Fluent_API.OneToMany
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }
    }
}
