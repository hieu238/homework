using System;
using System.Collections.Generic;


class Program
{
	static void Main(string[] args)
	{
		 List<int> numbers = new List<int>();

		Console.WriteLine("Vui lòng nhập các số nguyên vào đây: ");

		while (true)
		{
			string input = Console.ReadLine();


			if(input.ToLower() == "done")
			{
				break;
			}

			if(int.TryParse(input, out int number))
			{
				numbers.Add(number);
			}
			else
			{
				Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ: ");
			}
		}

		Console.WriteLine("Số nguyên bạn đã nhập: ");
		foreach(var number in numbers)
		{
			Console.WriteLine(number);
		}
	}
}