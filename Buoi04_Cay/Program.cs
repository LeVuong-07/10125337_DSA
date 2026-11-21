using System;

namespace Buoi04_Cay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("============================================================");
            Console.WriteLine("BUỔI 04 - CÂY NHỊ PHÂN TÌM KIẾM (CHƯƠNG 6)");
            Console.WriteLine("Họ tên: Lê Trọng Vượng - MSV: 10125337 - Lớp: 10125O.1");
            Console.WriteLine("============================================================\n");

            Node? goc = null;
            int[] dsGiaTri = { 50, 30, 70, 20, 40, 60, 80, 15, 25, 35, 65, 75, 85 };

            foreach (int x in dsGiaTri) goc = Them(goc, x);

            Console.WriteLine("Cây nhị phân tìm kiếm đã khởi tạo với các giá trị:");
            Console.WriteLine(string.Join(" -> ", dsGiaTri) + "\n");

            Console.WriteLine("=== Bài 1: Đếm số nút trên cây ===");
            Console.WriteLine("Tổng số nút trên cây: " + DemNut(goc));

            Console.WriteLine("\n=== Bài 2: Tổng giá trị các nút trên cây ===");
            Console.WriteLine("Tổng giá trị các nút: " + TongNut(goc));

            Console.WriteLine("\n=== Bài 3: Hiển thị giá trị các nút (thứ tự tăng dần LNR) ===");
            Console.Write("Giá trị các nút: ");
            HienThi(goc);
            Console.WriteLine();

            Console.WriteLine("\n=== Bài 4: Hiển thị các nút có giá trị chẵn ===");
            Console.Write("Các nút có giá trị chẵn: ");
            HienThiChan(goc);
            Console.WriteLine();

            Console.WriteLine("\n=== Bài 5: Đếm số nút có giá trị chẵn ===");
            Console.WriteLine("Số lượng nút chẵn trên cây: " + DemChan(goc));

            Console.WriteLine("\n=== Bài 6: Đếm số con của một nút ===");
            int[] nutKiemTra = { 50, 30, 20, 15, 99 };
            foreach (int k in nutKiemTra)
            {
                Node? p = TimNut(goc, k);
                if (p == null) Console.WriteLine($"Nút {k}: Không tồn tại trên cây");
                else
                {
                    int con = 0;
                    if (p.left != null) con++;
                    if (p.right != null) con++;
                    Console.WriteLine($"Nút {k,2}: Có {con} con {(con == 2 ? "(đủ 2 con)" : con == 1 ? "(1 con)" : "(nút lá)")}");
                }
            }

            Console.WriteLine("\n=== Bài 7: Hiển thị các nút trên cây con trái ===");
            if (goc != null && goc.left != null)
            {
                Console.Write($"Các nút thuộc cây con trái của gốc ({goc.data}): ");
                HienThi(goc.left);
                Console.WriteLine();
            }

            Console.WriteLine("\n=== Bài 8: Ba phương pháp duyệt cây nhị phân ===");
            Console.Write("1. Duyệt tiền thứ tự (NLR - Gốc, Trái, Phải): ");
            NLR(goc);
            Console.WriteLine();

            Console.Write("2. Duyệt trung thứ tự (LNR - Trái, Gốc, Phải): ");
            LNR(goc);
            Console.WriteLine();

            Console.Write("3. Duyệt hậu thứ tự (LRN - Trái, Phải, Gốc): ");
            LRN(goc);
            Console.WriteLine();

            Console.WriteLine("\n============================================================");
            Console.WriteLine("HOÀN THÀNH TOÀN BỘ BÀI TẬP BUỔI 04!");
            Console.WriteLine("============================================================");
        }

        class Node
        {
            public int data;
            public Node? left;
            public Node? right;
        }

        static Node Them(Node? g, int x)
        {
            if (g == null) return new Node { data = x, left = null, right = null };
            if (x < g.data) g.left = Them(g.left, x);
            else if (x > g.data) g.right = Them(g.right, x);
            return g;
        }

        static int DemNut(Node? g)
        {
            if (g == null) return 0;
            return 1 + DemNut(g.left) + DemNut(g.right);
        }

        static int TongNut(Node? g)
        {
            if (g == null) return 0;
            return g.data + TongNut(g.left) + TongNut(g.right);
        }

        static void HienThi(Node? g)
        {
            if (g == null) return;
            HienThi(g.left);
            Console.Write(g.data + " ");
            HienThi(g.right);
        }

        static void HienThiChan(Node? g)
        {
            if (g == null) return;
            HienThiChan(g.left);
            if (g.data % 2 == 0) Console.Write(g.data + " ");
            HienThiChan(g.right);
        }

        static int DemChan(Node? g)
        {
            if (g == null) return 0;
            int dem = (g.data % 2 == 0) ? 1 : 0;
            return dem + DemChan(g.left) + DemChan(g.right);
        }

        static Node? TimNut(Node? g, int x)
        {
            if (g == null || g.data == x) return g;
            if (x < g.data) return TimNut(g.left, x);
            return TimNut(g.right, x);
        }

        static void NLR(Node? g)
        {
            if (g == null) return;
            Console.Write(g.data + " ");
            NLR(g.left);
            NLR(g.right);
        }

        static void LNR(Node? g)
        {
            if (g == null) return;
            LNR(g.left);
            Console.Write(g.data + " ");
            LNR(g.right);
        }

        static void LRN(Node? g)
        {
            if (g == null) return;
            LRN(g.left);
            LRN(g.right);
            Console.Write(g.data + " ");
        }
    }
}
