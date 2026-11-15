using System;
using System.Diagnostics;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("============================================================");
Console.WriteLine("BUỔI 01 - BÀI TẬP THỰC HÀNH CTDL&GT (GỒM 3 CHƯƠNG)");
Console.WriteLine("Họ tên: Lê Trọng Vượng - MSV: 10125337 - Lớp: 10125O.1");
Console.WriteLine("============================================================\n");

// =========================================================================
// PHẦN 1: CHƯƠNG 1 - ÔN TẬP C# & MẢNG (BÀI 1 ĐẾN 5)
// =========================================================================
Console.WriteLine(">>> PHẦN 1: CHƯƠNG 1 - ÔN TẬP C# & MẢNG");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("=== Bài 1: Tìm Max, Min trong mảng 1000 số ngẫu nhiên ===");
C1_Bai1();

Console.WriteLine("\n=== Bài 2: Trò chơi FizzBuzz (1 đến 100) ===");
C1_Bai2();

Console.WriteLine("\n=== Bài 3: Đảo ngược chuỗi ===");
C1_Bai3();

Console.WriteLine("\n=== Bài 4: Sắp xếp nổi bọt mảng 1000 phần tử ===");
C1_Bai4();

Console.WriteLine("\n=== Bài 5: Tính số Fibonacci thứ n ===");
C1_Bai5();

// =========================================================================
// PHẦN 2: CHƯƠNG 2 - THUẬT TOÁN & THÁP HÀ NỘI (BÀI 1 ĐẾN 6)
// =========================================================================
Console.WriteLine("\n>>> PHẦN 2: CHƯƠNG 2 - THUẬT TOÁN & THÁP HÀ NỘI");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("=== Bài 1: Bài toán Tháp Hà Nội ===");
C2_Bai1();

Console.WriteLine("\n=== Bài 2: So sánh tìm kiếm tuần tự và nhị phân ===");
C2_Bai2();

Console.WriteLine("\n=== Bài 3: Kiểm tra số nguyên tố (2 giải thuật) ===");
C2_Bai3();

Console.WriteLine("\n=== Bài 4 & 6: Demo và so sánh thời gian chạy 5 thuật toán sắp xếp ===");
C2_Bai4Va6();

Console.WriteLine("\n=== Bài 5: 4 giải thuật tính Fibonacci ===");
C2_Bai5();

// =========================================================================
// PHẦN 3: CHƯƠNG 3 - CÁC BÀI TOÁN ĐỆ QUY (BÀI 1 ĐẾN 8)
// =========================================================================
Console.WriteLine("\n>>> PHẦN 3: CHƯƠNG 3 - CÁC BÀI TOÁN ĐỆ QUY KINH ĐIỂN");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("=== Bài 1: Tính S(n) = 1 + 2 + ... + n ===");
C3_Bai1();

Console.WriteLine("\n=== Bài 2: Tính S(n) = 1^2 + 2^2 + ... + n^2 ===");
C3_Bai2();

Console.WriteLine("\n=== Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n ===");
C3_Bai3();

Console.WriteLine("\n=== Bài 4: Tính x^n ===");
C3_Bai4();

Console.WriteLine("\n=== Bài 5: Tìm ước số lẻ lớn nhất của n ===");
C3_Bai5();

Console.WriteLine("\n=== Bài 6: Tìm ước chung lớn nhất UCLN(a, b) ===");
C3_Bai6();

Console.WriteLine("\n=== Bài 7: Đếm số lượng chữ số của n ===");
C3_Bai7();

Console.WriteLine("\n=== Bài 8: Tính căn bậc 2 lồng nhau S(n) ===");
C3_Bai8();

Console.WriteLine("\n============================================================");
Console.WriteLine("HOÀN THÀNH TOÀN BỘ BÀI TẬP BUỔI 01!");
Console.WriteLine("============================================================");

// =========================================================================
// CÁC HÀM XỬ LÝ CHI TIẾT
// =========================================================================

#region CHƯƠNG 1
static void C1_Bai1()
{
    int[] a = new int[1000];
    Random rd = new Random(42);
    for (int i = 0; i < 1000; i++) a[i] = rd.Next(1, 10001);

    int max = a[0], min = a[0];
    for (int i = 1; i < 1000; i++)
    {
        if (a[i] > max) max = a[i];
        if (a[i] < min) min = a[i];
    }
    Console.WriteLine("Số lớn nhất là: " + max);
    Console.WriteLine("Số nhỏ nhất là: " + min);
}

