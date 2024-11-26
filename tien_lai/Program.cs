using System;
using System.Data.SqlTypes;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập số tiền gưi của bạn vào đây");
        double a = Double.Parse(Console.ReadLine());

        Console.WriteLine("Nhập số tỉ lệ lãi xuất(% năm): ");
        double b = Double.Parse(Console.ReadLine());

        Console.WriteLine("Nhập số tháng mà bạn muón gửi: ");
        int c = Int32.Parse(Console.ReadLine());

        // Chuyển đổi lãi suất sang % tháng
        double d = b / 100 / 12;


        double totalInterest = 0;
        for ( int month = 1; month <= c ; month++ )
        {
            double monthlyInterest =  a * d;
            totalInterest += monthlyInterest;
        }

        double totalAmount = a + totalInterest;


        Console.WriteLine($" Tổng số tiền lãi : {totalInterest:N0} VND");
        Console.WriteLine($"Tổng số tiền phải trả sau {c} tháng: {totalAmount:N0} VND");





    }
}