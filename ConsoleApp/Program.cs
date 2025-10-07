using System.Globalization;
using System.Runtime.CompilerServices;

internal class Program
{
    #region B2_1
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhập vào nhiệt độ (°C):");
        int temperature = Convert.ToInt32(Console.ReadLine());
        if (temperature > 0)
        {
            Console.WriteLine("🌤️ Trời ấm");
        }
        else if (temperature < 0)
        {
            Console.WriteLine("❄️ Trời lạnh, có thể có băng giá!");
        }
        else { Console.WriteLine("🌫️ Trời rất lạnh, đúng 0°C!"); }
    }
    #endregion

    #region B2_2
    // private static void Main(string[] args)
    // {
    //     Console.WriteLine("Nhập vào thu nhập:");
    //     int income = Convert.ToInt32(Console.ReadLine());
    //     if (income <= 5)
    //     {
    //         Console.WriteLine(" ✅ Miễn thuế");
    //     }
    //     else if (income <= 10)
    //     {
    //         Console.WriteLine("💰 Thuế 10%");
    //     }
    //     else { Console.WriteLine("💸 Thuế 20%"); }
    // }
    #endregion

    #region B2_3
    // private static void Main(string[] args)
    // {
    //     Console.WriteLine("Nhập số tháng (1 - 12):");
    //     int month = Convert.ToInt32(Console.ReadLine());
    //     if (1 <= month && month <= 3)
    //     {
    //         Console.WriteLine($@"Tháng {month} là Mùa Xuân");
    //     }
    //     else if (4 <= month && month <= 6)
    //     {
    //         Console.WriteLine($@"Tháng {month} là Mùa Hạ");
    //     }
    //     else if (7 <= month && month <= 9)
    //     {
    //         Console.WriteLine($@"Tháng {month} là Mùa Thu");
    //     }
    //     else if (10 <= month && month <= 12)
    //     {
    //         Console.WriteLine($@"Tháng {month} là Mùa Đông");
    //     }
    //     else { Console.WriteLine($@"Tháng {month} Không tồn tại.."); }
    // }
    #endregion

    #region B2_4
    // private static void Main(string[] args)
    // {
    //     Console.WriteLine("Nhập số tuổi:");
    //     int age = Convert.ToInt32(Console.ReadLine());
    //     if (age < 18)
    //     {
    //         Console.WriteLine($@"Tuổi {age} ❌ Chưa đủ tuổi tham gia NVQS");
    //     }
    //     else if (age >= 18 && age <= 27)
    //     {
    //         Console.WriteLine($@"Tuổi {age} → ✅ Đủ tuổi tham gia NVQS");
    //     }
    //     else { Console.WriteLine($@"Tuổi {age} ⛔ Quá tuổi tham gia NVQS"); }
    // }
    #endregion

    #region B2_5
    // private static void Main(string[] args)
    // {
    //     Console.WriteLine("Nhập vào số cần kiểm tra:");
    //     int num = Convert.ToInt32(Console.ReadLine());

    //     bool IsPrime = true;

    //     if (num < 2)
    //     {
    //         IsPrime = false;
    //     }
    //     else
    //     {
    //         // Kiểm tra chia hết
    //         for (int i = 2; i <= Math.Sqrt(num); i++)
    //         {
    //             if (num % i == 0)
    //             {
    //                 IsPrime = false;
    //                 break; // Không cần kiểm tra tiếp
    //             }
    //         }
    //     }

    //     if (IsPrime)
    //     {
    //         Console.WriteLine($@"Số {num} là 1 số nguyên tố!");
    //     }
    //     else { Console.WriteLine($@"Số {num} không phải là 1 số nguyên tố!"); }

    // }
    #endregion

    #region B2_6
    // private static void Main(string[] args)
    // {
    //     Console.WriteLine("Nhập vào số điện (Kwh) :");
    //     int Kwh = Convert.ToInt32(Console.ReadLine());
    //     int consumption = 0; //Số tiền điện phải trả.

    //     switch (Kwh)
    //     {
    //         case < 100:
    //             consumption = Kwh * 1800;
    //             break;
    //         case >= 100 and <= 200:
    //             consumption = Kwh * 2000;
    //             break;
    //         case > 200:
    //             consumption = Kwh * 2500;
    //             break;
    //     }

    //     Console.WriteLine(@$"Số tiền phải trả cho {Kwh} số điện là {consumption} !");

    // }
    #endregion

    #region B2_7
    // private static void Main(string[] args)
    // {
    //     Console.WriteLine("Vui lòng ấn phím để chọn hạng vé:\n"
    //     + "1 . Standard \n"
    //     + "2 . Premium \n"
    //     + "3 . VIP ");

    //     int ticketType = Convert.ToInt32(Console.ReadLine());

    //     switch (ticketType)
    //     {
    //         case 1:
    //             Console.WriteLine("Ghế ngồi thường, không có đồ uống");
    //             break;
    //         case 2:
    //             Console.WriteLine("Ghế ngồi thoải mái, có đồ uống miễn phí");
    //             break;
    //         case 3:
    //             Console.WriteLine("Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí");
    //             break;
    //         default:
    //             Console.WriteLine("Thông số nhập vào không phù hợp!");
    //             break;
    //     }
    // }
    #endregion

    #region B2_8
    // private static void Main(string[] args)
    // {
    //     Console.WriteLine("Nhập vào quãng đường (Km) :");
    //     int Km = Convert.ToInt32(Console.ReadLine());
    //     int consumption = 0; //Số tiền phải trả.

    //     switch (Km)
    //     {
    //         case < 0:
    //             consumption = -1;
    //             break;
    //         case <= 1:
    //             consumption = 10000;
    //             break;
    //         case <= 5:
    //             consumption = 10000 + (Km - 1) * 8000;
    //             break;
    //         case > 5:
    //             consumption = 10000 + 4 * 8000 + (Km - 5) * 6000;
    //             break;
    //     }

    //     if (consumption == -1)
    //         Console.WriteLine("Quãng đường nhập vào không hợp lệ!!");
    //     else
    //         Console.WriteLine(@$"Số tiền phải trả cho quãng đường {Km} Km là {consumption}");

    // }
    #endregion

    #region B2_9
    // private static void Main(string[] args)
    // {
    //     Console.WriteLine("Nhập vào 1 ký tự từ A-Z:");
    //     char charInput = Console.ReadKey().KeyChar; //Đọc ký tự
    //     Console.WriteLine("\n"); //Tạo xuống dòng
    //     if (!char.IsLetter(charInput)) //Kiểm tra xem có phải thuộc các ký tự A-Z
    //     {
    //         Console.WriteLine($@"Ký tự {charInput} không hợp lệ");
    //         return; //kết thúc chương trình.
    //     }
    //     switch (charInput)
    //     {
    //         case 'a':
    //         case 'e':
    //         case 'u':
    //         case 'i':
    //         case 'o':
    //         case 'A':
    //         case 'E':
    //         case 'U':
    //         case 'I':
    //         case 'O':
    //             Console.WriteLine("✅ Là nguyên âm");
    //             break;
    //         default:
    //             Console.WriteLine("🔠 Là phụ âm");
    //             break;

    //     }
    // }
    #endregion

    #region B2_10
    // private static void Main(string[] args)
    // {
    //     Console.WriteLine("Vui lòng ấn phím để chọn hạng vé:\n"
    //     + "1 . Economy \n"
    //     + "2 . Business \n"
    //     + "3 . First Class ");

    //     int ticketType = Convert.ToInt32(Console.ReadLine());

    //     switch (ticketType)
    //     {
    //         case 1:
    //             Console.WriteLine("Ghế thường");
    //             break;
    //         case 2:
    //             Console.WriteLine("Ghế rộng");
    //             break;
    //         case 3:
    //             Console.WriteLine("Ghế sang trọng");
    //             break;
    //         default:
    //             Console.WriteLine("Thông số nhập vào không phù hợp!");
    //             break;
    //     }
    // }
    #endregion
}




