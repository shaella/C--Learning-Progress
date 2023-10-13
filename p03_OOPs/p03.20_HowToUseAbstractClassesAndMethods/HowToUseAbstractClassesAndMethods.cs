using System;
namespace AbstractClassesAndMethods
{
	public abstract class Plan
	{
		protected abstract double getRate();
		public void Calculation(int units)
		{
			double rate = getRate();
			Console.WriteLine($"Bill Amount For {units} Units is: Rs. {rate * units}");
		}
	}

	class CommercialPlan : Plan
	{
		protected override double getRate()
		{
			return 5.00;
		}
	}

	class DomesticPlan : Plan
	{
		protected override double getRate()
		{
			return 2.50;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(10, 20);
			Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

			Triangle triangle = new Triangle(15, 25);
                        Console.WriteLine($"Area of Triangle: {triangle.GetArea()}");

			Circle circle = new Circle(12);
                        Console.WriteLine($"Area of Circle: {circle.GetArea()}");

			Cone cone = new Cone(5, 15);
                        Console.WriteLine($"Area of Cone: {cone.GetArea()}");


			Plan p;
			Console.WriteLine("Commercial Plan");
			p = new CommercialPlan();
			p.Calculation(250);

			Console.WriteLine("Domestic Plan");
			p = new DomesticPlan();
			p.Calculation(150);

			Console.ReadKey();
		}
	}

public abstract class Shape
{
	public double Height;
	public double Width;
	public double Radius;
	public const float PI = 3.14f;
	public abstract double GetArea();
}

public class Rectangle : Shape
{
	public Rectangle(double Height, double Width)
	{
		this.Height = Height;
		this.Width = Width;
	}

	public override double GetArea()
	{
		return Width * Height;
	}
}
public class Circle : Shape
{
	public Circle(double Radius)
	{
		this.Radius = Radius;
	}

	public override double GetArea()
        {
                return PI * Radius * Radius;
        }
}
public class Triangle : Shape
{
	public Triangle(double Height, double Width)
	{
		this.Height = Height;
		this.Width = Width;
	}

	public override double GetArea()
        {
                return (Width * Height) / 2;
        }
}
public class Cone : Shape
{
	public Cone(double Radius, double Height)
	{
		this.Radius = Radius;
		this.Height = Height;
	}

	public override double GetArea()
        {
                return PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
}
}
