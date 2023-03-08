namespace OneToOneToManyToManyRelations.OneToOne
{
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
