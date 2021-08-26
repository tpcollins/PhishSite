namespace Phish_Website.Backend.Model
{
    public class ConnectionString
    {
        public string Cs{get;set;}

        public ConnectionString(){
            string username = "c4if7c9t5cumjtu4"; 
            string password = "lu7eexsmzrvdu2pa"; 
            string host = "z3iruaadbwo0iyfp.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string port = "3306";
            string database = "c0z6a5drrrcdaeca";

            Cs = $@"host={host};username={username};database={database};port={port};password={password}";
        }
    }
}