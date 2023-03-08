Default Contention:
	Ýki tablonun bire bir (faklý da olabilir) iliþki kurulma esnasýnda bir primary key atanmasý tablo objesinde referans tablosuna

	public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public EmployeeAddress EmployeeAddress { get; set; }
    }

    public class EmployeeAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

Data Annotations:
	Eðer tablo objesinde bir column üzerinde bir attribute tanýmalnýyorsa [ForeignKey("")]

    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public EmployeeAddress EmployeeAddress { get; set; }
    }

    public class EmployeeAddress
    {
        ->[Key,ForeignKey(nameof(Employee))]
        public int Id { get; set; }
        public string Address { get; set; }
        public Employee Employee { get; set; }
    }
	