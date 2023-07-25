using GeometricShape;
class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(2);
        Rectangle rectangle = new Rectangle(10, 7.5);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter()); 

        Console.WriteLine();

        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());
    }
}