using System;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("========================================");
Console.WriteLine("BUỔI 03 - BÀI TẬP THỰC HÀNH");
Console.WriteLine("Họ tên: Lê Trọng Vượng - MSV: 10125337");
Console.WriteLine("========================================\n");

Console.WriteLine("=== Bài 1: Tính S(n) = 1 + 2 + ... + n ===");
Bai1();

Console.WriteLine("\n=== Bài 2: Tính S(n) = 1^2 + 2^2 + ... + n^2 ===");
Bai2();

Console.WriteLine("\n=== Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n ===");
Bai3();

Console.WriteLine("\n=== Bài 4: Tính x^n ===");
Bai4();

Console.WriteLine("\n=== Bài 5: Tìm ước số lẻ lớn nhất của n ===");
Bai5();

Console.WriteLine("\n=== Bài 6: Tìm ước chung lớn nhất UCLN(a, b) ===");
Bai6();

Console.WriteLine("\n=== Bài 7: Đếm số lượng chữ số của n ===");
Bai7();

Console.WriteLine("\n=== Bài 8: Tính căn bậc 2 lồng nhau S(n) ===");
Bai8();

// -----------------------------------------------------------
// CHI TIẾT CÁC BÀI TOÁN ĐỆ QUY
// -----------------------------------------------------------

static void Bai1()
{
    int n = 10;
    Console.WriteLine($"Nhập n: {n}");
    Console.WriteLine($"S({n}) = {S1(n)}");

    static int S1(int n)
    {
        if (n == 1) return 1;
        return S1(n - 1) + n;
    }
}

static void Bai2()
{
    int n = 5;
    Console.WriteLine($"Nhập n: {n}");
    Console.WriteLine($"S({n}) = {S2(n)}");

    static int S2(int n)
    {
        if (n == 1) return 1;
        return S2(n - 1) + n * n;
    }
}

static void Bai3()
{
    int n = 5;
    Console.WriteLine($"Nhập n: {n}");
    Console.WriteLine($"S({n}) = {S3(n):F4}");

    static double S3(int n)
    {
        if (n == 1) return 1;
        return S3(n - 1) + 1.0 / n;
    }
}

static void Bai4()
{
    double x = 2.0;
    int n = 5;
    Console.WriteLine($"Nhập x: {x}, n: {n}");
    Console.WriteLine($"{x}^{n} = {LuyThua(x, n)}");

    static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;
        if (n < 0) return 1.0 / LuyThua(x, -n);
        return LuyThua(x, n - 1) * x;
    }
}

static void Bai5()
{
    int n = 100;
    Console.WriteLine($"Nhập n: {n}");
    Console.WriteLine($"Ước lẻ lớn nhất của {n} là: {UocLeMax(n)}");

    static int UocLeMax(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeMax(n / 2);
    }
}

static void Bai6()
{
    int a = 48, b = 18;
    Console.WriteLine($"Nhập a: {a}, b: {b}");
    Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");

    static int UCLN(int a, int b)
    {
        if (a % b == 0) return b;
        return UCLN(b, a % b);
    }
}

static void Bai7()
{
    int n = 10125337;
    Console.WriteLine($"Nhập n: {n}");
    Console.WriteLine($"Số {n} có {SoChuSo(n)} chữ số");

    static int SoChuSo(int n)
    {
        if (n == 0) return 0;
        return SoChuSo(n / 10) + 1;
    }
}

static void Bai8()
{
    int n = 4;
    Console.WriteLine($"Nhập n: {n}");
    Console.WriteLine($"S({n}) = {S8(n):F4}");

    static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static double S8(int n)
    {
        return Can(1, n);
    }
}
