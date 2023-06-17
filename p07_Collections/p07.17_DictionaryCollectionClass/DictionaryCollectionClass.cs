using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericDictionary
{
	class Program
	{
		static void Main()
		{
			Dictionary<string, string> dictionaryCountries4 = new Dictionary<string, string>
			{
				{ "UK", "United Kingdom" },
					{ "USA", "United State of America" }
			};
			dictionaryCountries4["IND"] = "India";
			dictionaryCountries4["PAK"] = "Pakistan";
			dictionaryCountries4["SL"] = "Srilanka";
			foreach (var item in dictionaryCountries4)
			{
				Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
			}

			Dictionary<string, string> dictionaryCountries5 = new Dictionary<string, string>
			{
				{ "UK", "United Kingdom" },
					{ "USA", "United State of America" },
					{ "IND", "India"},
					{ "SL", "Srilanka"}
			};
			Console.WriteLine("Before Updating the Key UK and IND");
			Console.WriteLine($"USA:{dictionaryCountries5["UK"]}");
			Console.WriteLine($"IND:{dictionaryCountries5["IND"]}");

			dictionaryCountries5["UK"] = "United Kingdom Updated";
			dictionaryCountries5["IND"] = "India Updated";
			Console.WriteLine("\nAfter Updating the Key UK and IND");
			Console.WriteLine($"USA: {dictionaryCountries5["UK"]}");
			Console.WriteLine($"IND: {dictionaryCountries5["IND"]}");


			Dictionary<string, string> dictionaryCountries3 = new Dictionary<string, string>
			{
				{ "UK", "United Kingdom" },
					{ "USA", "United States of America" },
					{ "IND", "India" },
					{ "PAK", "Paskistan" },
					{ "SL", "Srilanka" }
			};

			Console.WriteLine($"Iterating Dictionary Using AsParallel().ForAll Method");
			dictionaryCountries3.AsParallel().ForAll(entry => Console.WriteLine(entry.Key + ":" + entry.Value));

			Console.WriteLine($"Dictionary Elements Count Before Removing: {dictionaryCountries3.Count}");
			foreach (var item in dictionaryCountries3)
			{
				Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
			}

			if (dictionaryCountries3.ContainsKey("PAK"))
			{
				dictionaryCountries3.Remove("PAK");
				Console.WriteLine($"\nDictionary Elements Count After Removing PAK: {dictionaryCountries3.Count}");
				foreach (var item in dictionaryCountries3)
				{
					Console.WriteLine($"Key: {item.Key}, Value:{item.Value}");
				}
			}

			dictionaryCountries3.Clear();
			Console.WriteLine($"\nDictionary Elements Count After Clear: {dictionaryCountries3.Count}");

			Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();
			dictionaryCountries.Add("UK", "London, Manchester, Birmingham");
			dictionaryCountries.Add("USA", "Chicago, New York, Washington");
			dictionaryCountries.Add("IND", "Mumbai, Delhi, Bhubaneswar");
			Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
			foreach (KeyValuePair<string, string> KVP in dictionaryCountries)
			{
				Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
			}
			Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
			for (int i = 0; i < dictionaryCountries.Count; i++)
			{
				string key = dictionaryCountries.Keys.ElementAt(i);
				string value = dictionaryCountries[key];
				Console.WriteLine($"Key: {key}, Value: {value}");
			}
			Console.WriteLine("\nAccessing Dictionary Elements using Keys");
			Console.WriteLine($"Key: UK, Value: {dictionaryCountries["UK"]}");
			Console.WriteLine($"Key: USA, Value: {dictionaryCountries["USA"]}");
			Console.WriteLine($"Key: IND, Value: {dictionaryCountries["IND"]}");


			Dictionary<string, string> dictionaryCountries2 = new Dictionary<string, string>()
			{
				{"UK2", "London, Manchester, Birmingham2"},
					{"USA2", "Chicago, New York, Washington2"},
					{"IND2", "Mumbai, Delhi, Bhubaneswar2"}
			};
			Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
                        foreach (KeyValuePair<string, string> KVP in dictionaryCountries2)
                        {
                                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
			}


			Console.WriteLine("\nIs USA Key Exists : " + dictionaryCountries.ContainsKey("USA"));
			Console.WriteLine("\nIs PAK Key Exists : " + dictionaryCountries.ContainsKey("PAK"));
			Console.WriteLine("\nIs India value Exists : " + dictionaryCountries.ContainsValue("India"));
			Console.WriteLine("\nIs Srilanka value Exists : " + dictionaryCountries.ContainsValue("Srilanka"));

			Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
			{
				{ 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
					{ 102, new Student() { ID = 102, Name ="Mohanty", Branch="CSE"} },
					{ 103, new Student() { ID = 103, Name ="Sambit", Branch="ETC"}}
			};
			foreach (KeyValuePair<int, Student> item in dictionaryStudents)
			{
				Console.WriteLine($"Key: {item.Key}, ID:{item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
			}

			Student std102;
			if (dictionaryStudents.TryGetValue(102, out std102))
			{
				Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
				Console.WriteLine($"ID: {std102.ID}, Name: {std102.Name}, Branch: {std102.Branch}");
			}
			else
			{
				Console.WriteLine("\nStudent with Key 102 is not found in the dictionary");
			}
			Student std105;
                        if (dictionaryStudents.TryGetValue(105, out std105))
                        {
                                Console.WriteLine("\nStudent with Key = 105 is found in the dictionary");
                                Console.WriteLine($"ID: {std105.ID}, Name: {std105.Name}, Branch: {std105.Branch}");
                        }
                        else
                        {
                                Console.WriteLine("\nStudent with Key 105 is not found in the dictionary");
                        }

			Student[] arrayStudents = new Student[3];
			arrayStudents[0] = new Student() { ID = 101, Name = "Anurag", Branch = "CSE" };
			arrayStudents[1] = new Student() { ID = 102, Name = "Mohanty", Branch = "CSE" };
			arrayStudents[2] = new Student() { ID = 103, Name = "Sambit", Branch = "ETC" };
			Dictionary<int, Student> dictionaryStudents1 = arrayStudents.ToDictionary(std => std.ID, std => std);

			foreach (KeyValuePair<int, Student> item in dictionaryStudents)
			{
				Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
			}

			Console.WriteLine("All Keys in Student Dictionary");
			foreach (int key in dictionaryStudents.Keys)
			{
				Console.WriteLine(key + " ");
			}

			Console.WriteLine("\nAll Keys and Values in Student Dictionary");
                        foreach (int key in dictionaryStudents.Keys)
                        {
                                var student = dictionaryStudents[key];
				Console.WriteLine($"Key: {key}, ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
			}

			Console.WriteLine("\nAll Students objects in Student Dictionary");
			foreach (Student student in dictionaryStudents.Values)
			{
				Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
			}

			Console.ReadKey();
		}
	}

	public class Student
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Branch { get; set; }
	}
}
