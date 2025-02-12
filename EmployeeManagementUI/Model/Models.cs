namespace EmployeeManagementUI.Model
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int departmentID { get; set; }
        public DateTime hireDate { get; set; }
        public Department department { get; set; }
    }

    public class Department
    {
        public int departmentID { get; set; }
        public string name { get; set; }
        public string location { get; set; }
    }

    public class AttendanceRecord
    {
        public int attendanceID { get; set; }
        public int employeeID { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
    }

    public class MissingAttendanceRequest
    {
        public int requestID { get; set; }
        public int employeeID { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
        public int? approvedBy { get; set; }
    }

}
