public abstract class Shape
{
	public abstract int GetArea();
}

public class Rectangle : Shape
{
	public int Width { get; set; }
	public int Height { get; set; }

	public Rectangle(int width, int height)
	{
		Width = width;
		Height = height;
	}

	public override int GetArea()
	{
		return (Width * Height);
	}
}

public class Square: Shape
{
	public int Side { get; set; }

	public Square(int side)
	{
		Side = side;
	}

	public override int GetArea()
	{
		return Side;
	}
}

class Program
{
	static void Main()
	{
		Shape rectangle = new Rectangle(7, 3);
		Shape square = new Square(5);

		Console.WriteLine(rectangle.GetArea());
		Console.WriteLine(square.GetArea());
	}
}
