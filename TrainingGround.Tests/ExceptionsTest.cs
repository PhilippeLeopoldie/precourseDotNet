public class ExceptionsTest
{
  [Fact]
  public void not_handling_an_exception()
  {
    try
    {
      // arrange
      var i = 1;

      // act
      var result = 14 / (i - 1);
    }
    catch(System.Exception e)
    {
      // assert
      Assert.IsType<DivideByZeroException>(e);

    }
  }
  [Fact]
  public void getting_age_from_person()
  {
    try
    {
      // arrange
      var p = new Person(2023);

      //
      var age = p.GetAge(2022);
    }
    catch(System.Exception e)
    {
      // assert
      Assert.Equal("Not born yet", e.Message);
      return;
    }
    Assert.True(false,"Expected exception didn't happen");
  }
}