using System;

public class Circle
{
    // Thuộc tính
    private double radius;
    private string color;

    // Constructor mặc định
    public Circle()
    {
        radius = 1.0;
        color = "red";
    }

    // Constructor với tham số
    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    // Getter và Setter cho radius
    public double GetRadius()
    {
        return radius;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    // Getter và Setter cho color
    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    // Phương thức tính diện tích
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    // Ghi đè phương thức ToString
    public override string ToString()
    {
        return $"Circle [radius={radius}, color={color}, area={GetArea():F2}]";
    }
}

public class Cylinder : Circle
{
    // Thuộc tính
    private double height;

    // Constructor mặc định
    public Cylinder() : base()
    {
        height = 1.0;
    }

    // Constructor với tham số
    public Cylinder(double radius, string color, double height) : base(radius, color)
    {
        this.height = height;
    }

    // Getter và Setter cho height
    public double GetHeight()
    {
        return height;
    }

    public void SetHeight(double height)
    {
        this.height = height;
    }

    // Phương thức tính thể tích
    public double GetVolume()
    {
        return GetArea() * height;
    }

    // Ghi đè phương thức ToString
    public override string ToString()
    {
        return $"Cylinder [radius={GetRadius()}, color={GetColor()}, height={height}, volume={GetVolume():F2}]";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Kiểm thử Circle
        Console.WriteLine("===== Circle Test =====");
        Circle circle1 = new Circle();
        Console.WriteLine(circle1);

        Circle circle2 = new Circle(3.5, "blue");
        Console.WriteLine(circle2);

        circle2.SetRadius(5.0);
        circle2.SetColor("green");
        Console.WriteLine($"Updated Circle: {circle2}");

        // Kiểm thử Cylinder
        Console.WriteLine("\n===== Cylinder Test =====");
        Cylinder cylinder1 = new Cylinder();
        Console.WriteLine(cylinder1);

        Cylinder cylinder2 = new Cylinder(3.0, "yellow", 7.0);
        Console.WriteLine(cylinder2);

        cylinder2.SetRadius(4.0);
        cylinder2.SetHeight(10.0);
        cylinder2.SetColor("purple");
        Console.WriteLine($"Updated Cylinder: {cylinder2}");
    }
}
