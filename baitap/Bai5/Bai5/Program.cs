using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Yêu cầu người dùng nhập đoạn văn bản
		Console.WriteLine("Nhập một đoạn văn bản:");
		string input = Console.ReadLine();

		// Tách đoạn văn bản thành các từ, loại bỏ các ký tự không phải chữ cái
		string[] words = input.Split(new[] { ' ', '.', ',', ';', '!', '?', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

		// Tạo dictionary để lưu trữ số lần xuất hiện của từng từ
		Dictionary<string, int> wordCount = new Dictionary<string, int>();

		// Duyệt qua từng từ trong mảng và đếm số lần xuất hiện
		foreach (string word in words)
		{
			// Chuyển các từ về dạng chữ thường để không phân biệt chữ hoa và chữ thường
			string cleanedWord = word.ToLower();

			if (wordCount.ContainsKey(cleanedWord))
			{
				wordCount[cleanedWord]++; // Tăng số lần xuất hiện
			}
			else
			{
				wordCount[cleanedWord] = 1; // Thêm từ mới vào dictionary
			}
		}

		// In ra kết quả số lần xuất hiện của mỗi từ
		Console.WriteLine("\nSố lần xuất hiện của từng từ:");
		foreach (var entry in wordCount)
		{
			Console.WriteLine($"{entry.Key}: {entry.Value}");
		}
	}
}
