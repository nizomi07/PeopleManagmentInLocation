
using ManagePeopleLocation.Entities;

var countries = new List<Country>
{
    new Country(1, "Tajikistan"),
    new Country(2, "Turkey"),
    new Country(3, "Canada"),
    new Country(4, "United States"),
    new Country(5, "United Kingdom")
};

var cities = new List<City>
{
    new City { Id = 1, Name = "Dushanbe", Population = 900000, CountryId = 1 },
    new City { Id = 2, Name = "Khujand", Population = 180000, CountryId = 1 },

    new City { Id = 3, Name = "Istanbul", Population = 15500000, CountryId = 2 },
    new City { Id = 4, Name = "Ankara", Population = 5500000, CountryId = 2 },

    new City { Id = 5, Name = "Toronto", Population = 6000000, CountryId = 3 },
    new City { Id = 6, Name = "Vancouver", Population = 2600000, CountryId = 3 },

    new City { Id = 7, Name = "New York", Population = 8000000, CountryId = 4 },
    new City { Id = 8, Name = "Los Angeles", Population = 3900000, CountryId = 4 },

    new City { Id = 9, Name = "London", Population = 9000000, CountryId = 5 },
    new City { Id = 10, Name = "Manchester", Population = 550000, CountryId = 5 }
};

var people = new List<Person>
{
    new Person { Id = 1, FullName = "John Smith", Age = 28, CityId = 7 },      // New York
    new Person { Id = 2, FullName = "Aisha Karimova", Age = 22, CityId = 1 },  // Dushanbe
    new Person { Id = 3, FullName = "Mehmet Yilmaz", Age = 31, CityId = 3 },   // Istanbul
    new Person { Id = 4, FullName = "Alice Johnson", Age = 19, CityId = 9 },   // London
    new Person { Id = 5, FullName = "Emily Brown", Age = 25, CityId = 5 },     // Toronto
    new Person { Id = 6, FullName = "David Wilson", Age = 37, CityId = 8 },    // Los Angeles
    new Person { Id = 7, FullName = "Ali Umarov", Age = 30, CityId = 2 },      // Khujand
    new Person { Id = 8, FullName = "Leyla Demir", Age = 27, CityId = 4 },     // Ankara
    new Person { Id = 9, FullName = "Omar Sharipov", Age = 18, CityId = 1 },   // Dushanbe
    new Person { Id = 10, FullName = "Emma Clark", Age = 33, CityId = 6 }      // Vancouver
};



// Task - 1

// var peopleWhoLiveInCityWithMoreThan3000000Population =
//     from p in people
//     join c in cities
//     on p.CityId equals c.Id
//     where c.Population > 3000000
//     select new {personName = p.FullName, age = p.Age, cityName = c.Name};
//
// foreach (var person in peopleWhoLiveInCityWithMoreThan3000000Population)
// {
//     Console.WriteLine($"{person.personName} {person.age} {person.cityName}");
// }



// Task - 2

// var citiesAboveAverageByCountry = cities
//     .Join(countries, c => c.CountryId, co => co.Id, (c, co) => new { c, co })
//     .GroupBy(c => c.co.Name)
//     .SelectMany(g =>
//     {
//         var averagePopulation = g.Average(x => x.c.Population);
//         return g.Where(x => x.c.Population > averagePopulation)
//             .Select(x => new
//             {
//                 CountryName = g.Key,
//                 CityName = x.c.Name,
//                 AveragePopulation = averagePopulation,
//                 Population = x.c.Population
//             });
//     });
//
// foreach (var city in citiesAboveAverageByCountry)
// {
//     Console.WriteLine($"{city.CountryName}: {city.AveragePopulation} - {city.CityName} ({city.Population})");
// }


// Task - 3

