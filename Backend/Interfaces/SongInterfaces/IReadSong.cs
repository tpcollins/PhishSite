using System.Collections.Generic;
using Phish_Website.Backend.Model;

namespace Phish_Website.Backend.Interfaces.SongInterfaces
{
    public interface IReadSong
    {
        public List<Songs> ReadSongTable();
    }
}