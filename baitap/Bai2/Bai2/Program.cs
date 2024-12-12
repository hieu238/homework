using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Tạo danh sách lưu trữ các số nguyên
		List<int> numbers = new List<int>();

		// Yêu cầu người dùng nhập các số nguyên
		Console.WriteLine("Nhập các số nguyên (nhập 'done' để kết thúc):");
		while (true)
		{
			string input = Console.ReadLine();

			// Kiểm tra nếu người dùng nhập 'done' thì thoát vòng lặp
			if (input.ToLower() == "done")
				break;

			// Kiểm tra nếu input là một số nguyên hợp lệ
			if (int.TryParse(input, out int number))
			{
				numbers.Add(number); // Thêm số vào danh sách
			}
			else
			{
				Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
			}
		}

		// Kiểm tra nếu danh sách không trống
		if (numbers.Count > 0)
		{
			// Tìm giá trị lớn nhất và nhỏ nhất trong danh sách
			int max = numbers[0]; // Giả sử giá trị đầu tiên là lớn nhất
			int min = numbers[0]; // Giả sử giá trị đầu tiên là nhỏ nhất

			foreach (var number in numbers)
			{
				if (number > max)
				{
					max = number; // Cập nhật giá trị lớn nhất
				}
				if (number < min)
				{
					min = number; // Cập nhật giá trị nhỏ nhất
				}
			}

			// In ra giá trị lớn nhất và nhỏ nhất
			Console.WriteLine($"Giá trị lớn nhất là: {max}");
			Console.WriteLine($"Giá trị nhỏ nhất là: {min}");
		}
		else
		{
			Console.WriteLine("Danh sách không có số nào.");
		}
	}
}
