public class LinqTests
{
  [Fact]
  public void loop_to_filter_numbers()
  {
   // arrange
   var numbers = new List<int>{1, 53, 2, 62, 2, 12, 17, 15, 16};
   // act
   var numbersLargerThan15 = new List<int>();
   foreach(var number in numbers)
   {
    if (number > 15)
    {
      numbersLargerThan15.Add(number);
    }
   }
   // assert
   Assert.Equal(4, numbersLargerThan15.Count);
  }

  [Fact]
  public void linq_to_filter_number()
  {
    // arrange
    var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16};

    // act
    var numbersLargerThan15 = numbers.FindAll(number => number > 15);

    // assert
    Assert.Equal(4, numbersLargerThan15.Count);
  }
  
}