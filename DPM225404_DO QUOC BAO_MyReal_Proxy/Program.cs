using DPM225404_DO_QUOC_BAO_MyReal_Proxy;
using System;

namespace Proxy.RealWorld2
{
    /// <summary>
    /// Proxy Design Pattern - Lazy loading document
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo proxy cho file PDF
            IDocument doc = new DocumentProxy("File_BaoCao.pdf");

            // Lúc này file chưa load thật sự
            Console.WriteLine("Proxy created. File chưa được mở.\n");

            // Khi cần hiển thị nội dung mới load
            doc.Display();

            // Lần 2 gọi lại thì không cần load lại nữa
            doc.Display();

            Console.ReadKey();
        }
    }
}