using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Tạo dictionary để lưu trữ các số nguyên, với giá trị bool (chỉ dùng để đánh dấu sự tồn tại)
		Dictionary<int, bool> numbers = new Dictionary<int, bool>();

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
				// Thêm số vào dictionary nếu chưa có
				if (!numbers.ContainsKey(number))
				{
					numbers[number] = true; // Gán giá trị bất kỳ (ở đây là true)
				}
				else
				{
					Console.WriteLine($"Số {number} đã có trong danh sách.");
				}
			}
			else
			{
				Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
			}
		}

		// Hiển thị danh sách các số đã nhập
		Console.WriteLine("\nDanh sách các số nguyên bạn đã nhập:");
		foreach (var number in numbers.Keys)
		{
			Console.WriteLine(number);
		}

		// Yêu cầu người dùng nhập một số để xóa khỏi dictionary nếu có
		Console.WriteLine("\nNhập một số bất kỳ để xóa khỏi danh sách:");
		if (int.TryParse(Console.ReadLine(), out int numberToRemove))
		{
			// Kiểm tra nếu số đó có trong dictionary và xóa nó
			if (numbers.ContainsKey(numberToRemove))
			{
				numbers.Remove(numberToRemove);
				Console.WriteLine($"Đã xóa số {numberToRemove} khỏi danh sách.");
			}
			else
			{
				Console.WriteLine($"Số {numberToRemove} không có trong danh sách.");
			}
		}
		else
		{
			Console.WriteLine("Số bạn nhập không hợp lệ.");
		}

		// Hiển thị lại danh sách sau khi xóa
		Console.WriteLine("\nDanh sách sau khi xóa:");
		foreach (var number in numbers.Keys)
		{
			Console.WriteLine(number);
		}
	}
}
