using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Print the rectangel");
            Console.WriteLine("2. Print the squar triangel");
            Console.WriteLine("3. Print the isosceles triangel");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    PrintRectangel();
                    break;
                case 2:
                    PrintSquareTriangel();
                    break;
                case 3:
                    PrintIsoscelesTriangel();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program. Goodbye! ");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choice agin:");
                    break;
            }
        }
    }
    static void PrintRectangel()
    {
        Console.WriteLine("Enter the width of the Rectangel: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the Rectangel: ");
        int height = int.Parse(Console.ReadLine());
        
        
        Console.WriteLine("\nRectangel: ");
        for(int i = 0; i < height;i++)
        {
            for(int j = 0; j < width; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    static void PrintSquareTriangel()
    {
        Console.WriteLine("\nSquare Triangel Option: ");
        Console.WriteLine("1. Bottom-Left");
        Console.WriteLine("2.Top-Left");
        Console.WriteLine("3.Bottom-Right");
        Console.WriteLine("4.Top-Right");
        Console.WriteLine("Choose the corner position (1-4): ");
        int corner = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the Triangel: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSquare Triangel: ");
        switch(corner)
        {
            case 1:
                for(int i = 1; i <= height; i++)
                {
                    for(int j = 0; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                break;
            case 2:
                for(int i = height; i >=1 ; i--)
                {
                    for(int j = 1; j <= i ; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                break;
            case 3:
                for(int i = 1; i <= height; i++)
                {
                    for(int j = 1; j <= height - i ; j++)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                break;
            case 4:
                for(int i = height; i >=1 ; i--)
                {
                    for(int j = 1; j <= height - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                break;
            default:
                Console.WriteLine("Incalid choice.");
                break;
        }
    }
    static void PrintIsoscelesTriangel()
    {
        Console.WriteLine("Enter the height of the Isosceles Triangel: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("\nIsosceles Triangel: ");
        for(int i = 1; i <= height; i++)
        {
            for(int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }
            for(int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}