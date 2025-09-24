using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal01_Iterator
{
    public class Playlist : IPlaylist
    {
        private List<Song> songs = new List<Song>();

        public PlaylistIterator CreateIterator()
        {
            return new PlaylistIterator(this);
        }

        public int Count
        {
            get { return songs.Count; }
        }

        // Indexer
        public Song this[int index]
        {
            get
            {
                if (index < songs.Count)
                    return songs[index];
                return null;
            }
            set
            {
                if (index < songs.Count)
                    songs[index] = value;
                else
                    songs.Add(value);
            }
        }
    }
}
