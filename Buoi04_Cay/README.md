# Buổi 04 – Cây nhị phân tìm kiếm (Chương 6)

Họ tên: Lê Trọng Vượng · MSV: 10125337 · Lớp: 10125O.1

## Danh sách bài đã làm (Tổng cộng 8 bài)
- **Bài 1:** Đếm tổng số lượng nút trên cây nhị phân tìm kiếm.
- **Bài 2:** Tính tổng giá trị các nút trên cây.
- **Bài 3:** Hiển thị giá trị các nút trên cây theo thứ tự tăng dần (duyệt LNR - In-order).
- **Bài 4:** Hiển thị các nút có giá trị chẵn trên cây.
- **Bài 5:** Đếm số lượng các nút có giá trị chẵn trên cây.
- **Bài 6:** Đếm số lượng nút con (0, 1 hoặc 2 con) của một nút có giá trị x cho trước.
- **Bài 7:** Hiển thị toàn bộ các nút thuộc cây con bên trái của gốc.
- **Bài 8:** Cài đặt 3 phương pháp duyệt cây cơ bản: Tiền thứ tự (NLR), Trung thứ tự (LNR), Hậu thứ tự (LRN).

## Cách chạy
```
dotnet run --project Buoi04_Cay
```

## Kết quả chạy
```
============================================================
BUỔI 04 - CÂY NHỊ PHÂN TÌM KIẾM (CHƯƠNG 6)
Họ tên: Lê Trọng Vượng - MSV: 10125337 - Lớp: 10125O.1
============================================================

Cây nhị phân tìm kiếm đã khởi tạo với các giá trị:
50 -> 30 -> 70 -> 20 -> 40 -> 60 -> 80 -> 15 -> 25 -> 35 -> 65 -> 75 -> 85

=== Bài 1: Đếm số nút trên cây ===
Tổng số nút trên cây: 13

=== Bài 2: Tổng giá trị các nút trên cây ===
Tổng giá trị các nút: 650

=== Bài 3: Hiển thị giá trị các nút (thứ tự tăng dần LNR) ===
Giá trị các nút: 15 20 25 30 35 40 50 60 65 70 75 80 85 

=== Bài 4: Hiển thị các nút có giá trị chẵn ===
Các nút có giá trị chẵn: 20 30 40 50 60 70 80 

=== Bài 5: Đếm số nút có giá trị chẵn ===
Số lượng nút chẵn trên cây: 7

=== Bài 6: Đếm số con của một nút ===
Nút 50: Có 2 con (đủ 2 con)
Nút 30: Có 2 con (đủ 2 con)
Nút 20: Có 2 con (đủ 2 con)
Nút 15: Có 0 con (nút lá)
Nút 99: Không tồn tại trên cây

=== Bài 7: Hiển thị các nút trên cây con trái ===
Các nút thuộc cây con trái của gốc (50): 15 20 25 30 35 40 

=== Bài 8: Ba phương pháp duyệt cây nhị phân ===
1. Duyệt tiền thứ tự (NLR - Gốc, Trái, Phải): 50 30 20 15 25 40 35 70 60 65 80 75 85 
2. Duyệt trung thứ tự (LNR - Trái, Gốc, Phải): 15 20 25 30 35 40 50 60 65 70 75 80 85 
3. Duyệt hậu thứ tự (LRN - Trái, Phải, Gốc): 15 25 20 35 40 30 65 60 75 85 80 70 50 

============================================================
HOÀN THÀNH TOÀN BỘ BÀI TẬP BUỔI 04!
============================================================
```
