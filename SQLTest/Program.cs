using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=localhost;user=;database=people;password=";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();
            string sql = "SELECT name FROM men WHERE id = 2";

            MySqlCommand command = new MySqlCommand(sql, conn);

            string name = command.ExecuteScalar().ToString();

            Console.WriteLine(name);


            conn.Close();
        }
    }
}
