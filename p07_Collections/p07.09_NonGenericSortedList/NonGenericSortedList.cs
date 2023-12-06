using System;
using System.Collections;

public class SortedListDemo
{
	public static void Main(string[] args)
	{
		SortedList sortedList = new SortedList();

		sortedList.Add(1, "One");
		sortedList.Add(5, "Five");
		sortedList.Add(4, "Four");
		sortedList.Add(2, "Two");
		sortedList.Add(3, "Three");

		Console.WriteLine($"Accessing SortedList using For loop");
		for (int x = 0; x < sortedList.Count; x++)
		{
			Console.WriteLine($"Key: {sortedList.GetKey(x)}, Value: {sortedList.GetByIndex(x)}");
		}

		Console.WriteLine("\nAccessing SortedList using For Each loop");
		foreach (DictionaryEntry item in sortedList)
		{
			Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
		}

		Console.WriteLine("\nAccessing SortedList using Keys");
		Console.WriteLine($"Key: 1, Value: {sortedList[1]}");
		Console.WriteLine($"Key: 2, Value: {sortedList[2]}");
		Console.WriteLine($"Key: 3, Value: {sortedList[3]}");

		Console.WriteLine("\nAccessing SortedList using Index");
		Console.WriteLine($"Key: 1, Index: 0, Value: {sortedList.GetByIndex(0)}");
		Console.WriteLine($"Key: 2, Index: 1, Value: {sortedList.GetByIndex(1)}");
		Console.WriteLine($"Key: 3, Index: 2, Value: {sortedList.GetByIndex(2)}");


		SortedList sortedList2 = new SortedList
		{
			{ "Ind", "India" },
				{ "USA", "United State of America" },
				{ "SA", "South Africa" },
				{ "PAK", "Pakistan" }
		};

		Console.WriteLine("SortedList Elements");
		foreach (DictionaryEntry item in sortedList2)
		{
			Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
		}


		Console.WriteLine("Is Ind Key Exists : " + sortedList2.Contains("Ind"));
		Console.WriteLine("Is NZ Key Exists : " + sortedList2.Contains("NZ"));

		Console.WriteLine("Is Ind Key Exists : " + sortedList2.ContainsKey("Ind"));
		Console.WriteLine("Is NZ Key Exists : " + sortedList2.ContainsKey("NZ"));

		Console.WriteLine("Is India value Exists : " + sortedList2.ContainsValue("India"));
		Console.WriteLine("Is Bangladesh value Exists : " + sortedList2.ContainsValue("Bangladesh"));


		SortedList cloneSortedList = (SortedList)sortedList2.Clone();
		foreach (DictionaryEntry item in cloneSortedList)
		{
			Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
		}


		DictionaryEntry[] myTargetArray = new DictionaryEntry[5];
		sortedList2.CopyTo(myTargetArray, 1);
		Console.WriteLine("\nCopyTo Method to Copy Keys and Values:");
		for (int i = 0; i < myTargetArray.Length; i++)
		{
			Console.WriteLine($"{myTargetArray[i].Key} : {myTargetArray[i].Value}");
		}

		Object[] myObjArrayKey = new Object[5];
		Object[] myObjArrayValue = new Object[5];

		Console.WriteLine("\nCopyTo Method to Copy Keys:");
		sortedList2.Keys.CopyTo(myObjArrayKey, 0);
		foreach (var key in myObjArrayKey)
		{
			Console.WriteLine($"{key} ");
		}

		Console.WriteLine("\nCopyTo Method to Copy Values:");
		sortedList2.Values.CopyTo(myObjArrayValue, 1);
		foreach (var key in myObjArrayValue)
		{
			Console.WriteLine($"{key} ");
		}


		sortedList2.Remove("PAK");

		Console.WriteLine("\nSortedList Elements After Remove Method");
		foreach (DictionaryEntry item in sortedList2)
		{
			Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
		}

		sortedList2.RemoveAt(1);
		Console.WriteLine("\nSortedList Elements After RemoveAt Method");
		foreach (DictionaryEntry item in sortedList2)
		{
			Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
		}

		sortedList2.Clear();
		{
			Console.WriteLine($"After Clear Method Total Key-Value Pair Present is : {sortedList2.Count} ");
		}

		Console.ReadKey();
	}
}
