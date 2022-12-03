public class PersonTests{
  [Fact]
  public void create_person_using_parameterless_constructor()
  {
    //act
    var p = new Person();
    // assert
    Assert.NotNull(p);

  }
  [Fact]
  public void create_person_using_parameter_with_name()
  {
    //act
    var person =new Person("Philippe");
    
    // assert
    Assert.NotNull(person);
    Assert.Equal("Philippe",person.Name);
  }
}