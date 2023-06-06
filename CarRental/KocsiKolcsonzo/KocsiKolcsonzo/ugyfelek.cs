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
    public partial class ugyfelek : UserControl
    {
        MySqlConnection Conn;
        UgyfelAdatok aktualis;
        public ugyfelek()
        {
            InitializeComponent();
        }

        private void ugyfelek_Load(object sender, EventArgs e)
        {
            Conn = Connect.InitDB();
            string query = "CALL pr_UgyfelInfo();";
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DGVUgyfel.Rows.Add(reader["jogositvany"], reader["nev"], reader["anyjaNeve"], reader["szulDatum"], reader["lakcim"], reader["telefon"]);
                InputAzon.Items.Add(reader["jogositvany"]);
                inputosszkoltes.Items.Add(reader["jogositvany"]);
            }
            Conn.Close();
        }

        private void ButModosit_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            string query = "CALL `pr_ValasztottUgyfel`(@azon);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            

            cmd.Parameters.AddWithValue("@azon", InputAzon.Text);
            cmd.Parameters["@azon"].Direction = ParameterDirection.Input;

            Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            aktualis = new UgyfelAdatok
                (
                    reader["jogositvany"].ToString(),
                    reader["nev"].ToString(),
                    reader["lakcim"].ToString(),
                    reader["telefon"].ToString()
                );
            Conn.Close();
            panel1.Visible = true;
            LabAzon.Text = aktualis.jogsi;
            InputNev.Text = aktualis.nev;
            InputLakcim.Text = aktualis.lakcim;
            InputTel.Text = aktualis.tel;
        }

        private void ButFelvetel_Click(object sender, EventArgs e)
        {
            string query = "CALL `pr_UgyfelModosit`(@jogsi, @nev, @lakcim, @tel);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            cmd.Parameters.AddWithValue("@jogsi", aktualis.jogsi);
            cmd.Parameters["@jogsi"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@nev", aktualis.nev);
            cmd.Parameters["@nev"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@lakcim", aktualis.lakcim);
            cmd.Parameters["@lakcim"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@tel", aktualis.tel);
            cmd.Parameters["@tel"].Direction = ParameterDirection.Input;

            Conn.Open();
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            if (result == 1)
            {
                MessageBox.Show("Sikeres Módosítás");
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Hiba lépett fel az adatok módosítása közben");
            }
        }

        private void ButUgyfelOsszkolt_Click(object sender, EventArgs e)
        {
            string query = "CALL pr_KivalasztottUgyfelOsszKolt(@jogsi);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            cmd.Parameters.AddWithValue("@jogsi", inputosszkoltes.SelectedItem);
            cmd.Parameters["@jogsi"].Direction = ParameterDirection.Input;

            Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            MessageBox.Show(reader["nev"].ToString() + " " + reader["osszkoltes"] + " ft");
            Conn.Close();
        }

        private void inputosszkoltes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (inputosszkoltes.Text != "")
                ButUgyfelOsszkolt.Enabled = true;
            else
                ButUgyfelOsszkolt.Enabled = false;
        }

        private void InputAzon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (InputAzon.Text != "")
                ButModosit.Enabled = true;
            else
                ButModosit.Enabled = false;
        }
    }
}
