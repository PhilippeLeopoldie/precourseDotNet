public class Person {
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
  public int BirthYear;
  public double LengthInMeters;

  public Person() { }
  public Person(string name){
    this.Name = name;
  

  }
}


