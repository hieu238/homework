using System;

class Program
{
    static void Main(string[] args)
     {
    //     // Bước 1: Khai báo và khởi tạo mảng số nguyên
         Console.Write("Nhập số phần tử của mảng N: ");
         int N = int.Parse(Console.ReadLine());
         int[] array = new int[N];

         Console.WriteLine("Nhập các phần tử của mảng:");
         for (int i = 0; i < N; i++)
         {
             Console.Write($"Phần tử [{i}]: ");
             array[i] = int.Parse(Console.ReadLine());
         }

         // Bước 2: Nhập X là số cần chèn
         Console.Write("Nhập số cần chèn X: ");
         int X = int.Parse(Console.ReadLine());

    //     // Bước 3: Nhập vị trí index cần chèn
         Console.Write("Nhập vị trí cần chèn (index): ");
         int index = int.Parse(Console.ReadLine());

    //     // Bước 4: Kiểm tra điều kiện index
         if (index <= 0 || index >= array.Length)
         {
             Console.WriteLine("Không chèn được phần tử vào mảng tại vị trí này.");
             return;
         }
        
    //         // Bước 5: Thực hiện chèn phần tử X
             int[] newArray = new int[array.Length + 1]; // Tạo mảng mới với kích thước lớn hơn 1
             for (int i = 0, j = 0; i < newArray.Length; i++)
             {
                 if (i == index)
                 {
                    newArray[i] = X; // Chèn X vào vị trí index
                 }
                 else
                 {
                     newArray[i] = array[j]; // Sao chép các phần tử còn lại
                     j++;
                 }
             }

    //         // Bước 6: In ra mảng sau khi chèn
            Console.WriteLine("Mảng sau khi chèn:");
             foreach (int item in newArray)
             {
                 Console.Write(item + " ");
             }
         
     }
}




