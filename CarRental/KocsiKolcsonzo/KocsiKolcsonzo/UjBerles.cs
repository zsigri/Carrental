using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KocsiKolcsonzo
{
    public partial class UjBerles : UserControl
    {
        MySqlConnection Conn;
        bool errKezdet = false, errVege = false;
        DateTime ma;

        private void InputVege_ValueChanged(object sender, EventArgs e)
        {
            if (InputVege.Value < InputKezdet.Value)
            {
                ErrorVeg.Text = "A bérlés vége nem lehet elöbb mint a bérlés kezdete";
            }
            else
            {
                ErrorVeg.Text = "";
                errVege = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
        }

        private void B(object sender, EventArgs e)
        {

        }

        private void InputKezdet_ValueChanged(object sender, EventArgs e)
        {
            if (InputKezdet.Value < ma)
            {
                ErrorKezdet.Text = "A bérlés kezdete nem lehet a multban.";
            }
            else
            {
                ErrorKezdet.Text = "";
                errKezdet = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
        }

        public UjBerles()
        {
            InitializeComponent();
        }

        private void ButFelvetel_Click(object sender, EventArgs e)
        {
            string kRendszam = InputRendszam.Text;
            kRendszam = kRendszam.Substring(0, 6);
            string uJogsi = InputJogsi.Text;
            uJogsi = uJogsi.Substring(0, uJogsi.IndexOf(":"));
            DateTime kezdet = InputKezdet.Value;
            DateTime vege = InputVege.Value;

            string query = "CALL pr_UjBerles(@brend, @bjogsi, @bkez, @bveg);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@brend", kRendszam);
            cmd.Parameters["@brend"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@bjogsi", uJogsi);
            cmd.Parameters["@bjogsi"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@bkez", kezdet);
            cmd.Parameters["@bkez"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@bveg", vege);
            cmd.Parameters["@bveg"].Direction = ParameterDirection.Input;

            Conn.Open();
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            if (result == 0)
            {
                MessageBox.Show("Hibás adatfelvitel");
            }
            else
            {
                MessageBox.Show("Sikeres adatfelvitel");
            }
        }

        private void UjBerles_Load(object sender, EventArgs e)
        {
            ma = DateTime.Today;
            Conn = Connect.InitDB();
            string query = "CALL pr_Kocsik();";
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                InputRendszam.Items.Add
                    (
                        reader["rendszam"] + ": " + reader["marka"] + " " + reader["tipus"]
                    );
            }
            Conn.Close();
            query = "CALL pr_Ugyfelek();";
            cmd = new MySqlCommand(query, Conn);
            Conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                InputJogsi.Items.Add
                    (
                        reader["Jogsi"] + ": " + reader["Nev"]
                    );
            }
            Conn.Close();
        }
        public bool Errors()
        {
            return errKezdet && errVege;
        }
    }
}
