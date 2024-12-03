using System;

public class Fan
{
    // Các hằng để biểu thị tốc độ quạt
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    // Các trường (fields) của lớp Fan
    private int speed;
    private bool on;
    private double radius;
    private string color;

    // Constructor không tham số (fan mặc định)
    public Fan()
    {
        speed = SLOW;
        on = false;
        radius = 5;
        color = "blue";
    }

    // Getter và Setter cho thuộc tính speed
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    // Getter và Setter cho thuộc tính on
    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    // Getter và Setter cho thuộc tính radius
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    // Getter và Setter cho thuộc tính color
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Phương thức ToString để hiển thị thông tin quạt
    public override string ToString()
    {
        if (on)
        {
            return $"Fan is on: Speed = {speed}, Color = {color}, Radius = {radius}";
        }
        else
        {
            return $"Fan is off: Color = {color}, Radius = {radius}";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo đối tượng Fan 1 với các giá trị lớn nhất
        Fan fan1 = new Fan
        {
            Speed = Fan.FAST,
            Radius = 10,
            Color = "yellow",
            On = true
        };

        // Tạo đối tượng Fan 2 với giá trị trung bình và tắt
        Fan fan2 = new Fan
        {
            Speed = Fan.MEDIUM,
            Radius = 5,
            Color = "blue",
            On = false
        };

        // Hiển thị thông tin của 2 đối tượng
        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString());
    }
}
