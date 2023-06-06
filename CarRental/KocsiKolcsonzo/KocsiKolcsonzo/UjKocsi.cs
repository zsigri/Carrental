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
    public partial class UjKocsi : UserControl
    {
        MySqlConnection Conn;
        bool errorRendszam = false, errorMarka = false, errorTipus = false;
        public UjKocsi()
        {
            InitializeComponent();
        }

        private void UjKocsi_Load(object sender, EventArgs e)
        {
            Conn = Connect.InitDB();
            InputUzemanyag.Items.Add("Benzin");
            InputUzemanyag.Items.Add("Dízel");
            InputUzemanyag.Items.Add("Palagáz");
            InputUzemanyag.Items.Add("Elektromos");
            InputUzemanyag.Items.Add("Hybrid");
        }

        private void ButFelvetel_Click(object sender, EventArgs e)
        {
            string rendszam = InputRendszam.Text;
            rendszam = rendszam.ToUpper();
            string marka = InputMarka.Text;
            string tipus = InputTipus.Text;
            int terfogat = Convert.ToInt32(InputTerfogat.Value);
            string uzemanyag = InputUzemanyag.Text;
            int kilometer = Convert.ToInt32(InputKilometer.Value);
            DateTime muszaki = InputMuszaki.Value;
            int napiDij = Convert.ToInt32(InputNapiDij.Value);
            string leiras = InputLeiras.Text;
            int stat = 0;

            string query = "CALL pr_UjKocsi(@rendszam, @marka, @tipus, @terfogat, @uzemanyag, @kilometer, @muszakiVege, @napiDij, @Leiras, @stat);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@rendszam", rendszam);
            cmd.Parameters["@rendszam"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@marka", marka);
            cmd.Parameters["@marka"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@tipus", tipus);
            cmd.Parameters["@tipus"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@terfogat", terfogat);
            cmd.Parameters["@terfogat"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@uzemanyag", uzemanyag);
            cmd.Parameters["@uzemanyag"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@kilometer", kilometer);
            cmd.Parameters["@kilometer"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@muszakiVege", muszaki);
            cmd.Parameters["@muszakiVege"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@napiDij", napiDij);
            cmd.Parameters["@napiDij"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Leiras", leiras);
            cmd.Parameters["@Leiras"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@stat", stat);
            cmd.Parameters["@stat"].Direction = ParameterDirection.Input;

            Conn.Open();
            int result = cmd.ExecuteNonQuery();
            Conn.Close();

            if (result == 1)
            {
                MessageBox.Show("Sikeres adatfelvitel");
                InputRendszam.Text = "";
                InputMarka.Text = "";
                InputTipus.Text = "";
                InputTerfogat.Value = 800;
                InputUzemanyag.Text = "";
                InputKilometer.Value = 0;
                InputMuszaki.Value = DateTime.Today;
                InputNapiDij.Value = 0;
                InputLeiras.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen adatfelvitel");
            }
            
        }

        private void InputRendszam_TextChanged(object sender, EventArgs e)
        {
            string rendszam = InputRendszam.Text.ToUpper();

            string query = "CALL pr_CheckRendszam(@rendszam);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@rendszam", rendszam);
            cmd.Parameters["@rendszam"].Direction = ParameterDirection.Input;

            Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            if (Convert.ToInt32(reader["foglalt"]) == 0)
            {
                ErrorRendszam.Text = "";
                errorRendszam = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
            else
            {
                ErrorRendszam.Text = "Foglalt ez a rendszam";
                errorRendszam = false;
            }
            Conn.Close();

        }

        private void InputMarka_TextChanged(object sender, EventArgs e)
        {
            if (InputMarka.Text.Length < 1)
            {
                ErrorMarka.Text = "Nem adott meg márkát";
                errorMarka = false;
            }
            else
            {
                ErrorMarka.Text = "";
                errorMarka = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
        }

        private void InputTipus_TextChanged(object sender, EventArgs e)
        {
            if (InputTipus.Text.Length < 1)
            {
                ErrorTipus.Text = "Nem adott meg tipust";
                errorTipus = false;
            }
            else
            {
                ErrorTipus.Text = "";
                errorTipus = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
        }
        private bool Errors()
        {
            return errorRendszam && errorMarka && errorTipus;
        }
    }
}
