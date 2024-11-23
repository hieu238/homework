using System;

namespace LinearEquationResolver
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Linear Equation Soluver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants: ");

            Console. WriteLine("Nhập số a vào đây:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhập số b vào đây:");
            double b = Convert.ToDouble(Console.ReadLine());

            if(a != 0)
            {
                double solution = -b / a;
                Console.WriteLine("Kết quả của phương trình là:" + solution);
            }
            else
            {
                if(b == 0)
                {
                    Console.WriteLine("Phương trình vô số nghiệm");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }
        }
    }
}