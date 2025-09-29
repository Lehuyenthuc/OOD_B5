using System;
using System.Text;
using System.IO;
using System.Data.SqlTypes;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        /*
        ==========================
        Thực hành 2: Tìm max trong 2 số nguyên a, b
        ==========================
        
        // Nhập dữ liệu
        Console.Write("Nhập vào số nguyên a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập vào số nguyên b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Tìm số max
        int max;
        if (a > b)
        {
            max = a;
        }
        else if (b > a)
        {
            max = b;
        }
        else
        {
            max = a; // hoặc b cũng được vì a == b
        }

        // Hiển thị kết quả
        Console.WriteLine("Số lớn hơn (hoặc bằng) trong 2 số là: " + max);
        */

        /*
        ==========================
        Thực hành 3: Tìm max trong 3 số nguyên a, b, c
        ==========================

        // Nhập dữ liệu
        Console.Write("Nhập vào số nguyên a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập vào số nguyên b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập vào số nguyên c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Tìm số max
        int max = a; // giả sử a là số lớn nhất trước
        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }

        // Hiển thị kết quả
        Console.WriteLine("Số lớn nhất trong 3 số là: " + max);
        */

        /*
        ==========================
        Thực hành 4: Tháng có bao nhiêu ngày
        ==========================

        // Nhập dữ liệu
        Console.Write("Nhập vào năm: ");
        int nam = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập vào tháng: ");
        int thang = Convert.ToInt32(Console.ReadLine());

        // Tìm số ngày trong tháng
        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Tháng {0} có 31 ngày!", thang);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Tháng {0} có 30 ngày!", thang);
                break;
            case 2:
                if ((nam % 400 == 0) || ((nam % 4 == 0) && (nam % 100 != 0)))
                {
                    Console.WriteLine("Tháng 2 năm {0} có 29 ngày! (năm nhuận)", nam);
                }
                else
                {
                    Console.WriteLine("Tháng 2 năm {0} có 28 ngày!", nam);
                }
                break;
            default:
                Console.WriteLine("Tháng không hợp lệ!");
                break;
        }
        */
        /*
         ==========================
         Thực hành 5: Kiểm tra số nguyên n
         ==========================

        // Nhập dữ liệu
        Console.Write("Nhập vào số nguyên n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // a) Kiểm tra chẵn lẻ
        if (n % 2 == 0)
        {
            Console.WriteLine("a) {0} là số chẵn.", n);
        }
        else
        {
            Console.WriteLine("a) {0} là số lẻ.", n);
        }

        // b) Kiểm tra âm hay không âm
        if (n < 0)
        {
            Console.WriteLine("b) {0} là số âm.", n);
        }
        else
        {
            Console.WriteLine("b) {0} là số không âm.", n);
        }
        */
        /*
        //==========================
        //Thực hành 6: Tính chu vi và diện tích hình chữ nhật
        //==========================

        // Nhập dữ liệu
        Console.Write("Nhập vào chiều dài của hình chữ nhật: ");
        double dai = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào chiều rộng của hình chữ nhật: ");
        double rong = Convert.ToDouble(Console.ReadLine());

        // Kiểm tra hợp lệ (chiều dài và chiều rộng phải dương)
        if (dai <= 0 || rong <= 0)
        {
            Console.WriteLine("Chiều dài và chiều rộng phải là số thực dương!");
        }
        else
        {
            // Tính chu vi và diện tích
            double chuVi = 2 * (dai + rong);
            double dienTich = dai * rong;

            // In kết quả
            Console.WriteLine("Chu vi hình chữ nhật là: " + chuVi);
            Console.WriteLine("Diện tích hình chữ nhật là: " + dienTich);
        }
        */
        /*
        //==========================
        // Thực hành 7: Kiểm tra tam giác, tính chu vi và diện tích
        // ==========================

        // Nhập dữ liệu
        Console.Write("Nhập vào độ dài cạnh a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào độ dài cạnh b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào độ dài cạnh c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Kiểm tra điều kiện tam giác: mỗi cạnh < tổng 2 cạnh còn lại
        if (a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a))
        {
            double chuVi = a + b + c;
            double p = chuVi / 2; // nửa chu vi
            double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Ba cạnh lập thành tam giác.");
            Console.WriteLine("Chu vi tam giác là: " + chuVi);
            Console.WriteLine("Diện tích tam giác là: " + dienTich);
        }
        else
        {
            Console.WriteLine("Ba đoạn thẳng này không lập thành tam giác!");
        }
        */
        /*
        // ==========================
        // Thực hành 8: Giải phương trình bậc 2 ax² + bx + c = 0
        // ==========================

        // Nhập dữ liệu
        Console.Write("Nhập vào hệ số a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào hệ số b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào hệ số c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            // Trường hợp phương trình trở thành bậc 1: bx + c = 0
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Phương trình bậc nhất có nghiệm x = " + x);
            }
        }
        else
        {
            // Tính delta
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm thực.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
        */
        /*
        // ==========================
        // Thực hành 9: Tính tổng các phần tử trong mảng
        // ==========================

        // Nhập kích thước mảng
        Console.Write("Nhập số phần tử của mảng: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int tong = 0;

        // Nhập các phần tử
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhập phần tử arr[{0}]: ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
            tong += arr[i]; // cộng dồn vào tổng
        }

        // Hiển thị kết quả
        Console.WriteLine("Tổng các phần tử trong mảng là: " + tong);
        */
        /*
        // ==========================
        // Thực hành 10: Selection Sort với mảng từ file
        // ==========================

        string filePath = @"C:\Users\Mi\Documents\ĐH_CNTT3\OOD\Lab_ThucHanh\input_array.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Không tìm thấy file input_array.txt!");
            return;
        }

        // Đọc nội dung file
        string content = File.ReadAllText(filePath).Trim();
        string[] parts = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        int n = parts.Length;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(parts[i]);
        }

        Console.WriteLine("Mảng ban đầu:");
        PrintArray(arr);

        // Thuật toán Selection Sort
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            // Hoán đổi
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        Console.WriteLine("\nMảng sau khi sắp xếp tăng dần (Selection Sort):");
        PrintArray(arr);

        // Giữ màn hình chờ nhấn phím
        Console.ReadKey();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        */

        // ==========================
        // Thực hành 11: Chèn thêm số nguyên từ mảng sắp xếp tăng dần
        // ==========================
        string filePath = @"C:\Users\Mi\Documents\ĐH_CNTT3\OOD\Lab_ThucHanh\input_array.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Không tìm thấy file input_array.txt!");
            return;
        }

        // Đọc nội dung file
        string content = File.ReadAllText(filePath).Trim();
        string[] parts = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        int n = parts.Length;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(parts[i]);
        }

        Console.WriteLine("Mảng ban đầu:");
        PrintArray(arr);

        // Thuật toán Selection Sort
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            // Hoán đổi
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        Console.WriteLine("\nMảng sau khi sắp xếp tăng dần (Selection Sort):");
        PrintArray(arr);

        // === Thực hành 11: Chèn thêm một số nguyên vào mảng đã sắp xếp ===
        Console.Write("\nNhập số nguyên cần chèn: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int[] newArr = new int[n + 1];
        bool inserted = false;
        int k = 0;

        for (int i = 0; i < n; i++)
        {
            if (!inserted && x < arr[i])
            {
                newArr[k++] = x;
                inserted = true;
            }
            newArr[k++] = arr[i];
        }

        if (!inserted) // nếu x lớn hơn tất cả
        {
            newArr[k] = x;
        }

        Console.WriteLine("\nMảng sau khi chèn {0} vào: ", x);
        PrintArray(newArr);

        Console.ReadKey();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        // Giữ màn hình chờ nhấn phím
        Console.ReadKey();
    }
}
