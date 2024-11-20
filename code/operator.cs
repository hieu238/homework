using System;
using System.Security.Cryptography.X509Certificates;

class Operator
{
    static void Main()
    {
        double width,height,area;

        Console.WriteLine("Nhập chiều cao vào đây: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập chiều rộng vào đây: ");
        width = Convert.ToDouble(Console.ReadLine());


        area = width * height;

        Console.WriteLine("Diện tích hình chữa nhật của bạn là: " + area);

        Console.ReadKey();
    }
}