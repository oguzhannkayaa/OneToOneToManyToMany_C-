namespace OneToOneToManyToManyRelations.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmantName { get; set; }

        //public ICollection<Employee> employees { get; set; }
    }
}
//navigation property ilişkisel tablolar arasındaki fiziksel erişimin entity classları üzerinden sağlayan propertylerdir.