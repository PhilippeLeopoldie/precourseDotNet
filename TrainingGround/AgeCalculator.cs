//namespace TrainingGround;
public class AgeCalculator
{
  public enum AgeCategory
  {
    Kid,
    Adult,
    Prime
  }
  public static AgeCategory GetAgeCategory(Person person, int currentYear)
  {
    var isOlderThan18 = person.GetAge(currentYear)>=18;
    var is50 = person.GetAge(currentYear)==50;
    if(is50)
    {
      return AgeCategory.Prime;
    }
    if(isOlderThan18)
    {
      return AgeCategory.Adult;
    }
    
    return AgeCategory.Kid;
  }

  public int GetAge (int birthdYear, int currentYear)
  {
    return currentYear - birthdYear;
  }

  public static string GetAgeSpan(AgeCategory category)
  {
    switch(category)
    {
      case  AgeCategory.Kid:
        return "Under 18 years";
      case AgeCategory.Adult:
        return "Above 18 years";
      case AgeCategory.Prime:
        return "exactly 50 - and proud!";
      default:
        return "Unknown";

    }
  }
}
