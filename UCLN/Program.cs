using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Tìm Ước Số Chung Lớn Nhất (USCLN) ***");

        // Nhập hai số nguyên từ người dùng
        Console.Write("Nhập số nguyên thứ nhất: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên thứ hai: ");
        int b = int.Parse(Console.ReadLine());

        // Gọi hàm tính USCLN
        int gcd = FindGCD(a, b);

        Console.WriteLine($"Ước số chung lớn nhất của {a} và {b} là: {gcd}");
    }

    // Hàm tính USCLN bằng thuật toán Euclid
    static int FindGCD(int a, int b)
    {
        a = Math.Abs(a); // Lấy giá trị tuyệt đối để xử lý số âm
        b = Math.Abs(b);

        while (b != 0) // Lặp đến khi số thứ hai là 0
        {
            int temp = b; 
            b = a % b;   // Lấy phần dư
            a = temp;    // Gán giá trị mới cho a
        }

        return a; // Khi b = 0, a là USCLN
    }
}
