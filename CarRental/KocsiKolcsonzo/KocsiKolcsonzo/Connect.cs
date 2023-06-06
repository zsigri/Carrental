using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KocsiKolcsonzo
{
    static class Connect
    {
        const String server = "localhost";
        const String user = "root";
        const String password = "";
        const String database = "kolcsonzo";

        public static MySqlConnection InitDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = database;

            string connString = builder.ToString();

            try
            {
                MySqlConnection Conn = new MySqlConnection(connString);
                return Conn;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hiba az adatbázishoz csatlakozás közben: " + Environment.NewLine + ex.Message);
                return default(MySqlConnection);
            }
        }

    }
}
