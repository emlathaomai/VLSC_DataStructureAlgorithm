namespace DSA_Session06_Basics;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        // Su dung vong lap do-while de hien thi menu va xu ly lua chon cua nguoi dung
        // Vong lap se tiep tuc cho den khi nguoi dung chon thoat (choice == 0)
        do
        {
            Console.WriteLine("\n=== MENU QUAN LY ===");
            Console.WriteLine("1. Chuc nang A");
            Console.WriteLine("2. Chuc nang B");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.Write("Moi ban chon (0-2): ");

            // Toan tu dieu kien (ternary operator) de kiem tra va gan gia tri cho bien choice
            choice = int.TryParse(Console.ReadLine(), out choice)
                ? choice
                : -1; // Neu nhap khong hop le, gan gia tri -1 de xu ly trong switch

            // Su dung switch-case de xu ly cac lua chon cua nguoi dung
            // Cau truc switch-case giup ma nguon ro rang va de bao tri hon so voi nhieu cau lenh if-else
            // Moi case tuong ung voi mot lua chon cua nguoi dung,
            // va default xu ly cac truong hop khong hop le
            // break duoc su dung de ngan chan viec thuc thi tiep tuc vao
            // cac case khac sau khi da thuc hien xong case hien tai
            // Neu khong co break, chuong trinh se tiep tuc thuc thi cac case tiep theo
            // cho den khi gap break hoac ket thuc switch
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Dang chay chuc nang A...");
                    break;
                case 2:
                    Console.WriteLine("Dang chay chuc nang B...");
                    break;
                case 0:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le, vui long nhap lai!");
                    break;
            }
        } while (choice != 0); // Ket thuc vong lap khi nguoi dung chon thoat (choice == 0)
    }
}