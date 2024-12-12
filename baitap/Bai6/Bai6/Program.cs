using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Tạo dictionary để lưu trữ danh bạ điện thoại
		Dictionary<string, string> phoneBook = new Dictionary<string, string>();

		while (true)
		{
			// Hiển thị menu
			Console.WriteLine("\nQuản lý danh bạ điện thoại:");
			Console.WriteLine("1. Thêm người và số điện thoại");
			Console.WriteLine("2. Hiển thị danh bạ");
			Console.WriteLine("3. Tìm kiếm số điện thoại theo tên");
			Console.WriteLine("4. Thoát");
			Console.Write("Chọn chức năng (1-4): ");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					// Thêm người và số điện thoại
					AddContact(phoneBook);
					break;

				case "2":
					// Hiển thị danh bạ
					DisplayContacts(phoneBook);
					break;

				case "3":
					// Tìm kiếm số điện thoại theo tên
					SearchContact(phoneBook);
					break;

				case "4":
					// Thoát chương trình
					Console.WriteLine("Thoát chương trình.");
					return;

				default:
					Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
					break;
			}
		}
	}

	// Thêm người và số điện thoại vào danh bạ
	static void AddContact(Dictionary<string, string> phoneBook)
	{
		Console.Write("Nhập tên: ");
		string name = Console.ReadLine();

		Console.Write("Nhập số điện thoại: ");
		string phoneNumber = Console.ReadLine();

		// Thêm vào danh bạ
		if (!phoneBook.ContainsKey(name))
		{
			phoneBook.Add(name, phoneNumber);
			Console.WriteLine($"Đã thêm {name} với số điện thoại {phoneNumber}.");
		}
		else
		{
			Console.WriteLine("Tên này đã có trong danh bạ.");
		}
	}

	// Hiển thị toàn bộ danh bạ
	static void DisplayContacts(Dictionary<string, string> phoneBook)
	{
		if (phoneBook.Count == 0)
		{
			Console.WriteLine("Danh bạ rỗng.");
		}
		else
		{
			Console.WriteLine("\nDanh bạ:");
			foreach (var contact in phoneBook)
			{
				Console.WriteLine($"Tên: {contact.Key}, Số điện thoại: {contact.Value}");
			}
		}
	}

	// Tìm kiếm số điện thoại theo tên
	static void SearchContact(Dictionary<string, string> phoneBook)
	{
		Console.Write("Nhập tên cần tìm: ");
		string name = Console.ReadLine();

		if (phoneBook.ContainsKey(name))
		{
			Console.WriteLine($"Số điện thoại của {name} là: {phoneBook[name]}");
		}
		else
		{
			Console.WriteLine($"Không tìm thấy người tên {name} trong danh bạ.");
		}
	}
}
