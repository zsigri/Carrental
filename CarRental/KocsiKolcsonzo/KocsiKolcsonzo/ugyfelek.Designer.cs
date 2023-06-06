
namespace KocsiKolcsonzo
{
    partial class ugyfelek
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVUgyfel = new System.Windows.Forms.DataGridView();
            this.jogsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anyjaneve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szulDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakcim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputNev = new System.Windows.Forms.TextBox();
            this.LabAzon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputTel = new System.Windows.Forms.TextBox();
            this.ErrorTel = new System.Windows.Forms.Label();
            this.ErrorLakcim = new System.Windows.Forms.Label();
            this.ErrorNev = new System.Windows.Forms.Label();
            this.ButFelvetel = new System.Windows.Forms.Button();
            this.InputLakcim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputAzon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButModosit = new System.Windows.Forms.Button();
            this.ButUgyfelOsszkolt = new System.Windows.Forms.Button();
            this.inputosszkoltes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUgyfel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVUgyfel
            // 
            this.DGVUgyfel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUgyfel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUgyfel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jogsi,
            this.nev,
            this.anyjaneve,
            this.szulDatum,
            this.lakcim,
            this.telefon});
            this.DGVUgyfel.Location = new System.Drawing.Point(5, 61);
            this.DGVUgyfel.Name = "DGVUgyfel";
            this.DGVUgyfel.Size = new System.Drawing.Size(809, 544);
            this.DGVUgyfel.TabIndex = 0;
            // 
            // jogsi
            // 
            this.jogsi.HeaderText = "Jogosítvány azonosító";
            this.jogsi.Name = "jogsi";
            this.jogsi.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.HeaderText = "Ügyfél neve";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // anyjaneve
            // 
            this.anyjaneve.HeaderText = "Anyja neve";
            this.anyjaneve.Name = "anyjaneve";
            this.anyjaneve.ReadOnly = true;
            // 
            // szulDatum
            // 
            this.szulDatum.HeaderText = "Születési dátum";
            this.szulDatum.Name = "szulDatum";
            this.szulDatum.ReadOnly = true;
            // 
            // lakcim
            // 
            this.lakcim.HeaderText = "Lakcím";
            this.lakcim.Name = "lakcim";
            this.lakcim.ReadOnly = true;
            // 
            // telefon
            // 
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1244, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ügyfél adataok módosítása";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InputNev);
            this.panel1.Controls.Add(this.LabAzon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.InputTel);
            this.panel1.Controls.Add(this.ErrorTel);
            this.panel1.Controls.Add(this.ErrorLakcim);
            this.panel1.Controls.Add(this.ErrorNev);
            this.panel1.Controls.Add(this.ButFelvetel);
            this.panel1.Controls.Add(this.InputLakcim);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(820, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 544);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // InputNev
            // 
            this.InputNev.Location = new System.Drawing.Point(158, 149);
            this.InputNev.Name = "InputNev";
            this.InputNev.Size = new System.Drawing.Size(200, 20);
            this.InputNev.TabIndex = 43;
            // 
            // LabAzon
            // 
            this.LabAzon.Location = new System.Drawing.Point(155, 124);
            this.LabAzon.Name = "LabAzon";
            this.LabAzon.Size = new System.Drawing.Size(157, 13);
            this.LabAzon.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Jogosítvány azonosító";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 33);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ügyfél adatainak módosítása";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputTel
            // 
            this.InputTel.Location = new System.Drawing.Point(158, 220);
            this.InputTel.Name = "InputTel";
            this.InputTel.Size = new System.Drawing.Size(200, 20);
            this.InputTel.TabIndex = 39;
            // 
            // ErrorTel
            // 
            this.ErrorTel.AutoSize = true;
            this.ErrorTel.Location = new System.Drawing.Point(391, 222);
            this.ErrorTel.Name = "ErrorTel";
            this.ErrorTel.Size = new System.Drawing.Size(0, 13);
            this.ErrorTel.TabIndex = 38;
            // 
            // ErrorLakcim
            // 
            this.ErrorLakcim.AutoSize = true;
            this.ErrorLakcim.Location = new System.Drawing.Point(391, 186);
            this.ErrorLakcim.Name = "ErrorLakcim";
            this.ErrorLakcim.Size = new System.Drawing.Size(0, 13);
            this.ErrorLakcim.TabIndex = 37;
            // 
            // ErrorNev
            // 
            this.ErrorNev.AutoSize = true;
            this.ErrorNev.Location = new System.Drawing.Point(391, 151);
            this.ErrorNev.Name = "ErrorNev";
            this.ErrorNev.Size = new System.Drawing.Size(0, 13);
            this.ErrorNev.TabIndex = 34;
            // 
            // ButFelvetel
            // 
            this.ButFelvetel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButFelvetel.Location = new System.Drawing.Point(158, 285);
            this.ButFelvetel.Name = "ButFelvetel";
            this.ButFelvetel.Size = new System.Drawing.Size(154, 47);
            this.ButFelvetel.TabIndex = 32;
            this.ButFelvetel.Text = "Módosít";
            this.ButFelvetel.UseVisualStyleBackColor = true;
            this.ButFelvetel.Click += new System.EventHandler(this.ButFelvetel_Click);
            // 
            // InputLakcim
            // 
            this.InputLakcim.Location = new System.Drawing.Point(158, 184);
            this.InputLakcim.Name = "InputLakcim";
            this.InputLakcim.Size = new System.Drawing.Size(200, 20);
            this.InputLakcim.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ügyfél telefonszáma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ügyfél lakcíme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ügyfél neve:";
            // 
            // InputAzon
            // 
            this.InputAzon.FormattingEnabled = true;
            this.InputAzon.Location = new System.Drawing.Point(201, 609);
            this.InputAzon.Name = "InputAzon";
            this.InputAzon.Size = new System.Drawing.Size(147, 21);
            this.InputAzon.TabIndex = 43;
            this.InputAzon.SelectedValueChanged += new System.EventHandler(this.InputAzon_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Módosítani kivánt ügyfél jogosítványa:";
            // 
            // ButModosit
            // 
            this.ButModosit.Enabled = false;
            this.ButModosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButModosit.Location = new System.Drawing.Point(5, 639);
            this.ButModosit.Name = "ButModosit";
            this.ButModosit.Size = new System.Drawing.Size(343, 35);
            this.ButModosit.TabIndex = 45;
            this.ButModosit.Text = "Módosít";
            this.ButModosit.UseVisualStyleBackColor = true;
            this.ButModosit.Click += new System.EventHandler(this.ButModosit_Click);
            // 
            // ButUgyfelOsszkolt
            // 
            this.ButUgyfelOsszkolt.Enabled = false;
            this.ButUgyfelOsszkolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButUgyfelOsszkolt.Location = new System.Drawing.Point(359, 639);
            this.ButUgyfelOsszkolt.Name = "ButUgyfelOsszkolt";
            this.ButUgyfelOsszkolt.Size = new System.Drawing.Size(350, 35);
            this.ButUgyfelOsszkolt.TabIndex = 46;
            this.ButUgyfelOsszkolt.Text = "Ugyfél összköltése";
            this.ButUgyfelOsszkolt.UseVisualStyleBackColor = true;
            this.ButUgyfelOsszkolt.Click += new System.EventHandler(this.ButUgyfelOsszkolt_Click);
            // 
            // inputosszkoltes
            // 
            this.inputosszkoltes.FormattingEnabled = true;
            this.inputosszkoltes.Location = new System.Drawing.Point(562, 609);
            this.inputosszkoltes.Name = "inputosszkoltes";
            this.inputosszkoltes.Size = new System.Drawing.Size(147, 21);
            this.inputosszkoltes.TabIndex = 47;
            this.inputosszkoltes.SelectedValueChanged += new System.EventHandler(this.inputosszkoltes_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 612);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Megtekinteni kívánt ügyfél jogosítványa:";
            // 
            // ugyfelek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputosszkoltes);
            this.Controls.Add(this.ButUgyfelOsszkolt);
            this.Controls.Add(this.ButModosit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputAzon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVUgyfel);
            this.Name = "ugyfelek";
            this.Size = new System.Drawing.Size(1244, 677);
            this.Load += new System.EventHandler(this.ugyfelek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUgyfel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUgyfel;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn anyjaneve;
        private System.Windows.Forms.DataGridViewTextBoxColumn szulDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn lakcim;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox InputTel;
        private System.Windows.Forms.Label ErrorTel;
        private System.Windows.Forms.Label ErrorLakcim;
        private System.Windows.Forms.Label ErrorNev;
        private System.Windows.Forms.Button ButFelvetel;
        private System.Windows.Forms.TextBox InputLakcim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabAzon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox InputAzon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButModosit;
        private System.Windows.Forms.TextBox InputNev;
        private System.Windows.Forms.Button ButUgyfelOsszkolt;
        private System.Windows.Forms.ComboBox inputosszkoltes;
        private System.Windows.Forms.Label label8;
    }
}
