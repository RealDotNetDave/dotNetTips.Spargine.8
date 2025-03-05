# DotNetTips.Spargine.8.Extensions - 2025.8.3.4

## ArrayExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineArrayExtensions

### T[] AddFirst(T[] array, T& item)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### T[] AddIf(T[] array, T& item, Boolean condition)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/28/2021
* **Description:** AddIf
* **Modified By:** David McCarter

### T[] AddLast(T[] array, T& item)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean AreEqual(T[] array, T[]& arrayToCheck)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** AreEqual
* **Modified By:** David McCarter

### ReadOnlySpan<T> AsReadOnlySpan(T[] list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/30/2023
* **Description:** AsReadOnlySpan
* **Modified By:** David McCarter

### Span<T> AsSpan(T[] list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/3/2024
* **Description:** AsSpan
* **Modified By:** David McCarter

### String BytesToString(Byte[] array)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** BytesToString
* **Modified By:** David McCarter

### String BytesToString(ReadOnlySpan<Byte> array)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/24/2021
* **Description:** BytesToString
* **Modified By:** David McCarter

### T[] Clone(T[] array)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/30/2020
* **Description:** Clone
* **Modified By:** David McCarter

### Boolean ContainsAny(T[] array, T[] items)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** ContainsAny
* **Modified By:** David McCarter

### Boolean DoesNotHaveItems(T[] array)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2022
* **Description:** DoesNotHaveItems
* **Modified By:** David McCarter

### Int64 FastCount(T[] array)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/9/2023
* **Description:** FastCount
* **Modified By:** David McCarter

### Byte[] FastHashData(Byte[] data)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/11/2024
* **Description:** FastHashData
* **Modified By:** David McCarter

### Void FastProcessor(T[] array, Action<T> action)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/8/2021
* **Description:** FastProcessor
* **Modified By:** David McCarter

### Int32 GenerateHashCode(T[] array)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean HasItems(T[] array)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Modified By:** David McCarter

### Boolean HasItems(T[] array, Func`2& actionFunction)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Modified By:** David McCarter

### Boolean HasItems(T[] array, Int32 count)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Modified By:** David McCarter

### Void PerformAction(T[] values, Action<T> action)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/4/2023
* **Description:** PerformAction
* **Modified By:** David McCarter

### T[] RemoveFirst(T[] array)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** RemoveFirst
* **Modified By:** David McCarter

### T[] RemoveLast(T[] array)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** RemoveLast
* **Modified By:** David McCarter

### T[] ToDistinct(T[] array)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToDistinct
* **Modified By:** David McCarter

### FrozenSet<T> ToFrozenSet(T[] list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/3/2024
* **Description:** ToFrozenSet
* **Modified By:** David McCarter

### T[] Upsert(T[] array, T item)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/28/2021
* **Description:** Upsert
* **Modified By:** David McCarter

### IDataRecord[] Upsert(IDataRecord[] array, IDataRecord item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** WIP
* **Author:** David McCarter
* **CreatedOn:** 5/2/2021
* **Description:** Upsert
* **Modified By:** David McCarter

*****
## AssemblyExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineAssemblyExtensions

### ReadOnlyCollection<Type> GetAllInterfaces(Assembly assembly)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/7/2021
* **Description:** GetAllInterfaces
* **Modified By:** David McCarter

### ReadOnlyCollection<Type> GetAllTypes(Assembly assembly)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **Description:** GetAllTypes
* **Modified By:** David McCarter

### IEnumerable<T> GetInstances(Assembly assembly)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/7/2021
* **Description:** GetInstances
* **Modified By:** David McCarter

### ReadOnlyCollection<Type> GetTypes(Assembly assembly, Type type)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/7/2021
* **Description:** GetTypes
* **Modified By:** David McCarter

*****
## BooleanExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** BooleanExtensions

### String ToLowerCase(Boolean value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Documentation:** ADD URL
* **Modified By:** David McCarter

*****
## CollectionExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineCollectionExtensions

### Void AddIf(ICollection<T> collection, T& item, Boolean condition)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** AddIf
* **Modified By:** David McCarter

### Boolean AddIfNotExists(ICollection<T> collection, T& item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** AddIfNotExists
* **Modified By:** David McCarter

### Boolean AddIfNotExists(ICollection<T> collection, T& item, IEqualityComparer`1& comparer)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean AddRange(ICollection<T> collection, IEnumerable<T> items, Boolean ensureUnique)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/7/2023
* **Description:** AddRange
* **Modified By:** David McCarter

### ReadOnlySpan<T> AsReadOnlySpan(Collection<T> list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/3/2024
* **Description:** AsReadOnlySpan
* **Modified By:** David McCarter

### Span<T> AsSpan(Collection<T> list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/3/2024
* **Description:** AsSpan
* **Modified By:** David McCarter

### Boolean DoesNotHaveItems(ICollection collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** DoesNotHaveItems
* **Modified By:** David McCarter

### Boolean HasItems(ICollection collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Modified By:** David McCarter

### Boolean HasItems(ICollection collection, Int32& count)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Modified By:** David McCarter

### FrozenSet<T> ToFrozenSet(Collection<T> list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/3/2024
* **Description:** ToFrozenSet
* **Modified By:** David McCarter

### Void Upsert(ICollection<T> collection, T& item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** Upsert
* **Modified By:** David McCarter

### Void Upsert(ICollection<T> collection, T item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/2/2021
* **Description:** Upsert
* **Modified By:** David McCarter

### Void Upsert(ICollection<IDataRecord> collection, IDataRecord& item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/2/2021
* **Description:** Upsert
* **Modified By:** David McCarter

*****
## ColorExtensions

### Color Average(IEnumerable<Color> colors)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 1/1/2015
* **Description:** Average
* **Modified By:** David McCarter

*****
## ConcurrentBagExtensions

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Void AddRange(ConcurrentBag<T> bag, IEnumerable<T> items)

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/24/2025
* **Description:** AddRange
* **Modified By:** David McCarter

### ConcurrentBag<T> RemoveRange(ConcurrentBag<T> bag, IEnumerable<T> items)

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/24/2025
* **Description:** RemoveRange
* **Modified By:** David McCarter

### List<T> ToList(ConcurrentBag<T> bag)

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/24/2025
* **Description:** ToList
* **Modified By:** David McCarter

*****
## DataContextExtensions

### ReadOnlyCollection<Tuple<T, T>> GetTrackedObjects(DataContext context)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** GetTrackedObjects
* **Modified By:** David McCarter

*****
## DataReaderExtensions

### ReadOnlyCollection<String> ToCsv(IDataReader dataReader, Boolean includeHeaderAsFirstRow, Char separator)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** ToCsv
* **Modified By:** David McCarter

*****
## DataTableExtensions

### Boolean HasRows(DataTable table)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** HasRows
* **Modified By:** David McCarter

