# nested-dictionary
C# library for easy use of nested dictionaries.

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

Other examples can be found in [Program.cs](src/ExampleCli/Program.cs)
