using System;

namespace Buoi02_DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("============================================================");
            Console.WriteLine("BUỔI 02 - DANH SÁCH (CHƯƠNG 4)");
            Console.WriteLine("Họ tên: Lê Trọng Vượng - MSV: 10125337 - Lớp: 10125O.1");
            Console.WriteLine("============================================================\n");

            Console.WriteLine("=== Bài 1: Dãy số nguyên - Nhập, hiển thị, chèn phần tử ===");
            Bai1();

            Console.WriteLine("\n=== Bài 2: Quản lý nhân viên (Struct NhanVien) ===");
            Bai2();

            Console.WriteLine("\n=== Bài 3: Ma trận vuông - Tổng đường chéo, đếm số lẻ ===");
            Bai3();

            Console.WriteLine("\n=== Bài 4: Danh sách liên kết đơn (Đếm x, tìm min dương, xóa x) ===");
            Bai4();

            Console.WriteLine("\n=== Bài 5: Danh sách liên kết đơn nâng cao (Max, Tổng, SNT, Đếm) ===");
            Bai5();

            Console.WriteLine("\n============================================================");
            Console.WriteLine("HOÀN THÀNH TOÀN BỘ BÀI TẬP BUỔI 02!");
            Console.WriteLine("============================================================");
        }

        #region BÀI 1
        static void Bai1()
        {
            int[] a = { 12, 45, 23, 67, 34, 89, 56 };
            Console.WriteLine("Dãy số ban đầu:");
            Console.WriteLine(string.Join(" ", a));

            int x = 99;
            int k = 3;
            Console.WriteLine($"Chèn giá trị x = {x} vào vị trí k = {k}:");

            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i < k; i++) tmp[i] = a[i];
            tmp[k] = x;
            for (int i = k; i < a.Length; i++) tmp[i + 1] = a[i];
            a = tmp;

            Console.WriteLine("Dãy số sau khi chèn:");
            Console.WriteLine(string.Join(" ", a));
        }
        #endregion

        #region BÀI 2
        struct NhanVien
        {
            public string MaNV;
            public string Hoten;
            public int Namsinh;
            public string Phongban;
            public int LuongCB;
            public int Thuong;
        }

        static void Bai2()
        {
            NhanVien[] DS = new NhanVien[]
            {
                new NhanVien { MaNV = "NV01", Hoten = "Lê Trọng Vượng", Namsinh = 2004, Phongban = "Kỹ thuật", LuongCB = 12000000, Thuong = 3000000 },
                new NhanVien { MaNV = "NV02", Hoten = "Nguyễn Văn An",   Namsinh = 2003, Phongban = "Kinh doanh", LuongCB = 8500000,  Thuong = 2000000 },
                new NhanVien { MaNV = "NV03", Hoten = "Trần Thị Bình",  Namsinh = 2002, Phongban = "Kế toán",   LuongCB = 9000000,  Thuong = 1500000 },
                new NhanVien { MaNV = "NV04", Hoten = "Phạm Hoàng Nam", Namsinh = 2005, Phongban = "Kỹ thuật", LuongCB = 7500000,  Thuong = 1000000 }
            };

            Console.WriteLine($"Danh sách nhân viên ({DS.Length} người):");
            for (int i = 0; i < DS.Length; i++)
            {
                long thucLinh = DS[i].LuongCB + DS[i].Thuong;
                Console.WriteLine($"  [{DS[i].MaNV}] {DS[i].Hoten,-18} - PB: {DS[i].Phongban,-10} - Lương: {DS[i].LuongCB:N0}đ - Thực lĩnh: {thucLinh:N0}đ");
            }

            long tong = 0;
            for (int i = 0; i < DS.Length; i++) tong += (DS[i].LuongCB + DS[i].Thuong);
            Console.WriteLine("\na. Tổng thực lĩnh tháng của công ty: " + tong.ToString("N0") + " VNĐ");

            int minLuong = int.MaxValue;
            for (int i = 0; i < DS.Length; i++) if (DS[i].LuongCB < minLuong) minLuong = DS[i].LuongCB;
            Console.WriteLine($"b. Nhân viên có lương cơ bản thấp nhất ({minLuong:N0} VNĐ):");
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].LuongCB == minLuong)
                    Console.WriteLine($"   -> {DS[i].Hoten} ({DS[i].MaNV}) - Phòng: {DS[i].Phongban}");
            }
        }
        #endregion

        #region BÀI 3
        static void Bai3()
        {
            int[,] a = {
                { 4, 7, 2 },
                { 3, 5, 9 },
                { 8, 1, 6 }
            };
            int n = 3;

            Console.WriteLine("Ma trận vuông cấp 3x3:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("  ");
                for (int j = 0; j < n; j++) Console.Write($"{a[i, j],4}");
                Console.WriteLine();
            }

            int tongChinh = 0, tongPhu = 0, demLe = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) tongChinh += a[i, j];
                    if (i + j == n - 1) tongPhu += a[i, j];
                    if (a[i, j] % 2 != 0) demLe++;
                }
            }

            Console.WriteLine("\na. Tổng các phần tử trên đường chéo chính: " + tongChinh);
            Console.WriteLine("b. Tổng các phần tử trên đường chéo phụ:   " + tongPhu);
            Console.WriteLine("c. Số lượng phần tử lẻ trong ma trận:     " + demLe);
        }
        #endregion

        #region BÀI 4
        class Node4
        {
            public int data;
            public Node4? next;
        }

        static void Bai4()
        {
            Node4? head = null;
            int[] initValues = { 15, -4, 7, 23, 7, -8, 2, 7, 19 };

            foreach (int val in initValues)
            {
                Node4 m = new Node4 { data = val, next = null };
                if (head == null) head = m;
                else
                {
                    Node4 p = head;
                    while (p.next != null) p = p.next;
                    p.next = m;
                }
            }

            Console.Write("Danh sách liên kết ban đầu: ");
            InDS4(head);

            int x = 7;
            int dem = 0;
            for (Node4? p = head; p != null; p = p.next) if (p.data == x) dem++;
            Console.WriteLine($"a. Số lần xuất hiện của phần tử x = {x}: {dem} lần");

            int minDuong = int.MaxValue;
            for (Node4? p = head; p != null; p = p.next)
                if (p.data > 0 && p.data < minDuong) minDuong = p.data;
            Console.WriteLine($"b. Phần tử dương nhỏ nhất trong danh sách: {minDuong}");

            Node4? curr = head, prev = null;
            while (curr != null && curr.data != x)
            {
                prev = curr;
                curr = curr.next;
            }
            if (curr != null)
            {
                if (prev == null) head = curr.next;
                else prev.next = curr.next;
            }

            Console.Write($"c. Danh sách sau khi xóa phần tử đầu tiên có giá trị {x}: ");
            InDS4(head);

            static void InDS4(Node4? h)
            {
                for (Node4? p = h; p != null; p = p.next) Console.Write(p.data + (p.next != null ? " -> " : " -> NULL\n"));
            }
        }
        #endregion

        #region BÀI 5
        class Node5
        {
            public int data;
            public Node5? next;
        }

        static void Bai5()
        {
            Node5? head = null;
            int[] initValues = { 11, -3, 0, 7, 18, -9, 2, 0, 13, 24 };

            foreach (int val in initValues)
            {
                Node5 m = new Node5 { data = val, next = null };
                if (head == null) head = m;
                else
                {
                    Node5 p = head;
                    while (p.next != null) p = p.next;
                    p.next = m;
                }
            }

            Console.Write("Danh sách liên kết: ");
            for (Node5? p = head; p != null; p = p.next) Console.Write(p.data + (p.next != null ? " -> " : " -> NULL\n"));

            int max = int.MinValue, tong = 0, demNT = 0, am = 0, khong = 0, duong = 0, minDuong = int.MaxValue;
            int x = 7, demX = 0;

            for (Node5? p = head; p != null; p = p.next)
            {
                if (p.data > max) max = p.data;
                tong += p.data;
                if (IsPrime(p.data)) demNT++;
                if (p.data < 0) am++;
                else if (p.data > 0) duong++;
                else khong++;
                if (p.data == x) demX++;
                if (p.data > 0 && p.data < minDuong) minDuong = p.data;
            }

            Console.WriteLine("a. Phần tử lớn nhất trong danh sách: " + max);
            Console.WriteLine("b. Tổng giá trị các phần tử:         " + tong);
            Console.WriteLine("c. Số lượng số nguyên tố:             " + demNT);
            Console.WriteLine($"d. Phân loại: {am} số âm, {khong} số không, {duong} số dương");
            Console.WriteLine($"e. Số lần xuất hiện của x = {x}:       {demX}");
            Console.WriteLine("f. Phần tử dương nhỏ nhất:           " + (minDuong == int.MaxValue ? "Không có" : minDuong.ToString()));

            static bool IsPrime(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i * i <= n; i++) if (n % i == 0) return false;
                return true;
            }
        }
        #endregion
    }
}
