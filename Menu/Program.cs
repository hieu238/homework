using System;

class Program
{
    static void Main(string[] args)
    {
        int choice; // Biến lưu lựa chọn của người dùng

        do
        {
            // Hiển thị menu
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            // Đọc lựa chọn từ người dùng
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number between 0 and 3.");
                continue; // Quay lại hiển thị menu
            }

            // Xử lý lựa chọn bằng switch-case
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nDraw the triangle:");
                    for (int i = 6; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("\nDraw the square:");
                    for (int i = 1; i <= 6; i++)
                    {
                        for (int j = 1; j <= 6; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("\nDraw the rectangle:");
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int j = 1; j <= 6; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 0:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("No choice! Please select a valid option.");
                    break;
            }

        } while (choice != 0); // Lặp lại menu nếu người dùng chưa chọn thoát (0)
    }
}
