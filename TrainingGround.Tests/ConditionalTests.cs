using static AgeCalculator;

public class ConditionalTest
{
  [Fact]
  public void should_be_kid_when_younger_than_18()
  {
    // arrange
    var p = new Person(2005);

    // act
    var category = AgeCalculator.GetAgeCategory(p, 2022);

    // assert
    Assert.Equal(AgeCategory.Kid, category);
  }

  [Fact]
  public void should_be_adult_when_older_than_18()
  {
    // arrange
    var p = new Person (2002);
    // act
    var category = AgeCalculator.GetAgeCategory(p, 2022);
    // assert
    Assert.Equal(AgeCategory.Adult, category);
  }

  
}