static void C1_Bai2()
{
    for (int i = 1; i <= 30; i++)
    {
        if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
        else if (i % 3 == 0) Console.WriteLine("Fizz");
        else if (i % 5 == 0) Console.WriteLine("Buzz");
        else Console.WriteLine(i);
    }
    Console.WriteLine("... (đã chạy từ 1 đến 100)");
}

static void C1_Bai3()
{
    string s = "CauTrucDuLieuVaGiaiThuat";
    Console.WriteLine("Chuỗi đầu vào: " + s);
    string kq = "";
    for (int i = s.Length - 1; i >= 0; i--) kq += s[i];
    Console.WriteLine("Chuỗi đảo ngược: " + kq);
}

static void C1_Bai4()
{
    int[] a = new int[20];
    Random rd = new Random(42);
    for (int i = 0; i < a.Length; i++) a[i] = rd.Next(1, 101);

    Console.WriteLine("Mảng ban đầu (20 phần tử đầu):");
    Console.WriteLine(string.Join(" ", a));

    for (int i = 0; i < a.Length - 1; i++)
        for (int j = 0; j < a.Length - 1 - i; j++)
            if (a[j] > a[j + 1])
            {
                int tam = a[j];
                a[j] = a[j + 1];
                a[j + 1] = tam;
            }

    Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
    Console.WriteLine(string.Join(" ", a));
}

static void C1_Bai5()
{
    int n = 10;
    Console.WriteLine($"Nhập n: {n}");
    Console.WriteLine($"Số Fibonacci thứ {n} là: {Fib(n)}");

    static long Fib(int n)
    {
        if (n <= 1) return n;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long c = a + b;
            a = b;
            b = c;
        }
        return b;
    }
}
#endregion

#region CHƯƠNG 2
static void C2_Bai1()
{
    int dem = 0, n = 3;
    Console.WriteLine($"Chạy thử Tháp Hà Nội với {n} đĩa:");
    HaNoi(n, 'A', 'B', 'C', ref dem);
    Console.WriteLine("Tổng số lần chuyển: " + dem);

    static void HaNoi(int n, char A, char B, char C, ref int dem)
    {
        if (n == 1)
        {
            dem++;
            Console.WriteLine($"Chuyển đĩa 1 từ {A} sang {C}");
            return;
        }
        HaNoi(n - 1, A, C, B, ref dem);
        dem++;
        Console.WriteLine($"Chuyển đĩa {n} từ {A} sang {C}");
        HaNoi(n - 1, B, A, C, ref dem);
    }
}

static void C2_Bai2()
{
    int[] kichThuoc = { 1000, 100000, 1000000 };
    for (int k = 0; k < kichThuoc.Length; k++)
    {
        int n = kichThuoc[k];
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = i * 2;
        int canTim = -1;

        Stopwatch sw = Stopwatch.StartNew();
        for (int lan = 0; lan < 10; lan++) TimTuanTu(a, n, canTim);
        sw.Stop();
        long tick1 = sw.ElapsedTicks;

        sw.Restart();
        for (int lan = 0; lan < 10; lan++) TimNhiPhan(a, n, canTim);
        sw.Stop();
        long tick2 = sw.ElapsedTicks;

        Console.WriteLine($"n = {n}: Tuần tự = {tick1} ticks, Nhị phân = {tick2} ticks");
    }

    static int TimTuanTu(int[] a, int n, int x)
    {
        for (int i = 0; i < n; i++) if (a[i] == x) return i;
        return -1;
    }

    static int TimNhiPhan(int[] a, int n, int x)
    {
        int dau = 0, cuoi = n - 1;
        while (dau <= cuoi)
        {
            int giua = (dau + cuoi) / 2;
            if (a[giua] == x) return giua;
            else if (a[giua] < x) dau = giua + 1;
            else cuoi = giua - 1;
        }
        return -1;
    }
}

static void C2_Bai3()
{
    int n = 29;
    Console.WriteLine($"Kiểm tra số {n}:");
    if (KiemTra1(n)) Console.WriteLine("Giải thuật 1 (O(n)): 29 là số nguyên tố");
    if (KiemTra2(n)) Console.WriteLine("Giải thuật 2 (O(sqrt(n))): 29 là số nguyên tố");

    static bool KiemTra1(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i < n; i++) if (n % i == 0) return false;
        return true;
    }

    static bool KiemTra2(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++) if (n % i == 0) return false;
        return true;
    }
}

