using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
	public string FullName { get; set; }
	public double Score { get; set; }
}

class Program
{
	static void Main()
	{
		// Tạo danh sách sinh viên và điểm số của họ
		List<Student> students = new List<Student>
		{
			new Student { FullName = "Nguyễn Trung Hiếu", Score = 85.5 },
			new Student { FullName = "Đỗ Trung Hiếu", Score = 90.0 },
			new Student { FullName = "Nguyễn Ngọc Linh", Score = 78.3 },
			new Student { FullName = "Phạm Hồng Ngọc", Score = 82.4 },
			new Student { FullName = "Đặng Thành An", Score = 91.2 },
			new Student { FullName = "Nguyễn Minh Quang", Score = 76.8 },
			new Student { FullName = "Ngô Anh Minh", Score = 88.5 },
			new Student { FullName = "Trần Thị Thu Phương", Score = 92.3 },
			new Student { FullName = "Ngô Thị Ngọc Lan", Score = 80.0 },
			new Student { FullName = "Đào Văn Hùng", Score = 84.1 }
		};

		// Sắp xếp danh sách sinh viên theo điểm từ cao đến thấp
		var sortedStudents = students.OrderByDescending(s => s.Score).ToList();

		// Hiển thị danh sách sinh viên xếp hạng theo điểm
		Console.WriteLine("Danh sách sinh viên xếp hạng theo điểm (từ cao đến thấp):\n");
		foreach (var student in sortedStudents)
		{
			Console.WriteLine($"{student.FullName} - Điểm: {student.Score}");
		}
	}
}
