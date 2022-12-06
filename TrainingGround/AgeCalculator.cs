//namespace TrainingGround;
public class AgeCalculator
{
  public enum AgeCategory
  {
    Kid,
    Adult
  }
  public static AgeCategory GetAgeCategory(Person person, int currentYear)
  {
    var isOlderThan18 = person.GetAge(currentYear)>18;
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

}
