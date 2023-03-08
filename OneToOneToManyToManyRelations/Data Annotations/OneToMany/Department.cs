namespace OneToOneToManyToManyRelations.Data_Annotations.OneToMany
{
    public class Department
    {
        public int Id { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