### Boolean IsDBNull(Object value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** HasRows
* **Modified By:** David McCarter

*****
## DateTimeExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineDateTimeExtensions

### DateTime FromMilliEpochTime(Int64& epochTime)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/24/2017
* **Description:** FromMilliEpochTime
* **Modified By:** David McCarter

### DateTimeOffset GetLastDayOfWeek(DateTimeOffset& input, DayOfWeek dayOfWeek)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### DateTimeOffset GetNextDayOfWeek(DateTimeOffset& input, DayOfWeek dayOfWeek)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean Intersects(DateTime& startDate, DateTime& endDate, DateTime& intersectingStartDate, DateTime& intersectingEndDate)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Intersects

### Boolean Intersects(DateTimeOffset& startDate, DateTimeOffset& endDate, DateTimeOffset& intersectingStartDate, DateTimeOffset& intersectingEndDate)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean IsInRange(DateTime& value, DateTime& beginningTime, DateTime& endTime)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** IsInRange
* **Modified By:** David McCarter

### Boolean IsInRange(TimeSpan& value, TimeSpan& beginningTime, TimeSpan& endTime)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** IsInRange
* **Modified By:** David McCarter

### Boolean IsInRange(DateTimeOffset& value, DateTimeOffset& beginningTime, DateTimeOffset& endTime)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** IsInRange
* **Modified By:** David McCarter

### Boolean IsInRangeThrowsException(DateTime& value, DateTime& beginningTime, DateTime& endTime, String paramName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/5/2020
* **Description:** IsInRangeThrowsException
* **Modified By:** David McCarter

### Boolean IsInRangeThrowsException(TimeSpan& value, TimeSpan& beginningTime, TimeSpan& endTime, String paramName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/5/2020
* **Description:** IsInRangeThrowsException
* **Modified By:** David McCarter

### Boolean IsInRangeThrowsException(DateTimeOffset& value, DateTimeOffset& beginningTime, DateTimeOffset& endTime, String paramName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/5/2020
* **Description:** IsInRangeThrowsException
* **Modified By:** David McCarter

### DateTime LocalTimeFromUtc(DateTime& date, Int32& timezoneFromUtc)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** LocalTimeFromUtc
* **Modified By:** David McCarter

### DateTime Max(DateTime& date, DateTime& compareTo)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Max
* **Modified By:** David McCarter

### DateTimeOffset Max(DateTimeOffset& date, DateTimeOffset& compareTo)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Max
* **Modified By:** David McCarter

### DateTime Subtract(DateTime& input, TimeSpan& time)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** NotRequired
* **Author:** David McCarter
* **CreatedOn:** 10/9/2023
* **Description:** Subtract
* **Modified By:** David McCarter

### TimeSpan TimeUntilNextHour(DateTime& dateTime)

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** GitHub Copilot
* **CreatedOn:** 3/3/2025
* **Description:** TimeUntilNextHour
* **Modified By:** GitHub Copilot

### TimeSpan TimeUntilNextHour(DateTimeOffset& dateTime)

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** GitHub Copilot
* **CreatedOn:** 3/3/2025
* **Description:** TimeUntilNextHour
* **Modified By:** GitHub Copilot

### TimeSpan TimeUntilNextMinute(DateTime& dateTime)

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** GitHub Copilot
* **CreatedOn:** 3/3/2025
* **Description:** TimeUntilNextMinute
* **Modified By:** GitHub Copilot

### TimeSpan TimeUntilNextMinute(DateTimeOffset& dateTime)

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** GitHub Copilot
* **CreatedOn:** 3/3/2025
* **Description:** TimeUntilNextMinute
* **Modified By:** GitHub Copilot

### String ToFormattedString(DateTime& input, DateTimeFormat format)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2020
* **Description:** ToFormattedString
* **Modified By:** David McCarter

### String ToFormattedString(DateTimeOffset input, DateTimeFormat format)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2020
* **Description:** ToFormattedString
* **Modified By:** David McCarter

### String ToFriendlyDateString(DateTime& input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** ToFriendlyDateString
* **Modified By:** David McCarter

### String ToFriendlyDateString(DateTimeOffset& input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Int64 ToMilliEpochTime(DateTime& date)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/24/2017
* **Description:** ToMilliEpochTime
* **Modified By:** David McCarter

*****
## DateTimeFormat

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** DateTimeFormat

### String DisplayName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** DisplayName

### Int32 Value { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Value

*****
## DictionaryExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineDictionaryExtensions

### Boolean AddIfNotExists(IDictionary<TKey, TValue> collection, TKey key, TValue& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean AddRange(IDictionary<TKey, TValue> collection, IEnumerable<T> items, Func<T, TKey> keyFunction, Func<T, TValue> valueFunction)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** AddRange
* **Modified By:** David McCarter

### Void DisposeCollection(IDictionary<TKey, TValue> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** DisposeCollection
* **Modified By:** David McCarter

### TValue GetOrAdd(IDictionary<TKey, TValue> collection, TKey key, TValue value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean HasItems(IDictionary<TKey, TValue> collection, Func<KeyValuePair<TKey, TValue>, Boolean> actionPredicate)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Modified By:** David McCarter

### ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary(IDictionary<TKey, TValue> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/23/2022
* **Description:** ToSortedDictionary
* **Modified By:** David McCarter

### String ToDelimitedString(IDictionary<TKey, TValue> collection, Char& delimiter)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/3/2020
* **Description:** ToDelimitedString
* **Modified By:** David McCarter

### FrozenDictionary<TKey, TValue> ToFrozenDictionary(IDictionary<TKey, TValue> list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/3/2024
* **Description:** ToFrozenDictionary
* **Modified By:** David McCarter

### ImmutableDictionary<TKey, TValue> ToImmutableDictionary(IDictionary<TKey, TValue> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToImmutableDictionary
* **Modified By:** David McCarter

### ImmutableSortedDictionary<TKey, TValue> ToImmutableSortedDictionary(IDictionary<TKey, TValue> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/3/2024
* **Description:** ToImmutableSortedDictionary
* **Modified By:** David McCarter

### Func<TKey, TValue> ToLookupWithDefault(IDictionary<TKey, TValue> collection, TValue defaultValue)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/3/2025
* **Description:** Original code by Simon Painter.
* **Modified By:** David McCarter

### ReadOnlyCollection<KeyValuePair<TKey, TValue>> ToReadOnlyCollection(IDictionary<TKey, TValue> dictionary)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/6/2023
* **Description:** ToReadOnlyCollection
* **Modified By:** David McCarter

### ReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary(IDictionary<TKey, TValue> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/3/2024
* **Description:** ToReadOnlyDictionary
* **Modified By:** David McCarter

### SortedDictionary<TKey, TValue> ToSortedDictionary(IDictionary<TKey, TValue> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/27/2022
* **Description:** ToSortedDictionary
* **Modified By:** David McCarter