// var mostPopulatedCitiesByCountry = countries
//     .Join(cities, c => c.Id, city => city.CountryId, (c, city) => new { c, city })
//     .GroupBy(x => new { x.c.Id, x.c.Name })
//     .Select(g => new
//     {
//         CountryName = g.Key.Name,
//         City = g.OrderByDescending(x => x.city.Population).First().city.Name,
//         Population = g.OrderByDescending(x => x.city.Population).First().city.Population
//     });
//
// foreach (var item in mostPopulatedCitiesByCountry)
// {
//     Console.WriteLine($"{item.CountryName} - {item.City} with population {item.Population}");
// }




// Task - 4

// var peopleInfo =
//     from person in people
//     join city in cities on person.CityId equals city.Id
//     join country in countries on city.CountryId equals country.Id
//     select new
//     {
//         Fullname = person.FullName,
//         CityName = city.Name,
//         CountryName = country.Name,
//     };
//
// foreach (var person in peopleInfo)
// {
//     Console.WriteLine($"Fullname: {person.Fullname}, CityName: {person.CityName}, CountryName: {person.CountryName}");
// }




// Task - 5

// var citiesAliceLives = people
//     .Where(p => string.Equals(
//         p.FullName.Split(' ')[0],
//         "Alice",
//         StringComparison.OrdinalIgnoreCase))
//     .Join(cities,
//         p => p.CityId,
//         c => c.Id,
//         (p, c) => c)
//     .Distinct();
//
//
// var result = people
//     .Where(p => string.Equals(p.FullName.Split(' ')[0], "Alice", StringComparison.OrdinalIgnoreCase))
//     .Join(cities,
//         p => p.CityId,
//         c => c.Id,
//         (p, c) => c);
//
// foreach (var city in citiesAliceLives)
// {
//     Console.WriteLine(city.Name);
// }


// Task - 6

// var oldestPersonInEachCity = cities
//     .Join(people, city => city.Id, person => person.CityId, (city, person) => new { city, person })
//     .GroupBy(x => x.city)
//     .Select(g => new
//     {
//         CityName = g.Key.Name,
//         OldestPerson = g.OrderByDescending(x => x.person.Age).First().person.FullName,
//         Age = g.OrderByDescending(x => x.person.Age).First().person.Age
//     });
//
// foreach (var city in oldestPersonInEachCity)
// {
//     Console.WriteLine(city.CityName +  " " + city.OldestPerson +  " " + city.Age);
// }
//


// Task - 8

// int cityNameLength = Convert.ToInt32(Console.ReadLine());
//
// var peopleInCitiesWithNameLength =
//     from person in people
//     join city in cities on person.CityId equals city.Id
//     where city.Name.Length == cityNameLength
//     select new
//     {
//         PersonName = person.FullName,
//         Age = person.Age,
//         CityName = city.Name
//     };
//
// if (peopleInCitiesWithNameLength.Any())
// {
//     foreach (var item in peopleInCitiesWithNameLength)
//     {
//         Console.WriteLine($"{item.PersonName} ({item.Age}) - {item.CityName}");
//     }
// }
// else
// {
//     Console.WriteLine("No people found!");
// }




// Task - 9

// var result =
//     from person in people
//     join city in cities on person.CityId equals city.Id
//     join country in countries on city.CountryId equals country.Id
//     group new {person, city, country} by new {country.Id, country.Name } into g
//     select new
//     {
//         CountryName = g.Key.Name,
//         YoungestPerson = g.OrderBy(x => x.person.Age).First().person.FullName,
//         Age =  g.OrderBy(x => x.person.Age).First().person.Age
//     };
//
// Console.WriteLine("----------Youngest People in each Country-------------");
//
// foreach (var item in result)
// {
//     Console.WriteLine($"{item.CountryName}: {item.YoungestPerson} ({item.Age})");
// }
//
// Console.WriteLine("-------------------------------------------------------");
//
//



// Task - 10

int diapasonFrom = Convert.ToInt32(Console.ReadLine());
int diapasonTill = Convert.ToInt32(Console.ReadLine());

var result =
    from city in cities
    join person in people on city.Id equals person.CityId
    where person.Age > diapasonFrom && person.Age < diapasonTill
    select new
    {
        CityName = city.Name,
        Person = person
    };

foreach (var item in result)
{
    Console.WriteLine(item.CityName);
}

