# Buổi 03 – Stack và Queue (Chương 5)

Họ tên: Lê Trọng Vượng · MSV: 10125337 · Lớp: 10125O.1

## Danh sách bài đã làm (Tổng cộng 6 bài)
- **Bài 1:** Kiểm tra tính hợp lệ của biểu thức dấu ngoặc `()`, `[]`, `{}` bằng Stack.
- **Bài 2:** Mô phỏng lịch sử điều hướng trình duyệt Back / Forward bằng 2 Stack.
- **Bài 3:** Mô phỏng cơ chế Call Stack khi thực thi gọi và trả về của các hàm.
- **Bài 4:** Hệ thống hàng đợi in ấn (Print Spooler) theo thứ tự FIFO bằng Queue.
- **Bài 5:** Xử lý và truyền gói tin mạng (Network Packet Buffer) theo nguyên lý FIFO bằng Queue.
- **Bài 6:** Mô phỏng hệ thống quầy giao dịch khách hàng lấy số thứ tự tự động bằng Queue.

## Cách chạy
```
dotnet run --project Buoi03_Stack_Queue
```

## Kết quả chạy
```
============================================================
BUỔI 03 - STACK VÀ QUEUE (CHƯƠNG 5)
Họ tên: Lê Trọng Vượng - MSV: 10125337 - Lớp: 10125O.1
============================================================

=== Bài 1: Kiểm tra biểu thức dấu ngoặc (Stack) ===
Biểu thức: "{ [ ( a + b ) * c ] - d }" -> HỢP LỆ
Biểu thức: "( [ a + b } )            " -> KHÔNG HỢP LỆ
Biểu thức: "( ( a + b ) * [ c - d ] )" -> HỢP LỆ
Biểu thức: "( [ a + b ] ) )          " -> KHÔNG HỢP LỆ

=== Bài 2: Mô phỏng lịch sử trình duyệt Back/Forward (2 Stack) ===
1. Bắt đầu tại: google.com
2. Truy cập: github.com (Back stack: 1 trang)
2. Truy cập: utehy.edu.vn (Back stack: 2 trang)
2. Truy cập: stackoverflow.com (Back stack: 3 trang)

--- Thao tác Back ---
<- Back về: utehy.edu.vn | Forward stack: 1
<- Back về: github.com | Forward stack: 2

--- Thao tác Forward ---
-> Forward tới: utehy.edu.vn

=== Bài 3: Mô phỏng Function Call Stack (Ngăn xếp gọi hàm) ===
Mô phỏng luồng thực thi hàm:
[CALL] -> Gọi hàm: Main()          | Call Stack depth: 1 (Main())
[CALL] -> Gọi hàm: ProcessData()   | Call Stack depth: 2 (ProcessData() <- Main())
[CALL] -> Gọi hàm: ReadFromFile()  | Call Stack depth: 3 (ReadFromFile() <- ProcessData() <- Main())
[RET ] <- Thoát:   ReadFromFile()  | Call Stack depth: 2
[CALL] -> Gọi hàm: Calculate()     | Call Stack depth: 3 (Calculate() <- ProcessData() <- Main())
[RET ] <- Thoát:   Calculate()     | Call Stack depth: 2
[RET ] <- Thoát:   ProcessData()   | Call Stack depth: 1
[RET ] <- Thoát:   Main()          | Call Stack depth: 0

=== Bài 4: Hệ thống hàng đợi in ấn Spooler (Queue) ===
Gửi yêu cầu in vào hàng đợi:
  [+] Đã thêm vào hàng đợi in: BaoCao_CTDLGT.pdf
  [+] Đã thêm vào hàng đợi in: DeCuongOnTap.docx
  [+] Đã thêm vào hàng đợi in: BangDiem_Ky1.xlsx
  [+] Đã thêm vào hàng đợi in: Slide_Buoi03.pptx

Số lượng tài liệu đang chờ in: 4

Bắt đầu in tuần tự theo thứ tự FIFO:
  [v] Máy in hoàn thành: BaoCao_CTDLGT.pdf (Còn lại: 3)
  [v] Máy in hoàn thành: DeCuongOnTap.docx (Còn lại: 2)
  [v] Máy in hoàn thành: BangDiem_Ky1.xlsx (Còn lại: 1)
  [v] Máy in hoàn thành: Slide_Buoi03.pptx (Còn lại: 0)

=== Bài 5: Xử lý đường truyền gói tin FIFO (Queue) ===
Mô phỏng truyền gói tin mạng FIFO:
  -> Gửi gói tin: Packet#001 [SYN_REQUEST]
  -> Gửi gói tin: Packet#002 [ACK_RESPONSE]
  -> Gửi gói tin: Packet#003 [DATA_PAYLOAD_CHUNK_1]
  <- Đã truyền thành công: Packet#001 [SYN_REQUEST] (Hàng chờ: 2)
  -> Gửi gói tin: Packet#004 [DATA_PAYLOAD_CHUNK_2]
  <- Đã truyền thành công: Packet#002 [ACK_RESPONSE] (Hàng chờ: 2)
  <- Đã truyền thành công: Packet#003 [DATA_PAYLOAD_CHUNK_1] (Hàng chờ: 1)
  <- Đã truyền thành công: Packet#004 [DATA_PAYLOAD_CHUNK_2] (Hàng chờ: 0)

=== Bài 6: Quản lý hàng đợi khách hàng giao dịch (Queue) ===
Khách hàng lần lượt lấy số thứ tự vào hàng đợi:
  [STT 1] Khách: Lê Trọng Vượng   | Dịch vụ: Mở tài khoản VIP     | Giờ đến: 08:15:00
  [STT 2] Khách: Trần Thị Mai     | Dịch vụ: Chuyển tiền quốc tế  | Giờ đến: 08:18:30
  [STT 3] Khách: Nguyễn Văn Hùng  | Dịch vụ: Gửi tiết kiệm        | Giờ đến: 08:22:15
  [STT 4] Khách: Đặng Hoàng Anh   | Dịch vụ: Tư vấn vay vốn       | Giờ đến: 08:25:40

Quầy giao dịch bắt đầu phục vụ (FIFO):
  -> Quầy phục vụ vé #1: Lê Trọng Vượng (Mở tài khoản VIP) - Còn lại 3 khách chờ
  -> Quầy phục vụ vé #2: Trần Thị Mai (Chuyển tiền quốc tế) - Còn lại 2 khách chờ
  -> Quầy phục vụ vé #3: Nguyễn Văn Hùng (Gửi tiết kiệm) - Còn lại 1 khách chờ
  -> Quầy phục vụ vé #4: Đặng Hoàng Anh (Tư vấn vay vốn) - Còn lại 0 khách chờ

============================================================
HOÀN THÀNH TOÀN BỘ BÀI TẬP BUỔI 03!
============================================================
```
