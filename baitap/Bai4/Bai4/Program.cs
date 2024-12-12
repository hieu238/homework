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

		// Hiển thị danh sách các số đã nhập
		Console.WriteLine("\nDanh sách các số nguyên bạn đã nhập:");
		foreach (var number in numbers)
		{
			Console.WriteLine(number);
		}

		// Sắp xếp danh sách theo thứ tự tăng dần
		numbers.Sort();
		Console.WriteLine("\nDanh sách sau khi sắp xếp tăng dần:");
		foreach (var number in numbers)
		{
			Console.WriteLine(number);
		}

		// Sắp xếp danh sách theo thứ tự giảm dần
		numbers.Sort((a, b) => b.CompareTo(a));
		Console.WriteLine("\nDanh sách sau khi sắp xếp giảm dần:");
		foreach (var number in numbers)
		{
			Console.WriteLine(number);
		}
	}
}
