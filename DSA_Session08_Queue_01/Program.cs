using System;
using System.Collections.Generic;

namespace DSA_Session08_Queue_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Queue<string> callQueue = new Queue<string>();

            Console.WriteLine("=== HE THONG TONG DAI CSKH ===");
            Console.WriteLine("- Nhap ten khach hang de dua vao hang doi.");
            Console.WriteLine("- De trong va nhan [ENTER] de nhan vien nhan cuoc goi.");
            Console.WriteLine("- Nhap 'exit' de dong he thong.\n");

            while (true)
            {
                Console.Write("Lenh (Ten KH / [Enter] / exit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("He thong da tat.");
                    break;
                }

                if (string.IsNullOrEmpty(input))
                {
                    if (callQueue.Count > 0)
                    {
                        string nextCustomer = callQueue.Dequeue();
                        Console.WriteLine($">>> Dang ket noi may... Xin chao anh/chi: {nextCustomer}!");
                    }
                    else
                    {
                        Console.WriteLine(">>> Tong dai dang ranh, khong co khach hang nao cho.");
                    }
                }
                else
                {
                    callQueue.Enqueue(input);
                    Console.WriteLine($"[+] Da them khach hang '{input}' vao hang doi. (Dang cho: {callQueue.Count})");
                }
            }
        }
    }
}