namespace OneToOneToManyToManyRelations.Fluent_API.OneToMany
{
    public class Department
    {
        public int Id { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
