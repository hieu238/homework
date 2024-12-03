using System;

public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;

    // Phương thức khởi tạo không tham số
    public StopWatch()
    {
        startTime = DateTime.Now;
    }

    // Getter cho startTime
    public DateTime StartTime
    {
        get { return startTime; }
    }

    // Getter cho endTime
    public DateTime EndTime
    {
        get { return endTime; }
    }

    // Phương thức Start để reset startTime
    public void Start()
    {
        startTime = DateTime.Now;
    }

    // Phương thức Stop để gán endTime
    public void Stop()
    {
        endTime = DateTime.Now;
    }

    // Phương thức GetElapsedTime để trả về thời gian trôi qua (ms)
    public double GetElapsedTime()
    {
        return (endTime - startTime).TotalMilliseconds;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo một mảng ngẫu nhiên gồm 100,000 phần tử
        int[] array = new int[100000];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100000);
        }

        // Tạo đối tượng StopWatch
        StopWatch stopWatch = new StopWatch();

        // Bắt đầu đo thời gian
        stopWatch.Start();

        // Sắp xếp mảng bằng thuật toán Selection Sort
        SelectionSort(array);

        // Dừng đo thời gian
        stopWatch.Stop();

        // Hiển thị thời gian thực thi
        Console.WriteLine($"Thời gian thực thi thuật toán Selection Sort: {stopWatch.GetElapsedTime()} ms");
    }

    // Hàm Selection Sort
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // Tìm chỉ số của phần tử nhỏ nhất
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Hoán đổi phần tử nhỏ nhất với phần tử đầu tiên
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}
