using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal01_Iterator
{
    public interface IPlaylistIterator
    {
        Song First();
        Song Next();
        bool IsDone { get; }
        Song CurrentSong { get; }
    }
}
