public class PersonTests{

  private Person _person;
  public PersonTests()
  {
    _person = new Person();
  }
  private int currentYear = 2022;


  [Fact]
  public void create_person_using_parameterless_constructor()
  {
    //act
    //var p = new Person();
    // assert
    Assert.NotNull(_person);

  }
  [Fact]
  public void create_person_using_parameter_with_name()
  {
    //act
    var person = new Person("Philippe");
    
    
    // assert
    Assert.NotNull(person);
    Assert.Equal("Philippe",person.Name);
  }

  [Fact]
  public void a_personn_born_1972_is_50_2022()
  {
    // arrange
    //var p= new Person(1972);
    
    // assert
    Assert.Equal(50, _person.GetAge(1972, currentYear));
  }

  [Fact]
  public void a_personn_born_1982_is_40_2022()
  {
    // Arrange
    //var p = new Person(1982);

    // Assert
    Assert.Equal(40, _person.GetAge(1982, currentYear));
  }
  [Fact]
  public void a_personn_born_1992_is_30_2022()
  {
    // Arrange
    //var p = new Person(1992);

    // assert
    Assert.Equal(30, _person.GetAge(1992, currentYear));
  }
  [Fact]
  public void an_employee_is_a_person()
  {
    // act
    var emp = new Employee();
    emp.LengthInMeters = 1.95;

    // assert
    Assert.IsType(typeof(Employee), emp);
    Assert.Equal(1.95, emp.LengthInMeters);
  }

  public void an_employee_has_an_employeeId()
  {
    // act
    var emp = new Employee("Marcus", "234-BDAS");

    // assert
    Assert.IsType(typeof(Employee), emp);
    Assert.Equal("Marcus", emp.Name);
    Assert.Equal("234-BDAS", emp.EmployeeId);
  }
[Fact]
  public void a_person_has_an_address()
  {
    // arrange
    var p = new Person("Philippe");

    // act
    p.Address = new Address();
    p.Address.Street = "A street";
    p.Address.SteeetNo = 23;
    p.Address.City = "Stockholm";

    // assert
    Assert.NotNull(p.Address);
    Assert.IsType(typeof(Address), p.Address);
  }
}
