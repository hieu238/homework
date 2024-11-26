using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** In 20 số nguyên tố đầu tiên ***");
        int count = 0; // Đếm số lượng số nguyên tố đã tìm được
        int number = 2; // Bắt đầu kiểm tra từ số 2

        while (count < 20) // Dừng khi đã tìm đủ 20 số nguyên tố
        {
            if (IsPrime(number))
            {
                Console.Write($"{number} "); // In số nguyên tố ra màn hình
                count++; // Tăng số lượng số nguyên tố tìm được
            }
            number++; // Kiểm tra số tiếp theo
        }

        Console.WriteLine("\nHoàn thành!");
    }

    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int num)
    {
        if (num < 2) return false; // Số nhỏ hơn 2 không phải số nguyên tố

        for (int i = 2; i <= Math.Sqrt(num); i++) // Kiểm tra từ 2 đến căn bậc hai của num
        {
            if (num % i == 0) return false; // Nếu chia hết thì không phải số nguyên tố
        }

        return true; // Nếu không chia hết cho bất kỳ số nào, là số nguyên tố
    }
}