### SortedDictionary<TKey, TValue> ToSortedDictionary(IDictionary<TKey, TValue> collection, IComparer<TKey> comparer)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToSortedDictionary

### TValue TryGetValue(IDictionary<TKey, TValue> collection, TKey key, Func<TKey, TValue> valueFunction)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/3/2025
* **Description:** Original code by Simon Painter.
* **Modified By:** David McCarter

### Void Upsert(IDictionary<TKey, TValue> collection, TValue& item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/2/2021
* **Description:** Upsert
* **Modified By:** David McCarter

### Void Upsert(IDictionary<TKey, TValue> collection, TKey key, TValue& item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

*****
## DirectoryInfoExtensions

### Int64 GetSize(DirectoryInfo path, String searchPattern, SearchOption searchOption)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** GetSize
* **Modified By:** David McCarter

*****
## EnumerableExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineEnumerableExtensions

### IEnumerable<T> AddDistinct(IEnumerable<T> source, T[] items)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/22/2023
* **Description:** AddDistinct
* **Modified By:** David McCarter

### IEnumerable<T> AddFirst(IEnumerable<T> collection, T item)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/24/2023
* **Description:** AddFirst
* **Modified By:** David McCarter

### IEnumerable<T> AddIf(IEnumerable<T> collection, T item, Boolean condition)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** AddIf
* **Modified By:** David McCarter

### IEnumerable<T> AddLast(IEnumerable<T> collection, T item)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/24/2023
* **Description:** AddLast
* **Modified By:** David McCarter

### Boolean ContainsAny(IEnumerable<T> collection, T[] items)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** ContainsAny
* **Modified By:** David McCarter

### Int32 Count(IEnumerable collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** Count
* **Modified By:** David McCarter

### Task<Int32> CountAsync(IEnumerable<T> collection, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/2/2023
* **Description:** CountAsync
* **Modified By:** David McCarter

### Collection<T> Create(IEnumerable<T> items, Boolean& ensureUnique)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/12/2020
* **Description:** Create
* **Modified By:** David McCarter

### Boolean DoesNotHaveItems(IEnumerable collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** DoesNotHaveItems
* **Modified By:** David McCarter

### IEnumerable<T> EnsureUnique(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/8/2022
* **Description:** EnsureUnique
* **Modified By:** David McCarter

### Boolean FastAny(IEnumerable<T> collection, Func<T, Boolean> accumulatorPredicate)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** FastAny
* **Modified By:** David McCarter

### Int64 FastCount(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/21/2022
* **Description:** FastCount
* **Modified By:** David McCarter

### Int64 FastCount(IList<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/12/2022
* **Description:** FastCount
* **Modified By:** David McCarter

### Int64 FastCount(IEnumerable<T> collection, Func<T, Boolean> accumulatorPredicate)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** FastCount
* **Modified By:** David McCarter

### ReadOnlyCollection<T> FastModifyCollection(IEnumerable<T> collection, Func<T, T> action)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/7/2024
* **Description:** FastModifyCollection
* **Modified By:** David McCarter

### Void FastProcessor(IEnumerable<T> collection, Action<T> action)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/9/2022
* **Description:** FastProcessor
* **Modified By:** David McCarter

### T FirstOrDefault(IEnumerable<T> collection, T alternate)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** FirstOrDefault
* **Modified By:** David McCarter

### T FirstOrDefault(IEnumerable<T> list, Func<T, Boolean> accumulatorPredicate, T alternate)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** FirstOrDefault
* **Modified By:** David McCarter

### Nullable<T> FirstOrNull(IEnumerable<T> collection, Func<T, Boolean> accumulatorPredicate)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** FirstOrNull
* **Modified By:** David McCarter

### Boolean HasDuplicates(IEnumerable<T> items)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/3/2023
* **Description:** HasDuplicates
* **Modified By:** David McCarter

### Boolean HasItems(IEnumerable collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Modified By:** David McCarter

### Boolean HasItems(IEnumerable collection, Int32& count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Modified By:** David McCarter

### Int32 IndexOf(IEnumerable<T> collection, T item)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** IndexOf
* **Modified By:** David McCarter

### Int32 IndexOf(IEnumerable<T> collection, Func<T, Boolean> accumulatorPredicate)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Original code by Simon Painter.

### Int32 IndexOf(IEnumerable<T> collection, T item, IEqualityComparer<T> comparer)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** IndexOf
* **Modified By:** David McCarter

### Boolean IsNullOrEmpty(IEnumerable collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/7/2021
* **Description:** IsNullOrEmpty
* **Modified By:** David McCarter

### String Join(IEnumerable<Object> collection, String separator)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** Join
* **Modified By:** David McCarter

### IEnumerable<T> OrderBy(IEnumerable<T> collection, String sortExpression)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** OrderBy
* **Modified By:** David McCarter

### IOrderedEnumerable<T> OrderByOrdinal(IEnumerable<T> collection, Func<T, String> accumulatorFunction)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** OrderByOrdinal
* **Modified By:** David McCarter

### IEnumerable<IEnumerable<T>> Page(IEnumerable<T> collection, Int32 pageSize)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2010
* **Description:** Page
* **Modified By:** David McCarter

### IEnumerable<IEnumerable<T>> Partition(IEnumerable<T> collection, Int32 pageCount)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/2/2023
* **Description:** Partition
* **Modified By:** David McCarter

### T PickRandom(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/26/2020
* **Description:** PickRandom
* **Modified By:** David McCarter

### SimpleResult<IEnumerable<T>> RemoveDuplicates(IEnumerable<T> items)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/3/2023
* **Description:** RemoveDuplicates
* **Modified By:** David McCarter

### IEnumerable<T> RemoveNulls(IEnumerable<T> collection)

* **Status:** New
* **Optimization Status:** None
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/28/2025
* **Description:** RemoveNulls
* **Modified By:** David McCarter

### IEnumerable<T> ReplaceIf(IEnumerable<T> collection, Func<T, Int32, Boolean> accumulatorPredicate, T replacement)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Original code by Simon Painter.

### IEnumerable<T2> Scan(IEnumerable<T1> source, T2 seed, Func<T2, T1, T2> accumulatorFunction)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Original code by Simon Painter.

### IEnumerable<T> Shuffle(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/26/2020
* **Description:** Shuffle
* **Modified By:** David McCarter

### IEnumerable<T> Shuffle(IEnumerable<T> collection, Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/26/2020
* **Description:** Shuffle
* **Modified By:** David McCarter

### IEnumerable<IEnumerable<T>> Split(IEnumerable<T> collection, Int32 size)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/2/2023
* **Description:** Split
* **Modified By:** David McCarter

### Boolean StartsWith(IEnumerable<T> first, IEnumerable<T> second)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** StartsWith
* **Modified By:** David McCarter

