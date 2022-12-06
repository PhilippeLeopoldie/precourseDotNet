
  public class Employee : Person, IPrintable
  {
    public Employee(string name, string employeeId) : base(name)
    {
      
      this.EmployeeId = employeeId;
    }

  public string? EmployeeId { get; private set; }
  public Employee(){}

  public new string GetPrintString()
  {
    // throw new NotImplementedException();
    return @$"{this.Name} ({this.EmployeeId})
      {this.Address?.Street} {this.Address?.StreetNo}
      {this.Address?.City}
      ";
  }
}
