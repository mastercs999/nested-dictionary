using NestedDictionaryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCli
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertValue(CreateSampleDictionary());
            GetValue(CreateSampleDictionary());
            AddValue(CreateSampleDictionary());
            ContainsKey(CreateSampleDictionary());
            ContainsValue(CreateSampleDictionary());
            Remove(CreateSampleDictionary());
            TryGetValue(CreateSampleDictionary());
        }

        private static NestedDictionary<string, int, bool, decimal> CreateSampleDictionary() => new NestedDictionary<string, int, bool, decimal>()
        {
            { "Oslo", 2007, true, 12m },
            { "Oslo", 2007, false, 10m },
            { "Oslo", 2008, true, 5m },
            { "Oslo", 2009, true, 6m },
            { "Boston", 2006, false, 5m },
            { "Boston", 2006, true, 6m },
        };
        private static void PrintDictionary(NestedDictionary<string, int, bool, decimal> dictionary)
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, NestedDictionary<int, bool, decimal>> kvp1 in dictionary)
                foreach (KeyValuePair<int, NestedDictionary<bool, decimal>> kvp2 in kvp1.Value)
                    foreach (KeyValuePair<bool, decimal> kvp3 in kvp2.Value)
                        Console.WriteLine($"{kvp1.Key}\t-\t{kvp2.Key}\t-\t{kvp3.Key}\t-\t{kvp3.Value}");
            Console.WriteLine();
        }

        private static void InsertValue(NestedDictionary<string, int, bool, decimal> dictionary)
        {
            Console.WriteLine("---Insert Value---");

            dictionary["York"][2006][true] = 98m;
            dictionary["York"][2009][false] = 14m;

            dictionary["Phoenix"] = new NestedDictionary<int, bool, decimal>()
            {
                { 2008, true, 5m },
                { 2009, true, 5m },
            };

            PrintDictionary(dictionary);
        }
        private static void GetValue(NestedDictionary<string, int, bool, decimal> dictionary)
        {
            Console.WriteLine("---Get Value---");

            Console.WriteLine(dictionary["Oslo"][2007][true]);      // 12m
            Console.WriteLine(dictionary["Boston"][2006][false]);   // 5m

            // Get dictionary with Oslo only
            NestedDictionary<int, bool, decimal> osloDicionary = dictionary["Oslo"];

            // Throws KeyNotFoundException
            try
            {
                decimal value = dictionary["Oslo"][99][false];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            PrintDictionary(dictionary);
        }
        private static void AddValue(NestedDictionary<string, int, bool, decimal> dictionary)
        {
            Console.WriteLine("---Add Value---");

            dictionary.Add("York", 2017, true, 15m);
            dictionary.Add("York", 2016, true, 15m);

            dictionary.Add("Phoenix", 2016, new NestedDictionary<bool, decimal>()
            {
                { false, 12m }
            });

            // Throws argument exception - key already in the dictionary
            try
            {
                dictionary.Add("Phoenix", 2016, false, 10m);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Throws argument exception - key already in the dictionary
            try
            {
                dictionary.Add("York", new NestedDictionary<int, bool, decimal>()
                {
                    { 2011, false, 5m }
                });
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            PrintDictionary(dictionary);
        }
        private static void ContainsKey(NestedDictionary<string, int, bool, decimal> dictionary)
        {
            Console.WriteLine("---Contains Key---");

            Console.WriteLine(dictionary.ContainsKey("Oslo"));                 // True
            Console.WriteLine(dictionary.ContainsKey("Oslo", 2008));           // True
            Console.WriteLine(dictionary.ContainsKey("Boston", 2006, false));  // True
            Console.WriteLine(dictionary.ContainsKey("Boston", 2011, false));  // False

            PrintDictionary(dictionary);
        }
        private static void ContainsValue(NestedDictionary<string, int, bool, decimal> dictionary)
        {
            Console.WriteLine("---Contains Value---");

            Console.WriteLine(dictionary.ContainsValue(12m));    // True
            Console.WriteLine(dictionary.ContainsValue(5m));     // True
            Console.WriteLine(dictionary.ContainsValue(15m));    // False

            PrintDictionary(dictionary);
        }
        private static void Remove(NestedDictionary<string, int, bool, decimal> dictionary)
        {
            Console.WriteLine("---Remove---");

            Console.WriteLine(dictionary.Remove("Oslo", 2009));       // True
            Console.WriteLine(dictionary.ContainsKey("Oslo", 2009));  // False
            Console.WriteLine(dictionary.ContainsKey("Oslo"));        // True

            Console.WriteLine(dictionary.Remove("Oslo", 2007, true)); // True

            Console.WriteLine(dictionary.Remove("Oslo", 2011));       // False

            Console.WriteLine(dictionary.Remove("Boston"));           // True

            PrintDictionary(dictionary);
        }
        private static void TryGetValue(NestedDictionary<string, int, bool, decimal> dictionary)
        {
            Console.WriteLine("---Try Get Value---");

            Console.WriteLine(dictionary.TryGetValue("Oslo", out NestedDictionary<int, bool, decimal> value));       // True
            Console.WriteLine(dictionary.TryGetValue("Boston", 2011, out NestedDictionary<bool, decimal> value2));   // False
            Console.WriteLine(dictionary.TryGetValue("Boston", 2006, true, out decimal value3));                     // True

            PrintDictionary(dictionary);
        }
    }
}
