using System;
using System.Windows.Forms;

namespace EmailServer_WindowForm
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // KIỂM TRA: Nếu có tham số "--child-smtp", đây là Tiến trình con xử lý gửi mail độc lập
            if (args.Length > 0 && args[0] == "--child-smtp")
            {
                ChildSmtpWorker.Execute(args);
                return;
            }

            // Chạy chế độ GUI bình thường đối với tiến trình Cha (Main Server)
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}