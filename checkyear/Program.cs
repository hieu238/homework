using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập năm cần kiểm tra: ");

        int a = Convert.ToInt32(Console.ReadLine());

        if(a % 400 == 0)
        {
            Console.WriteLine($"{a} là năm nhuận");
        }
        else if( a % 4 == 0 && a % 100 !=0)
        {
            Console.WriteLine($"{a} là năm nhuận");
        }
        else
        {
            Console.WriteLine($"{a} không phải là năm nhuận");
        }
    }
}