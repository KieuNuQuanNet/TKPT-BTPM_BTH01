using DPM225404_DO_QUOC_BAO_Myreal01_Iterator;
using System;
using System.Collections.Generic;

namespace Iterator.PlaylistExample
{
    // ==================== Program ====================
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo playlist
            Playlist playlist = new Playlist();
            playlist[0] = new Song("Shape of You");
            playlist[1] = new Song("See You Again");
            playlist[2] = new Song("Despacito");
            playlist[3] = new Song("Sugar");
            playlist[4] = new Song("Counting Stars");

            // Tạo iterator
            PlaylistIterator iterator = playlist.CreateIterator();

            // Chọn bước nhảy = 1 (lặp qua tất cả bài hát)
            iterator.Step = 1;

            Console.WriteLine("🎶 Danh sách phát nhạc:");

            for (Song song = iterator.First();
                 !iterator.IsDone; song = iterator.Next())
            {
                Console.WriteLine("- " + song.Title);
            }

            Console.ReadKey();
        }
    }
}