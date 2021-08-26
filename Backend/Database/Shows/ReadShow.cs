using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Phish_Website.Backend.Model;
using Phish_Website.Backend.Interfaces.ShowInterfaces;

namespace Phish_Website.Backend.Database
{
    public class ReadShow : IReadShowTable
    {
        public List<Shows> ReadShowTable()
        {
            List<Shows> showList = new List<Shows>();

            ConnectionString tempCs = new ConnectionString();
            string cS = tempCs.Cs;
            using var con = new MySqlConnection(cS);
            con.Open();

            string stm = "SELECT * FROM Shows";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read()){
                showList.Add(new Shows(){ShowID = rdr.GetInt32(0), Year = rdr.GetInt32(1), Location = rdr.GetString(2), Date = rdr.GetDateTime(3)});
            }

            return showList;
        }
    }
}