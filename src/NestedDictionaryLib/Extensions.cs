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
    /// Provides a set of static (Shared in Visual Basic) methods for creation of nested dictionaries from objects that implement ienumerable.
    /// </summary>
    public static class ExtensionsTest
    {
		
			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to specified key selectors and element selector functions.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
			/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TElement> elementSelector)
			{
				return ToNestedDictionary(source, key1Selector, key2Selector, elementSelector, null, null);
			}

			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to a specified key selectors function, comparers, and an element selector function.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
							/// <param name="comparer1">An comparer to compare keys on level 1.</param>
							/// <param name="comparer2">An comparer to compare keys on level 2.</param>
						/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2)
			{
				if (source == null)
					throw new ArgumentNullException(nameof(source));
									if (key1Selector == null)
						throw new ArgumentNullException(nameof(key1Selector));
									if (key2Selector == null)
						throw new ArgumentNullException(nameof(key2Selector));
								if (elementSelector == null)
					throw new ArgumentNullException(nameof(elementSelector));

				NestedDictionary<TKey1, TKey2, TElement> dictionary = new NestedDictionary<TKey1, TKey2, TElement>(comparer1, comparer2);

				foreach (TSource element in source)
					dictionary.Add(key1Selector(element), key2Selector(element), elementSelector(element));

				return dictionary;
			}

		
			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to specified key selectors and element selector functions.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
			/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TElement> elementSelector)
			{
				return ToNestedDictionary(source, key1Selector, key2Selector, key3Selector, elementSelector, null, null, null);
			}

			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to a specified key selectors function, comparers, and an element selector function.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
							/// <param name="comparer1">An comparer to compare keys on level 1.</param>
							/// <param name="comparer2">An comparer to compare keys on level 2.</param>
							/// <param name="comparer3">An comparer to compare keys on level 3.</param>
						/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3)
			{
				if (source == null)
					throw new ArgumentNullException(nameof(source));
									if (key1Selector == null)
						throw new ArgumentNullException(nameof(key1Selector));
									if (key2Selector == null)
						throw new ArgumentNullException(nameof(key2Selector));
									if (key3Selector == null)
						throw new ArgumentNullException(nameof(key3Selector));
								if (elementSelector == null)
					throw new ArgumentNullException(nameof(elementSelector));

				NestedDictionary<TKey1, TKey2, TKey3, TElement> dictionary = new NestedDictionary<TKey1, TKey2, TKey3, TElement>(comparer1, comparer2, comparer3);

				foreach (TSource element in source)
					dictionary.Add(key1Selector(element), key2Selector(element), key3Selector(element), elementSelector(element));

				return dictionary;
			}

		
			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to specified key selectors and element selector functions.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
			/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TElement> elementSelector)
			{
				return ToNestedDictionary(source, key1Selector, key2Selector, key3Selector, key4Selector, elementSelector, null, null, null, null);
			}

			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to a specified key selectors function, comparers, and an element selector function.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
							/// <param name="comparer1">An comparer to compare keys on level 1.</param>
							/// <param name="comparer2">An comparer to compare keys on level 2.</param>
							/// <param name="comparer3">An comparer to compare keys on level 3.</param>
							/// <param name="comparer4">An comparer to compare keys on level 4.</param>
						/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4)
			{
				if (source == null)
					throw new ArgumentNullException(nameof(source));
									if (key1Selector == null)
						throw new ArgumentNullException(nameof(key1Selector));
									if (key2Selector == null)
						throw new ArgumentNullException(nameof(key2Selector));
									if (key3Selector == null)
						throw new ArgumentNullException(nameof(key3Selector));
									if (key4Selector == null)
						throw new ArgumentNullException(nameof(key4Selector));
								if (elementSelector == null)
					throw new ArgumentNullException(nameof(elementSelector));

				NestedDictionary<TKey1, TKey2, TKey3, TKey4, TElement> dictionary = new NestedDictionary<TKey1, TKey2, TKey3, TKey4, TElement>(comparer1, comparer2, comparer3, comparer4);

				foreach (TSource element in source)
					dictionary.Add(key1Selector(element), key2Selector(element), key3Selector(element), key4Selector(element), elementSelector(element));

				return dictionary;
			}

		
			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to specified key selectors and element selector functions.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
							/// <typeparam name="TKey5">The type of the key returned by key5Selector for level 5.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
							/// <param name="key5Selector">A function to extract a key for level 5 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
			/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TKey5, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TKey5> key5Selector, Func<TSource, TElement> elementSelector)
			{
				return ToNestedDictionary(source, key1Selector, key2Selector, key3Selector, key4Selector, key5Selector, elementSelector, null, null, null, null, null);
			}

			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to a specified key selectors function, comparers, and an element selector function.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
							/// <typeparam name="TKey5">The type of the key returned by key5Selector for level 5.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
							/// <param name="key5Selector">A function to extract a key for level 5 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
							/// <param name="comparer1">An comparer to compare keys on level 1.</param>
							/// <param name="comparer2">An comparer to compare keys on level 2.</param>
							/// <param name="comparer3">An comparer to compare keys on level 3.</param>
							/// <param name="comparer4">An comparer to compare keys on level 4.</param>
							/// <param name="comparer5">An comparer to compare keys on level 5.</param>
						/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TKey5, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TKey5> key5Selector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5)
			{
				if (source == null)
					throw new ArgumentNullException(nameof(source));
									if (key1Selector == null)
						throw new ArgumentNullException(nameof(key1Selector));
									if (key2Selector == null)
						throw new ArgumentNullException(nameof(key2Selector));
									if (key3Selector == null)
						throw new ArgumentNullException(nameof(key3Selector));
									if (key4Selector == null)
						throw new ArgumentNullException(nameof(key4Selector));
									if (key5Selector == null)
						throw new ArgumentNullException(nameof(key5Selector));
								if (elementSelector == null)
					throw new ArgumentNullException(nameof(elementSelector));

				NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TElement> dictionary = new NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TElement>(comparer1, comparer2, comparer3, comparer4, comparer5);

				foreach (TSource element in source)
					dictionary.Add(key1Selector(element), key2Selector(element), key3Selector(element), key4Selector(element), key5Selector(element), elementSelector(element));

				return dictionary;
			}

		
			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to specified key selectors and element selector functions.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
							/// <typeparam name="TKey5">The type of the key returned by key5Selector for level 5.</typeparam>
							/// <typeparam name="TKey6">The type of the key returned by key6Selector for level 6.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
							/// <param name="key5Selector">A function to extract a key for level 5 from each element.</param>
							/// <param name="key6Selector">A function to extract a key for level 6 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
			/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TKey5> key5Selector, Func<TSource, TKey6> key6Selector, Func<TSource, TElement> elementSelector)
			{
				return ToNestedDictionary(source, key1Selector, key2Selector, key3Selector, key4Selector, key5Selector, key6Selector, elementSelector, null, null, null, null, null, null);
			}

			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to a specified key selectors function, comparers, and an element selector function.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
							/// <typeparam name="TKey5">The type of the key returned by key5Selector for level 5.</typeparam>
							/// <typeparam name="TKey6">The type of the key returned by key6Selector for level 6.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
							/// <param name="key5Selector">A function to extract a key for level 5 from each element.</param>
							/// <param name="key6Selector">A function to extract a key for level 6 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
							/// <param name="comparer1">An comparer to compare keys on level 1.</param>
							/// <param name="comparer2">An comparer to compare keys on level 2.</param>
							/// <param name="comparer3">An comparer to compare keys on level 3.</param>
							/// <param name="comparer4">An comparer to compare keys on level 4.</param>
							/// <param name="comparer5">An comparer to compare keys on level 5.</param>
							/// <param name="comparer6">An comparer to compare keys on level 6.</param>
						/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TKey5> key5Selector, Func<TSource, TKey6> key6Selector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6)
			{
				if (source == null)
					throw new ArgumentNullException(nameof(source));
									if (key1Selector == null)
						throw new ArgumentNullException(nameof(key1Selector));
									if (key2Selector == null)
						throw new ArgumentNullException(nameof(key2Selector));
									if (key3Selector == null)
						throw new ArgumentNullException(nameof(key3Selector));
									if (key4Selector == null)
						throw new ArgumentNullException(nameof(key4Selector));
									if (key5Selector == null)
						throw new ArgumentNullException(nameof(key5Selector));
									if (key6Selector == null)
						throw new ArgumentNullException(nameof(key6Selector));
								if (elementSelector == null)
					throw new ArgumentNullException(nameof(elementSelector));

				NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TElement> dictionary = new NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TElement>(comparer1, comparer2, comparer3, comparer4, comparer5, comparer6);

				foreach (TSource element in source)
					dictionary.Add(key1Selector(element), key2Selector(element), key3Selector(element), key4Selector(element), key5Selector(element), key6Selector(element), elementSelector(element));

				return dictionary;
			}

		
			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to specified key selectors and element selector functions.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
							/// <typeparam name="TKey5">The type of the key returned by key5Selector for level 5.</typeparam>
							/// <typeparam name="TKey6">The type of the key returned by key6Selector for level 6.</typeparam>
							/// <typeparam name="TKey7">The type of the key returned by key7Selector for level 7.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
							/// <param name="key5Selector">A function to extract a key for level 5 from each element.</param>
							/// <param name="key6Selector">A function to extract a key for level 6 from each element.</param>
							/// <param name="key7Selector">A function to extract a key for level 7 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
			/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TKey5> key5Selector, Func<TSource, TKey6> key6Selector, Func<TSource, TKey7> key7Selector, Func<TSource, TElement> elementSelector)
			{
				return ToNestedDictionary(source, key1Selector, key2Selector, key3Selector, key4Selector, key5Selector, key6Selector, key7Selector, elementSelector, null, null, null, null, null, null, null);
			}

			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to a specified key selectors function, comparers, and an element selector function.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
							/// <typeparam name="TKey5">The type of the key returned by key5Selector for level 5.</typeparam>
							/// <typeparam name="TKey6">The type of the key returned by key6Selector for level 6.</typeparam>
							/// <typeparam name="TKey7">The type of the key returned by key7Selector for level 7.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
							/// <param name="key5Selector">A function to extract a key for level 5 from each element.</param>
							/// <param name="key6Selector">A function to extract a key for level 6 from each element.</param>
							/// <param name="key7Selector">A function to extract a key for level 7 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
							/// <param name="comparer1">An comparer to compare keys on level 1.</param>
							/// <param name="comparer2">An comparer to compare keys on level 2.</param>
							/// <param name="comparer3">An comparer to compare keys on level 3.</param>
							/// <param name="comparer4">An comparer to compare keys on level 4.</param>
							/// <param name="comparer5">An comparer to compare keys on level 5.</param>
							/// <param name="comparer6">An comparer to compare keys on level 6.</param>
							/// <param name="comparer7">An comparer to compare keys on level 7.</param>
						/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TKey5> key5Selector, Func<TSource, TKey6> key6Selector, Func<TSource, TKey7> key7Selector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6, IEqualityComparer<TKey7> comparer7)
			{
				if (source == null)
					throw new ArgumentNullException(nameof(source));
									if (key1Selector == null)
						throw new ArgumentNullException(nameof(key1Selector));
									if (key2Selector == null)
						throw new ArgumentNullException(nameof(key2Selector));
									if (key3Selector == null)
						throw new ArgumentNullException(nameof(key3Selector));
									if (key4Selector == null)
						throw new ArgumentNullException(nameof(key4Selector));
									if (key5Selector == null)
						throw new ArgumentNullException(nameof(key5Selector));
									if (key6Selector == null)
						throw new ArgumentNullException(nameof(key6Selector));
									if (key7Selector == null)
						throw new ArgumentNullException(nameof(key7Selector));
								if (elementSelector == null)
					throw new ArgumentNullException(nameof(elementSelector));

				NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TElement> dictionary = new NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TElement>(comparer1, comparer2, comparer3, comparer4, comparer5, comparer6, comparer7);

				foreach (TSource element in source)
					dictionary.Add(key1Selector(element), key2Selector(element), key3Selector(element), key4Selector(element), key5Selector(element), key6Selector(element), key7Selector(element), elementSelector(element));

				return dictionary;
			}

		
			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to specified key selectors and element selector functions.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
							/// <typeparam name="TKey5">The type of the key returned by key5Selector for level 5.</typeparam>
							/// <typeparam name="TKey6">The type of the key returned by key6Selector for level 6.</typeparam>
							/// <typeparam name="TKey7">The type of the key returned by key7Selector for level 7.</typeparam>
							/// <typeparam name="TKey8">The type of the key returned by key8Selector for level 8.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
							/// <param name="key5Selector">A function to extract a key for level 5 from each element.</param>
							/// <param name="key6Selector">A function to extract a key for level 6 from each element.</param>
							/// <param name="key7Selector">A function to extract a key for level 7 from each element.</param>
							/// <param name="key8Selector">A function to extract a key for level 8 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
			/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TKey5> key5Selector, Func<TSource, TKey6> key6Selector, Func<TSource, TKey7> key7Selector, Func<TSource, TKey8> key8Selector, Func<TSource, TElement> elementSelector)
			{
				return ToNestedDictionary(source, key1Selector, key2Selector, key3Selector, key4Selector, key5Selector, key6Selector, key7Selector, key8Selector, elementSelector, null, null, null, null, null, null, null, null);
			}

			/// <summary>
			/// Creates a nested dictionary from an ienumerable according to a specified key selectors function, comparers, and an element selector function.
			/// </summary>
			/// <typeparam name="TSource">The type of the elements of source.</typeparam>
							/// <typeparam name="TKey1">The type of the key returned by key1Selector for level 1.</typeparam>
							/// <typeparam name="TKey2">The type of the key returned by key2Selector for level 2.</typeparam>
							/// <typeparam name="TKey3">The type of the key returned by key3Selector for level 3.</typeparam>
							/// <typeparam name="TKey4">The type of the key returned by key4Selector for level 4.</typeparam>
							/// <typeparam name="TKey5">The type of the key returned by key5Selector for level 5.</typeparam>
							/// <typeparam name="TKey6">The type of the key returned by key6Selector for level 6.</typeparam>
							/// <typeparam name="TKey7">The type of the key returned by key7Selector for level 7.</typeparam>
							/// <typeparam name="TKey8">The type of the key returned by key8Selector for level 8.</typeparam>
						/// <typeparam name="TElement">The type of the value returned by elementSelector.</typeparam>
			/// <param name="source">An ienumerable to create a nested dictionary from.</param>
							/// <param name="key1Selector">A function to extract a key for level 1 from each element.</param>
							/// <param name="key2Selector">A function to extract a key for level 2 from each element.</param>
							/// <param name="key3Selector">A function to extract a key for level 3 from each element.</param>
							/// <param name="key4Selector">A function to extract a key for level 4 from each element.</param>
							/// <param name="key5Selector">A function to extract a key for level 5 from each element.</param>
							/// <param name="key6Selector">A function to extract a key for level 6 from each element.</param>
							/// <param name="key7Selector">A function to extract a key for level 7 from each element.</param>
							/// <param name="key8Selector">A function to extract a key for level 8 from each element.</param>
						/// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
							/// <param name="comparer1">An comparer to compare keys on level 1.</param>
							/// <param name="comparer2">An comparer to compare keys on level 2.</param>
							/// <param name="comparer3">An comparer to compare keys on level 3.</param>
							/// <param name="comparer4">An comparer to compare keys on level 4.</param>
							/// <param name="comparer5">An comparer to compare keys on level 5.</param>
							/// <param name="comparer6">An comparer to compare keys on level 6.</param>
							/// <param name="comparer7">An comparer to compare keys on level 7.</param>
							/// <param name="comparer8">An comparer to compare keys on level 8.</param>
						/// <returns>A nested dictionary that contains values of type TElement selected from the input sequence.</returns>
			/// <exception cref="ArgumentNullException">source or some of keySelectors or elementSelector is null.-or- some of keySelectors produces a key that is null.</exception>
			/// <exception cref="ArgumentException">Some of keySelectors produces duplicate keys for two elements.</exception>
			public static NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TElement> ToNestedDictionary<TSource, TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey1> key1Selector, Func<TSource, TKey2> key2Selector, Func<TSource, TKey3> key3Selector, Func<TSource, TKey4> key4Selector, Func<TSource, TKey5> key5Selector, Func<TSource, TKey6> key6Selector, Func<TSource, TKey7> key7Selector, Func<TSource, TKey8> key8Selector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey1> comparer1, IEqualityComparer<TKey2> comparer2, IEqualityComparer<TKey3> comparer3, IEqualityComparer<TKey4> comparer4, IEqualityComparer<TKey5> comparer5, IEqualityComparer<TKey6> comparer6, IEqualityComparer<TKey7> comparer7, IEqualityComparer<TKey8> comparer8)
			{
				if (source == null)
					throw new ArgumentNullException(nameof(source));
									if (key1Selector == null)
						throw new ArgumentNullException(nameof(key1Selector));
									if (key2Selector == null)
						throw new ArgumentNullException(nameof(key2Selector));
									if (key3Selector == null)
						throw new ArgumentNullException(nameof(key3Selector));
									if (key4Selector == null)
						throw new ArgumentNullException(nameof(key4Selector));
									if (key5Selector == null)
						throw new ArgumentNullException(nameof(key5Selector));
									if (key6Selector == null)
						throw new ArgumentNullException(nameof(key6Selector));
									if (key7Selector == null)
						throw new ArgumentNullException(nameof(key7Selector));
									if (key8Selector == null)
						throw new ArgumentNullException(nameof(key8Selector));
								if (elementSelector == null)
					throw new ArgumentNullException(nameof(elementSelector));

				NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TElement> dictionary = new NestedDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TElement>(comparer1, comparer2, comparer3, comparer4, comparer5, comparer6, comparer7, comparer8);

				foreach (TSource element in source)
					dictionary.Add(key1Selector(element), key2Selector(element), key3Selector(element), key4Selector(element), key5Selector(element), key6Selector(element), key7Selector(element), key8Selector(element), elementSelector(element));

				return dictionary;
			}

		    }
}