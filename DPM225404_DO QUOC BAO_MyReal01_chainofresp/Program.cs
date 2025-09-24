using DPM225404_DO_QUOC_BAO_MyReal01_chainofresp;
using System;

namespace Chain.SupportExample
{
    /// <summary>
    /// Chain of Responsibility Design Pattern
    /// Ví dụ: Hệ thống hỗ trợ khách hàng
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo các handler
            SupportHandler level1 = new Level1Support();
            SupportHandler level2 = new Level2Support();
            SupportHandler manager = new ManagerSupport();

            // Setup chain
            level1.SetNext(level2);
            level2.SetNext(manager);

            // Tạo vài request
            SupportRequest r1 = new SupportRequest(1, "Password reset", 1);
            SupportRequest r2 = new SupportRequest(2, "Network issue", 2);
            SupportRequest r3 = new SupportRequest(3, "System outage", 3);
            SupportRequest r4 = new SupportRequest(4, "Critical security breach", 4);

            // Bắt đầu xử lý từ Level1
            level1.HandleRequest(r1);
            level1.HandleRequest(r2);
            level1.HandleRequest(r3);
            level1.HandleRequest(r4);

            Console.ReadKey();
        }
    }
}