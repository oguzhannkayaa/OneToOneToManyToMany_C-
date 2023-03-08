using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToOneToManyToManyRelations.Data_Annotations.OneToOne
{
    public class EmployeeAddress
    {
        [Key,ForeignKey(nameof(Employee))]
        public int Id { get; set; }
        public string Address { get; set; }
        public Employee Employee { get; set; }
    }
}
