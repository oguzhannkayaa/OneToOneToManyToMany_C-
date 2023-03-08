namespace OneToOneToManyToManyRelations.Models
{
    public class EmployeeDA
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public EmployeeAddress EmployeeAddress { get; set; }
    }
}