### Boolean StructuralSequenceEqual(IEnumerable<T> first, IEnumerable<T> second)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** StructuralSequenceEqual
* **Modified By:** David McCarter

### BlockingCollection<T> ToBlockingCollection(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/13/2021
* **Description:** ToBlockingCollection
* **Modified By:** David McCarter

### Collection<T> ToCollection(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/13/2021
* **Description:** ToCollection
* **Modified By:** David McCarter

### String ToDelimitedString(IEnumerable<T> collection, Char delimiter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToDelimitedString
* **Modified By:** David McCarter

### FrozenSet<T> ToFrozenSet(IEnumerable<T> list)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/3/2024
* **Description:** ToFrozenSet
* **Modified By:** David McCarter

### ImmutableList<T> ToImmutable(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToImmutable
* **Modified By:** David McCarter

### ImmutableArray<T> ToImmutableArray(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/7/2024
* **Description:** ToImmutable
* **Modified By:** David McCarter

### LinkedList<T> ToLinkedList(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToLinkedList
* **Modified By:** David McCarter

### Task<List<T>> ToListAsync(IEnumerable<T> collection, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToListAsync
* **Modified By:** David McCarter

### ReadOnlyCollection<T> ToReadOnlyCollection(IEnumerable<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToReadOnlyCollection
* **Modified By:** David McCarter

### ReadOnlyCollection<T> ToReadOnlyCollection(ConcurrentBag<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/5/2024
* **Description:** ToReadOnlyCollection
* **Modified By:** David McCarter

### IEnumerable<T> Upsert(IEnumerable<T> collection, T item)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** Upsert
* **Modified By:** David McCarter

*****
## EnumExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineEnumExtensions

### String GetDescription(Enum input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetDescription

### ReadOnlyCollection<ValueTuple<String, Int32>> GetItems(Enum input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetItems

### T Parse(String name)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Parse

*****
## ExceptionExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### IEnumerable<TSource> FromHierarchy(TSource source, Func<TSource, TSource> accumulatorFunction)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** FromHierarchy

### IEnumerable<TSource> FromHierarchy(TSource source, Func<TSource, TSource> nextItem, Func<TSource, Boolean> canContinuePreducate)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** FromHierarchy

### String GetAllMessages(Exception exception, Char& separator)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetAllMessages
* **Documentation:** https://bit.ly/SpargineAug2024

### ReadOnlyCollection<ValueTuple<String, String>> GetAllMessagesWithStackTrace(Exception exception)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/12/2020
* **Description:** GetAllMessagesWithStackTrace
* **Documentation:** https://bit.ly/SpargineAug2024
* **Modified By:** David McCarter

### Boolean IsCritical(Exception exception)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean IsFatal(Exception exception)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean IsSecurityOrCritical(Exception exception)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### T TraverseFor(Exception exception)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** TraverseFor

*****
## GuidExtensions

### String ToDigits(Guid input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToDigits

*****
## HashSetExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Void AddIf(HashSet<T> collection, T item, Boolean condition)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/2/2021
* **Description:** AddIf
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

### ConcurrentHashSet<T> ToConcurrentHashSet(HashSet<T> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/3/2021
* **Description:** ToConcurrentHashSet
* **Documentation:** https://bit.ly/SpargineJan2022
* **Modified By:** David McCarter

### ImmutableHashSet<T> ToImmutableHashSet(HashSet<T> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToImmutableHashSet
* **Modified By:** David McCarter

### Void Upsert(HashSet<T> collection, T item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/2/2021
* **Description:** Upsert
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

*****
## HttpClientExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Task<T> GetAndDeserializeAsync(HttpClient client, Uri url, JsonSerializerOptions options, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/13/2021
* **Description:** Original code from: https://ardalis.com/keep-tests-short-and-dry-with-extensions
* **Modified By:** David McCarter

*****
## HttpContextExtensions

### String GetRemoteIPAddress(HttpContext context)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 9/4/2017
* **Description:** Original code from: https://edi.wang/post/2017/10/16/get-client-ip-aspnet-20
* **Modified By:** David McCarter

*****
## HttpRequestExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Task<Byte[]> GetRawBodyBytesAsync(HttpRequest request, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 11/7/2023
* **Description:** GetRawBodyBytesAsync
* **Modified By:** David McCarter

### Task<String> GetRawBodyStringAsync(HttpRequest request, Encoding encoding, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 11/7/2023
* **Description:** GetRawBodyStringAsync
* **Modified By:** David McCarter

### Boolean TryGetBody(HttpRequest request, T& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 11/7/2023
* **Description:** TryGetBody
* **Modified By:** David McCarter

### Boolean TryGetBody(HttpRequest request, Byte[]& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 11/7/2023
* **Description:** TryGetBody
* **Modified By:** David McCarter

*****
## HttpResponseHeaderExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### String GetName(HttpResponseHeader header)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

*****
## ImmutableArrayExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean HasItems(ImmutableArray<T> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(ImmutableArray<T> list, Func<T, Boolean> actionPredicate)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(ImmutableArray<T> list, Int32 count)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### ImmutableArray<T> Shuffle(ImmutableArray<T> list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/27/2020
* **Description:** Shuffle
* **Modified By:** David McCarter

*****
## LinqExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 8/18/2020
* **Description:** LinqExtensions
* **Modified By:** David McCarter

### IQueryable<T> If(IQueryable<T> input, Boolean should, Func`2[] transformsFunction)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/18/2020
* **Description:** Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine
* **Modified By:** David McCarter

### IEnumerable<T> If(IEnumerable<T> input, Boolean should, Func`2[] transformsFunction)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/18/2020
* **Description:** Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine
* **Modified By:** David McCarter

*****
## ListExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineListExtentions

### Void AddFirst(List<T> collection, T item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Void AddLast(List<T> collection, T item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### List<T> AddRangeIfNotExists(List<T> collection, IEnumerable<T> items)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/30/2024
* **Description:** AddRangeIfNotExists
* **Modified By:** David McCarter

### ReadOnlySpan<T> AsReadOnlySpan(List<T> list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/30/2023
* **Description:** AsReadOnlySpan
* **Modified By:** David McCarter

### Span<T> AsSpan(List<T> list)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/3/2022
* **Description:** AsSpan
* **Modified By:** David McCarter

### Boolean ClearNulls(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/12/2020
* **Description:** ClearNulls
* **Modified By:** David McCarter

### Boolean DoesNotHaveItems(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2022
* **Description:** DoesNotHaveItems
* **Modified By:** David McCarter

### Int32 GenerateHashCode(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean HasItems(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/27/2021
* **Description:** HasItems
* **Modified By:** David McCarter

### Boolean HasItems(List<T> collection, Predicate<T> action)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Modified By:** David McCarter

