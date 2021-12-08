using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace _366Proj
{
    internal class Database
    {
        public SQLiteConnection conn;

        public Database()
        {
            conn = new SQLiteConnection("Data Source=GameDB.db; Version = 3.0");
        }
        public void Print()
        {
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM games WHERE Platform='NES'";
            SQLiteDataReader sqlDR = cmd.ExecuteReader();
            while (sqlDR.Read())
            {
                Console.Write(sqlDR.GetString(1) + " | ");
                Console.Write(sqlDR.GetString(5) + "\n");
            }
            sqlDR.Close();
            conn.Close();
        }
    }
}
