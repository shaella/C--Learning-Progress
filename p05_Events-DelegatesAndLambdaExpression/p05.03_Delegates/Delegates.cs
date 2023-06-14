using System;
using System.Reflection;
namespace Delegates
{
	public delegate void WorkPerformedHandler(int hours, WorkType workType);
	public delegate void CallbackMethodHandler(string message);
	public delegate void DoSomeMethodHandler(string message2);

	class Program
	{
		static void Main(string[] args)
		{
			SomeClass obj3 = new SomeClass();
			DoSomeMethodHandler del3 = new DoSomeMethodHandler(obj3.DoSomework);
			MethodInfo Method = del3.Method;
			object Target = del3.Target;
			Delegate[] InvocationList = del3.GetInvocationList();
			Console.WriteLine($"Method Property: {Method}");
			Console.WriteLine($"Target Property: {Target}");
			foreach (var item in InvocationList)
			{
				Console.WriteLine($"InvocationList: {item}");
			}
			
			Program obj = new Program();
			CallbackMethodHandler del2 = new CallbackMethodHandler(obj.CallbackMethod);
			DoSomework(del2);

			
			WorkPerformedHandler del1 = new WorkPerformedHandler(Manager_WorkPerformed);
			del1(10, WorkType.Golf);
			Console.ReadKey();
		}
		public static void Manager_WorkPerformed(int workHours, WorkType wType)
		{
			Console.WriteLine("Work Performed by Event Handler");
			Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
		}


		public static void DoSomework(CallbackMethodHandler del2)
		{
			Console.WriteLine("Processing some Task");
			del2("Pranaya");
		}

		public void CallbackMethod(string message)
		{
			Console.WriteLine("CallbackMethod Executed");
			Console.WriteLine($"Hello: {message}, Good Morning");
		}
	}

	public enum WorkType
	{
		Golf,
		GotoMeetings,
		GenerateReports
	}

	public class SomeClass
	{
		public void DoSomework(string message)
		{
			Console.WriteLine("DoSomework Executed");
			Console.WriteLine($"Hello: {message}, Good Morning");
		}
	}

}