### Boolean HasItems(List<T> collection, Int32 count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/27/2021
* **Description:** HasItems
* **Modified By:** David McCarter

### T IndexAtLooped(List<T> collection, Int32 index)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/17/2022
* **Description:** IndexAtLooped
* **Modified By:** David McCarter

### Boolean IsEqualTo(List<T> collection, List<T> collectionToCheck)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/22/2023
* **Description:** IsEqualTo
* **Modified By:** David McCarter

### Void PerformAction(List<T> collection, Action<T> action)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/4/2023
* **Description:** PerformAction
* **Modified By:** David McCarter

### Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> Pivot(IEnumerable<TSource> collection, Func<TSource, TFirstKey> firstKeySelectorFunction, Func<TSource, TSecondKey> secondKeySelectorFunction, Func<IEnumerable<TSource>, TValue> aggregateFunction)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** Pivot
* **Modified By:** David McCarter

### Boolean RemoveFirst(List<T> collection, T item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/30/2024
* **Description:** RemoveFirst
* **Modified By:** David McCarter

### Boolean RemoveLast(List<T> collection, T item)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/30/2024
* **Description:** RemoveLast
* **Modified By:** David McCarter

### Void Shuffle(List<T> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/30/2024
* **Description:** Shuffle
* **Modified By:** David McCarter

### ReadOnlyCollection<ReadOnlyCollection<T>> Split(List<T> collection, Int32 size)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/30/2024
* **Description:** Split
* **Modified By:** David McCarter

### Collection<T> ToCollection(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/21/2021
* **Description:** ToCollection
* **Modified By:** David McCarter

### DistinctBlockingCollection<T> ToDistinctBlockingCollection(List<T> collection, Boolean completeAdding)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/21/2021
* **Description:** ToDistinctBlockingCollection
* **Modified By:** David McCarter

### DistinctConcurrentBag<T> ToDistinctConcurrentBag(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/21/2021
* **Description:** ToDistinctConcurrentBag
* **Modified By:** David McCarter

### FastSortedList<T> ToFastSortedList(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/21/2021
* **Description:** ToFastSortedList
* **Modified By:** David McCarter

### FastSortedList<T> ToFastSortedList(List<T> collection, IComparer<T> comparer)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToFastSortedList

### FrozenSet<T> ToFrozenSet(List<T> list)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/3/2024
* **Description:** ToFrozenSet
* **Modified By:** David McCarter

### ImmutableArray<T> ToImmutableArray(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/3/2021
* **Description:** ToCollection
* **Modified By:** David McCarter

### Task<List<T>> ToListAsync(IAsyncEnumerable<T> collection, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/3/2021
* **Description:** ToListAsync
* **Modified By:** David McCarter

### ObservableCollection<T> ToObservableCollection(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToObservableCollection
* **Modified By:** David McCarter

### ObservableList<T> ToObservableList(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/21/2021
* **Description:** ToObservableList
* **Modified By:** David McCarter

### ReadOnlyCollection<T> ToReadOnlyCollection(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToReadOnlyCollection
* **Modified By:** David McCarter

### IReadOnlyList<T> ToReadOnlyList(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/10/2022
* **Description:** ToReadOnlyList
* **Modified By:** David McCarter

### ReadOnlyObservableCollection<T> ToReadOnlyObservableCollection(List<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/26/2022
* **Description:** ToObservableCollection
* **Modified By:** David McCarter

*****
## MathExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Double Add(Int32& input, Int32& add)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/19/2022
* **Description:** Add
* **Documentation:** https://bit.ly/SpargineNov2022
* **Modified By:** David McCarter

### Double CalculatePercent(TimeSpan& first, TimeSpan& second)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CalculatePercent

### Double CalculatePercent(Int32& first, Int32& second)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CalculatePercent

### Double CalculatePercent(Double& first, Double& second)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CalculatePercent

### Double CalculatePercent(Int64& first, Int64& second)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** CalculatePercent

