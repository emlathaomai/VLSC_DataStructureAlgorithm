using System;

class Program
{
    static void Main(string[] args)
    {
        // Bai 1: Hoan doi 2 so khong dung bien tam (Toan hoc)
        Console.WriteLine("Bai 1: Hoan doi 2 so khong dung bien tam");
        Console.Write("Nhap so a: ");
        string inputA = Console.ReadLine()!;
        int a;
        while (!int.TryParse(inputA, out a))
        {
            Console.Write("So a khong hop le. Vui long nhap lai: ");
            inputA = Console.ReadLine()!;
        }

        Console.Write("Nhap so b: ");
        string inputB = Console.ReadLine()!;
        int b;
        while (!int.TryParse(inputB, out b))
        {
            Console.Write("So b khong hop le. Vui long nhap lai: ");
            inputB = Console.ReadLine()!;
        }

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"a={a}, b={b}");

        Console.WriteLine("==============================");
        // Bai 2: Ve hinh vuong dau sao (n x n)
        Console.WriteLine("Bai 2: Ve hinh vuong dau sao (n x n)");
        Console.Write("Nhap kich thuoc n cua hinh vuong: ");
        string inputN = Console.ReadLine()!;
        int n;
        while (!int.TryParse(inputN, out n) || n <= 0)
        {
            Console.Write("Kich thuoc n khong hop le. Vui long nhap lai: ");
            inputN = Console.ReadLine()!;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("==============================");
        // Bai 3: In bang cuu chuong (2 den 9)
        Console.WriteLine("Bai 3: In bang cuu chuong (2 den 9)");
        for (int i = 2; i <= 9; i++)
        {
            Console.WriteLine($"--- Bang cuu chuong {i} ---");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }
}