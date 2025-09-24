using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal01_Iterator
{
    public class PlaylistIterator : IPlaylistIterator
    {
        private Playlist playlist;
        private int current = 0;
        private int step = 1;

        public PlaylistIterator(Playlist playlist)
        {
            this.playlist = playlist;
        }

        public Song First()
        {
            current = 0;
            return playlist[current];
        }

        public Song Next()
        {
            current += step;
            if (!IsDone)
                return playlist[current];
            else
                return null;
        }

        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        public Song CurrentSong
        {
            get { return playlist[current]; }
        }

        public bool IsDone
        {
            get { return current >= playlist.Count; }
        }
    }
}
