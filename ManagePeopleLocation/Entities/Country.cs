namespace ManagePeopleLocation.Entities;

public class Country : BaseEntity
{
    public string Name { get; set; } = null!;
    public List<City> Cities { get; set; } = new();
    
    public Country() { }

    public Country(int id, string name)
    {
        Id = id;
        Name = name;
    }
}