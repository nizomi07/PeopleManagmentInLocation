namespace ManagePeopleLocation.Entities;

public class Person : BaseEntity
{
    public string FullName { get; set; } = null!;
    public int Age { get; set; }
    public int CityId { get; set; }
    public City City { get; set; } = null!;
    
    public Person() { }
    public Person(int id, string fullName, int age, int cityId)
    {
        Id = id;
        FullName = fullName;
        Age = age;
        CityId = cityId;
    }
}