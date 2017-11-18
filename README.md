# nested-dictionary
C# library for easy use of nested dictionaries.

## Install
* Use a [NuGet](https://www.nuget.org/packages/NestedDictionaryLib) package
* Or use the code in this repository

## Example
```cs
// Initialize
NestedDictionary<string, int, bool, decimal> dictionary = new NestedDictionary<string, int, bool, decimal>()
{
    { "Oslo", 2007, true, 12m },
    { "Oslo", 2007, false, 10m },
    { "Oslo", 2008, true, 5m },
    { "Oslo", 2009, true, 6m },
    { "Boston", 2006, false, 5m },
    { "Boston", 2006, true, 6m },
};

// Insert value
dictionary["York"][2006][true] = 98m;

// Get value
decimal value = dictionary["Boston"][2006][false];

// Try get value
if (dictionary.TryGetValue("Boston", 2006, true, out decimal value2))
    Console.WriteLine("Value is " + value2);

// Get intermediate level
NestedDictionary<int, bool, decimal> osloDicionary = dictionary["Oslo"];

// Remove value
dictionary.Remove("Oslo", 2007, true);

// Remove intermediate level
dictionary.Remove("Oslo", 2009);
```
There is also a possibility to use ToNestedDictionary extension: 
```cs
// Example class
public class Place
{
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int Number { get; set; }

    public Place(string country, string city, string street, int number)
    {
        Country = country;
        City = city;
        Street = street;
        Number = number;
    }
}

// Create list of places
List<Place> places = new List<Place>()
{
    { new Place("USA", "Dallas", "Abrams Road", 234) },
    { new Place("Germany", "Berlin", "Vogel Strase", 111) },
    { new Place("USA", "Washington", "Skillman Street", 43) },
    { new Place("USA", "Washington", "Ranking Avenue", 4553) },
    { new Place("USA", "Phoenix", "Golf Drive", 134) },
    { new Place("USA", "Phoenix", "Gold Drive", 135) },
    { new Place("Canada", "Ottawa", "Daly Avenue", 6743) },
    { new Place("Canada", "Ottawa", "Steward Street", 85) },
    { new Place("Canada", "Gatineau", "George Street", 8125) },
    { new Place("Canada", "Gatineau", "York Street", 903) },
};

// Create a dictionary for the places
NestedDictionary<string, string, string, int, Place> dictionary = places.ToNestedDictionary(x => x.Country, x => x.City, x => x.Street, x => x.Number, x => x);
```
Other examples can be found in [Program.cs](src/ExampleCli/Program.cs)
