namespace OneToOneToManyToManyRelations.Data_Annotations.OneToOne
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public EmployeeAddress EmployeeAddress { get; set; }
    }
}
