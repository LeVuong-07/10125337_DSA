using System;
using System.Diagnostics;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("========================================");
Console.WriteLine("BUỔI 02 - BÀI TẬP THỰC HÀNH");
Console.WriteLine("Họ tên: Lê Trọng Vượng - MSV: 10125337");
Console.WriteLine("========================================\n");

Console.WriteLine("=== Bài 1: Bài toán Tháp Hà Nội ===");
Bai1();

Console.WriteLine("\n=== Bài 2: So sánh tìm kiếm tuần tự và nhị phân ===");
Bai2();

Console.WriteLine("\n=== Bài 3: Kiểm tra số nguyên tố (2 giải thuật) ===");
Bai3();

Console.WriteLine("\n=== Bài 4 & 6: Demo và so sánh thời gian chạy 5 thuật toán sắp xếp ===");
Bai4Va6();

Console.WriteLine("\n=== Bài 5: 4 giải thuật tính Fibonacci (Đệ quy, Lặp, Quy hoạch động, Ma trận) ===");
Bai5();

// -----------------------------------------------------------
// CHI TIẾT CÁC BÀI TOÁN
// -----------------------------------------------------------

static void Bai1()
{
    int dem = 0;
    int n = 3; // Mặc định 3 đĩa để demo nhanh
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

static void Bai2()
{
    int[] kichThuoc = { 1000, 100000, 1000000 };

    for (int k = 0; k < kichThuoc.Length; k++)
    {
        int n = kichThuoc[k];
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = i * 2;
        }

        int canTim = -1;

        Stopwatch sw = new Stopwatch();

        sw.Start();
        for (int lan = 0; lan < 10; lan++)
        {
            TimTuanTu(a, n, canTim);
        }
        sw.Stop();
        long tick1 = sw.ElapsedTicks;

        sw.Restart();
        for (int lan = 0; lan < 10; lan++)
        {
            TimNhiPhan(a, n, canTim);
        }
        sw.Stop();
        long tick2 = sw.ElapsedTicks;

        Console.WriteLine($"n = {n}: Tuần tự = {tick1} ticks, Nhị phân = {tick2} ticks");
    }

    static int TimTuanTu(int[] a, int n, int x)
    {
        for (int i = 0; i < n; i++)
        {
            if (a[i] == x) return i;
        }
        return -1;
    }

    static int TimNhiPhan(int[] a, int n, int x)
    {
        int dau = 0;
        int cuoi = n - 1;
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

static void Bai3()
{
    int n = 29;
    Console.WriteLine($"Kiểm tra số {n}:");
    if (KiemTra1(n))
        Console.WriteLine("Giải thuật 1 (O(n)): " + n + " là số nguyên tố");
    if (KiemTra2(n))
        Console.WriteLine("Giải thuật 2 (O(sqrt(n))): " + n + " là số nguyên tố");

    static bool KiemTra1(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= n - 1; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static bool KiemTra2(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}

static void Bai4Va6()
{
    Random rd = new Random(42);
    double[] goc = new double[10];
    for (int i = 0; i < 10; i++)
    {
        goc[i] = Math.Round(rd.NextDouble() * 100, 2);
    }
    Console.WriteLine("Dãy ban đầu:");
    InMang(goc);

    double[] a = (double[])goc.Clone();
    NoiBot(a);
    Console.WriteLine("1. Nổi bọt:");
    InMang(a);

    a = (double[])goc.Clone();
    Chon(a);
    Console.WriteLine("2. Chọn:");
    InMang(a);

    a = (double[])goc.Clone();
    Chen(a);
    Console.WriteLine("3. Chèn:");
    InMang(a);

    a = (double[])goc.Clone();
    Nhanh(a, 0, a.Length - 1);
    Console.WriteLine("4. Nhanh (QuickSort):");
    InMang(a);

    a = (double[])goc.Clone();
    Tron(a, 0, a.Length - 1);
    Console.WriteLine("5. Trộn (MergeSort):");
    InMang(a);

    int[] kichThuoc = { 1000, 5000 };
    Console.WriteLine("\nSo sánh thời gian chạy (ms):");
    for (int k = 0; k < kichThuoc.Length; k++)
    {
        int n = kichThuoc[k];
        double[] x = new double[n];
        for (int i = 0; i < n; i++)
        {
            x[i] = rd.NextDouble() * 100000;
        }

        Stopwatch sw = new Stopwatch();

        a = (double[])x.Clone();
        sw.Restart();
        NoiBot(a);
        sw.Stop();
        long t1 = sw.ElapsedMilliseconds;

        a = (double[])x.Clone();
        sw.Restart();
        Chon(a);
        sw.Stop();
        long t2 = sw.ElapsedMilliseconds;

        a = (double[])x.Clone();
        sw.Restart();
        Chen(a);
        sw.Stop();
        long t3 = sw.ElapsedMilliseconds;

        a = (double[])x.Clone();
        sw.Restart();
        Nhanh(a, 0, n - 1);
        sw.Stop();
        long t4 = sw.ElapsedMilliseconds;

        a = (double[])x.Clone();
        sw.Restart();
        Tron(a, 0, n - 1);
        sw.Stop();
        long t5 = sw.ElapsedMilliseconds;

        Console.WriteLine($"n = {n}: Nổi bọt = {t1}ms, Chọn = {t2}ms, Chèn = {t3}ms, Nhanh = {t4}ms, Trộn = {t5}ms");
    }

    static void InMang(double[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + "  ");
        }
        Console.WriteLine();
    }

    static void NoiBot(double[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    double tam = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tam;
                }
            }
        }
    }

    static void Chon(double[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int iMin = i;
            for (int j = i + 1; j < n; j++)
            {
                if (a[j] < a[iMin]) iMin = j;
            }
            double tam = a[i];
            a[i] = a[iMin];
            a[iMin] = tam;
        }
    }

    static void Chen(double[] a)
    {
        int n = a.Length;
        for (int i = 1; i < n; i++)
        {
            double x = a[i];
            int j = i - 1;
            while (j >= 0 && a[j] > x)
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = x;
        }
    }

    static void Nhanh(double[] a, int dau, int cuoi)
    {
        if (dau >= cuoi) return;
        int vt = PhanHoach(a, dau, cuoi);
        Nhanh(a, dau, vt - 1);
        Nhanh(a, vt + 1, cuoi);
    }

    static int PhanHoach(double[] a, int dau, int cuoi)
    {
        double chot = a[cuoi];
        int i = dau - 1;
        for (int j = dau; j < cuoi; j++)
        {
            if (a[j] < chot)
            {
                i++;
                double tam = a[i];
                a[i] = a[j];
                a[j] = tam;
            }
        }
        double t = a[i + 1];
        a[i + 1] = a[cuoi];
        a[cuoi] = t;
        return i + 1;
    }

    static void Tron(double[] a, int dau, int cuoi)
    {
        if (dau >= cuoi) return;
        int giua = (dau + cuoi) / 2;
        Tron(a, dau, giua);
        Tron(a, giua + 1, cuoi);
        GopHaiNua(a, dau, giua, cuoi);
    }

    static void GopHaiNua(double[] a, int dau, int giua, int cuoi)
    {
        double[] tam = new double[cuoi - dau + 1];
        int i = dau;
        int j = giua + 1;
        int k = 0;

        while (i <= giua && j <= cuoi)
        {
            if (a[i] <= a[j])
            {
                tam[k] = a[i];
                i++;
            }
            else
            {
                tam[k] = a[j];
                j++;
            }
            k++;
        }
        while (i <= giua)
        {
            tam[k] = a[i];
            i++;
            k++;
        }
        while (j <= cuoi)
        {
            tam[k] = a[j];
            j++;
            k++;
        }
        for (k = 0; k < tam.Length; k++)
        {
            a[dau + k] = tam[k];
        }
    }
}

static void Bai5()
{
    int n = 20;
    Console.WriteLine($"Tính Fibonacci thứ {n}:");
    Console.WriteLine("Giải thuật 1 (đệ quy):        " + FiboDeQuy(n));
    Console.WriteLine("Giải thuật 2 (vòng lặp):      " + FiboLap(n));

    long[] nho = new long[n + 2];
    for (int i = 0; i < n + 2; i++) nho[i] = -1;
    Console.WriteLine("Giải thuật 3 (đệ quy có nhớ): " + FiboNho(n, nho));

    Console.WriteLine("Giải thuật 4 (ma trận):       " + FiboMaTran(n));

    static long FiboDeQuy(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FiboDeQuy(n - 1) + FiboDeQuy(n - 2);
    }

    static long FiboLap(int n)
    {
        if (n == 0) return 0;
        long a = 0;
        long b = 1;
        for (int i = 2; i <= n; i++)
        {
            long c = a + b;
            a = b;
            b = c;
        }
        return b;
    }

    static long FiboNho(int n, long[] nho)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        if (nho[n] != -1) return nho[n];
        nho[n] = FiboNho(n - 1, nho) + FiboNho(n - 2, nho);
        return nho[n];
    }

    static long[,] NhanMaTran(long[,] x, long[,] y)
    {
        long[,] kq = new long[2, 2];
        kq[0, 0] = x[0, 0] * y[0, 0] + x[0, 1] * y[1, 0];
        kq[0, 1] = x[0, 0] * y[0, 1] + x[0, 1] * y[1, 1];
        kq[1, 0] = x[1, 0] * y[0, 0] + x[1, 1] * y[1, 0];
        kq[1, 1] = x[1, 0] * y[0, 1] + x[1, 1] * y[1, 1];
        return kq;
    }

    static long FiboMaTran(int n)
    {
        if (n == 0) return 0;

        long[,] kq = { { 1, 0 }, { 0, 1 } };
        long[,] m = { { 1, 1 }, { 1, 0 } };

        while (n > 0)
        {
            if (n % 2 == 1) kq = NhanMaTran(kq, m);
            m = NhanMaTran(m, m);
            n = n / 2;
        }
        return kq[0, 1];
    }
}
