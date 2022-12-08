
  public class Employee : Person, IPrintable
  {
    public Employee(string name, string employeeId) : base(name)
    {
      
      this.EmployeeId = employeeId;
      this.Addresses = new List<Address>();
    }

  public string? EmployeeId { get; private set; }
  public Employee(){
   this.Addresses = new List<Address>();
  }
 

  public new string GetPrintString()
  {
    return @$"{this.Name} ({this.EmployeeId})
      {this.Address?.Street} {this.Address?.StreetNo}
      {this.Address?.City}
      ";
  }
  
}
