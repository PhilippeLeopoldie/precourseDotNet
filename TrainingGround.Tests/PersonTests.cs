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
  public void reference_types_can_be_changed_via_reference()
  {
    // Arrange
    Person a = new Person ("Person A");
    a.LengthInMeters = 1.95;
    Person b = a;

    // Acte
    b.LengthInMeters = 1.96;

    // Assert
    Assert.Equal(1.96, b.LengthInMeters);
    Assert.Equal(1.96, a.LengthInMeters);
  }

  [Fact]
  public void value_types_cannot_be_chnaged_via_reference()
  {
    // arrange
    double aLengthInMeters = 1.95;
    double bLengthInMeters = aLengthInMeters;
    // act
    bLengthInMeters = 1.96;

    // assert
    Assert.Equal(1.96, bLengthInMeters);
    Assert.Equal(1.95, aLengthInMeters);
  }

}
