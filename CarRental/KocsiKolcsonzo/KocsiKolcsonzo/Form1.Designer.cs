
namespace KocsiKolcsonzo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újKocsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újÜgyfélToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újKölcsönzésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kocsiMenedzsmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ügyfélMenedzsmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelek1 = new KocsiKolcsonzo.ugyfelek();
            this.kocsik1 = new KocsiKolcsonzo.kocsik();
            this.ujBerles1 = new KocsiKolcsonzo.UjBerles();
            this.ujUgyfel1 = new KocsiKolcsonzo.UjUgyfel();
            this.ujKocsi1 = new KocsiKolcsonzo.UjKocsi();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újKocsiToolStripMenuItem,
            this.újÜgyfélToolStripMenuItem,
            this.újKölcsönzésToolStripMenuItem,
            this.kocsiMenedzsmentToolStripMenuItem,
            this.ügyfélMenedzsmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újKocsiToolStripMenuItem
            // 
            this.újKocsiToolStripMenuItem.Name = "újKocsiToolStripMenuItem";
            this.újKocsiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.újKocsiToolStripMenuItem.Text = "Új kocsi";
            this.újKocsiToolStripMenuItem.Click += new System.EventHandler(this.újKocsiToolStripMenuItem_Click);
            // 
            // újÜgyfélToolStripMenuItem
            // 
            this.újÜgyfélToolStripMenuItem.Name = "újÜgyfélToolStripMenuItem";
            this.újÜgyfélToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.újÜgyfélToolStripMenuItem.Text = "Új ügyfél";
            this.újÜgyfélToolStripMenuItem.Click += new System.EventHandler(this.újÜgyfélToolStripMenuItem_Click);
            // 
            // újKölcsönzésToolStripMenuItem
            // 
            this.újKölcsönzésToolStripMenuItem.Name = "újKölcsönzésToolStripMenuItem";
            this.újKölcsönzésToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.újKölcsönzésToolStripMenuItem.Text = "Új kölcsönzés";
            this.újKölcsönzésToolStripMenuItem.Click += new System.EventHandler(this.újKölcsönzésToolStripMenuItem_Click);
            // 
            // kocsiMenedzsmentToolStripMenuItem
            // 
            this.kocsiMenedzsmentToolStripMenuItem.Name = "kocsiMenedzsmentToolStripMenuItem";
            this.kocsiMenedzsmentToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.kocsiMenedzsmentToolStripMenuItem.Text = "Kocsi menedzsment";
            this.kocsiMenedzsmentToolStripMenuItem.Click += new System.EventHandler(this.kocsiMenedzsmentToolStripMenuItem_Click);
            // 
            // ügyfélMenedzsmentToolStripMenuItem
            // 
            this.ügyfélMenedzsmentToolStripMenuItem.Name = "ügyfélMenedzsmentToolStripMenuItem";
            this.ügyfélMenedzsmentToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.ügyfélMenedzsmentToolStripMenuItem.Text = "Ügyfél menedzsment";
            this.ügyfélMenedzsmentToolStripMenuItem.Click += new System.EventHandler(this.ügyfélMenedzsmentToolStripMenuItem_Click);
            // 
            // ugyfelek1
            // 
            this.ugyfelek1.Location = new System.Drawing.Point(37, 27);
            this.ugyfelek1.Name = "ugyfelek1";
            this.ugyfelek1.Size = new System.Drawing.Size(1244, 677);
            this.ugyfelek1.TabIndex = 5;
            this.ugyfelek1.Visible = false;
            // 
            // kocsik1
            // 
            this.kocsik1.Location = new System.Drawing.Point(8, 38);
            this.kocsik1.Name = "kocsik1";
            this.kocsik1.Size = new System.Drawing.Size(1414, 651);
            this.kocsik1.TabIndex = 4;
            this.kocsik1.Visible = false;
            // 
            // ujBerles1
            // 
            this.ujBerles1.Location = new System.Drawing.Point(316, 38);
            this.ujBerles1.Name = "ujBerles1";
            this.ujBerles1.Size = new System.Drawing.Size(690, 417);
            this.ujBerles1.TabIndex = 3;
            this.ujBerles1.Visible = false;
            // 
            // ujUgyfel1
            // 
            this.ujUgyfel1.Location = new System.Drawing.Point(372, 38);
            this.ujUgyfel1.Name = "ujUgyfel1";
            this.ujUgyfel1.Size = new System.Drawing.Size(598, 489);
            this.ujUgyfel1.TabIndex = 2;
            this.ujUgyfel1.Visible = false;
            // 
            // ujKocsi1
            // 
            this.ujKocsi1.Location = new System.Drawing.Point(391, 27);
            this.ujKocsi1.Name = "ujKocsi1";
            this.ujKocsi1.Size = new System.Drawing.Size(526, 582);
            this.ujKocsi1.TabIndex = 1;
            this.ujKocsi1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 724);
            this.Controls.Add(this.ugyfelek1);
            this.Controls.Add(this.kocsik1);
            this.Controls.Add(this.ujBerles1);
            this.Controls.Add(this.ujUgyfel1);
            this.Controls.Add(this.ujKocsi1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kocsi kölcsönzö";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újKocsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újÜgyfélToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újKölcsönzésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kocsiMenedzsmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ügyfélMenedzsmentToolStripMenuItem;
        private UjKocsi ujKocsi1;
        private UjUgyfel ujUgyfel1;
        private UjBerles ujBerles1;
        private kocsik kocsik1;
        private ugyfelek ugyfelek1;
    }
}

