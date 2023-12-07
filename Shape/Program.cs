using System;

class Shape
{
    // Virtual method to calculate area (returns 0 by default)
    public virtual float CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    // Properties
    private float radius;

    // Constructor
    public Circle(float radius)
    {
        this.radius = radius;
    }

    // Override CalculateArea method to calculate area of a circle
    public override float CalculateArea()
    {
        return (float)(Math.PI * Math.Pow(radius, 2));
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Circle class with a radius of 5
        Circle myCircle = new Circle(5);

        // Call the CalculateArea method and print out the result
        float area = myCircle.CalculateArea();
        Console.WriteLine($"Area of the circle: {area} square units");
    }
}
