
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
  public void for_each_loop_over_adresses()
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

  [Fact]
  public void break_stops_loops()
  {
    // arrange
    var addressList = new List<Address>();
    addressList.Add(new Address(){ Street = "Street", StreetNo = 1});
    addressList.Add(new Address(){ Street = "Street", StreetNo = 2});
    addressList.Add(new Address(){ Street = "Street", StreetNo = 3});

    // act
    var foundIt= false;
    foreach(var currentValueInTheLoop in addressList)
    {
      if (currentValueInTheLoop.StreetNo == 2)
      {
        foundIt = true;
        break;
      }
    }
    // assert
    Assert.True(foundIt);
  }

  [Fact]
  public void continue_loops_only_for_even_number()
  {
    // arrange
    var addressList = new List<Address>();
    var i = 0;
    while(i < 11)
    {
      if(i % 2 ==0){
        i ++;
        continue;
      }
      addressList.Add(new Address(){Street=$" Street of the {i} flowers", StreetNo= i});
      i ++; 
    }
    // act
    Boolean isEven= false;
    foreach(var oneAddress in addressList){
      /*if(oneAddress.StreetNo % 2==0)
      {
        isEven = true;
      }*/
      isEven=(oneAddress.StreetNo % 2==0)? true:false;
    }
    // assert
    Assert.Equal(false, isEven);
  }
}