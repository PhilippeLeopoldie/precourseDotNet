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

  [Fact]
  public void when_50_then_prim_Age()
  {
    // arrange
    var p = new Person(1972);

    // act
    var category = AgeCalculator.GetAgeCategory(p, 2022);

    // assert
    Assert.Equal(AgeCategory.Prime, category);
  }

  [Theory]
  [InlineData(AgeCategory.Kid,"Under 18 years")]
  [InlineData(AgeCategory.Adult,"Above 18 years")]
  [InlineData(AgeCategory.Prime, "exactly 50 - and proud!")]
  public void should_return_spanAge(AgeCategory category, string expected)
  {
    // act
     var span = AgeCalculator.GetAgeSpan(category);

    // assert
    Assert.Equal(expected, span);
  }


}