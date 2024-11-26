using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n*** Prime Number Checker ***");
            Console.Write("Enter a positive integer to check (or '0' to exit): ");

            if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
                continue;
            }

            if (number == 0)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
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
