using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phish_Website.Backend.Interfaces.ShowInterfaces;
using Phish_Website.Backend.Model;

namespace Phish_Website.Backend.Database
{
    public class CreateShow : ICreateShowTable
    {
        public void CreateShows(Shows show)
        {
            ConnectionString tempCs = new ConnectionString();
            string cS = tempCs.Cs;

            using var con = new MySqlConnection(cS);
            con.Open();

            string stm = @"INSERT INTO Shows(Year, Location, Date) VALUES(@Year, @Location, @Date)";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@Year", show.Year);
            cmd.Parameters.AddWithValue("@Location", show.Location);
            cmd.Parameters.AddWithValue("@Date", show.Date);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
        public void CreateShowTable()
        {
            ConnectionString tempCs = new ConnectionString();
            string cS = tempCs.Cs;

            using var con = new MySqlConnection(cS);
            con.Open();

            string stm = "CREATE TABLE Shows(ShowID INTEGER PRIMARY KEY AUTO_INCREMENT, Year TEXT, Location TEXT, Date TEXT)";
            using var cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery();
        }
    }
}