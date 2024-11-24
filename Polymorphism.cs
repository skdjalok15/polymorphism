public class Shape
{
    public virtual double Area() 
    {
        return 0;
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area() 
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double width, height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area() 
    {
        return width * height;
    }
}

// Example of polymorphism in action
Shape myShape1 = new Circle(5);
Shape myShape2 = new Rectangle(4, 6);

Console.WriteLine("Circle Area: " + myShape1.Area()); // Outputs: Circle Area: 78.5398
Console.WriteLine("Rectangle Area: " + myShape2.Area()); // Outputs: Rectangle Area: 24
