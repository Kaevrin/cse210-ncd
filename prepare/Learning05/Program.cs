using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Red", 5);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        shapes.Add(rectangle);
        Circle circle = new Circle("Yellow", 3);
        shapes.Add(circle);
        foreach (Shape shape in shapes) {
            Console.WriteLine($"{shape.GetType().Name}");
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}