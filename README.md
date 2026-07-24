# Bài thực hành Lập trình mạng

Kho lưu trữ các bài thực hành Lập trình mạng bằng C# và .NET.

## Nội dung dự án

### LAB4

- Lập trình TCP Socket Client/Server.
- Giao tiếp bảo mật TLS/SSL.
- Email Client/Server dạng Console và Windows Forms.
- Meeting Client/Server dạng Console và Windows Forms.
- Tạo và sử dụng chứng chỉ số cho kết nối bảo mật.

### LAB5

- Các bài Client/Server mở rộng.
- Truyền dữ liệu qua Socket.
- Thực hành kết nối TLS giữa máy khách và máy chủ.

## Công nghệ sử dụng

- C#
- .NET 8
- TCP/IP Socket
- TLS/SSL
- SMTP
- Windows Forms
- Lập trình đa luồng và bất đồng bộ

## Cách chạy

1. Cài Visual Studio và .NET 8 SDK.
2. Mở file `.sln` hoặc `.slnx` của bài cần chạy.
3. Chạy chương trình Server trước.
4. Chạy chương trình Client và nhập đúng địa chỉ IP, cổng.
5. Nếu chạy trên hai máy, kiểm tra Windows Firewall và bảo đảm hai máy kết nối được với nhau.
6. Với bài TLS, đặt biến môi trường `PFX_PASSWORD` trước khi tạo chứng chỉ.

## Ghi chú

Các thư mục tự sinh như `.vs`, `bin`, `obj` và bộ cài XAMPP không được đưa lên GitHub vì có thể tạo hoặc cài lại.
