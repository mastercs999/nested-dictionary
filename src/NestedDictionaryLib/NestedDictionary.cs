using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NestedDictionaryLib
{
    /// <summary>
    /// Represents a collection of keys and values.
    /// </summary>
    /// <typeparam name="TKey1">The type of the key</typeparam>
    /// <typeparam name="TValue">The type of the value</typeparam>
    public class NestedDictionary<TKey1, TValue> : Dictionary<TKey1, TValue>
    {
        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and uses the default equality comparer for the key type.
        /// </summary>
        public NestedDictionary() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the specified initial capacity, and uses the default equality comparer for the key type.
        /// </summary>
        /// <param name="capacity">The initial number of elements that the dictionary can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
        public NestedDictionary(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and uses the specified equality comparer.
        /// </summary>
        /// <param name="comparer">The comparer implementation to use when comparing keys, or null to use the default comparer for the type of the key.</param>
        public NestedDictionary(IEqualityComparer<TKey1> comparer) : base(comparer)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the default equality comparer for the key type.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, TValue> dictionary) : base(dictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the specified initial capacity, and uses the specified comparer.
        /// </summary>
        /// <param name="capacity">The initial number of elements that the dictionary can contain.</param>
        /// <param name="comparer">The comparer implementation to use when comparing keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
        public NestedDictionary(int capacity, IEqualityComparer<TKey1> comparer) : base(capacity, comparer)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the specified comparer.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <param name="comparer">The comparer implementation to use when comparing keys, or null to use the default comparer for the type of the key</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, TValue> dictionary, IEqualityComparer<TKey1> comparer) : base(dictionary, comparer)
        {
        }
    }
    /// <summary>
    /// Represents a collection of keys and values where a key leads through nested dictionary to a value.
    /// </summary>
    /// <typeparam name="TKey1">The type of the 1. key</typeparam>
    /// <typeparam name="TKey2">The type of the 2. key</typeparam>
    /// <typeparam name="TValue">The type of the value</typeparam>
    public class NestedDictionary<TKey1, TKey2, TValue> : NestedDictionary<TKey1, NestedDictionary<TKey2, TValue>>
    {
        private int _capacity2 = 0;

        private IEqualityComparer<TKey2> _comparer2 = null;

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        public NestedDictionary() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">a capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2) : base(capacity1)
        {
            _capacity2 = capacity2;
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and all level dictionaries use the specified equality comparers.
        /// </summary>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        public NestedDictionary(IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2) : base(comparer1)
        {
            _comparer2 = comparer2;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TValue>> dictionary) : base(dictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity and use the specified comparer.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2) : base(capacity1, comparer1)
        {
            _capacity2 = capacity2;

            _comparer2 = comparer2;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the specified comparer.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TValue>> dictionary, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2) : base(dictionary, comparer1)
        {
            _comparer2 = comparer2;
        }




        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key1">The key of the value to get or set</param>
        /// <returns>The value associated with the specified key. If the specified key is not found and the key leads to a value, a get operation 
        /// throws a System.Collections.Generic.KeyNotFoundException. If the specified key is not found and the key leads to another nested dictionary (goes deeper),
        /// the nested dictionary is created. Set operation creates a new element with the specified key.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and key does not exist in the lowest level of the collection</exception>
        public new NestedDictionary<TKey2, TValue> this[TKey1 key1]
        {
            get => TryGetValue(key1, out NestedDictionary<TKey2, TValue> dict) ? dict : base[key1] = new NestedDictionary<TKey2, TValue>(_capacity2, _comparer2);
            set => base[key1] = value;
        }

        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 2. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey2> Comparer2 => _comparer2;




        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="value">The value of the element to add. The value can be null for reference types.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TValue value)
        {
            this[key1].Add(key2, value);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TValue> dict) && dict.ContainsKey(key2);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the nested dictionary. The value can be null for reference types.</param>
        /// <returns>True if the nested dictionary contains an element with the specified value; otherwise, false.</returns>
        public bool ContainsValue(TValue value)
        {
            foreach (NestedDictionary<TKey2, TValue> dict in Values)
                if (dict.ContainsValue(value))
                    return true;

            return false;
        }




        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TValue> dict))
                return dict.Remove(key2);

            return false;
        }




        /// <summary>
        /// Gets the value associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, out TValue value)
        {
            value = default(TValue);
            return TryGetValue(key1, out NestedDictionary<TKey2, TValue> dict) && dict.TryGetValue(key2, out value);
        }
    }
    /// <summary>
    /// Represents a collection of keys and values where a key leads through nested dictionary to a value.
    /// </summary>
    /// <typeparam name="TKey1">The type of the 1. key</typeparam>
    /// <typeparam name="TKey2">The type of the 2. key</typeparam>
    /// <typeparam name="TKey3">The type of the 3. key</typeparam>
    /// <typeparam name="TValue">The type of the value</typeparam>
    public class NestedDictionary<TKey1, TKey2, TKey3, TValue> : NestedDictionary<TKey1, NestedDictionary<TKey2, TKey3, TValue>>
    {
        private int _capacity2 = 0;
        private int _capacity3 = 0;

        private IEqualityComparer<TKey2> _comparer2 = null;
        private IEqualityComparer<TKey3> _comparer3 = null;

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        public NestedDictionary() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">a capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3) : base(capacity1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and all level dictionaries use the specified equality comparers.
        /// </summary>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        public NestedDictionary(IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3) : base(comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TValue>> dictionary) : base(dictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity and use the specified comparer.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3) : base(capacity1, comparer1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;

            _comparer2 = comparer2;
            _comparer3 = comparer3;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the specified comparer.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TValue>> dictionary, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3) : base(dictionary, comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
        }




        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key1">The key of the value to get or set</param>
        /// <returns>The value associated with the specified key. If the specified key is not found and the key leads to a value, a get operation 
        /// throws a System.Collections.Generic.KeyNotFoundException. If the specified key is not found and the key leads to another nested dictionary (goes deeper),
        /// the nested dictionary is created. Set operation creates a new element with the specified key.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and key does not exist in the lowest level of the collection</exception>
        public new NestedDictionary<TKey2, TKey3, TValue> this[TKey1 key1]
        {
            get => TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TValue> dict) ? dict : base[key1] = new NestedDictionary<TKey2, TKey3, TValue>(_capacity2, _capacity3, _comparer2, _comparer3);
            set => base[key1] = value;
        }

        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 2. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey2> Comparer2 => _comparer2;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 3. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey3> Comparer3 => _comparer3;




        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="value">The value of the element to add. The value can be null for reference types.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TValue value)
        {
            this[key1].Add(key2, key3, value);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="dict">The dictionary for 3. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, NestedDictionary<TKey3, TValue> dict)
        {
            this[key1].Add(key2, dict);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TValue> dict) && dict.ContainsKey(key2, key3);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TValue> dict) && dict.ContainsKey(key2);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the nested dictionary. The value can be null for reference types.</param>
        /// <returns>True if the nested dictionary contains an element with the specified value; otherwise, false.</returns>
        public bool ContainsValue(TValue value)
        {
            foreach (NestedDictionary<TKey2, TKey3, TValue> dict in Values)
                if (dict.ContainsValue(value))
                    return true;

            return false;
        }




        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TValue> dict))
                return dict.Remove(key2, key3);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TValue> dict))
                return dict.Remove(key2);

            return false;
        }




        /// <summary>
        /// Gets the value associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, out TValue value)
        {
            value = default(TValue);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TValue> dict) && dict.TryGetValue(key2, key3, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, out NestedDictionary<TKey3, TValue> value)
        {
            value = default(NestedDictionary<TKey3, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TValue> dict) && dict.TryGetValue(key2, out value);
        }
    }
    /// <summary>
    /// Represents a collection of keys and values where a key leads through nested dictionary to a value.
    /// </summary>
    /// <typeparam name="TKey1">The type of the 1. key</typeparam>
    /// <typeparam name="TKey2">The type of the 2. key</typeparam>
    /// <typeparam name="TKey3">The type of the 3. key</typeparam>
    /// <typeparam name="TKey4">The type of the 4. key</typeparam>
    /// <typeparam name="TValue">The type of the value</typeparam>
    public class NestedDictionary<TKey1, TKey2, TKey3, TKey4, TValue> : NestedDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TValue>>
    {
        private int _capacity2 = 0;
        private int _capacity3 = 0;
        private int _capacity4 = 0;

        private IEqualityComparer<TKey2> _comparer2 = null;
        private IEqualityComparer<TKey3> _comparer3 = null;
        private IEqualityComparer<TKey4> _comparer4 = null;

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        public NestedDictionary() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">a capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4) : base(capacity1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and all level dictionaries use the specified equality comparers.
        /// </summary>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        public NestedDictionary(IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4) : base(comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TValue>> dictionary) : base(dictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity and use the specified comparer.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4) : base(capacity1, comparer1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;

            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the specified comparer.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TValue>> dictionary, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4) : base(dictionary, comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
        }




        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key1">The key of the value to get or set</param>
        /// <returns>The value associated with the specified key. If the specified key is not found and the key leads to a value, a get operation 
        /// throws a System.Collections.Generic.KeyNotFoundException. If the specified key is not found and the key leads to another nested dictionary (goes deeper),
        /// the nested dictionary is created. Set operation creates a new element with the specified key.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and key does not exist in the lowest level of the collection</exception>
        public new NestedDictionary<TKey2, TKey3, TKey4, TValue> this[TKey1 key1]
        {
            get => TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict) ? dict : base[key1] = new NestedDictionary<TKey2, TKey3, TKey4, TValue>(_capacity2, _capacity3, _capacity4, _comparer2, _comparer3, _comparer4);
            set => base[key1] = value;
        }

        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 2. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey2> Comparer2 => _comparer2;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 3. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey3> Comparer3 => _comparer3;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 4. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey4> Comparer4 => _comparer4;




        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="value">The value of the element to add. The value can be null for reference types.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TValue value)
        {
            this[key1].Add(key2, key3, key4, value);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="dict">The dictionary for 4. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, NestedDictionary<TKey4, TValue> dict)
        {
            this[key1].Add(key2, key3, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="dict">The dictionary for 3. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, NestedDictionary<TKey3, TKey4, TValue> dict)
        {
            this[key1].Add(key2, dict);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict) && dict.ContainsKey(key2, key3, key4);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict) && dict.ContainsKey(key2, key3);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict) && dict.ContainsKey(key2);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the nested dictionary. The value can be null for reference types.</param>
        /// <returns>True if the nested dictionary contains an element with the specified value; otherwise, false.</returns>
        public bool ContainsValue(TValue value)
        {
            foreach (NestedDictionary<TKey2, TKey3, TKey4, TValue> dict in Values)
                if (dict.ContainsValue(value))
                    return true;

            return false;
        }




        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict))
                return dict.Remove(key2, key3, key4);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict))
                return dict.Remove(key2, key3);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict))
                return dict.Remove(key2);

            return false;
        }




        /// <summary>
        /// Gets the value associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, out TValue value)
        {
            value = default(TValue);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict) && dict.TryGetValue(key2, key3, key4, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, out NestedDictionary<TKey4, TValue> value)
        {
            value = default(NestedDictionary<TKey4, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict) && dict.TryGetValue(key2, key3, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, out NestedDictionary<TKey3, TKey4, TValue> value)
        {
            value = default(NestedDictionary<TKey3, TKey4, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TValue> dict) && dict.TryGetValue(key2, out value);
        }
    }
    /// <summary>
    /// Represents a collection of keys and values where a key leads through nested dictionary to a value.
    /// </summary>
    /// <typeparam name="TKey1">The type of the 1. key</typeparam>
    /// <typeparam name="TKey2">The type of the 2. key</typeparam>
    /// <typeparam name="TKey3">The type of the 3. key</typeparam>
    /// <typeparam name="TKey4">The type of the 4. key</typeparam>
    /// <typeparam name="TKey5">The type of the 5. key</typeparam>
    /// <typeparam name="TValue">The type of the value</typeparam>
    public class NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TValue> : NestedDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue>>
    {
        private int _capacity2 = 0;
        private int _capacity3 = 0;
        private int _capacity4 = 0;
        private int _capacity5 = 0;

        private IEqualityComparer<TKey2> _comparer2 = null;
        private IEqualityComparer<TKey3> _comparer3 = null;
        private IEqualityComparer<TKey4> _comparer4 = null;
        private IEqualityComparer<TKey5> _comparer5 = null;

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        public NestedDictionary() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <param name="capacity5">The initial number of elements that the 5. level dictionary can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">a capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4, int capacity5) : base(capacity1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;
            _capacity5 = capacity5;
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and all level dictionaries use the specified equality comparers.
        /// </summary>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        public NestedDictionary(IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5) : base(comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue>> dictionary) : base(dictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity and use the specified comparer.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <param name="capacity5">The initial number of elements that the 5. level dictionary can contain.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4, int capacity5, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5) : base(capacity1, comparer1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;
            _capacity5 = capacity5;

            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the specified comparer.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue>> dictionary, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5) : base(dictionary, comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
        }




        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key1">The key of the value to get or set</param>
        /// <returns>The value associated with the specified key. If the specified key is not found and the key leads to a value, a get operation 
        /// throws a System.Collections.Generic.KeyNotFoundException. If the specified key is not found and the key leads to another nested dictionary (goes deeper),
        /// the nested dictionary is created. Set operation creates a new element with the specified key.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and key does not exist in the lowest level of the collection</exception>
        public new NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> this[TKey1 key1]
        {
            get => TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict) ? dict : base[key1] = new NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue>(_capacity2, _capacity3, _capacity4, _capacity5, _comparer2, _comparer3, _comparer4, _comparer5);
            set => base[key1] = value;
        }

        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 2. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey2> Comparer2 => _comparer2;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 3. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey3> Comparer3 => _comparer3;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 4. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey4> Comparer4 => _comparer4;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 5. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey5> Comparer5 => _comparer5;




        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="value">The value of the element to add. The value can be null for reference types.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TValue value)
        {
            this[key1].Add(key2, key3, key4, key5, value);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="dict">The dictionary for 5. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, NestedDictionary<TKey5, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="dict">The dictionary for 4. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, NestedDictionary<TKey4, TKey5, TValue> dict)
        {
            this[key1].Add(key2, key3, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="dict">The dictionary for 3. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, NestedDictionary<TKey3, TKey4, TKey5, TValue> dict)
        {
            this[key1].Add(key2, dict);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict) && dict.ContainsKey(key2, key3, key4);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict) && dict.ContainsKey(key2, key3);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict) && dict.ContainsKey(key2);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the nested dictionary. The value can be null for reference types.</param>
        /// <returns>True if the nested dictionary contains an element with the specified value; otherwise, false.</returns>
        public bool ContainsValue(TValue value)
        {
            foreach (NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict in Values)
                if (dict.ContainsValue(value))
                    return true;

            return false;
        }




        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict))
                return dict.Remove(key2, key3, key4, key5);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict))
                return dict.Remove(key2, key3, key4);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict))
                return dict.Remove(key2, key3);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict))
                return dict.Remove(key2);

            return false;
        }




        /// <summary>
        /// Gets the value associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, out TValue value)
        {
            value = default(TValue);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, out NestedDictionary<TKey5, TValue> value)
        {
            value = default(NestedDictionary<TKey5, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict) && dict.TryGetValue(key2, key3, key4, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, out NestedDictionary<TKey4, TKey5, TValue> value)
        {
            value = default(NestedDictionary<TKey4, TKey5, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict) && dict.TryGetValue(key2, key3, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, out NestedDictionary<TKey3, TKey4, TKey5, TValue> value)
        {
            value = default(NestedDictionary<TKey3, TKey4, TKey5, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TValue> dict) && dict.TryGetValue(key2, out value);
        }
    }
    /// <summary>
    /// Represents a collection of keys and values where a key leads through nested dictionary to a value.
    /// </summary>
    /// <typeparam name="TKey1">The type of the 1. key</typeparam>
    /// <typeparam name="TKey2">The type of the 2. key</typeparam>
    /// <typeparam name="TKey3">The type of the 3. key</typeparam>
    /// <typeparam name="TKey4">The type of the 4. key</typeparam>
    /// <typeparam name="TKey5">The type of the 5. key</typeparam>
    /// <typeparam name="TKey6">The type of the 6. key</typeparam>
    /// <typeparam name="TValue">The type of the value</typeparam>
    public class NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TValue> : NestedDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue>>
    {
        private int _capacity2 = 0;
        private int _capacity3 = 0;
        private int _capacity4 = 0;
        private int _capacity5 = 0;
        private int _capacity6 = 0;

        private IEqualityComparer<TKey2> _comparer2 = null;
        private IEqualityComparer<TKey3> _comparer3 = null;
        private IEqualityComparer<TKey4> _comparer4 = null;
        private IEqualityComparer<TKey5> _comparer5 = null;
        private IEqualityComparer<TKey6> _comparer6 = null;

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        public NestedDictionary() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <param name="capacity5">The initial number of elements that the 5. level dictionary can contain.</param>
        /// <param name="capacity6">The initial number of elements that the 6. level dictionary can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">a capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4, int capacity5, int capacity6) : base(capacity1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;
            _capacity5 = capacity5;
            _capacity6 = capacity6;
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and all level dictionaries use the specified equality comparers.
        /// </summary>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer6">The comparer implementation to use when comparing 6. level keys, or null to use the default comparer for the type of the key.</param>
        public NestedDictionary(IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6) : base(comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
            _comparer6 = comparer6;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue>> dictionary) : base(dictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity and use the specified comparer.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <param name="capacity5">The initial number of elements that the 5. level dictionary can contain.</param>
        /// <param name="capacity6">The initial number of elements that the 6. level dictionary can contain.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer6">The comparer implementation to use when comparing 6. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4, int capacity5, int capacity6, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6) : base(capacity1, comparer1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;
            _capacity5 = capacity5;
            _capacity6 = capacity6;

            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
            _comparer6 = comparer6;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the specified comparer.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer6">The comparer implementation to use when comparing 6. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue>> dictionary, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6) : base(dictionary, comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
            _comparer6 = comparer6;
        }




        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key1">The key of the value to get or set</param>
        /// <returns>The value associated with the specified key. If the specified key is not found and the key leads to a value, a get operation 
        /// throws a System.Collections.Generic.KeyNotFoundException. If the specified key is not found and the key leads to another nested dictionary (goes deeper),
        /// the nested dictionary is created. Set operation creates a new element with the specified key.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and key does not exist in the lowest level of the collection</exception>
        public new NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> this[TKey1 key1]
        {
            get => TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) ? dict : base[key1] = new NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue>(_capacity2, _capacity3, _capacity4, _capacity5, _capacity6, _comparer2, _comparer3, _comparer4, _comparer5, _comparer6);
            set => base[key1] = value;
        }

        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 2. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey2> Comparer2 => _comparer2;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 3. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey3> Comparer3 => _comparer3;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 4. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey4> Comparer4 => _comparer4;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 5. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey5> Comparer5 => _comparer5;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 6. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey6> Comparer6 => _comparer6;




        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="key6">The key of the element to add for 6. level.</param>
        /// <param name="value">The value of the element to add. The value can be null for reference types.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TValue value)
        {
            this[key1].Add(key2, key3, key4, key5, key6, value);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="dict">The dictionary for 6. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, NestedDictionary<TKey6, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, key5, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="dict">The dictionary for 5. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, NestedDictionary<TKey5, TKey6, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="dict">The dictionary for 4. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, NestedDictionary<TKey4, TKey5, TKey6, TValue> dict)
        {
            this[key1].Add(key2, key3, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="dict">The dictionary for 3. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, NestedDictionary<TKey3, TKey4, TKey5, TKey6, TValue> dict)
        {
            this[key1].Add(key2, dict);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <param name="key6">The key to locate for 6. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5, key6);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.ContainsKey(key2, key3, key4);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.ContainsKey(key2, key3);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.ContainsKey(key2);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the nested dictionary. The value can be null for reference types.</param>
        /// <returns>True if the nested dictionary contains an element with the specified value; otherwise, false.</returns>
        public bool ContainsValue(TValue value)
        {
            foreach (NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict in Values)
                if (dict.ContainsValue(value))
                    return true;

            return false;
        }




        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <param name="key6">The key for 6. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict))
                return dict.Remove(key2, key3, key4, key5, key6);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict))
                return dict.Remove(key2, key3, key4, key5);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict))
                return dict.Remove(key2, key3, key4);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict))
                return dict.Remove(key2, key3);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict))
                return dict.Remove(key2);

            return false;
        }




        /// <summary>
        /// Gets the value associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="key6">The key of the value to get 6. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, out TValue value)
        {
            value = default(TValue);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, key6, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, out NestedDictionary<TKey6, TValue> value)
        {
            value = default(NestedDictionary<TKey6, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, out NestedDictionary<TKey5, TKey6, TValue> value)
        {
            value = default(NestedDictionary<TKey5, TKey6, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.TryGetValue(key2, key3, key4, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, out NestedDictionary<TKey4, TKey5, TKey6, TValue> value)
        {
            value = default(NestedDictionary<TKey4, TKey5, TKey6, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.TryGetValue(key2, key3, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, out NestedDictionary<TKey3, TKey4, TKey5, TKey6, TValue> value)
        {
            value = default(NestedDictionary<TKey3, TKey4, TKey5, TKey6, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue> dict) && dict.TryGetValue(key2, out value);
        }
    }
    /// <summary>
    /// Represents a collection of keys and values where a key leads through nested dictionary to a value.
    /// </summary>
    /// <typeparam name="TKey1">The type of the 1. key</typeparam>
    /// <typeparam name="TKey2">The type of the 2. key</typeparam>
    /// <typeparam name="TKey3">The type of the 3. key</typeparam>
    /// <typeparam name="TKey4">The type of the 4. key</typeparam>
    /// <typeparam name="TKey5">The type of the 5. key</typeparam>
    /// <typeparam name="TKey6">The type of the 6. key</typeparam>
    /// <typeparam name="TKey7">The type of the 7. key</typeparam>
    /// <typeparam name="TValue">The type of the value</typeparam>
    public class NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> : NestedDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue>>
    {
        private int _capacity2 = 0;
        private int _capacity3 = 0;
        private int _capacity4 = 0;
        private int _capacity5 = 0;
        private int _capacity6 = 0;
        private int _capacity7 = 0;

        private IEqualityComparer<TKey2> _comparer2 = null;
        private IEqualityComparer<TKey3> _comparer3 = null;
        private IEqualityComparer<TKey4> _comparer4 = null;
        private IEqualityComparer<TKey5> _comparer5 = null;
        private IEqualityComparer<TKey6> _comparer6 = null;
        private IEqualityComparer<TKey7> _comparer7 = null;

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        public NestedDictionary() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <param name="capacity5">The initial number of elements that the 5. level dictionary can contain.</param>
        /// <param name="capacity6">The initial number of elements that the 6. level dictionary can contain.</param>
        /// <param name="capacity7">The initial number of elements that the 7. level dictionary can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">a capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4, int capacity5, int capacity6, int capacity7) : base(capacity1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;
            _capacity5 = capacity5;
            _capacity6 = capacity6;
            _capacity7 = capacity7;
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and all level dictionaries use the specified equality comparers.
        /// </summary>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer6">The comparer implementation to use when comparing 6. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer7">The comparer implementation to use when comparing 7. level keys, or null to use the default comparer for the type of the key.</param>
        public NestedDictionary(IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6, IEqualityComparer<TKey7> comparer7) : base(comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
            _comparer6 = comparer6;
            _comparer7 = comparer7;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue>> dictionary) : base(dictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity and use the specified comparer.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <param name="capacity5">The initial number of elements that the 5. level dictionary can contain.</param>
        /// <param name="capacity6">The initial number of elements that the 6. level dictionary can contain.</param>
        /// <param name="capacity7">The initial number of elements that the 7. level dictionary can contain.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer6">The comparer implementation to use when comparing 6. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer7">The comparer implementation to use when comparing 7. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4, int capacity5, int capacity6, int capacity7, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6, IEqualityComparer<TKey7> comparer7) : base(capacity1, comparer1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;
            _capacity5 = capacity5;
            _capacity6 = capacity6;
            _capacity7 = capacity7;

            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
            _comparer6 = comparer6;
            _comparer7 = comparer7;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the specified comparer.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer6">The comparer implementation to use when comparing 6. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer7">The comparer implementation to use when comparing 7. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue>> dictionary, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6, IEqualityComparer<TKey7> comparer7) : base(dictionary, comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
            _comparer6 = comparer6;
            _comparer7 = comparer7;
        }




        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key1">The key of the value to get or set</param>
        /// <returns>The value associated with the specified key. If the specified key is not found and the key leads to a value, a get operation 
        /// throws a System.Collections.Generic.KeyNotFoundException. If the specified key is not found and the key leads to another nested dictionary (goes deeper),
        /// the nested dictionary is created. Set operation creates a new element with the specified key.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and key does not exist in the lowest level of the collection</exception>
        public new NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> this[TKey1 key1]
        {
            get => TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) ? dict : base[key1] = new NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue>(_capacity2, _capacity3, _capacity4, _capacity5, _capacity6, _capacity7, _comparer2, _comparer3, _comparer4, _comparer5, _comparer6, _comparer7);
            set => base[key1] = value;
        }

        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 2. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey2> Comparer2 => _comparer2;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 3. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey3> Comparer3 => _comparer3;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 4. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey4> Comparer4 => _comparer4;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 5. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey5> Comparer5 => _comparer5;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 6. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey6> Comparer6 => _comparer6;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 7. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey7> Comparer7 => _comparer7;




        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="key6">The key of the element to add for 6. level.</param>
        /// <param name="key7">The key of the element to add for 7. level.</param>
        /// <param name="value">The value of the element to add. The value can be null for reference types.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7, TValue value)
        {
            this[key1].Add(key2, key3, key4, key5, key6, key7, value);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="key6">The key of the element to add for 6. level.</param>
        /// <param name="dict">The dictionary for 7. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, NestedDictionary<TKey7, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, key5, key6, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="dict">The dictionary for 6. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, NestedDictionary<TKey6, TKey7, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, key5, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="dict">The dictionary for 5. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, NestedDictionary<TKey5, TKey6, TKey7, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="dict">The dictionary for 4. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, NestedDictionary<TKey4, TKey5, TKey6, TKey7, TValue> dict)
        {
            this[key1].Add(key2, key3, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="dict">The dictionary for 3. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, NestedDictionary<TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict)
        {
            this[key1].Add(key2, dict);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <param name="key6">The key to locate for 6. level.</param>
        /// <param name="key7">The key to locate for 7. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5, key6, key7);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <param name="key6">The key to locate for 6. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5, key6);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.ContainsKey(key2, key3, key4);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.ContainsKey(key2, key3);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.ContainsKey(key2);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the nested dictionary. The value can be null for reference types.</param>
        /// <returns>True if the nested dictionary contains an element with the specified value; otherwise, false.</returns>
        public bool ContainsValue(TValue value)
        {
            foreach (NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict in Values)
                if (dict.ContainsValue(value))
                    return true;

            return false;
        }




        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <param name="key6">The key for 6. level.</param>
        /// <param name="key7">The key for 7. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict))
                return dict.Remove(key2, key3, key4, key5, key6, key7);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <param name="key6">The key for 6. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict))
                return dict.Remove(key2, key3, key4, key5, key6);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict))
                return dict.Remove(key2, key3, key4, key5);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict))
                return dict.Remove(key2, key3, key4);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict))
                return dict.Remove(key2, key3);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict))
                return dict.Remove(key2);

            return false;
        }




        /// <summary>
        /// Gets the value associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="key6">The key of the value to get 6. level.</param>
        /// <param name="key7">The key of the value to get 7. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7, out TValue value)
        {
            value = default(TValue);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, key6, key7, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="key6">The key of the value to get 6. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, out NestedDictionary<TKey7, TValue> value)
        {
            value = default(NestedDictionary<TKey7, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, key6, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, out NestedDictionary<TKey6, TKey7, TValue> value)
        {
            value = default(NestedDictionary<TKey6, TKey7, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, out NestedDictionary<TKey5, TKey6, TKey7, TValue> value)
        {
            value = default(NestedDictionary<TKey5, TKey6, TKey7, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.TryGetValue(key2, key3, key4, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, out NestedDictionary<TKey4, TKey5, TKey6, TKey7, TValue> value)
        {
            value = default(NestedDictionary<TKey4, TKey5, TKey6, TKey7, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.TryGetValue(key2, key3, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, out NestedDictionary<TKey3, TKey4, TKey5, TKey6, TKey7, TValue> value)
        {
            value = default(NestedDictionary<TKey3, TKey4, TKey5, TKey6, TKey7, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> dict) && dict.TryGetValue(key2, out value);
        }
    }
    /// <summary>
    /// Represents a collection of keys and values where a key leads through nested dictionary to a value.
    /// </summary>
    /// <typeparam name="TKey1">The type of the 1. key</typeparam>
    /// <typeparam name="TKey2">The type of the 2. key</typeparam>
    /// <typeparam name="TKey3">The type of the 3. key</typeparam>
    /// <typeparam name="TKey4">The type of the 4. key</typeparam>
    /// <typeparam name="TKey5">The type of the 5. key</typeparam>
    /// <typeparam name="TKey6">The type of the 6. key</typeparam>
    /// <typeparam name="TKey7">The type of the 7. key</typeparam>
    /// <typeparam name="TKey8">The type of the 8. key</typeparam>
    /// <typeparam name="TValue">The type of the value</typeparam>
    public class NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> : NestedDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue>>
    {
        private int _capacity2 = 0;
        private int _capacity3 = 0;
        private int _capacity4 = 0;
        private int _capacity5 = 0;
        private int _capacity6 = 0;
        private int _capacity7 = 0;
        private int _capacity8 = 0;

        private IEqualityComparer<TKey2> _comparer2 = null;
        private IEqualityComparer<TKey3> _comparer3 = null;
        private IEqualityComparer<TKey4> _comparer4 = null;
        private IEqualityComparer<TKey5> _comparer5 = null;
        private IEqualityComparer<TKey6> _comparer6 = null;
        private IEqualityComparer<TKey7> _comparer7 = null;
        private IEqualityComparer<TKey8> _comparer8 = null;

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        public NestedDictionary() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity, and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <param name="capacity5">The initial number of elements that the 5. level dictionary can contain.</param>
        /// <param name="capacity6">The initial number of elements that the 6. level dictionary can contain.</param>
        /// <param name="capacity7">The initial number of elements that the 7. level dictionary can contain.</param>
        /// <param name="capacity8">The initial number of elements that the 8. level dictionary can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">a capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4, int capacity5, int capacity6, int capacity7, int capacity8) : base(capacity1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;
            _capacity5 = capacity5;
            _capacity6 = capacity6;
            _capacity7 = capacity7;
            _capacity8 = capacity8;
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, has the default initial capacity, and all level dictionaries use the specified equality comparers.
        /// </summary>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer6">The comparer implementation to use when comparing 6. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer7">The comparer implementation to use when comparing 7. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer8">The comparer implementation to use when comparing 8. level keys, or null to use the default comparer for the type of the key.</param>
        public NestedDictionary(IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6, IEqualityComparer<TKey7> comparer7, IEqualityComparer<TKey8> comparer8) : base(comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
            _comparer6 = comparer6;
            _comparer7 = comparer7;
            _comparer8 = comparer8;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the default equality comparer for the key types.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue>> dictionary) : base(dictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of this class that is empty, all level dictionaries have the specified initial capacity and use the specified comparer.
        /// </summary>
        /// <param name="capacity1">The initial number of elements that the 1. level dictionary can contain.</param>
        /// <param name="capacity2">The initial number of elements that the 2. level dictionary can contain.</param>
        /// <param name="capacity3">The initial number of elements that the 3. level dictionary can contain.</param>
        /// <param name="capacity4">The initial number of elements that the 4. level dictionary can contain.</param>
        /// <param name="capacity5">The initial number of elements that the 5. level dictionary can contain.</param>
        /// <param name="capacity6">The initial number of elements that the 6. level dictionary can contain.</param>
        /// <param name="capacity7">The initial number of elements that the 7. level dictionary can contain.</param>
        /// <param name="capacity8">The initial number of elements that the 8. level dictionary can contain.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer6">The comparer implementation to use when comparing 6. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer7">The comparer implementation to use when comparing 7. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer8">The comparer implementation to use when comparing 8. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
        public NestedDictionary(int capacity1, int capacity2, int capacity3, int capacity4, int capacity5, int capacity6, int capacity7, int capacity8, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6, IEqualityComparer<TKey7> comparer7, IEqualityComparer<TKey8> comparer8) : base(capacity1, comparer1)
        {
            _capacity2 = capacity2;
            _capacity3 = capacity3;
            _capacity4 = capacity4;
            _capacity5 = capacity5;
            _capacity6 = capacity6;
            _capacity7 = capacity7;
            _capacity8 = capacity8;

            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
            _comparer6 = comparer6;
            _comparer7 = comparer7;
            _comparer8 = comparer8;
        }

        /// <summary>
        /// Initializes a new instance of this class that contains elements copied from the specified dictionary and uses the specified comparer.
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new dictionary.</param>
        /// <param name="comparer1">The comparer implementation to use when comparing 1. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer2">The comparer implementation to use when comparing 2. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer3">The comparer implementation to use when comparing 3. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer4">The comparer implementation to use when comparing 4. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer5">The comparer implementation to use when comparing 5. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer6">The comparer implementation to use when comparing 6. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer7">The comparer implementation to use when comparing 7. level keys, or null to use the default comparer for the type of the key.</param>
        /// <param name="comparer8">The comparer implementation to use when comparing 8. level keys, or null to use the default comparer for the type of the key.</param>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        /// <exception cref="ArgumentException">dictionary contains one or more duplicate keys</exception>
        public NestedDictionary(IDictionary<TKey1, NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue>> dictionary, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6, IEqualityComparer<TKey7> comparer7, IEqualityComparer<TKey8> comparer8) : base(dictionary, comparer1)
        {
            _comparer2 = comparer2;
            _comparer3 = comparer3;
            _comparer4 = comparer4;
            _comparer5 = comparer5;
            _comparer6 = comparer6;
            _comparer7 = comparer7;
            _comparer8 = comparer8;
        }




        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key1">The key of the value to get or set</param>
        /// <returns>The value associated with the specified key. If the specified key is not found and the key leads to a value, a get operation 
        /// throws a System.Collections.Generic.KeyNotFoundException. If the specified key is not found and the key leads to another nested dictionary (goes deeper),
        /// the nested dictionary is created. Set operation creates a new element with the specified key.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and key does not exist in the lowest level of the collection</exception>
        public new NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> this[TKey1 key1]
        {
            get => TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) ? dict : base[key1] = new NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue>(_capacity2, _capacity3, _capacity4, _capacity5, _capacity6, _capacity7, _capacity8, _comparer2, _comparer3, _comparer4, _comparer5, _comparer6, _comparer7, _comparer8);
            set => base[key1] = value;
        }

        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 2. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey2> Comparer2 => _comparer2;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 3. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey3> Comparer3 => _comparer3;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 4. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey4> Comparer4 => _comparer4;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 5. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey5> Comparer5 => _comparer5;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 6. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey6> Comparer6 => _comparer6;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 7. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey7> Comparer7 => _comparer7;
        /// <summary>
        /// Gets the comparer that is used to determine equality of keys for the 8. level of the dictionary.
        /// </summary>
        public IEqualityComparer<TKey8> Comparer8 => _comparer8;




        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="key6">The key of the element to add for 6. level.</param>
        /// <param name="key7">The key of the element to add for 7. level.</param>
        /// <param name="key8">The key of the element to add for 8. level.</param>
        /// <param name="value">The value of the element to add. The value can be null for reference types.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7, TKey8 key8, TValue value)
        {
            this[key1].Add(key2, key3, key4, key5, key6, key7, key8, value);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="key6">The key of the element to add for 6. level.</param>
        /// <param name="key7">The key of the element to add for 7. level.</param>
        /// <param name="dict">The dictionary for 8. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7, NestedDictionary<TKey8, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, key5, key6, key7, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="key6">The key of the element to add for 6. level.</param>
        /// <param name="dict">The dictionary for 7. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, NestedDictionary<TKey7, TKey8, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, key5, key6, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="key5">The key of the element to add for 5. level.</param>
        /// <param name="dict">The dictionary for 6. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, NestedDictionary<TKey6, TKey7, TKey8, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, key5, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="key4">The key of the element to add for 4. level.</param>
        /// <param name="dict">The dictionary for 5. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, NestedDictionary<TKey5, TKey6, TKey7, TKey8, TValue> dict)
        {
            this[key1].Add(key2, key3, key4, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="key3">The key of the element to add for 3. level.</param>
        /// <param name="dict">The dictionary for 4. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, TKey3 key3, NestedDictionary<TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict)
        {
            this[key1].Add(key2, key3, dict);
        }

        /// <summary>
        /// Adds the specified keys and value to the dictionaries.
        /// </summary>
        /// <param name="key1">The key of the element to add for 1. level.</param>
        /// <param name="key2">The key of the element to add for 2. level.</param>
        /// <param name="dict">The dictionary for 3. level.</param>
        /// <exception cref="ArgumentNullException">A key is null</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary</exception>
        public void Add(TKey1 key1, TKey2 key2, NestedDictionary<TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict)
        {
            this[key1].Add(key2, dict);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <param name="key6">The key to locate for 6. level.</param>
        /// <param name="key7">The key to locate for 7. level.</param>
        /// <param name="key8">The key to locate for 8. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7, TKey8 key8)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5, key6, key7, key8);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <param name="key6">The key to locate for 6. level.</param>
        /// <param name="key7">The key to locate for 7. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5, key6, key7);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <param name="key6">The key to locate for 6. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5, key6);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <param name="key5">The key to locate for 5. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.ContainsKey(key2, key3, key4, key5);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <param name="key4">The key to locate for 4. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.ContainsKey(key2, key3, key4);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <param name="key3">The key to locate for 3. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.ContainsKey(key2, key3);
        }

        /// <summary>
        /// Determines whether the nested dictionary contains specified key chain.
        /// </summary>
        /// <param name="key1">The key to locate for 1. level.</param>
        /// <param name="key2">The key to locate for 2. level.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool ContainsKey(TKey1 key1, TKey2 key2)
        {
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.ContainsKey(key2);
        }




        /// <summary>
        /// Determines whether the nested dictionary contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the nested dictionary. The value can be null for reference types.</param>
        /// <returns>True if the nested dictionary contains an element with the specified value; otherwise, false.</returns>
        public bool ContainsValue(TValue value)
        {
            foreach (NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict in Values)
                if (dict.ContainsValue(value))
                    return true;

            return false;
        }




        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <param name="key6">The key for 6. level.</param>
        /// <param name="key7">The key for 7. level.</param>
        /// <param name="key8">The key for 8. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7, TKey8 key8)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict))
                return dict.Remove(key2, key3, key4, key5, key6, key7, key8);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <param name="key6">The key for 6. level.</param>
        /// <param name="key7">The key for 7. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict))
                return dict.Remove(key2, key3, key4, key5, key6, key7);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <param name="key6">The key for 6. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict))
                return dict.Remove(key2, key3, key4, key5, key6);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <param name="key5">The key for 5. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict))
                return dict.Remove(key2, key3, key4, key5);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <param name="key4">The key for 4. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict))
                return dict.Remove(key2, key3, key4);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <param name="key3">The key for 3. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2, TKey3 key3)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict))
                return dict.Remove(key2, key3);

            return false;
        }

        /// <summary>
        ///  Removes the value or nested dictionary on a deeper level with the specified key chain from the nested dictionary.
        /// </summary>
        /// <param name="key1">The key for 1. level.</param>
        /// <param name="key2">The key for 2. level.</param>
        /// <returns>True if the element is successfully found and removed; otherwise, false. This method returns false if key is not found in the nested dictionary.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool Remove(TKey1 key1, TKey2 key2)
        {
            if (TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict))
                return dict.Remove(key2);

            return false;
        }




        /// <summary>
        /// Gets the value associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="key6">The key of the value to get 6. level.</param>
        /// <param name="key7">The key of the value to get 7. level.</param>
        /// <param name="key8">The key of the value to get 8. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7, TKey8 key8, out TValue value)
        {
            value = default(TValue);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, key6, key7, key8, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="key6">The key of the value to get 6. level.</param>
        /// <param name="key7">The key of the value to get 7. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7, out NestedDictionary<TKey8, TValue> value)
        {
            value = default(NestedDictionary<TKey8, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, key6, key7, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="key6">The key of the value to get 6. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, out NestedDictionary<TKey7, TKey8, TValue> value)
        {
            value = default(NestedDictionary<TKey7, TKey8, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, key6, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="key5">The key of the value to get 5. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, out NestedDictionary<TKey6, TKey7, TKey8, TValue> value)
        {
            value = default(NestedDictionary<TKey6, TKey7, TKey8, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.TryGetValue(key2, key3, key4, key5, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="key4">The key of the value to get 4. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, out NestedDictionary<TKey5, TKey6, TKey7, TKey8, TValue> value)
        {
            value = default(NestedDictionary<TKey5, TKey6, TKey7, TKey8, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.TryGetValue(key2, key3, key4, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="key3">The key of the value to get 3. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, out NestedDictionary<TKey4, TKey5, TKey6, TKey7, TKey8, TValue> value)
        {
            value = default(NestedDictionary<TKey4, TKey5, TKey6, TKey7, TKey8, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.TryGetValue(key2, key3, out value);
        }

        /// <summary>
        /// Gets the nested dictionary of deeper level associated with the specified key chain.
        /// </summary>
        /// <param name="key1">The key of the value to get 1. level.</param>
        /// <param name="key2">The key of the value to get 2. level.</param>
        /// <param name="value">When this method returns true, contains the value associated with the specified key chain, if the key chain is found; otherwise,
        /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the nested dictionary contains an element with the specified key chain; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey1 key1, TKey2 key2, out NestedDictionary<TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> value)
        {
            value = default(NestedDictionary<TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue>);
            return TryGetValue(key1, out NestedDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue> dict) && dict.TryGetValue(key2, out value);
        }
    }

}