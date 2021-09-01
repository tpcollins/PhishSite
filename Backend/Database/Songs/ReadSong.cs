using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Phish_Website.Backend.Model;
using Phish_Website.Backend.Interfaces.SongInterfaces;

namespace Phish_Website.Backend.Database.Songs
{
    public class ReadSong : IReadSong
    {
        public List<Model.Songs> ReadSongTable()
        {
            throw new System.NotImplementedException();
        }
    }
}