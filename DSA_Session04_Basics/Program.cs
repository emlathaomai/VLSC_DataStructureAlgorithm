using System;
using System.Text;

class Program {
    static void Main() {
        Console.OutputEncoding = Encoding.UTF8;

        // --- BAI 1: LOI CHAO ---
        Console.WriteLine("----- BÀI 1: LỜI CHÀO THÔNG MINH -----");
        Console.Write("Nhap ho ten: ");
        string name = Console.ReadLine();
        Console.Write("Nhap MSSV: ");
        string mssv = Console.ReadLine();
        Console.WriteLine($"Chao mung sinh vien {name} (MS: {mssv}) den voi lop CTDL&GT!");
        Console.WriteLine("------------------------------------------");

        // --- BAI 2: MAY TINH CO BAN ---
        Console.WriteLine("----- BÀI 2: MÁY TÍNH CƠ BẢN -----");
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tong: {a + b}");
        Console.WriteLine($"Hieu: {a - b}");
        Console.WriteLine($"Tich: {a * b}");
        if (b != 0) {
            Console.WriteLine($"Thuong: {(double)a / b}");
        } else {
            Console.WriteLine("Khong the chia cho 0!");
        }

        // --- BAI 3: KY THUAT HOAN DOI ---

        int x = 5, y =10;
        Console.WriteLine("----- BÀI 3: KỸ THUẬT HOÀN ĐỔI -----");
        Console.WriteLine($"Truoc khi hoan doi:\n x = {x}, y = {y}");
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"Sau khi hoan doi: x = {x}, y = {y}");

    }
}