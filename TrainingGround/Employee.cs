
  public class Employee : Person
  {
    public Employee(string name, string employeeId) : base(name)
    {
      
      this.EmployeeId = employeeId;
    }

  public string EmployeeId { get; private set; }
  public Employee(){}
}
