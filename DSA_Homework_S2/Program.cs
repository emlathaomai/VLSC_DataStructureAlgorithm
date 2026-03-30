using System;

class Program
{
    static int TinhTong(int n)
    {
        if (n == 1) return 1;

        return n + TinhTong(n - 1);
    }

    static long GiaiThuaVongLap(int n)
    {
        long ketQua = 1;
        for (int i = 1; i <= n; i++)
        {
            ketQua *= i; 
        }
        return ketQua;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.Write("Nhập n để tính tổng: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Tổng S({n}) = {TinhTong(n)}");
        Console.WriteLine($"Giai thừa của {n} là {GiaiThuaVongLap(n)}");
        
       
    }
}


