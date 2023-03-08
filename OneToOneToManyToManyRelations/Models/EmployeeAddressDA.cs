using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToOneToManyToManyRelations.Models
{
    public class EmployeeAddressDA
    {
        [Key, ForeignKey(nameof(EmployeeDA))]
        public int Id { get; set; }
        public string Address { get; set; }
        public EmployeeDA EmployeeDA { get; set; }
    }
}
