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
    public partial class kocsik : UserControl
    {
        Kocsi aktualis;
        MySqlConnection Conn;
        bool muszakiVege = false, errKilometer = false;
        DateTime lejarat;
        int km;
        public kocsik()
        {
            InitializeComponent();
        }
        
        private void Kocsik_Load(object sender, EventArgs e)
        {
            Conn = Connect.InitDB();
            string query = "CALL pr_OsszesKocsi()";
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DGVKocsik.Rows.Add(reader["rendszam"], reader["marka"], reader["tipus"], reader["terfogat"], reader["uzemanyag"], reader["kilometer"], reader["muszakiVege"], reader["napiDij"], reader["stat"]);
                InputRendszam.Items.Add(reader["rendszam"]);
                inputAlkalmak.Items.Add(reader["rendszam"]);
            }
            Conn.Close();

            if (Errors())
                ButFelvitel.Enabled = false;
            else
            {
                ButFelvitel.Enabled = true;
            }
            
        }

        private void InputRendszam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputRendszam.SelectedValue == "")
            {
                ButModosit.Enabled = false;
            }
            else
            {
                ButModosit.Enabled = true;
            }
        }

        private void ButModosit_Click(object sender, EventArgs e)
        {
            
            string query = "CALL pr_ValasztottKocsi(@rendszam);";
            string valasztottRendszam = InputRendszam.Text;
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            cmd.Parameters.AddWithValue("@rendszam", valasztottRendszam);
            cmd.Parameters["@rendszam"].Direction = ParameterDirection.Input;

            Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            aktualis = new Kocsi
                (
                    reader["rendszam"].ToString(),
                    reader["marka"].ToString(),
                    reader["tipus"].ToString(),
                    Convert.ToInt32(reader["terfogat"]),
                    reader["uzemanyag"].ToString(),
                    Convert.ToInt32(reader["kilometer"]),
                    Convert.ToDateTime(reader["muszakiVege"]),
                    Convert.ToInt32(reader["napiDij"]),
                    reader["leiras"].ToString(),
                    Convert.ToInt32(reader["stat"])
                );
            Conn.Close();
            panel1.Visible = true;
            InputMarka.Text = aktualis.marka;
            InputTipus.Text = aktualis.tipus;
            InputTerfogat.Value = aktualis.terfogat;
            InputUzemanyag.Text = aktualis.uzemanyag;
            InputKilometer.Value = aktualis.kilometer;
            InputMuszaki.Value = aktualis.muszaki;
            InputNapiDij.Value = aktualis.napidij;
            InputLeiras.Text = aktualis.leiras;
            if (aktualis.stat == 1)
            {
                InputStat.Checked = true;
            }
            else
            {
                InputStat.Checked = false;
            }
        }

        private void ButFelvitel_Click(object sender, EventArgs e)
        {
            string query = "CALL pr_KocsiModosit(@rendszam, @marka, @tipus, @terfogat, @uzemanyag, @kilometer, @muszaki, @napidij, @leiras, @stat);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            cmd.Parameters.AddWithValue("@rendszam", InputRendszam.Text);
            cmd.Parameters["@rendszam"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@marka", InputMarka.Text);
            cmd.Parameters["@marka"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@tipus", InputTipus.Text);
            cmd.Parameters["@tipus"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@terfogat", InputTerfogat.Text);
            cmd.Parameters["@terfogat"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@uzemanyag", InputUzemanyag.Text);
            cmd.Parameters["@uzemanyag"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@kilometer", InputKilometer.Text);
            cmd.Parameters["@kilometer"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@muszaki", InputMuszaki.Value);
            cmd.Parameters["@muszaki"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@napidij", InputNapiDij.Text);
            cmd.Parameters["@napidij"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@leiras", InputLeiras.Text);
            cmd.Parameters["@leiras"].Direction = ParameterDirection.Input;
            
            if (InputStat.Checked == true)
            {
                cmd.Parameters.AddWithValue("@stat", 1);
                cmd.Parameters["@stat"].Direction = ParameterDirection.Input;
            }
            else
            {
                cmd.Parameters.AddWithValue("@stat", 0);
                cmd.Parameters["@stat"].Direction = ParameterDirection.Input;
            }
            Conn.Open();
            int result = cmd.ExecuteNonQuery();
            Conn.Close();

            if (result == 1)
            {
                MessageBox.Show("Sikeres módosítás");
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Hiba lépett fel az adatok módosítása közben.");
            }
        }

        private void InputMuszaki_ValueChanged(object sender, EventArgs e)
        {
            lejarat = InputMuszaki.Value;
            if (lejarat < aktualis.muszaki)
            {
                muszakiVege = false;
                if (Errors())
                    ButFelvitel.Enabled = false;
            }
            else
            {
                muszakiVege = true;
                if (Errors())
                    ButFelvitel.Enabled = true;
            }
        }

        private void InputKilometer_ValueChanged(object sender, EventArgs e)
        {
            km = Convert.ToInt32(InputKilometer.Value);
            if (km < aktualis.kilometer)
            {
                errKilometer = false;
                if (Errors())
                    ButFelvitel.Enabled = false;
            }
            else
            {
                errKilometer = true;
                if (Errors())
                    ButFelvitel.Enabled = true;
            }
        }

        private void ButAlkalmak_Click(object sender, EventArgs e)
        {
            string query = "CALL pr_KivalasztottKocsiAlkalmak(@rendszam);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            cmd.Parameters.AddWithValue("@rendszam", inputAlkalmak.Text);
            cmd.Parameters["@rendszam"].Direction = ParameterDirection.Input;

            Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            MessageBox.Show(reader["marka"].ToString() + " " + reader["tipus"].ToString() + " " + reader["alkalmak"].ToString() + " alkalom");
            Conn.Close();
        }

        private void inputAlkalmak_SelectedValueChanged(object sender, EventArgs e)
        {
            if (inputAlkalmak.Text != "")
                ButAlkalmak.Enabled = true;
            else
                ButAlkalmak.Enabled = false;
        }

        private bool Errors()
        {
            return muszakiVege && errKilometer;
        }
    }
}
