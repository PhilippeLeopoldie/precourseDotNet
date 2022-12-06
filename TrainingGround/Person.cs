public class Person : IPrintable
 {
  /*public string? name { get; set;}*/
  /*private string? _name;
  public string? Name
  {
    get{ return _name;}
    set
    {
      if(value.Length < 5)
      {
        this._name = value;
      }
    }
  }*/
  /*public string GetName()
  {
    return this.Name;
  }
  public string SetName(string nameToSet)
  {
    if (nameToSet.Length > 5)
    {
       this.Name = nameToSet;
    }
    return nameToSet;
    {
      
    }
  }*/
  public string? Name {get; private set;}

  private int _birthYear;
  //private int currentYear = 2022;
  public int birthYear{get; private set;}
  public Address? Address { get; set; }

  public double LengthInMeters;

  public Person() { }

  
  
  public Person(string name){
    this.Name = name;
  
  }
  
  public Person(int year){
    birthYear = year;
  }

  public int GetAge(int currentYear)
  {
    return currentYear - birthYear;
  }

  public int SetAge(int BirthYear)
  {
    return _birthYear=BirthYear;

  }
  public string GetPrintString()
  {
    return @$"{this.Name}
    {this.birthYear}
    {this.Address}
    ";
  }
 
}


