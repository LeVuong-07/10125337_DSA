# Buổi 02 – Danh sách (Chương 4)

Họ tên: Lê Trọng Vượng · MSV: 10125337 · Lớp: 10125O.1

## Danh sách bài đã làm (Tổng cộng 5 bài)
- **Bài 1:** Dãy số nguyên - Khởi tạo, hiển thị và chèn phần tử vào vị trí k bất kỳ.
- **Bài 2:** Quản lý nhân viên (Struct NhanVien) - Tính tổng thực lĩnh và tìm nhân viên có lương cơ bản thấp nhất.
- **Bài 3:** Ma trận vuông - Tính tổng đường chéo chính, đường chéo phụ và đếm số lượng phần tử lẻ.
- **Bài 4:** Danh sách liên kết đơn cơ bản - Đếm số lần xuất hiện của x, tìm số dương nhỏ nhất, xóa phần tử đầu tiên có giá trị x.
- **Bài 5:** Danh sách liên kết đơn nâng cao - Tìm phần tử lớn nhất, tính tổng, đếm số nguyên tố, phân loại âm/không/dương.

## Cách chạy
```
dotnet run --project Buoi02_DanhSach
```

## Kết quả chạy
```
============================================================
BUỔI 02 - DANH SÁCH (CHƯƠNG 4)
Họ tên: Lê Trọng Vượng - MSV: 10125337 - Lớp: 10125O.1
============================================================

=== Bài 1: Dãy số nguyên - Nhập, hiển thị, chèn phần tử ===
Dãy số ban đầu:
12 45 23 67 34 89 56
Chèn giá trị x = 99 vào vị trí k = 3:
Dãy số sau khi chèn:
12 45 23 99 67 34 89 56

=== Bài 2: Quản lý nhân viên (Struct NhanVien) ===
Danh sách nhân viên (4 người):
  [NV01] Lê Trọng Vượng     - PB: Kỹ thuật   - Lương: 12,000,000đ - Thực lĩnh: 15,000,000đ
  [NV02] Nguyễn Văn An      - PB: Kinh doanh - Lương: 8,500,000đ - Thực lĩnh: 10,500,000đ
  [NV03] Trần Thị Bình      - PB: Kế toán    - Lương: 9,000,000đ - Thực lĩnh: 10,500,000đ
  [NV04] Phạm Hoàng Nam     - PB: Kỹ thuật   - Lương: 7,500,000đ - Thực lĩnh: 8,500,000đ

a. Tổng thực lĩnh tháng của công ty: 44,500,000 VNĐ
b. Nhân viên có lương cơ bản thấp nhất (7,500,000 VNĐ):
   -> Phạm Hoàng Nam (NV04) - Phòng: Kỹ thuật

=== Bài 3: Ma trận vuông - Tổng đường chéo, đếm số lẻ ===
Ma trận vuông cấp 3x3:
     4   7   2
     3   5   9
     8   1   6

a. Tổng các phần tử trên đường chéo chính: 15
b. Tổng các phần tử trên đường chéo phụ:   15
c. Số lượng phần tử lẻ trong ma trận:     5

=== Bài 4: Danh sách liên kết đơn (Đếm x, tìm min dương, xóa x) ===
Danh sách liên kết ban đầu: 15 -> -4 -> 7 -> 23 -> 7 -> -8 -> 2 -> 7 -> 19 -> NULL
a. Số lần xuất hiện của phần tử x = 7: 3 lần
b. Phần tử dương nhỏ nhất trong danh sách: 2
c. Danh sách sau khi xóa phần tử đầu tiên có giá trị 7: 15 -> -4 -> 23 -> 7 -> -8 -> 2 -> 7 -> 19 -> NULL

=== Bài 5: Danh sách liên kết đơn nâng cao (Max, Tổng, SNT, Đếm) ===
Danh sách liên kết: 11 -> -3 -> 0 -> 7 -> 18 -> -9 -> 2 -> 0 -> 13 -> 24 -> NULL
a. Phần tử lớn nhất trong danh sách: 24
b. Tổng giá trị các phần tử:         63
c. Số lượng số nguyên tố:             4
d. Phân loại: 2 số âm, 2 số không, 6 số dương
e. Số lần xuất hiện của x = 7:       1
f. Phần tử dương nhỏ nhất:           2

============================================================
HOÀN THÀNH TOÀN BỘ BÀI TẬP BUỔI 02!
============================================================
```
