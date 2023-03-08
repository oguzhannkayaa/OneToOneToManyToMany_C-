using System.ComponentModel.DataAnnotations.Schema;

namespace OneToOneToManyToManyRelations.Data_Annotations.OneToMany
{
    public class Employee
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Department))]
        public int DId { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }
    }
}
