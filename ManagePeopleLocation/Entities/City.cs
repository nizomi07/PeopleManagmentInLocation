namespace ManagePeopleLocation.Entities;

public class City : BaseEntity
{
    public string Name { get; set; } = null!;
    public int Population { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; } = null!;
    public List<Person> People { get; set; } = new();
    
    public City() { }

    public City(int id, string name, int population, int countryId)
    {
        Id = id;
        Name = name;
        Population = population;
        CountryId = countryId;
    }
}