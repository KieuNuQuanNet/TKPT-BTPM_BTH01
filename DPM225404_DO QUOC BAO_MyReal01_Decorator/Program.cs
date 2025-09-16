using DPM225404_DO_QUOC_BAO_Real01_Decorator;
using System;
using System.Collections.Generic;
namespace Decorator.RealWorld
{
    /// <summary>
    /// Decorator Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();
            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();
            // Make video borrowable, then borrow and display
            Console.WriteLine("\nBiến video thành có thể cho mượn:");
            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Khách hàng #1");
            borrowvideo.BorrowItem("Khách hàng #2");
            borrowvideo.Display();
            // Wait for user
            Console.ReadKey();
        }
    }
}