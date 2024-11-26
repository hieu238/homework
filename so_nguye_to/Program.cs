using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Các số nguyên tố nhỏ hơn 100 là: ");
        for(int num = 2; num <= 100; num++)
        {
            if(IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
    }
    static bool IsPrime(int num)
    {
        if(num < 2) return false; // Nếu số nào nhỏ hơn 2 thì không phải là số nguyên tố
        for(int i = 2; i <= Math.Sqrt(num); i++) // Check từ số 2 đến căn bặc 2 của num
        {
            if(num % i == 0) return false; // Nếu như num chia hết  thì không phải số nguyên tố 
        }
        return true; // Nếu như không chia hết cho số nào thì là số nguyên tố
    }
}