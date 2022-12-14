using FluentAssertions;

namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    private AgeCalculator _calculator;
    public AgeCalculatorTests()
    {
        _calculator = new AgeCalculator();
    }

    [Fact]
    public void sommeone_born_1972_is_50_in_2022()
    {
        // act
        var age= _calculator.GetAge(1972, 2022);

        // assert
        Assert.Equal(50, age);// before
        age.Should().Be(50);// then using FluentAssertions;
        
    }

    [Fact]
    public void someone_born_in_2022_is_0_in_2002()
    {
        //Act
        var age = _calculator.GetAge(2022, 2022);

        // Assert
        Assert.Equal(0, age);
       
    }
}