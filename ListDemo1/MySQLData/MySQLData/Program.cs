using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;



// #### https://qawithexperts.com/article/c-sharp/read-excel-file-in-c-console-application-example-using-oledb/168 ###


namespace MySQLData
{
    public class Program
    {
        static void Main(string[] args)
        {

            // MySQL connection string
            string connStr = "server=localhost; user=root; database=world;port=3306;password=Amur7EHE";


            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                //SQL Query to execute
                string sql = "select * from world.country limit 10;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]  +  " " + rdr[1]);
                

                }
                rdr.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            conn.Close();
            Console.WriteLine("Connection Closed. Press any key to exit...");
            Console.Read();
        }
    }
}