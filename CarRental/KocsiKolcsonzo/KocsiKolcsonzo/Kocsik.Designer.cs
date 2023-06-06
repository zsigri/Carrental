
namespace KocsiKolcsonzo
{
    partial class kocsik
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGVKocsik = new System.Windows.Forms.DataGridView();
            this.rendzsam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terfogat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzemanyag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muszaki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dij = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputRendszam = new System.Windows.Forms.ComboBox();
            this.rendzsamLabel = new System.Windows.Forms.Label();
            this.ButModosit = new System.Windows.Forms.Button();
            this.InputUzemanyag = new System.Windows.Forms.ComboBox();
            this.ButFelvitel = new System.Windows.Forms.Button();
            this.InputLeiras = new System.Windows.Forms.RichTextBox();
            this.InputNapiDij = new System.Windows.Forms.NumericUpDown();
            this.InputMuszaki = new System.Windows.Forms.DateTimePicker();
            this.InputKilometer = new System.Windows.Forms.NumericUpDown();
            this.InputTerfogat = new System.Windows.Forms.NumericUpDown();
            this.InputTipus = new System.Windows.Forms.TextBox();
            this.InputMarka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputStat = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ButAlkalmak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAlkalmak = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKocsik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputNapiDij)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputKilometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTerfogat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1414, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kocsi menedzsment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVKocsik
            // 
            this.DGVKocsik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVKocsik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKocsik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rendzsam,
            this.marka,
            this.tipus,
            this.terfogat,
            this.uzemanyag,
            this.kilometer,
            this.muszaki,
            this.dij,
            this.stat});
            this.DGVKocsik.Location = new System.Drawing.Point(16, 42);
            this.DGVKocsik.Name = "DGVKocsik";
            this.DGVKocsik.Size = new System.Drawing.Size(934, 519);
            this.DGVKocsik.TabIndex = 1;
            // 
            // rendzsam
            // 
            this.rendzsam.HeaderText = "Rendszám";
            this.rendzsam.Name = "rendzsam";
            this.rendzsam.ReadOnly = true;
            // 
            // marka
            // 
            this.marka.HeaderText = "Márka";
            this.marka.Name = "marka";
            this.marka.ReadOnly = true;
            // 
            // tipus
            // 
            this.tipus.HeaderText = "Típus";
            this.tipus.Name = "tipus";
            this.tipus.ReadOnly = true;
            // 
            // terfogat
            // 
            this.terfogat.HeaderText = "Motor térfogat";
            this.terfogat.Name = "terfogat";
            this.terfogat.ReadOnly = true;
            // 
            // uzemanyag
            // 
            this.uzemanyag.HeaderText = "Üzemanyag";
            this.uzemanyag.Name = "uzemanyag";
            this.uzemanyag.ReadOnly = true;
            // 
            // kilometer
            // 
            this.kilometer.HeaderText = "Kilóméter állása";
            this.kilometer.Name = "kilometer";
            this.kilometer.ReadOnly = true;
            // 
            // muszaki
            // 
            this.muszaki.HeaderText = "Műszaki vizsga érvényessége";
            this.muszaki.Name = "muszaki";
            this.muszaki.ReadOnly = true;
            // 
            // dij
            // 
            this.dij.HeaderText = "Napidíj";
            this.dij.Name = "dij";
            this.dij.ReadOnly = true;
            // 
            // stat
            // 
            this.stat.HeaderText = "Stat";
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            // 
            // InputRendszam
            // 
            this.InputRendszam.FormattingEnabled = true;
            this.InputRendszam.Location = new System.Drawing.Point(190, 575);
            this.InputRendszam.Name = "InputRendszam";
            this.InputRendszam.Size = new System.Drawing.Size(154, 21);
            this.InputRendszam.TabIndex = 2;
            this.InputRendszam.SelectedIndexChanged += new System.EventHandler(this.InputRendszam_SelectedIndexChanged);
            // 
            // rendzsamLabel
            // 
            this.rendzsamLabel.AutoSize = true;
            this.rendzsamLabel.Location = new System.Drawing.Point(13, 578);
            this.rendzsamLabel.Name = "rendzsamLabel";
            this.rendzsamLabel.Size = new System.Drawing.Size(171, 13);
            this.rendzsamLabel.TabIndex = 3;
            this.rendzsamLabel.Text = "Modosítani kivánt kocsi renszáma:";
            // 
            // ButModosit
            // 
            this.ButModosit.Enabled = false;
            this.ButModosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButModosit.Location = new System.Drawing.Point(16, 602);
            this.ButModosit.Name = "ButModosit";
            this.ButModosit.Size = new System.Drawing.Size(328, 36);
            this.ButModosit.TabIndex = 4;
            this.ButModosit.Text = "Módisítás";
            this.ButModosit.UseVisualStyleBackColor = true;
            this.ButModosit.Click += new System.EventHandler(this.ButModosit_Click);
            // 
            // InputUzemanyag
            // 
            this.InputUzemanyag.FormattingEnabled = true;
            this.InputUzemanyag.Location = new System.Drawing.Point(162, 126);
            this.InputUzemanyag.Name = "InputUzemanyag";
            this.InputUzemanyag.Size = new System.Drawing.Size(200, 21);
            this.InputUzemanyag.TabIndex = 66;
            // 
            // ButFelvitel
            // 
            this.ButFelvitel.Enabled = false;
            this.ButFelvitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButFelvitel.Location = new System.Drawing.Point(162, 479);
            this.ButFelvitel.Name = "ButFelvitel";
            this.ButFelvitel.Size = new System.Drawing.Size(200, 40);
            this.ButFelvitel.TabIndex = 65;
            this.ButFelvitel.Text = "Módosit";
            this.ButFelvitel.UseVisualStyleBackColor = true;
            this.ButFelvitel.Click += new System.EventHandler(this.ButFelvitel_Click);
            // 
            // InputLeiras
            // 
            this.InputLeiras.Location = new System.Drawing.Point(162, 300);
            this.InputLeiras.Name = "InputLeiras";
            this.InputLeiras.Size = new System.Drawing.Size(200, 138);
            this.InputLeiras.TabIndex = 64;
            this.InputLeiras.Text = "";
            // 
            // InputNapiDij
            // 
            this.InputNapiDij.Location = new System.Drawing.Point(162, 224);
            this.InputNapiDij.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.InputNapiDij.Name = "InputNapiDij";
            this.InputNapiDij.Size = new System.Drawing.Size(200, 20);
            this.InputNapiDij.TabIndex = 63;
            // 
            // InputMuszaki
            // 
            this.InputMuszaki.Location = new System.Drawing.Point(162, 188);
            this.InputMuszaki.Name = "InputMuszaki";
            this.InputMuszaki.Size = new System.Drawing.Size(200, 20);
            this.InputMuszaki.TabIndex = 62;
            this.InputMuszaki.ValueChanged += new System.EventHandler(this.InputMuszaki_ValueChanged);
            // 
            // InputKilometer
            // 
            this.InputKilometer.Location = new System.Drawing.Point(162, 157);
            this.InputKilometer.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.InputKilometer.Name = "InputKilometer";
            this.InputKilometer.Size = new System.Drawing.Size(200, 20);
            this.InputKilometer.TabIndex = 61;
            this.InputKilometer.ValueChanged += new System.EventHandler(this.InputKilometer_ValueChanged);
            // 
            // InputTerfogat
            // 
            this.InputTerfogat.Location = new System.Drawing.Point(162, 100);
            this.InputTerfogat.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.InputTerfogat.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.InputTerfogat.Name = "InputTerfogat";
            this.InputTerfogat.Size = new System.Drawing.Size(200, 20);
            this.InputTerfogat.TabIndex = 60;
            this.InputTerfogat.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // InputTipus
            // 
            this.InputTipus.Enabled = false;
            this.InputTipus.Location = new System.Drawing.Point(162, 65);
            this.InputTipus.Name = "InputTipus";
            this.InputTipus.Size = new System.Drawing.Size(200, 20);
            this.InputTipus.TabIndex = 59;
            // 
            // InputMarka
            // 
            this.InputMarka.Enabled = false;
            this.InputMarka.Location = new System.Drawing.Point(162, 35);
            this.InputMarka.Name = "InputMarka";
            this.InputMarka.Size = new System.Drawing.Size(200, 20);
            this.InputMarka.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Muszaki vizsga lejárata:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Kilóméter állása:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Üzemanyag:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Motor térfogat:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InputLeiras);
            this.panel1.Controls.Add(this.InputStat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.InputUzemanyag);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ButFelvitel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.InputNapiDij);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.InputMuszaki);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.InputKilometer);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.InputTerfogat);
            this.panel1.Controls.Add(this.InputMarka);
            this.panel1.Controls.Add(this.InputTipus);
            this.panel1.Location = new System.Drawing.Point(974, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 562);
            this.panel1.TabIndex = 69;
            this.panel1.Visible = false;
            // 
            // InputStat
            // 
            this.InputStat.AutoSize = true;
            this.InputStat.Location = new System.Drawing.Point(162, 263);
            this.InputStat.Name = "InputStat";
            this.InputStat.Size = new System.Drawing.Size(86, 17);
            this.InputStat.TabIndex = 68;
            this.InputStat.Text = "Bérelhető e?";
            this.InputStat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Márka:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Stat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Típus:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Napidíj:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Leiras:";
            // 
            // ButAlkalmak
            // 
            this.ButAlkalmak.Enabled = false;
            this.ButAlkalmak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButAlkalmak.Location = new System.Drawing.Point(362, 602);
            this.ButAlkalmak.Name = "ButAlkalmak";
            this.ButAlkalmak.Size = new System.Drawing.Size(328, 36);
            this.ButAlkalmak.TabIndex = 72;
            this.ButAlkalmak.Text = "Kocsi bérlésének alkalmai";
            this.ButAlkalmak.UseVisualStyleBackColor = true;
            this.ButAlkalmak.Click += new System.EventHandler(this.ButAlkalmak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Személygépjármű renszáma:";
            // 
            // inputAlkalmak
            // 
            this.inputAlkalmak.FormattingEnabled = true;
            this.inputAlkalmak.Location = new System.Drawing.Point(536, 575);
            this.inputAlkalmak.Name = "inputAlkalmak";
            this.inputAlkalmak.Size = new System.Drawing.Size(154, 21);
            this.inputAlkalmak.TabIndex = 70;
            this.inputAlkalmak.SelectedValueChanged += new System.EventHandler(this.inputAlkalmak_SelectedValueChanged);
            // 
            // kocsik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButAlkalmak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputAlkalmak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButModosit);
            this.Controls.Add(this.rendzsamLabel);
            this.Controls.Add(this.InputRendszam);
            this.Controls.Add(this.DGVKocsik);
            this.Controls.Add(this.label1);
            this.Name = "kocsik";
            this.Size = new System.Drawing.Size(1414, 651);
            this.Load += new System.EventHandler(this.Kocsik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVKocsik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputNapiDij)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputKilometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTerfogat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVKocsik;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendzsam;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn terfogat;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzemanyag;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn muszaki;
        private System.Windows.Forms.DataGridViewTextBoxColumn dij;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;
        private System.Windows.Forms.ComboBox InputRendszam;
        private System.Windows.Forms.Label rendzsamLabel;
        private System.Windows.Forms.Button ButModosit;
        private System.Windows.Forms.ComboBox InputUzemanyag;
        private System.Windows.Forms.Button ButFelvitel;
        private System.Windows.Forms.RichTextBox InputLeiras;
        private System.Windows.Forms.NumericUpDown InputNapiDij;
        private System.Windows.Forms.DateTimePicker InputMuszaki;
        private System.Windows.Forms.NumericUpDown InputKilometer;
        private System.Windows.Forms.NumericUpDown InputTerfogat;
        private System.Windows.Forms.TextBox InputTipus;
        private System.Windows.Forms.TextBox InputMarka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox InputStat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ButAlkalmak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputAlkalmak;
    }
}
