
public class LoopTests
{
  [Fact]
  public void while_loop()
  {
    // arrange
    var ints = new int[] {1, 2, 3, 4, 5};

    // act
    var i = 0;
   
    while (i < ints.Length)
    {
      var currentValueInTheLoop = ints[i];

      Console.WriteLine($"i is now '{i}'");
      Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

      // assert
      Assert.Equal(i + 1, currentValueInTheLoop);
      i = i + 1;
    }
  }
  [Fact]
  public void for_loop()
  {
    // arrange
    var ints = new int[] {1,2,3,4,5};
    // act
    for (var i = 0; i< ints.Length; i++)
    {
      var currentValueInTheLoop = ints[i];

      Console.WriteLine($"i is now '{i}'");
      Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");
    
    // assert
    Assert.Equal(i + 1, currentValueInTheLoop);
    }
  }
  [Fact]
  public void for_each()
  {
    // arrange
    var ints = new int[] {1,2,3,4,5};

    // act
    foreach(var currentValueInTheLoop in ints)
    {
     // Console.WriteLine($"i is now '{i}'");
      Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");
    
    // assert
    Assert.IsType<int>(currentValueInTheLoop);
    }
  }
  [Fact]
  void for_each_loop_over_adresses()
  {
    // assert
    var emp = new Employee("phil", "my-id");
    emp.Addresses.Add(new Address(){Street="myStreet1", StreetNo = 1});
    emp.Addresses.Add(new Address(){Street="myStreet2", StreetNo = 2});
    emp.Addresses.Add(new Address(){Street="myStreet3", StreetNo = 3});
    

    // act
    foreach(var oneAdress in emp.Addresses)
    {
      Console.WriteLine($"Address street: {oneAdress.Street}, streetNo: {oneAdress.StreetNo}");

      // assert
    Assert.IsType<List<Address>>(emp.Addresses);
    Assert.IsType<Address>(oneAdress);
    }

    

  }

  
  
}