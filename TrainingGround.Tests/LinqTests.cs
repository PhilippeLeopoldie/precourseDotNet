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
  [Fact]
  public void linq_to_find_first()
  {
    // arrange
    var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16};

    // act
    var firstNumberLargerThan15 = numbers.Find(number => number > 15);

    // assert
    Assert.Equal(53, firstNumberLargerThan15);
  }
  [Fact]
  public void linq_to_check_if_any_matches()
  {
    // arrange
    var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16};

    // act
    var anyOver100 = numbers.Any(number => number > 100);

    // assert
    Assert.Equal(false, anyOver100);
  }

  [Fact]
  public void linq_check_if_all_positive()
  {
    // arrange
    var numbers = new List<int> {1, 53, 2, 62, 2, 12, 17, 15, 16};

    // act
    var allPositive = numbers.All(number => number > 0);

    // assert
    Assert.Equal(true,allPositive);
  }
  [Fact]
  public void filter_poeple_by_name_longer_Than_4()
  {
    // arrange
    var people = new List<Person>
    {
      new Person("Aaaron"),
      new Person("Bea"),
      new Person("Ceasar"),
      new Person("Dave")

    };

    // act
    var allPeopleNameLongerThan4 = people
    .Where(p => p.Name.Length >4)
    .ToList();

    // assert
    Assert.Equal(2, allPeopleNameLongerThan4.Count);
    Assert.Equal(true, allPeopleNameLongerThan4.Any(p => p.Name=="Aaaron"));
    Assert.Equal("Aaaron", allPeopleNameLongerThan4.First().Name);
    Assert.Equal("Ceasar", allPeopleNameLongerThan4[1].Name);
  }

  [Fact]
  public void filter_people_by_age_only_names()
  {
    // arrange
    var people = new List<Person> 
    {
      new Person("Aaaron"),
      new Person("Bea"),
      new Person("Ceasar"),
      new Person("Dave")
    };

    // act
    var allPeopleNameLongerThan4 = people
    .Where(p => p.Name.Length >4)
    .Select(p => p.Name)
    .ToList();

    // assert
    Assert.Equal(2, allPeopleNameLongerThan4.Count);
    Assert.Equal(true, allPeopleNameLongerThan4.Any(p => p =="Aaaron"));
    Assert.Equal("Aaaron", allPeopleNameLongerThan4.First());
    Assert.Equal("Ceasar", allPeopleNameLongerThan4[1]);
  }
  [Fact]
  public void filter_people_by_height_names()
  {
    // arrange
    var a = new Person("Aaaron");
    a.LengthInMeters = 1.96;
    var people = new List<Person> 
    {
      a,
      new Person("Bea"),
      new Person("Ceasar"),
      new Person("Dave")
    };
    // act
    var namesAndHeight = people
      .Where(p => p.Name.Length > 4)
      .Select(p => new { Name = p.Name, Height = p.LengthInMeters})
      .ToList();
    // assert
    Assert.Equal(2, namesAndHeight.Count);
    Assert.Equal("Aaaron", namesAndHeight[0].Name);
    Assert.Equal(1.96, namesAndHeight.First().Height);
  }
  [Fact]
  public void filter_people_by_height_name_Query_Syntax()
  {
    // arrange
    var a = new Person("Aaaron");
    a.LengthInMeters = 1.96;
    var people = new List<Person>
    {
      a,
      new Person("Bea"),
      new Person("Ceasar"),
      new Person("Dave")
    };
    // act
    var query =
    from p in people 
    where p.Name.Length >4
    select new{ Name= p.Name, Height = p.LengthInMeters};
    var nameAndheight = query.ToList();

    // assert
    Assert.Equal(2,nameAndheight.Count());
    Assert.Equal("Aaaron", nameAndheight.First().Name);
    Assert.Equal(1.96, nameAndheight.First().Height);
  }
}