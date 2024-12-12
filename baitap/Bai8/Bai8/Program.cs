using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
	public string Name { get; set; }
	public double Price { get; set; }
}

class Program
{
	static void Main()
	{
		// Tạo danh sách sản phẩm với tên và giá
		List<Product> products = new List<Product>
		{
			new Product { Name = "Laptop", Price = 1500.50 },
			new Product { Name = "Smartphone", Price = 799.99 },
			new Product { Name = "Tablet", Price = 450.75 },
			new Product { Name = "Headphones", Price = 99.99 },
			new Product { Name = "Smartwatch", Price = 199.49 },
			new Product { Name = "Keyboard", Price = 59.99 }
		};

		// Tìm sản phẩm có giá cao nhất
		var highestPriceProduct = products.OrderByDescending(p => p.Price).First();

		// Tìm sản phẩm có giá thấp nhất
		var lowestPriceProduct = products.OrderBy(p => p.Price).First();

		// Hiển thị sản phẩm có giá cao nhất và thấp nhất
		Console.WriteLine("Sản phẩm có giá cao nhất:");
		Console.WriteLine($"{highestPriceProduct.Name} - Giá: {highestPriceProduct.Price:C}");

		Console.WriteLine("\nSản phẩm có giá thấp nhất:");
		Console.WriteLine($"{lowestPriceProduct.Name} - Giá: {lowestPriceProduct.Price:C}");
	}
}
