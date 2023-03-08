using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace OneToOneToManyToManyRelations.Fluent_API.OneToOne
{
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public Employee Employee { get; set; }
    }
}
