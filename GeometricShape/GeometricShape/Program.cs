using GeometricShape;
class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(2, "Circle1");
        Rectangle rectangle = new Rectangle("Rectangle1", 10, 7.5);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter()); 

        Console.WriteLine();

        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());
    }
}