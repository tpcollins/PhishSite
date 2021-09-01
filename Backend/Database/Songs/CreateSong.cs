using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phish_Website.Backend.Interfaces.ShowInterfaces;
using Phish_Website.Backend.Interfaces.SongInterfaces;
using Phish_Website.Backend.Model;
namespace Phish_Website.Backend.Database.Songs
{
    public class CreateSong : ICreateSong
    {
        public void CreateSongTable()
        {
            throw new System.NotImplementedException();
        }

        void ICreateSong.CreateSong(Model.Songs song)
        {
            ConnectionString tempCs = new ConnectionString();
            string cS = tempCs.Cs;

            using var con = new MySqlConnection(cS);
            con.Open();

            string stm = "CREATE TABLE Songs(SongID INTEGER PRIMARY KEY AUTO_INCREMENT, Year TEXT, Location TEXT, Date TEXT)";
            using var cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery();
        }
    }
}