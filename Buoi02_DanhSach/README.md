# Buổi 02 – Danh sách & Giải thuật

Họ tên: Lê Trọng Vượng · MSV: 10125337 · Lớp: 10125O.1

## Bài đã làm
Bài 1, 2, 3, 4, 5, 6

## Cách chạy
```
dotnet run --project Buoi02_DanhSach
```

## Kết quả chạy
```
========================================
BUỔI 02 - BÀI TẬP THỰC HÀNH
Họ tên: Lê Trọng Vượng - MSV: 10125337
========================================

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
n = 1000: Tuần tự = 1393 ticks, Nhị phân = 988 ticks
n = 100000: Tuần tự = 16766 ticks, Nhị phân = 10 ticks
n = 1000000: Tuần tự = 211028 ticks, Nhị phân = 37 ticks

=== Bài 3: Kiểm tra số nguyên tố (2 giải thuật) ===
Kiểm tra số 29:
Giải thuật 1 (O(n)): 29 là số nguyên tố
Giải thuật 2 (O(sqrt(n))): 29 là số nguyên tố

=== Bài 4 & 6: Demo và so sánh thời gian chạy 5 thuật toán sắp xếp ===
Dãy ban đầu:
66.81  14.09  12.55  52.28  16.84  26.26  72.44  51.29  17.37  76.13  
1. Nổi bọt:
12.55  14.09  16.84  17.37  26.26  51.29  52.28  66.81  72.44  76.13  
2. Chọn:
12.55  14.09  16.84  17.37  26.26  51.29  52.28  66.81  72.44  76.13  
3. Chèn:
12.55  14.09  16.84  17.37  26.26  51.29  52.28  66.81  72.44  76.13  
4. Nhanh (QuickSort):
12.55  14.09  16.84  17.37  26.26  51.29  52.28  66.81  72.44  76.13  
5. Trộn (MergeSort):
12.55  14.09  16.84  17.37  26.26  51.29  52.28  66.81  72.44  76.13  

So sánh thời gian chạy (ms):
n = 1000: Nổi bọt = 1ms, Chọn = 0ms, Chèn = 0ms, Nhanh = 0ms, Trộn = 0ms
n = 5000: Nổi bọt = 64ms, Chọn = 30ms, Chèn = 23ms, Nhanh = 0ms, Trộn = 1ms

=== Bài 5: 4 giải thuật tính Fibonacci (Đệ quy, Lặp, Quy hoạch động, Ma trận) ===
Tính Fibonacci thứ 20:
Giải thuật 1 (đệ quy):        6765
Giải thuật 2 (vòng lặp):      6765
Giải thuật 3 (đệ quy có nhớ): 6765
Giải thuật 4 (ma trận):       6765
```
