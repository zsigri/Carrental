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
    public partial class UjUgyfel : UserControl
    {
        MySqlConnection Conn;
        bool errJogsi = false, errNev = false, errAnya = false, errDatum = false, errCim = false, errTel = false;
        DateTime ma;

        public UjUgyfel()
        {
            InitializeComponent();
        }

        private void UjUgyfel_Load(object sender, EventArgs e)
        {
            Conn = Connect.InitDB();
            ma = DateTime.Today;
        }

        private void ButFelvetel_Click(object sender, EventArgs e)
        {
            string jogsi = InputJogsi.Text;
            string nev = InputNev.Text;
            string anya = InputAnyaNev.Text;
            DateTime szuletes = InputDatum.Value;
            string lakcim = InputLakcim.Text;
            string tel = InputTel.Text;

            string query = "CALL pr_UjUgyfel(@jogsi, @nev, @anya, @datum, @cim, @tel);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@jogsi", jogsi);
            cmd.Parameters["@jogsi"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@nev", nev);
            cmd.Parameters["@nev"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@anya", anya);
            cmd.Parameters["@anya"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@datum", szuletes);
            cmd.Parameters["@datum"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@cim", lakcim);
            cmd.Parameters["@cim"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters["@tel"].Direction = ParameterDirection.Input;

            Conn.Open();
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            if (result == 1)
            {
                MessageBox.Show("Sikeres adatfelvitel");
                InputJogsi.Text = "";
                InputNev.Text = "";
                InputAnyaNev.Text = "";
                InputDatum.Value = DateTime.Today;
                InputLakcim.Text = "";
                InputTel.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen adatfelvitel");
            }
        }

        private void InputJogsi_TextChanged(object sender, EventArgs e)
        {
            string jogsi = InputJogsi.Text.ToUpper();

            string query = "CALL pr_CheckJogsi(@jogsi);";
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@jogsi", jogsi);
            cmd.Parameters["@jogsi"].Direction = ParameterDirection.Input;

            Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            if (Convert.ToInt32(reader["foglalt"]) == 0)
            {
                ErrorJogsi.Text = "";
                errJogsi = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
            else
            {
                ErrorJogsi.Text = "Ezzel a jogosítvánnyal már van felhasználó";
            }
            Conn.Close();
        }
        private void InputTel_TextChanged(object sender, EventArgs e)
        {
            if (InputTel.Text.Length < 6)
            {
                ErrorTel.Text = "Túl rövid telefonszámot irt be.";
                errTel = false;
            }
            else
            {
                ErrorTel.Text = "";
                errTel = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
        }
        private void InputLakcim_TextChanged(object sender, EventArgs e)
        {
            if (InputLakcim.Text.Length < 6)
            {
                ErrorLakcim.Text = "Túl rövid települést irt be.";
                errCim = false;
            }
            else
            {
                ErrorLakcim.Text = "";
                errCim = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
        }
        private void InputAnyaNev_TextChanged(object sender, EventArgs e)
        {
            if (InputAnyaNev.Text.Length < 6)
            {
                ErrorAnya.Text = "Túl rövid nevet irt be.";
                errAnya = false;
            }
            else
            {
                ErrorAnya.Text = "";
                errAnya = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
        }
        private void InputNev_TextChanged(object sender, EventArgs e)
        {
            if (InputNev.Text.Length < 6)
            {
                ErrorNev.Text = "Túl rövid az ügyfél neve";
                errNev = false;
            }
            else
            {
                ErrorNev.Text = "";
                errNev = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
        }
        private void InputDatum_ValueChanged(object sender, EventArgs e)
        {
            if ((ma.Year - InputDatum.Value.Year) >= 17)
            {
                ErrorDatum.Text = "";
                errDatum = true;
                if (Errors())
                    ButFelvetel.Enabled = true;
            }
            else
            {
                ErrorDatum.Text = "Túl korai a dátum.";
                errDatum = false;
            }
        }
        public bool Errors()
        {
            return errJogsi && errNev && errAnya && errDatum && errCim && errTel;
        }
    }
}
