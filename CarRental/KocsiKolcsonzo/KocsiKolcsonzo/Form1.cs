using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KocsiKolcsonzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void újKocsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ujBerles1.Visible = false;
            kocsik1.Visible = false;
            ujUgyfel1.Visible = false;
            ugyfelek1.Visible = false;
            ujKocsi1.Visible = true;
        }

        private void újÜgyfélToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kocsik1.Visible = false;
            ujBerles1.Visible = false;
            ujKocsi1.Visible = false;
            ugyfelek1.Visible = false;
            ujUgyfel1.Visible = true;
        }

        private void újKölcsönzésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kocsik1.Visible = false;
            ujUgyfel1.Visible = false;
            ujKocsi1.Visible = false;
            ugyfelek1.Visible = false;
            ujBerles1.Visible = true;
        }

        private void kocsiMenedzsmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ujUgyfel1.Visible = false;
            ujKocsi1.Visible = false;
            ujBerles1.Visible = false;
            ugyfelek1.Visible = false;
            kocsik1.Visible = true;
        }

        private void ügyfélMenedzsmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ujUgyfel1.Visible = false;
            ujKocsi1.Visible = false;
            ujBerles1.Visible = false;
            kocsik1.Visible = false;
            ugyfelek1.Visible = true;
        }
    }
}
