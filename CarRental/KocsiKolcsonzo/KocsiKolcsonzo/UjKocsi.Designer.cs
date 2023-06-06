
namespace KocsiKolcsonzo
{
    partial class UjKocsi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InputRendszam = new System.Windows.Forms.TextBox();
            this.InputMarka = new System.Windows.Forms.TextBox();
            this.InputTipus = new System.Windows.Forms.TextBox();
            this.InputTerfogat = new System.Windows.Forms.NumericUpDown();
            this.InputKilometer = new System.Windows.Forms.NumericUpDown();
            this.InputMuszaki = new System.Windows.Forms.DateTimePicker();
            this.InputNapiDij = new System.Windows.Forms.NumericUpDown();
            this.InputLeiras = new System.Windows.Forms.RichTextBox();
            this.ButFelvetel = new System.Windows.Forms.Button();
            this.ErrorRendszam = new System.Windows.Forms.Label();
            this.ErrorMarka = new System.Windows.Forms.Label();
            this.ErrorTipus = new System.Windows.Forms.Label();
            this.InputUzemanyag = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputTerfogat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputKilometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputNapiDij)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új kocsi felvevése az adatbázisba";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rendszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Márka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Típus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motor térfogat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Üzemanyag:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kilóméter állása:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Muszaki vizsga lejárata:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Napidíj:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Leiras:";
            // 
            // InputRendszam
            // 
            this.InputRendszam.Location = new System.Drawing.Point(175, 84);
            this.InputRendszam.Name = "InputRendszam";
            this.InputRendszam.Size = new System.Drawing.Size(200, 20);
            this.InputRendszam.TabIndex = 10;
            this.InputRendszam.TextChanged += new System.EventHandler(this.InputRendszam_TextChanged);
            // 
            // InputMarka
            // 
            this.InputMarka.Location = new System.Drawing.Point(175, 114);
            this.InputMarka.Name = "InputMarka";
            this.InputMarka.Size = new System.Drawing.Size(200, 20);
            this.InputMarka.TabIndex = 11;
            this.InputMarka.TextChanged += new System.EventHandler(this.InputMarka_TextChanged);
            // 
            // InputTipus
            // 
            this.InputTipus.Location = new System.Drawing.Point(175, 144);
            this.InputTipus.Name = "InputTipus";
            this.InputTipus.Size = new System.Drawing.Size(200, 20);
            this.InputTipus.TabIndex = 12;
            this.InputTipus.TextChanged += new System.EventHandler(this.InputTipus_TextChanged);
            // 
            // InputTerfogat
            // 
            this.InputTerfogat.Location = new System.Drawing.Point(175, 179);
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
            this.InputTerfogat.TabIndex = 14;
            this.InputTerfogat.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // InputKilometer
            // 
            this.InputKilometer.Location = new System.Drawing.Point(175, 236);
            this.InputKilometer.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.InputKilometer.Name = "InputKilometer";
            this.InputKilometer.Size = new System.Drawing.Size(200, 20);
            this.InputKilometer.TabIndex = 15;
            // 
            // InputMuszaki
            // 
            this.InputMuszaki.Location = new System.Drawing.Point(175, 267);
            this.InputMuszaki.Name = "InputMuszaki";
            this.InputMuszaki.Size = new System.Drawing.Size(200, 20);
            this.InputMuszaki.TabIndex = 16;
            // 
            // InputNapiDij
            // 
            this.InputNapiDij.Location = new System.Drawing.Point(175, 303);
            this.InputNapiDij.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.InputNapiDij.Name = "InputNapiDij";
            this.InputNapiDij.Size = new System.Drawing.Size(200, 20);
            this.InputNapiDij.TabIndex = 17;
            // 
            // InputLeiras
            // 
            this.InputLeiras.Location = new System.Drawing.Point(175, 344);
            this.InputLeiras.Name = "InputLeiras";
            this.InputLeiras.Size = new System.Drawing.Size(200, 138);
            this.InputLeiras.TabIndex = 19;
            this.InputLeiras.Text = "";
            // 
            // ButFelvetel
            // 
            this.ButFelvetel.Enabled = false;
            this.ButFelvetel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButFelvetel.Location = new System.Drawing.Point(175, 523);
            this.ButFelvetel.Name = "ButFelvetel";
            this.ButFelvetel.Size = new System.Drawing.Size(200, 40);
            this.ButFelvetel.TabIndex = 20;
            this.ButFelvetel.Text = "Felvétel";
            this.ButFelvetel.UseVisualStyleBackColor = true;
            this.ButFelvetel.Click += new System.EventHandler(this.ButFelvetel_Click);
            // 
            // ErrorRendszam
            // 
            this.ErrorRendszam.AutoSize = true;
            this.ErrorRendszam.ForeColor = System.Drawing.Color.Red;
            this.ErrorRendszam.Location = new System.Drawing.Point(409, 87);
            this.ErrorRendszam.Name = "ErrorRendszam";
            this.ErrorRendszam.Size = new System.Drawing.Size(0, 13);
            this.ErrorRendszam.TabIndex = 21;
            // 
            // ErrorMarka
            // 
            this.ErrorMarka.AutoSize = true;
            this.ErrorMarka.ForeColor = System.Drawing.Color.Red;
            this.ErrorMarka.Location = new System.Drawing.Point(409, 117);
            this.ErrorMarka.Name = "ErrorMarka";
            this.ErrorMarka.Size = new System.Drawing.Size(0, 13);
            this.ErrorMarka.TabIndex = 23;
            // 
            // ErrorTipus
            // 
            this.ErrorTipus.AutoSize = true;
            this.ErrorTipus.ForeColor = System.Drawing.Color.Red;
            this.ErrorTipus.Location = new System.Drawing.Point(409, 147);
            this.ErrorTipus.Name = "ErrorTipus";
            this.ErrorTipus.Size = new System.Drawing.Size(0, 13);
            this.ErrorTipus.TabIndex = 24;
            // 
            // InputUzemanyag
            // 
            this.InputUzemanyag.FormattingEnabled = true;
            this.InputUzemanyag.Location = new System.Drawing.Point(175, 205);
            this.InputUzemanyag.Name = "InputUzemanyag";
            this.InputUzemanyag.Size = new System.Drawing.Size(200, 21);
            this.InputUzemanyag.TabIndex = 25;
            // 
            // UjKocsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputUzemanyag);
            this.Controls.Add(this.ErrorTipus);
            this.Controls.Add(this.ErrorMarka);
            this.Controls.Add(this.ErrorRendszam);
            this.Controls.Add(this.ButFelvetel);
            this.Controls.Add(this.InputLeiras);
            this.Controls.Add(this.InputNapiDij);
            this.Controls.Add(this.InputMuszaki);
            this.Controls.Add(this.InputKilometer);
            this.Controls.Add(this.InputTerfogat);
            this.Controls.Add(this.InputTipus);
            this.Controls.Add(this.InputMarka);
            this.Controls.Add(this.InputRendszam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UjKocsi";
            this.Size = new System.Drawing.Size(547, 583);
            this.Load += new System.EventHandler(this.UjKocsi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputTerfogat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputKilometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputNapiDij)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox InputRendszam;
        private System.Windows.Forms.TextBox InputMarka;
        private System.Windows.Forms.TextBox InputTipus;
        private System.Windows.Forms.NumericUpDown InputTerfogat;
        private System.Windows.Forms.NumericUpDown InputKilometer;
        private System.Windows.Forms.DateTimePicker InputMuszaki;
        private System.Windows.Forms.NumericUpDown InputNapiDij;
        private System.Windows.Forms.RichTextBox InputLeiras;
        private System.Windows.Forms.Button ButFelvetel;
        private System.Windows.Forms.Label ErrorRendszam;
        private System.Windows.Forms.Label ErrorMarka;
        private System.Windows.Forms.Label ErrorTipus;
        private System.Windows.Forms.ComboBox InputUzemanyag;
    }
}
