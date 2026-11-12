# HƯỚNG DẪN TỰ NỘP BÀI TẬP CTDL&GT (DSA) QUA GITHUB
> Dành cho sinh viên: **Lê Trọng Vượng** · MSV: **10125337** · Lớp: **10125O.1**  
> Áp dụng cho các buổi thực hành tiếp theo (Buổi 04 Cây, Buổi 05 Sắp xếp, Buổi 06 Tìm kiếm, Bài tập lớn).

---

## 📌 QUY TRÌNH 7 BƯỚC LÀM VÀ NỘP BÀI MỖI BUỔI

*(Ví dụ minh họa cho **Buổi 04 – Cây**: thư mục `Buoi04_Cay`)*

### Bước 1: Mở Terminal/PowerShell tại thư mục Repo
1. Mở ứng dụng **PowerShell** hoặc **Terminal** trên Windows.
2. Di chuyển vào thư mục repo bài tập:
   ```powershell
   cd D:\Gemini\10125337_DSA
   ```

---

### Bước 2: Tạo Project Console C# cho buổi mới
Chạy lệnh tạo project với đúng tên thư mục thầy yêu cầu:
```powershell
dotnet new console -n Buoi04_Cay
```
> Lệnh này sẽ tự tạo thư mục `Buoi04_Cay/` gồm:
> - `Buoi04_Cay.csproj`
> - `Program.cs`

---

### Bước 3: Viết code vào `Program.cs`
Mở file `Buoi04_Cay/Program.cs` bằng VS Code hoặc Visual Studio. Cấu trúc code nên viết như sau:

```csharp
using System;

// Hỗ trợ hiển thị tiếng Việt có dấu trong Console
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("========================================");
Console.WriteLine("BUỔI 04 - BÀI TẬP THỰC HÀNH");
Console.WriteLine("Họ tên: Lê Trọng Vượng - MSV: 10125337");
Console.WriteLine("========================================\n");

Console.WriteLine("=== Bài 1 ===");
Bai1();

Console.WriteLine("\n=== Bài 2 ===");
Bai2();

// Viết từng bài thành một hàm static riêng bên dưới:
static void Bai1()
{
    // Code bài 1...
}

static void Bai2()
{
    // Code bài 2...
}
```

---

### Bước 4: Chạy thử và sao chép kết quả in ra màn hình
Tại thư mục repo, chạy lệnh:
```powershell
dotnet run --project Buoi04_Cay
```
Kiểm tra xem chương trình chạy đúng và in ra màn hình đầy đủ các bài.  
👉 **Bôi đen toàn bộ nội dung chương trình in ra trong Terminal và bấm `Ctrl + C` để copy.**

---

### Bước 5: Tạo file `README.md` trong thư mục của buổi
Tạo file `Buoi04_Cay/README.md` và dán theo mẫu sau:

````markdown
# Buổi 04 – Cây

Họ tên: Lê Trọng Vượng · MSV: 10125337 · Lớp: 10125O.1

## Bài đã làm
Bài 1, 2, 3...

## Cách chạy
```
dotnet run --project Buoi04_Cay
```

## Kết quả chạy
```
(Dán toàn bộ nội dung copy ở Bước 4 vào đây)
```
````

---

### Bước 6: Cập nhật file `README.md` ở thư mục gốc
Mở file `README.md` ở thư mục lớn ngoài cùng (`D:\Gemini\10125337_DSA\README.md`):
- Tìm dòng của Buổi 04, sửa chữ `Chưa nộp` thành `Đã nộp`.

---

### Bước 7: Đẩy bài lên GitHub (3 lệnh thần thánh)
Tại cửa sổ PowerShell, chạy 3 lệnh sau:

```powershell
git add .
git commit -m "Buoi04: cay nhi phan tim kiem"
git push
```

🎉 **Xong!** Bạn mở link repo `https://github.com/LeVuong-07/10125337_DSA` trên trình duyệt xem thư mục mới xuất hiện là hoàn tất việc nộp bài.

---

## ⚠️ MẸO VÀ LƯU Ý QUAN TRỌNG

1. **Tên thư mục phải chuẩn từng chữ hoa/thường:**
   - Buổi 04: `Buoi04_Cay`
   - Buổi 05: `Buoi05_SapXep`
   - Buổi 06: `Buoi06_TimKiem`
   - Bài tập lớn: `BaiTapLon`
2. **Không xóa file `.gitignore`:** File này giúp ngăn không đẩy các thư mục rác nặng máy như `bin/`, `obj/` lên GitHub.
3. **Mỗi buổi bắt buộc phải có `README.md`:** Thầy yêu cầu phải có kết quả chạy thực tế thì mới được tính là hoàn thành đủ bài.
4. **Nếu sửa file trực tiếp trên web GitHub:** Trước khi làm tiếp trên máy, luôn chạy lệnh `git pull` để đồng bộ về máy trước khi làm bài mới.
