using System;
using System.Collections;

public class ArrayListDemo
{
	public static void Main()
	{
		ArrayList arrayList1 = new ArrayList();
		arrayList1.Add(101);
		arrayList1.Add("James");
//		arrayList1.Add("James");
//		arrayList1.Add(" ");
		arrayList1.Add(true);
		arrayList1.Add(4.5);
//		arrayList1.Add(null);

		foreach (var item in arrayList1)
		{
			Console.WriteLine(item);
		}

		var arrayList2 = new ArrayList()
		{
			102, "Smith", "Smith", true, 15.6
		};

	foreach (var item in arrayList2)
	{
	Console.WriteLine(item);
	}

	int firstElement = (int)arrayList1[0];
	string secondElement = (string)arrayList1[1];
	Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");

	var firstItem = arrayList1[0];
	var secondItem = arrayList1[1];
	Console.WriteLine($"First Item: {firstItem}, Second Iten: {secondItem}");

	arrayList1[0] = "Smith";
	arrayList1[1] = 1010;

	Console.WriteLine("Using ForEach Loop");
	foreach (var item in arrayList1)
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine("\n\nUsing For Loop");
	for (int i = 0; i < arrayList1.Count; i++)
	{
		Console.Write($"{arrayList1[i]} ");
	}

	ArrayList arrayList = new ArrayList()
	{
		101,
			"James",
			true,
			10.20
	};

	arrayList.Insert(0, "First Element");

	arrayList.Insert(2, "Third Element");

	foreach (var item in arrayList)
	{
		Console.WriteLine($"{item}");
	}


	ArrayList arrayList3 = new ArrayList()
	{
		"India",
			"USA",
			"UK",
			"Nepal"
	};
	Console.WriteLine("Array List elements");
	foreach (var item in arrayList3)
	{
		Console.Write($"{item} ");
	}

	ArrayList arrayList4 = new ArrayList()
	{
		"Srilanka",
			"Japan",
			"Britem"
	};
	arrayList3.InsertRange(2, arrayList4);

	Console.WriteLine("\n\nArray List Elements After InsertRange");
	foreach (var item in arrayList3)
	{
		Console.Write($"{item} ");
	}


	ArrayList arrayList5 = new ArrayList()
	{
		"India",
			"USA",
			"UK",
			"Nepal",
			"HongKong",
			"Srilanka",
			"Japan",
			"Britem",
			"HongKong",
	};

	Console.WriteLine("Array List Elements");
	foreach (var item in arrayList5)
	{
		Console.Write($"{item} ");
	}

	arrayList5.Remove("HongKong");
	Console.WriteLine("\n\nArray List Elements After Removing First Occurances of HongKong");
	foreach (var item in arrayList5)
	{
		Console.Write($"{item} ");
	}

	arrayList5.RemoveAt(3);
	Console.WriteLine("\n\nArray List Elements After Removing Element from Index 3");
	foreach (var item in arrayList5)
	{
		Console.Write($"{item} ");
	}

	arrayList5.RemoveRange(0, 2);
	Console.WriteLine("\n\nArray List Elements After Removing First Two Elemnets");
	foreach (var item in arrayList5)
	{
		Console.Write($"{item} ");
	}


	ArrayList arrayList6 = new ArrayList()
	{
		"India",
			"USA",
			"UK",
			"Denmark",
			"Nepal",
	};

	int totalItems = arrayList6.Count;
	Console.WriteLine(string.Format($"Total Items: {totalItems}, Capacity: {arrayList.Capacity}"));
	arrayList6.Clear();

	totalItems = arrayList6.Count;
	Console.WriteLine(string.Format($"Total Items After Clear(): {totalItems}, Capacity: {arrayList6.Capacity}"));

	ArrayList arrayList7 = new ArrayList()
	{
		"India",
			"UK",
			"Nepal",
			101
	};

	Console.WriteLine("Array List Elements");
	foreach (var item in arrayList7)
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine($"\n\nIs ArrayList Contains India: {arrayList7.Contains("India")}");
	Console.WriteLine($"Is ArrayList Contains USA: {arrayList7.Contains("USA")}");
	Console.WriteLine($"Is ArrayList Contains 101: {arrayList7.Contains(101)}");
	Console.WriteLine($"Is ArrayList Contains 10.5: {arrayList7.Contains(10.5)}");

	ArrayList arrayList8 = new ArrayList()
	{
		"India",
			"USA",
			"UK",
			"Denmark",
			"HongKong",
	};

	Console.WriteLine("Array List Elements:");
	foreach (var item in arrayList8)
	{
		Console.WriteLine($"{item} ");
	}

	ArrayList cloneArrayList = (ArrayList)arrayList8.Clone();
	Console.WriteLine("\nCloned ArrayList Elements:");
	foreach (var item in cloneArrayList)
	{
		Console.WriteLine($"{item} ");
	}

	object[] arrayListCopy = new object[arrayList.Count];
	arrayList8.CopyTo(arrayListCopy);
	Console.WriteLine("\nArrayList Copy Array Elements:");
	foreach (var item in arrayListCopy)
	{
		Console.WriteLine(item);
	}

	ArrayList arrayList9 = new ArrayList()
	{
		"India",
			"USA",
			"UK",
			"Denmark",
			"Nepal",
			"HongKong",
			"Australia",
			"Srilanka",
			"Japan",
			"Britem",
			"Brazil",
	};

	Console.WriteLine("Array List Elements Before Sorting");
	foreach (var item in arrayList9)
	{
		Console.Write($"{item} ");
	}

	arrayList9.Sort();
	Console.WriteLine("\n\nArray List Elements After Sorting");
	foreach (var item in arrayList9)
	{
		Console.Write($"{item} ");
	}

Console.ReadKey();
	}
}
