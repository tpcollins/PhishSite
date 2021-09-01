using Phish_Website.Backend.Model;

namespace Phish_Website.Backend.Interfaces.SongInterfaces
{
    public interface ICreateSong
    {
        public void CreateSongTable();
        public void CreateSong(Songs song);
    }
}