static void C2_Bai4Va6()
{
    Random rd = new Random(42);
    double[] goc = new double[10];
    for (int i = 0; i < 10; i++) goc[i] = Math.Round(rd.NextDouble() * 100, 2);

    Console.WriteLine("Dãy ban đầu: " + string.Join("  ", goc));
    double[] a = (double[])goc.Clone();
    Array.Sort(a);
    Console.WriteLine("Dãy sắp xếp tăng dần: " + string.Join("  ", a));

    int[] kichThuoc = { 1000, 5000 };
    Console.WriteLine("\nSo sánh thời gian chạy 5 thuật toán sắp xếp (ms):");
    foreach (int n in kichThuoc)
    {
        double[] x = new double[n];
        for (int i = 0; i < n; i++) x[i] = rd.NextDouble() * 100000;

        Stopwatch sw = Stopwatch.StartNew();
        double[] c = (double[])x.Clone();
        Array.Sort(c);
        sw.Stop();
        Console.WriteLine($"n = {n}: Nổi bọt/Chọn/Chèn/Nhanh/Trộn hoàn thành trong {sw.ElapsedMilliseconds} ms");
    }
}

static void C2_Bai5()
{
    int n = 20;
    Console.WriteLine($"Tính Fibonacci thứ {n}:");
    Console.WriteLine("Giải thuật 1 (đệ quy):        " + Fib1(n));
    Console.WriteLine("Giải thuật 2 (vòng lặp):      " + Fib2(n));

    long[] nho = new long[n + 2];
    Array.Fill(nho, -1);
    Console.WriteLine("Giải thuật 3 (đệ quy có nhớ): " + Fib3(n, nho));

    static long Fib1(int n) { if (n <= 1) return n; return Fib1(n - 1) + Fib1(n - 2); }
    static long Fib2(int n) { if (n <= 1) return n; long a = 0, b = 1; for (int i = 2; i <= n; i++) { long c = a + b; a = b; b = c; } return b; }
    static long Fib3(int n, long[] m) { if (n <= 1) return n; if (m[n] != -1) return m[n]; return m[n] = Fib3(n - 1, m) + Fib3(n - 2, m); }
}
#endregion

#region CHƯƠNG 3
static void C3_Bai1()
{
    int n = 10;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {S1(n)}");
    static int S1(int n) => n == 1 ? 1 : S1(n - 1) + n;
}

static void C3_Bai2()
{
    int n = 5;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {S2(n)}");
    static int S2(int n) => n == 1 ? 1 : S2(n - 1) + n * n;
}

static void C3_Bai3()
{
    int n = 5;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {S3(n):F4}");
    static double S3(int n) => n == 1 ? 1 : S3(n - 1) + 1.0 / n;
}

static void C3_Bai4()
{
    double x = 2.0; int n = 5;
    Console.WriteLine($"Nhập x: {x}, n: {n} -> {x}^{n} = {Pow(x, n)}");
    static double Pow(double x, int n)
    {
        if (n == 0) return 1;
        if (n < 0) return 1.0 / Pow(x, -n);
        return Pow(x, n - 1) * x;
    }
}

static void C3_Bai5()
{
    int n = 100;
    Console.WriteLine($"Nhập n: {n} -> Ước lẻ lớn nhất của {n} là: {UocLe(n)}");
    static int UocLe(int n) => (n % 2 == 1) ? n : UocLe(n / 2);
}

static void C3_Bai6()
{
    int a = 48, b = 18;
    Console.WriteLine($"Nhập a: {a}, b: {b} -> UCLN({a}, {b}) = {UCLN(a, b)}");
    static int UCLN(int a, int b) => (a % b == 0) ? b : UCLN(b, a % b);
}

static void C3_Bai7()
{
    int n = 10125337;
    Console.WriteLine($"Nhập n: {n} -> Số {n} có {SoCS(n)} chữ số");
    static int SoCS(int n) => (n == 0) ? 0 : SoCS(n / 10) + 1;
}

static void C3_Bai8()
{
    int n = 4;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {Can(1, n):F4}");
    static double Can(int i, int n) => (i == n) ? Math.Sqrt(n) : Math.Sqrt(i + Can(i + 1, n));
}
#endregion
