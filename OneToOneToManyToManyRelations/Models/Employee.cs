namespace OneToOneToManyToManyRelations.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public EmployeeAddress EmployeeAddress { get; set; }

        //public Department Department { get; set; }
    }
}
