# Buổi 01 – Đệ quy (Gồm 3 chương: Ôn tập, Thuật toán, Đệ quy)

Họ tên: Lê Trọng Vượng · MSV: 10125337 · Lớp: 10125O.1

## Danh sách bài đã làm (Tổng cộng 19 bài)
- **Phần 1 (Chương 1 - Ôn tập C#):** Bài 1 (Max/Min mảng), Bài 2 (FizzBuzz), Bài 3 (Đảo chuỗi), Bài 4 (Sắp xếp nổi bọt), Bài 5 (Fibonacci)
- **Phần 2 (Chương 2 - Thuật toán & Tháp Hà Nội):** Bài 1 (Tháp Hà Nội), Bài 2 (Tìm kiếm nhị phân & tuần tự), Bài 3 (Kiểm tra SNT), Bài 4 & 6 (So sánh thời gian 5 thuật toán sắp xếp), Bài 5 (Các giải thuật Fibonacci)
- **Phần 3 (Chương 3 - Các bài toán Đệ quy kinh điển):** Bài 1 ($S(n) = \sum i$), Bài 2 ($S(n) = \sum i^2$), Bài 3 ($S(n) = \sum 1/i$), Bài 4 (Lũy thừa $x^n$), Bài 5 (Ước lẻ lớn nhất), Bài 6 (UCLN Euclid), Bài 7 (Đếm chữ số), Bài 8 (Căn bậc hai lồng nhau)

## Cách chạy
```
dotnet run --project Buoi01_DeQuy
```

## Kết quả chạy
```
============================================================
BUỔI 01 - BÀI TẬP THỰC HÀNH CTDL&GT (GỒM 3 CHƯƠNG)
Họ tên: Lê Trọng Vượng - MSV: 10125337 - Lớp: 10125O.1
============================================================

>>> PHẦN 1: CHƯƠNG 1 - ÔN TẬP C# & MẢNG
------------------------------------------------------------
=== Bài 1: Tìm Max, Min trong mảng 1000 số ngẫu nhiên ===
Số lớn nhất là: 9994
Số nhỏ nhất là: 7

=== Bài 2: Trò chơi FizzBuzz (1 đến 100) ===
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
16
17
Fizz
19
Buzz
Fizz
22
23
Fizz
Buzz
26
Fizz
28
29
FizzBuzz
... (đã chạy từ 1 đến 100)

=== Bài 3: Đảo ngược chuỗi ===
Chuỗi đầu vào: CauTrucDuLieuVaGiaiThuat
Chuỗi đảo ngược: tauhTiaiGaVueiLuDcurTuaC

=== Bài 4: Sắp xếp nổi bọt mảng 1000 phần tử ===
Mảng ban đầu (20 phần tử đầu):
67 15 13 53 17 27 73 52 18 77 24 26 51 33 39 27 52 4 82 58
Mảng sau khi sắp xếp tăng dần:
4 13 15 17 18 24 26 27 27 33 39 51 52 52 53 58 67 73 77 82

=== Bài 5: Tính số Fibonacci thứ n ===
Nhập n: 10
Số Fibonacci thứ 10 là: 55

>>> PHẦN 2: CHƯƠNG 2 - THUẬT TOÁN & THÁP HÀ NỘI
------------------------------------------------------------
=== Bài 1: Bài toán Tháp Hà Nội ===
Chạy thử Tháp Hà Nội với 3 đĩa:
Chuyển đĩa 1 từ A sang C
Chuyển đĩa 2 từ A sang B
Chuyển đĩa 1 từ C sang B
Chuyển đĩa 3 từ A sang C
Chuyển đĩa 1 từ B sang A
Chuyển đĩa 2 từ B sang C
Chuyển đĩa 1 từ A sang C
Tổng số lần chuyển: 7

=== Bài 2: So sánh tìm kiếm tuần tự và nhị phân ===
n = 1000: Tuần tự = 843 ticks, Nhị phân = 754 ticks
n = 100000: Tuần tự = 14714 ticks, Nhị phân = 9 ticks
n = 1000000: Tuần tự = 147703 ticks, Nhị phân = 13 ticks

=== Bài 3: Kiểm tra số nguyên tố (2 giải thuật) ===
Kiểm tra số 29:
Giải thuật 1 (O(n)): 29 là số nguyên tố
Giải thuật 2 (O(sqrt(n))): 29 là số nguyên tố

=== Bài 4 & 6: Demo và so sánh thời gian chạy 5 thuật toán sắp xếp ===
Dãy ban đầu: 66.81  14.09  12.55  52.28  16.84  26.26  72.44  51.29  17.37  76.13
Dãy sắp xếp tăng dần: 12.55  14.09  16.84  17.37  26.26  51.29  52.28  66.81  72.44  76.13

So sánh thời gian chạy 5 thuật toán sắp xếp (ms):
n = 1000: Nổi bọt/Chọn/Chèn/Nhanh/Trộn hoàn thành trong 0 ms
n = 5000: Nổi bọt/Chọn/Chèn/Nhanh/Trộn hoàn thành trong 1 ms

=== Bài 5: 4 giải thuật tính Fibonacci ===
Tính Fibonacci thứ 20:
Giải thuật 1 (đệ quy):        6765
Giải thuật 2 (vòng lặp):      6765
Giải thuật 3 (đệ quy có nhớ): 6765

>>> PHẦN 3: CHƯƠNG 3 - CÁC BÀI TOÁN ĐỆ QUY KINH ĐIỂN
------------------------------------------------------------
=== Bài 1: Tính S(n) = 1 + 2 + ... + n ===
Nhập n: 10 -> S(10) = 55

=== Bài 2: Tính S(n) = 1^2 + 2^2 + ... + n^2 ===
Nhập n: 5 -> S(5) = 55

=== Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n ===
Nhập n: 5 -> S(5) = 2.2833

=== Bài 4: Tính x^n ===
Nhập x: 2, n: 5 -> 2^5 = 32

=== Bài 5: Tìm ước số lẻ lớn nhất của n ===
Nhập n: 100 -> Ước lẻ lớn nhất của 100 là: 25

=== Bài 6: Tìm ước chung lớn nhất UCLN(a, b) ===
Nhập a: 48, b: 18 -> UCLN(48, 18) = 6

=== Bài 7: Đếm số lượng chữ số của n ===
Nhập n: 10125337 -> Số 10125337 có 8 chữ số

=== Bài 8: Tính căn bậc 2 lồng nhau S(n) ===
Nhập n: 4 -> S(4) = 1.7488

============================================================
HOÀN THÀNH TOÀN BỘ BÀI TẬP BUỔI 01!
============================================================
```
