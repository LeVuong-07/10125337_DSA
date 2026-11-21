using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("============================================================");
            Console.WriteLine("BUỔI 03 - STACK VÀ QUEUE (CHƯƠNG 5)");
            Console.WriteLine("Họ tên: Lê Trọng Vượng - MSV: 10125337 - Lớp: 10125O.1");
            Console.WriteLine("============================================================\n");

            Console.WriteLine("=== Bài 1: Kiểm tra biểu thức dấu ngoặc (Stack) ===");
            Bai1();

            Console.WriteLine("\n=== Bài 2: Mô phỏng lịch sử trình duyệt Back/Forward (2 Stack) ===");
            Bai2();

            Console.WriteLine("\n=== Bài 3: Mô phỏng Function Call Stack (Ngăn xếp gọi hàm) ===");
            Bai3();

            Console.WriteLine("\n=== Bài 4: Hệ thống hàng đợi in ấn Spooler (Queue) ===");
            Bai4();

            Console.WriteLine("\n=== Bài 5: Xử lý đường truyền gói tin FIFO (Queue) ===");
            Bai5();

            Console.WriteLine("\n=== Bài 6: Quản lý hàng đợi khách hàng giao dịch (Queue) ===");
            Bai6();

            Console.WriteLine("\n============================================================");
            Console.WriteLine("HOÀN THÀNH TOÀN BỘ BÀI TẬP BUỔI 03!");
            Console.WriteLine("============================================================");
        }

        #region BÀI 1
        static void Bai1()
        {
            string[] expressions = {
                "{ [ ( a + b ) * c ] - d }",
                "( [ a + b } )",
                "( ( a + b ) * [ c - d ] )",
                "( [ a + b ] ) )"
            };

            foreach (string s in expressions)
            {
                bool hopLe = KiemTraNgoac(s);
                Console.WriteLine($"Biểu thức: \"{s,-25}\" -> {(hopLe ? "HỢP LỆ" : "KHÔNG HỢP LỆ")}");
            }

            static bool KiemTraNgoac(string s)
            {
                Stack<char> st = new Stack<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    if (c == '(' || c == '[' || c == '{') st.Push(c);
                    else if (c == ')' || c == ']' || c == '}')
                    {
                        if (st.Count == 0) return false;
                        char top = st.Pop();
                        if (c == ')' && top != '(') return false;
                        if (c == ']' && top != '[') return false;
                        if (c == '}' && top != '{') return false;
                    }
                }
                return st.Count == 0;
            }
        }
        #endregion

        #region BÀI 2
        static void Bai2()
        {
            Stack<string> back = new Stack<string>();
            Stack<string> forward = new Stack<string>();
            string current = "google.com";
            Console.WriteLine("1. Bắt đầu tại: " + current);

            string[] nav = { "github.com", "utehy.edu.vn", "stackoverflow.com" };
            foreach (string page in nav)
            {
                back.Push(current);
                forward.Clear();
                current = page;
                Console.WriteLine($"2. Truy cập: {current} (Back stack: {back.Count} trang)");
            }

            Console.WriteLine("\n--- Thao tác Back ---");
            for (int i = 0; i < 2; i++)
            {
                forward.Push(current);
                current = back.Pop();
                Console.WriteLine($"<- Back về: {current} | Forward stack: {forward.Count}");
            }

            Console.WriteLine("\n--- Thao tác Forward ---");
            back.Push(current);
            current = forward.Pop();
            Console.WriteLine($"-> Forward tới: {current}");
        }
        #endregion

        #region BÀI 3
        static void Bai3()
        {
            Stack<string> callStack = new Stack<string>();

            void Call(string func)
            {
                callStack.Push(func);
                Console.WriteLine($"[CALL] -> Gọi hàm: {func,-15} | Call Stack depth: {callStack.Count} ({string.Join(" <- ", callStack)})");
            }

            void Return()
            {
                if (callStack.Count > 0)
                {
                    string func = callStack.Pop();
                    Console.WriteLine($"[RET ] <- Thoát:   {func,-15} | Call Stack depth: {callStack.Count}");
                }
            }

            Console.WriteLine("Mô phỏng luồng thực thi hàm:");
            Call("Main()");
            Call("ProcessData()");
            Call("ReadFromFile()");
            Return();
            Call("Calculate()");
            Return();
            Return();
            Return();
        }
        #endregion

        #region BÀI 4
        static void Bai4()
        {
            Queue<string> printerQueue = new Queue<string>();

            string[] docs = { "BaoCao_CTDLGT.pdf", "DeCuongOnTap.docx", "BangDiem_Ky1.xlsx", "Slide_Buoi03.pptx" };
            Console.WriteLine("Gửi yêu cầu in vào hàng đợi:");
            foreach (string d in docs)
            {
                printerQueue.Enqueue(d);
                Console.WriteLine($"  [+] Đã thêm vào hàng đợi in: {d}");
            }

            Console.WriteLine($"\nSố lượng tài liệu đang chờ in: {printerQueue.Count}");
            Console.WriteLine("\nBắt đầu in tuần tự theo thứ tự FIFO:");
            while (printerQueue.Count > 0)
            {
                string printed = printerQueue.Dequeue();
                Console.WriteLine($"  [v] Máy in hoàn thành: {printed} (Còn lại: {printerQueue.Count})");
            }
        }
        #endregion

        #region BÀI 5
        static void Bai5()
        {
            Queue<string> packetQueue = new Queue<string>();
            int packetId = 0;

            void SendPacket(string data)
            {
                packetId++;
                string packet = $"Packet#{packetId:D3} [{data}]";
                packetQueue.Enqueue(packet);
                Console.WriteLine($"  -> Gửi gói tin: {packet}");
            }

            void ProcessPacket()
            {
                if (packetQueue.Count > 0)
                {
                    string p = packetQueue.Dequeue();
                    Console.WriteLine($"  <- Đã truyền thành công: {p} (Hàng chờ: {packetQueue.Count})");
                }
            }

            Console.WriteLine("Mô phỏng truyền gói tin mạng FIFO:");
            SendPacket("SYN_REQUEST");
            SendPacket("ACK_RESPONSE");
            SendPacket("DATA_PAYLOAD_CHUNK_1");
            ProcessPacket();
            SendPacket("DATA_PAYLOAD_CHUNK_2");
            ProcessPacket();
            ProcessPacket();
            ProcessPacket();
        }
        #endregion

        #region BÀI 6
        struct KhachHang
        {
            public string Ten;
            public string LoaiDichVu;
            public string GioDen;
        }

        static void Bai6()
        {
            Queue<KhachHang> queue = new Queue<KhachHang>();

            KhachHang[] dsKhach = {
                new KhachHang { Ten = "Lê Trọng Vượng", LoaiDichVu = "Mở tài khoản VIP", GioDen = "08:15:00" },
                new KhachHang { Ten = "Trần Thị Mai",   LoaiDichVu = "Chuyển tiền quốc tế", GioDen = "08:18:30" },
                new KhachHang { Ten = "Nguyễn Văn Hùng",LoaiDichVu = "Gửi tiết kiệm", GioDen = "08:22:15" },
                new KhachHang { Ten = "Đặng Hoàng Anh", LoaiDichVu = "Tư vấn vay vốn", GioDen = "08:25:40" }
            };

            Console.WriteLine("Khách hàng lần lượt lấy số thứ tự vào hàng đợi:");
            foreach (var k in dsKhach)
            {
                queue.Enqueue(k);
                Console.WriteLine($"  [STT {queue.Count}] Khách: {k.Ten,-16} | Dịch vụ: {k.LoaiDichVu,-20} | Giờ đến: {k.GioDen}");
            }

            Console.WriteLine($"\nQuầy giao dịch bắt đầu phục vụ (FIFO):");
            int stt = 1;
            while (queue.Count > 0)
            {
                var k = queue.Dequeue();
                Console.WriteLine($"  -> Quầy phục vụ vé #{stt++}: {k.Ten} ({k.LoaiDichVu}) - Còn lại {queue.Count} khách chờ");
            }
        }
        #endregion
    }
}
