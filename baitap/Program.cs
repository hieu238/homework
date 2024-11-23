using System;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhập chiều cao của bạn vào đây");
            double height = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập cân nặng của bạn vào đây: ");
            double weight = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height,2);
            Console.WriteLine("BMI của bạn là: " + bmi);

            if(bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if(bmi >=18.5 || bmi <20)
            {
                Console.WriteLine("Normal");
            }
            else if(bmi >= 25 || bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }


        }
    }
}