### Boolean IsPrime(Int32& number)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2022
* **Description:** IsPrime
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Int32 Round(Double& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Round

### Int32 Round(Decimal& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Round

### Int32 Round(Double& value, Int32& digits)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Round

### Int32 Round(Double& value, MidpointRounding mode)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Round

### Int32 Round(Decimal& value, Int32& digits)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Round

### Int32 Round(Decimal& value, MidpointRounding mode)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Round

### Int32 Round(Double& value, Int32& digits, MidpointRounding mode)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Round

### Int32 Round(Decimal& value, Int32& digits, MidpointRounding mode)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Round

### Double Subtract(Int32& input, Int32& subtract)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/19/2022
* **Description:** Subtract
* **Documentation:** https://bit.ly/SpargineNov2022
* **Modified By:** David McCarter

*****
## NumericExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineNumericExtensions

### Double Average(Double& a, Double& b)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/19/2023
* **Description:** Average
* **Modified By:** David McCarter

### Int64 Average(Int64& a, Int64& b)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/19/2023
* **Description:** Average
* **Modified By:** David McCarter

### Int32 Average(Int32& a, Int32& b)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/19/2023
* **Description:** Average
* **Modified By:** David McCarter

### Decimal Average(Decimal& a, Decimal& b)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/19/2023
* **Description:** Average
* **Modified By:** David McCarter

### Double BytesToMegabytes(Int64 bytes)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/9/2024
* **Description:** BytesToMegabytes
* **Modified By:** David McCarter

### Int32 Decrement(Int32& value, Int32& lowerBound, Int32 step)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Decrement

### Int32 EnsureMinimum(Int32& value, Int32& minValue)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** EnsureMinimum

### String FormatSize(Int64& fileSize)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** FormatSize

### String FormatSize(Double fileSize)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** FormatSize

### Int32 Increment(Int32& value, Int32& upperBound, Int32 step)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Increment

### Boolean IsEven(Decimal& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsEven

### Boolean IsEven(Double& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsEven

### Boolean IsEven(Single& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsEven

### Boolean IsEven(Int32& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsEven

### Boolean IsEven(Int64& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsEven

### Boolean IsEven(SByte& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsEven

### Boolean IsEven(Int16& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsEven

### Boolean IsInRange(Int32& value, Int32& lower, Int32& upper)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsInRange

### Boolean IsInRange(Int64& value, Int64& lower, Int64& upper)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsInRange

### Boolean IsInRange(Double& value, Double& lower, Double& upper)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsInRange

### Boolean IsInRange(Decimal& value, Decimal& lower, Decimal& upper)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsInRange

### Boolean IsInRangeThrowsException(Double& value, Double& lower, Double& upper)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/5/2020
* **Description:** IsInRangeThrowsException
* **Modified By:** David McCarter

### Boolean IsInRangeThrowsException(Decimal& value, Decimal& lower, Decimal& upper)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/5/2020
* **Description:** IsInRangeThrowsException
* **Modified By:** David McCarter

### Boolean IsInRangeThrowsException(Int32& value, Int32& lower, Int32& upper)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/5/2020
* **Description:** IsInRangeThrowsException
* **Modified By:** David McCarter

### Boolean IsInRangeThrowsException(Int64& value, Int64& lower, Int64& upper)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/5/2020
* **Description:** IsInRangeThrowsException
* **Modified By:** David McCarter

### Boolean IsInterval(Int32& value, Int32& interval)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsInterval

### Boolean IsIntervalThrowsException(Int32& value, Int32& interval, String paramName)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/5/2020
* **Description:** IsIntervalThrowsException
* **Modified By:** David McCarter

### Boolean IsNegative(Double& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean IsNegative(Int32& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean IsNegative(Int64& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean IsNegative(SByte& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean IsNegative(Int16& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean IsNegative(Decimal& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean IsNegative(Single& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### String MillisecondsToString(Int64 totalMilliseconds)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/16/2003
* **Description:** MillisecondsToString
* **Modified By:** David McCarter

### String MillisecondsToString(TimeSpan& input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/16/2003
* **Description:** MillisecondsToString
* **Modified By:** David McCarter

### String MillisecondsToString(Int32 totalMilliseconds)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/16/2003
* **Description:** MillisecondsToString
* **Modified By:** David McCarter

### Int32 RoundToPowerOf2(Int32 value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** RoundToPowerOf2

### String ToFormattedString(Int32& input, NumericFormat format)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2020
* **Description:** ToFormattedString
* **Modified By:** David McCarter

### String ToFormattedString(Double& input, NumericFormat format)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2020
* **Description:** ToFormattedString
* **Modified By:** David McCarter

### String ToFormattedString(Int64& input, NumericFormat format)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2020
* **Description:** ToFormattedString
* **Modified By:** David McCarter

### String ToFormattedString(UInt64& input, NumericFormat format)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2020
* **Description:** ToFormattedString
* **Modified By:** David McCarter

### String ToFormattedString(UInt32& input, NumericFormat format)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2020
* **Description:** ToFormattedString
* **Modified By:** David McCarter

### String ToFormattedString(Int16& input, NumericFormat format)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2020
* **Description:** ToFormattedString
* **Modified By:** David McCarter

### String ToFormattedString(UInt16& input, NumericFormat format)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2020
* **Description:** ToFormattedString
* **Modified By:** David McCarter

### Int32 ToPositiveValue(Int32& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToPositiveValue

### Int64 ToPositiveValue(Int64& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToPositiveValue

### Decimal ToPositiveValue(Decimal& value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToPositiveValue

### String ToRomanNumeral(Int32 number)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToRomanNumeral

### String ToStringOrEmpty(Int32& value, Int32& lowerLimit, Int32& upperLimit, String defaultText)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToStringOrEmpty

### String ToWords(Int32 value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToWords

*****
## NumericFormat

### String DisplayName { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** DisplayName

### Int32 Value { get; set; }

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Value

*****
## ObjectExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineObjectExtensions

### T As(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** As

### T Clone(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Clone

### String ComputeSha256Hash(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ComputeSha256Hash

### Void DisposeFields(IDisposable obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** DisposeFields

### Int32 FastGetHashCode(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** FastGetHashCode

### TResult FromJson(String json)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/21/2022
* **Description:** FromJson
* **Modified By:** David McCarter

### Boolean HasProperty(Object obj, String& propertyName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** HasProperty

### Void InitializeFields(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** InitializeFields

### Boolean IsNotNull(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsNotNull

### Boolean IsNull(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsNull

### IDictionary<String, String> PropertiesToDictionary(Object obj, String memberName, Boolean ignoreNulls)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/19/2020
* **Description:** Original code by: Diego De Vita
* **Modified By:** David McCarter

### String PropertiesToString(Object obj, String header, Char keyValueSeparator, String sequenceSeparator, Boolean ignoreNulls, Boolean includeMemberName)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/19/2020
* **Description:** PropertiesToString
* **Modified By:** David McCarter

### String StripNull(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** StripNull

### String ToJson(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToJson

### SimpleResult<String> ToJson(Object obj, JsonSerializerOptions& options)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToJson

### Void ToJsonFile(Object obj, FileInfo file)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToJsonFile

### Void TryDispose(IDisposable obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** TryDispose

### Void TryDispose(IDisposable obj, Boolean throwException)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** TryDispose

*****
## ObservableCollectionExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean DoesNotHaveItems(ObservableCollection<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** DoesNotHaveItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(ObservableCollection<T> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(ObservableCollection<T> collection, Func<T, Boolean> actionPredicate)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(ObservableCollection<T> collection, Int32& count)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

*****
## ProcessExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Void EnsureHighPriority(Process process, ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### Void EnsureLowPriority(Process process, ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### Int32 RunProcessAndIgnoreOutput(String fileName, String arguments, TimeSpan& timeout)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### ValueTuple<Int32, String> RunProcessAndReadOutput(String fileName, String arguments, TimeSpan& timeout)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### Boolean TrySetPriority(Process process, ProcessPriorityClass priority, ILogger logger)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

*****
## ReadOnlyCollectionExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean DoesNotHaveItems(ReadOnlyCollection<T> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2022
* **Description:** DoesNotHaveItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Int32 GenerateHashCode(ReadOnlyCollection<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean HasItems(ReadOnlyCollection<T> collection, Func<T, Boolean> actionPredicate)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

*****
## ReadOnlySpanExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### T PickRandom(ReadOnlySpan<T> span)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/28/2021
* **Description:** PickRandom
* **Modified By:** David McCarter

*****
## SocketExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Int32 BindToAnonymousPort(Socket socket, IPAddress address)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Void ForceNonBlocking(Socket socket, Boolean force)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean TryConnect(Socket socket, EndPoint remoteEndpoint, Int32 millisecondsTimeout)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

*****
## SortedDictionaryExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean DoesNotHaveItems(SortedDictionary<TKey, TValue> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2022
* **Description:** DoesNotHaveItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(SortedDictionary<TKey, TValue> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(SortedDictionary<TKey, TValue> collection, Func<KeyValuePair<TKey, TValue>, Boolean> actionPredicate)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(SortedDictionary<TKey, TValue> collection, Int32& count)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### ImmutableSortedDictionary<TKey, TValue> ToImmutable(SortedDictionary<TKey, TValue> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToImmutable
* **Modified By:** David McCarter

### TValue Upsert(SortedDictionary<TKey, TValue> collection, TKey key, TValue value)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 4/28/2020
* **Description:** Upsert
* **Documentation:** https://bit.ly/SpargineJun2021
* **Modified By:** David McCarter

*****
## SortedSetExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean DoesNotHaveItems(SortedSet<T> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/17/2022
* **Description:** DoesNotHaveItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(SortedSet<T> collection)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### Boolean HasItems(SortedSet<T> collection, Func<T, Boolean> actionPredicate)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/15/2022
* **Description:** HasItems
* **Documentation:** https://bit.ly/SpargineAug2022
* **Modified By:** David McCarter

### ImmutableSortedSet<T> ToImmutableSortedSet(SortedSet<T> collection)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/21/2020
* **Description:** ToImmutableSortedSet
* **Modified By:** David McCarter

*****
## StreamExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Void FlushClose(Stream stream)

* **Status:** Available
* **Optimization Status:** NotRequired
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** FlushClose
* **Modified By:** David McCarter

*****
## StringBuilderExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** David McCarter
* **CreatedOn:** 5/26/2020
* **Description:** StringBuilderExtensions
* **Documentation:** ADD URL
* **Modified By:** David McCarter

### Void AppendBytes(StringBuilder sb, Byte[] bytes)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/26/2020
* **Description:** Original code from efcore-master on GitHub
* **Modified By:** David McCarter

### Void AppendKeyValue(StringBuilder sb, String key, String value, Boolean includeQuotes, Boolean includeComma)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** FROM .NET CORE SOURCE
* **Modified By:** David McCarter

### Void AppendValues(StringBuilder sb, String separator, IEnumerable<String> values)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/1/2020
* **Description:** Original code from efcore-master on GitHub.
* **Modified By:** David McCarter

### Void AppendValues(StringBuilder sb, String separator, String[] values)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/26/2020
* **Description:** Original code from efcore-master on GitHub
* **Modified By:** David McCarter

### Void AppendValues(StringBuilder sb, String separator, IEnumerable<T> values, Action<T> joinAction)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/26/2020
* **Description:** Original code from efcore-master on GitHub
* **Modified By:** David McCarter

### Void AppendValues(StringBuilder sb, String separator, IEnumerable<T> values, TParam param, Action<T, TParam> joinAction)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/26/2020
* **Description:** Original code from efcore-master on GitHub
* **Modified By:** David McCarter

### Void AppendValues(StringBuilder sb, String separator, IEnumerable<T> values, TParam1 param1, TParam2 param2, Action<StringBuilder, T, TParam1, TParam2> joinAction)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/26/2020
* **Description:** Original code from efcore-master on GitHub
* **Modified By:** David McCarter

### StringBuilder ClearSetCapacity(StringBuilder sb, Int32& capacity)

* **Status:** Available
* **Optimization Status:** NotRequired
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/13/2024
* **Description:** ClearSetCapacity
* **Modified By:** David McCarter

*****
## StringExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineStringExtensions

### Int32 CalculateByteArraySize(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/6/2024
* **Description:** CalculateByteArraySize
* **Modified By:** David McCarter

### String CombineToString(String input, String[] args)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 1/3/2023
* **Description:** Concat
* **Modified By:** David McCarter

### String ComputeHash(String input, HashType hashType)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** ComputeHash
* **Modified By:** David McCarter

### String ComputeSHA256Hash(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/15/2017
* **Description:** ComputeSHA256Hash
* **Modified By:** David McCarter

### String Concat(String input, String delimiter, Boolean addLineFeed, String[] args)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/15/2017
* **Description:** Concat
* **Modified By:** David McCarter

### Boolean ContainsAny(String input, StringComparison stringComparison, String[] characters)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/15/2017
* **Description:** ContainsAny
* **Modified By:** David McCarter

### String DefaultIfNull(String value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/15/2017
* **Description:** DefaultIfNull
* **Modified By:** David McCarter

### String DefaultIfNull(String value, String defaultValue)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/15/2017
* **Description:** DefaultIfNull
* **Modified By:** David McCarter

### String DefaultIfNullOrEmpty(String value, String defaultValue)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/15/2017
* **Description:** DefaultIfNullOrEmpty
* **Modified By:** David McCarter

### String[] DelimitedStringToArray(String input, Char& delimiter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/13/2020
* **Description:** DelimitedStringToArray
* **Modified By:** David McCarter

### Boolean EqualsIgnoreCase(String input, String inputToCompare)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** EqualsIgnoreCase
* **Modified By:** David McCarter

### Boolean EqualsOrBothNullOrEmpty(String input, String inputToCompare)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** EqualsOrBothNullOrEmpty
* **Modified By:** David McCarter

### String Extract(String input, String start, String end)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** Extract
* **Modified By:** David McCarter

### Boolean FastCompare(String value, String valueToCompare, StringComparison& comparison)

* **Status:** New
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 2/16/2025
* **Description:** FastCompare
* **Modified By:** David McCarter

### String FromBase64(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** FromBase64
* **Modified By:** David McCarter

### Task<String> FromBrotliStringAsync(String value, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/24/2020
* **Description:** FromBrotliStringAsync
* **Modified By:** David McCarter

### Task<String> FromDeflateStringAsync(String value, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/12/2022
* **Description:** FromDeflateStringAsync
* **Modified By:** David McCarter

### Task<String> FromGZipStringAsync(String value, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/24/2020
* **Description:** FromGZipStringAsync
* **Modified By:** David McCarter

### Task<String> FromZLibStringAsync(String value, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Optimize
* **BenchMarkStatus:** Benchmark
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/12/2022
* **Description:** FromZLibStringAsync
* **Modified By:** David McCarter

### Boolean HasValue(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** HasValue

### Boolean HasValue(String input, Int32 length)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** HasValue

### Boolean HasValue(String input, String value)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** HasValue

### Boolean HasValue(String input, String expression, RegexOptions options)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** HasValue

### Boolean HasValue(String input, Int32 minLength, Int32 maxLength)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** HasValue

### Boolean HasWhitespace(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### String Indent(String input, Int32& length, Char& indentationCharacter)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Indent

### Boolean IsAsciiDigit(Char& character)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/10/2021
* **Description:** IsAsciiDigit
* **Modified By:** David McCarter

### Boolean IsAsciiLetter(Char& character)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/30/2020
* **Description:** IsAsciiLetter
* **Modified By:** David McCarter

### Boolean IsAsciiLetterOrDigit(Char& character)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/30/2020
* **Description:** IsAsciiLetterOrDigit
* **Modified By:** David McCarter

### Boolean IsAsciiWhitespace(Char& character)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/10/2021
* **Description:** IsAsciiWhitespace
* **Modified By:** David McCarter

### Boolean IsCreditCardNumber(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsCreditCardNumber

### Boolean IsCurrencyCode(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsCurrencyCode

### Boolean IsDomainAddress(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsDomainAddress

### Boolean IsEmailAddress(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsEmailAddress

### Boolean IsEmpty(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/18/2020
* **Description:** IsEmpty
* **Modified By:** David McCarter

### Boolean IsFirstLastName(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsFirstLastName

### Boolean IsGuid(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/24/2017
* **Description:** IsGuid
* **Modified By:** David McCarter

### Boolean IsISBN(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsISBN

### Boolean IsMacAddress(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 3/24/2017
* **Description:** IsMacAddress
* **Modified By:** David McCarter

### Boolean IsNotEmpty(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 8/18/2020
* **Description:** IsNotEmpty
* **Modified By:** David McCarter

### Boolean IsOneToSevenAlpha(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsOneToSevenAlpha

### Boolean IsScientific(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsScientific

### Boolean IsString(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsString

### Boolean IsStringSHA1Hash(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 5/31/2021
* **Description:** IsStringSHA1Hash
* **Modified By:** David McCarter

### Boolean IsUrl(String input)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** IsUrl

### String RemoveCRLF(String input, String replacement)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** Kristine Tran
* **CreatedOn:** 2/1/2021
* **Description:** RemoveCRLF
* **Modified By:** Kristine Tran

### String ReplaceEllipsisWithPeriod(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ReplaceEllipsisWithPeriod

### ReadOnlyCollection<String> Split(String input, StringSplitOptions options, Char& separator)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### ReadOnlyCollection<String> Split(String input, StringSplitOptions options, Int32 count, Char& separator)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### ReadOnlyCollection<String> Split(String input, StringSplitOptions options, Int32 count, String separator)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### LineSplitEnumerator SplitLines(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 6/9/2022
* **Description:** SplitLines
* **Modified By:** David McCarter

### ReadOnlyCollection<String> SplitRemoveEmpty(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** SplitRemoveEmpty

### Boolean StartsWithOrdinal(String input, String inputToCompare)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** StartsWithOrdinal
* **Modified By:** David McCarter

### Boolean StartsWithOrdinalIgnoreCase(String input, String inputToCompare)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### String SubstringTrim(String input, Int32& startIndex, Int32& length)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** CheckPerformance
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** SubstringTrim
* **Modified By:** David McCarter

### String ToBase64(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** ToBase64
* **Modified By:** David McCarter

### Span<Byte> ToBase64ByteSpan(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 11/5/2024
* **Description:** ToBase64ByteSpan
* **Modified By:** David McCarter

### Task<String> ToBrotliStringAsync(String input, CompressionLevel level, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/24/2020
* **Description:** ToBrotliStringAsync
* **Modified By:** David McCarter

### Byte[] ToByteArray(String input, Encoding encoding)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 12/21/2022
* **Description:** ToByteArray
* **Modified By:** David McCarter

### Task<String> ToDeflateStringAsync(String input, CompressionLevel level, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/12/2022
* **Description:** ToDeflateStringAsync
* **Modified By:** David McCarter

### Task<String> ToGZipStringAsync(String input, CompressionLevel level, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/24/2020
* **Description:** ToGZipStringAsync
* **Modified By:** David McCarter

### String ToTitleCase(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 10/8/2020
* **Description:** ToTitleCase
* **Modified By:** David McCarter

### String ToTrimmed(String input)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** ToTrimmed

### Task<String> ToZLibStringAsync(String input, CompressionLevel level, CancellationToken cancellationToken)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** NotRequired
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 9/12/2022
* **Description:** ToZLibStringAsync
* **Modified By:** David McCarter

*****
## TaskExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Void FireAndForget(Task task)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/13/2021
* **Description:** Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App
* **Documentation:** https://bit.ly/SpargineSep2022
* **Modified By:** David McCarter

### Void FireAndForget(Task task, Action<Exception> action)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/13/2021
* **Description:** Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App
* **Documentation:** https://bit.ly/SpargineSep2022
* **Modified By:** David McCarter

*****
## ThreadExtensions

* **Status:** NeedsDocumentation
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None

### Boolean TrySetPriority(Thread thread, ThreadPriority priority)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### Void WaitUntil(Thread thread, TimeSpan interval)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** WaitUntil

### Void WaitUntil(Thread thread, TimeSpan interval, Int32 waitIterations)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** WaitUntil

*****
## TypeExtensions

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Documentation:** https://bit.ly/SpargineTypeExtension

### ReadOnlyCollection<MethodInfo> GetAllAbstractMethods(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetAllAbstractMethods

### IEnumerable<FieldInfo> GetAllDeclaredFields(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/30/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### IEnumerable<MethodInfo> GetAllDeclaredMethods(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/30/2020
* **Description:** Original Code .NET Core source.
* **Modified By:** David McCarter

### IEnumerable<FieldInfo> GetAllFields(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetAllFields

### ReadOnlyCollection<MethodInfo> GetAllGenericMethods(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### IEnumerable<MethodInfo> GetAllMethods(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### IEnumerable<PropertyInfo> GetAllProperties(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### ReadOnlyCollection<MethodInfo> GetAllPublicMethods(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### ReadOnlyCollection<MethodInfo> GetAllStaticMethods(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### TAttribute GetAttribute(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### TAttribute GetAttribute(MethodInfo methodInfo)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### TAttribute GetAttribute(PropertyInfo propertyInfo)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### TAttribute GetAttribute(FieldInfo fieldInfo)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### ReadOnlyCollection<String> GetImplementedInterfaces(Object input, String[] interfaceNames)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetImplementedInterfaces

### ReadOnlyCollection<MemberInfo> GetTypeMembersWithAttribute(Type type)

* **Status:** Updated
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### TypeOfType GetTypeOfType(Object obj)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** Completed
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** GetTypeOfType

### Boolean HasAttribute(MethodInfo methodInfo)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### Boolean HasBaseClass(Type type, Type baseClass)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/30/2020
* **Description:** From .NET Core source.
* **Modified By:** David McCarter

### Boolean HasParameterlessConstructor(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** HasParameterlessConstructor

### Boolean IsEnumerable(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** HasParameterlessConstructor
* **Documentation:** http://bit.ly/SpargineMarch2021

### Boolean IsNullable(Type type)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/15/2020
* **Description:** Original Code from: https://github.com/dotnet/BenchmarkDotNet.
* **Modified By:** David McCarter

### Boolean IsStatic(PropertyInfo property)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** David McCarter
* **CreatedOn:** 7/31/2020
* **Description:** From .NET EF Core source.
* **Modified By:** David McCarter

### T Max(T obj1, T obj2)

* **Status:** Available
* **Optimization Status:** None
* **BenchMarkStatus:** None
* **Unit Test Status:** Completed
* **Author:** UNKNOWN
* **Description:** Max

*****
## WebClientExtensions

### T ConvertFrom(WebClient client, Uri url)

* **Status:** Available
* **Optimization Status:** Completed
* **BenchMarkStatus:** None
* **Unit Test Status:** None
* **Author:** UNKNOWN
* **Description:** ConvertFrom

*****
**Generated by Spargine - dotNetTips.com on 3/5/2025 8:20:12 PM UTC**
