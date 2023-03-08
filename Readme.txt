Default Contention:
	�ki tablonun bire bir (fakl� da olabilir) ili�ki kurulma esnas�nda bir primary key atanmas� tablo objesinde referans tablosuna

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
	E�er tablo objesinde bir column �zerinde bir attribute tan�maln�yorsa [ForeignKey("")]

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
	