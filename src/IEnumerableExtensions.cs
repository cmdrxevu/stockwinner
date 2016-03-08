//using System.Collections.ObjectModel;
using System.Linq;

// ReSharper disable once CheckNamespace

namespace System.Collections.Generic
{
    /// <summary>
    /// Extension Methods für IEnumerable
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class IEnumerableExtensions
    {
 /*       /// <summary>
        /// Erzeugt eine ObservableCollection von einer IEnumerable-Datenquelle
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
        {
            if (source == null) {
                throw new ArgumentNullException("source");
            }

            return new ObservableCollection<T>(source);
        }

        /// <summary>Traverses an object hierarchy and return a flattened list of elements  based on a predicate.</summary>
        /// <typeparam name="TSource">The type of object in your collection.</typeparam>
        /// <param name="source">The collection of your topmost TSource objects.</param>
        /// <param name="selectorFunction">A predicate for choosing the objects you want.</param>
        /// <param name="getChildrenFunction"> A function that fetches the child collection from an object.</param>
        /// >
        /// <returns>A flattened list of objects which meet the criteria in selectorFunction.</returns>
        public static IEnumerable<TSource> Map<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> selectorFunction,
            Func<TSource, IEnumerable<TSource>> getChildrenFunction)
        {
            // Add what we have to the stack 
            var flattenedList = source.Where(selectorFunction);

            // Go through the input enumerable looking for children, 
            // and add those if we have them 
            foreach (var element in source) {
                flattenedList = flattenedList.Concat(
                    getChildrenFunction(element).Map(
                        selectorFunction,
                        getChildrenFunction)
                    );
            }
            return flattenedList;
        }

        /// <summary>
        /// <paramref name="source" /> iterieren und <paramref name="action" /> je Eintrag ausführen
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        public static void ForEachWithIndex<T>(this IEnumerable<T> source, Action<int, T> action)
        {
            if (source == null
                || action == null) {
                return;
            }

            var array = source.ToArray();
            var count = array.Length;

            for (var i = 0; i < count; i++) {
                action(i, array[i]);
            }
        }

        /// <summary>
        /// <paramref name="source" /> iterieren und <paramref name="action" /> je Eintrag ausführen
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null
                || action == null) {
                return;
            }

            var array = source.ToArray();
            foreach (var item in array) {
                action(item);
            }
        }

        /// <summary>
        /// <paramref name="source" /> iterieren und <paramref name="action" /> je Eintrag ausführen
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        public static void ForEachNotNull<T>(this IEnumerable<T> source, Action<T> action)
            where T : class
        {
            if (source == null
                || action == null) {
                return;
            }

            var array = source.ToArray();
            foreach (var item in array) {
                if (item == null) {
                    continue;
                }

                action(item);
            }
        }


        /// <summary>
        /// Erstellt ein Diff zwischen <paramref name="current"/> und 
        /// <paramref name="syncBase"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="current">Die Liste, auf der gearbeitet wird (z.B. gebunden in einem Grid)</param>
        /// <param name="syncBase">Die Liste, auf Basis derer current erstellt wurde
        /// und die letztlich die Repräsentation in der Datenbank darstellt. Ist hier
        /// ein Eintrag vorhanden, der in current nicht (mehr) drin ist, wird dieser
        /// in removed vermerkt. Ist in current ein Eintrag vorhanden, der in syncBase
        /// (noch) nicht vorhanden ist, wird diese in added vermerkt.</param>
        /// <param name="added"></param>
        /// <param name="removed"></param>
        public static void Diff<T>(
            this IEnumerable<T> current, 
            ICollection<T> syncBase, 
            out IEnumerable<T> added, 
            out IEnumerable<T> removed)
        {
            current.Diff(syncBase, out added, out removed, EqualityComparer<T>.Default);
       }

        /// <summary>
        /// Erstellt ein Diff zwischen <paramref name="current"/> und 
        /// <paramref name="syncBase"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="current">Die Liste, auf der gearbeitet wird (z.B. gebunden in einem Grid)</param>
        /// <param name="syncBase">Die Liste, auf Basis derer current erstellt wurde
        /// und die letztlich die Repräsentation in der Datenbank darstellt. Ist hier
        /// ein Eintrag vorhanden, der in current nicht (mehr) drin ist, wird dieser
        /// in removed vermerkt. Ist in current ein Eintrag vorhanden, der in syncBase
        /// (noch) nicht vorhanden ist, wird diese in added vermerkt.</param>
        /// <param name="added"></param>
        /// <param name="removed"></param>
        /// <param name="comparer"></param>
        public static void Diff<T>(
            this IEnumerable<T> current,
            ICollection<T> syncBase,
            out IEnumerable<T> added,
            out IEnumerable<T> removed,
            IEqualityComparer<T> comparer)
        {
            removed = syncBase.Where(i => !current.Contains(i, comparer)).ToArray();
            added = current.Where(i => !syncBase.Contains(i, comparer)).ToArray();
            removed.ForEach(i => syncBase.Remove(i));
            added.ForEach(syncBase.Add);
        }

        /// <summary>
        /// Gibt das Element aus der Liste <paramref name="source"/> zurück,
        /// dass NACH <paramref name="item"/> kommt und dem übergebenen <paramref name="predicate"/>
        /// entspricht.
        /// Es wird <c>default</c> zurückgegeben, wenn <paramref name="source"/>
        /// <c>null</c> ist oder <paramref name="item"/> ganz am Ende der Liste steht.
        /// Ist <paramref name="predicate"/> <c>null</c>, wird der direkte Nachfolger
        /// von <paramref name="item"/> zurückgegeben.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static T NextAfter<T>(this IEnumerable<T> source, T item, Predicate<T> predicate = null)
        {
            if (source == null) {
                return default(T);
            }

            bool itemIsReached = false;
            foreach (var actual in source){
                if (EqualityComparer<T>.Default.Equals(actual, item)) {
                    itemIsReached = true;
                    continue;
                }

                if (itemIsReached) {
                    if (predicate == null
                        || predicate(actual)) {
                        return actual;
                    }
                }
            }

            return default(T);
        }

        		/// <summary>
		///     Überprüft, ob sich in der angegebenen <see cref="IEnumerable&lt;T&gt;">Auflistung</see> mehr als die für
		///     <paramref
		///         name="count" />
		///     angegebenen Elemente befinden.
		/// </summary>
		/// <typeparam name="T">The type of objects to enumerate.</typeparam>
		/// <param name="source">
		///     Die zu prüfende <see cref="IEnumerable&lt;T&gt;">Auflistung</see>.
		/// </param>
		/// <param name="count">Die zu prüfende Anzahl.</param>
		/// <returns>
		///     <see langword="true" />, wenn die Anzahl der Elemente in der Auflistung größer dem Parameter <paramref name="count" /> ist, andernfalls
		///     <see
		///         langword="false" />
		///     .
		/// </returns>
		public static bool HasMoreThan<T>(this IEnumerable<T> source, int count)
		{
			var collection = source as ICollection<T>;
			if (collection != null)
			{
				return collection.Count > count;
			}
			else
			{
				var enumerator = source.GetEnumerator();
				int internalCounter = 0;
				while (enumerator.MoveNext())
				{
					internalCounter++;
					if (internalCounter > count)
					{
						return true;
					}
				}

				return false;
			}
		}
*/
		/// <summary>
		///     Splits all items of <paramref name="items" /> into blocks of the specified <paramref name="blockSize" /> and returns those. Missing items within the last block are padded with the
		///     <see
		///         langword="default" />
		///     value of <typeparamref name="T" />.
		///     Teilt alle Element von <paramref name="items" /> in Blöcke der in <paramref name="blockSize" /> angegeben Größe und gibt diese zurück. Fehlende Elemente im letzten Block sind mit den
		///     <see
		///         langword="default" />
		///     Werte von <typeparamref name="T" /> befüllt.
		/// </summary>
		/// <typeparam name="T">
		///     The type of items.
		///     Der Typ der Elemente.
		/// </typeparam>
		/// <param name="items">
		///     The items to be split.
		///     Die Elemente, welche in Blöcke zerlegt werden sollen.
		/// </param>
		/// <param name="blockSize">
		///     The size of an individual block.
		///     Die Größe eines individuellen Blockes.
		/// </param>
		/// <exception cref="ArgumentNullException">
		///     <paramref name="items" /> is <see langword="null" />.
		///     <paramref name="items" /> ist <see langword="null" />.
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///     <paramref name="blockSize" /> is less than or equal to zero (0).
		///     <paramref name="blockSize" /> ist kleiner oder gleich null (0).
		/// </exception>
		/// <returns>
		///     The individual blocks.
		///     Die individuellen Blöcke.
		/// </returns>
		public static IEnumerable<T[]> SplitToIntoBlocksOf<T>(this IEnumerable<T> items, int blockSize)
		{
	//		items.AssertArgumentIsNotNull("source");
	//		blockSize.AssertArgumentIsNotLessThanOrEqualToZero("blockSize");

			var list = new List<T[]>();

			int current = 0;
			T[] block = null;

			foreach (var item in items)
			{
				if (block == null)
				{
					block = new T[blockSize];
				}

				block[current++] = item;

				if (current == blockSize)
				{
					current = 0;
					list.Add(block);
					block = null;
				}
			}

			if (block != null)
			{
				list.Add(block);
			}

			return list;
		}
/*
		/// <summary>
		///     Disambiguierung der Einträge in <paramref name="source" /> auf Basis des
		///     Schlüssels aus <paramref name="keySelector" />. Sind Einträge im Sinne des
		///     Schlüssels doppelt vorhanden, wird der erste gefundene verwendet.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TKey"></typeparam>
		/// <param name="source"></param>
		/// <param name="keySelector"></param>
		/// <returns></returns>
		public static IEnumerable<T> Distinct<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
		{
			if (source == null)
			{
				return Enumerable.Empty<T>();
			}

			return source
				.GroupBy(keySelector)
				.Select(g => g.FirstOrDefault());
		}

        /// <summary>
        /// Selektiert alle numerischen Werte aus <paramref name="source"/>, bildet
        /// das Maximum und inkrementiert um 1. Sind keine Werte verfügbar, wird
        /// <c>0</c> zurückgegeben.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="intSelector"></param>
        /// <returns></returns>
        public static int MaxPlusOne<T>(this IEnumerable<T> source, Func<T, int?> intSelector)
        {
            if (source == null) {
                return 0;
            }

            var ints = source.Select(i => intSelector(i).GetValueOrDefault(-1));
            if (!ints.Any()) {
                return 0;
            }

            var max = ints.Max();
            max++;

            return max;
        }

        /// <summary>
        /// Prüft, ob die Auflistung <c>null</c> oder leer ist.
        /// Wenn dem so ist, wird <c>true</c> zurückgegeben. Sonst <c>false</c>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }
  */  }
}