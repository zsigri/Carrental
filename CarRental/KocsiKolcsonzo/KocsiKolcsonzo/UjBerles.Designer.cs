
namespace KocsiKolcsonzo
{
    partial class UjBerles
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
            System.Windows.Forms.Label label1;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputRendszam = new System.Windows.Forms.ComboBox();
            this.InputJogsi = new System.Windows.Forms.ComboBox();
            this.InputKezdet = new System.Windows.Forms.DateTimePicker();
            this.InputVege = new System.Windows.Forms.DateTimePicker();
            this.ButFelvetel = new System.Windows.Forms.Button();
            this.ErrorKezdet = new System.Windows.Forms.Label();
            this.ErrorVeg = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(690, 40);
            label1.TabIndex = 0;
            label1.Text = "Új Bérlés Felvétele";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bérelt kocsi rendszáma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bérlö jogositvány azonositoja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bérlés kezdete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bérlés vége:";
            // 
            // InputRendszam
            // 
            this.InputRendszam.FormattingEnabled = true;
            this.InputRendszam.Location = new System.Drawing.Point(186, 91);
            this.InputRendszam.Name = "InputRendszam";
            this.InputRendszam.Size = new System.Drawing.Size(238, 21);
            this.InputRendszam.TabIndex = 5;
            // 
            // InputJogsi
            // 
            this.InputJogsi.FormattingEnabled = true;
            this.InputJogsi.Location = new System.Drawing.Point(186, 121);
            this.InputJogsi.Name = "InputJogsi";
            this.InputJogsi.Size = new System.Drawing.Size(238, 21);
            this.InputJogsi.TabIndex = 6;
            // 
            // InputKezdet
            // 
            this.InputKezdet.Location = new System.Drawing.Point(186, 155);
            this.InputKezdet.Name = "InputKezdet";
            this.InputKezdet.Size = new System.Drawing.Size(238, 20);
            this.InputKezdet.TabIndex = 7;
            this.InputKezdet.ValueChanged += new System.EventHandler(this.InputKezdet_ValueChanged);
            // 
            // InputVege
            // 
            this.InputVege.Location = new System.Drawing.Point(186, 192);
            this.InputVege.Name = "InputVege";
            this.InputVege.Size = new System.Drawing.Size(238, 20);
            this.InputVege.TabIndex = 8;
            this.InputVege.ValueChanged += new System.EventHandler(this.InputVege_ValueChanged);
            // 
            // ButFelvetel
            // 
            this.ButFelvetel.Enabled = false;
            this.ButFelvetel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButFelvetel.Location = new System.Drawing.Point(211, 257);
            this.ButFelvetel.Name = "ButFelvetel";
            this.ButFelvetel.Size = new System.Drawing.Size(153, 46);
            this.ButFelvetel.TabIndex = 9;
            this.ButFelvetel.Text = "Felvétel";
            this.ButFelvetel.UseVisualStyleBackColor = true;
            this.ButFelvetel.Click += new System.EventHandler(this.ButFelvetel_Click);
            // 
            // ErrorKezdet
            // 
            this.ErrorKezdet.AutoSize = true;
            this.ErrorKezdet.Location = new System.Drawing.Point(439, 161);
            this.ErrorKezdet.Name = "ErrorKezdet";
            this.ErrorKezdet.Size = new System.Drawing.Size(0, 13);
            this.ErrorKezdet.TabIndex = 10;
            // 
            // ErrorVeg
            // 
            this.ErrorVeg.AutoSize = true;
            this.ErrorVeg.Location = new System.Drawing.Point(439, 198);
            this.ErrorVeg.Name = "ErrorVeg";
            this.ErrorVeg.Size = new System.Drawing.Size(0, 13);
            this.ErrorVeg.TabIndex = 11;
            // 
            // UjBerles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorVeg);
            this.Controls.Add(this.ErrorKezdet);
            this.Controls.Add(this.ButFelvetel);
            this.Controls.Add(this.InputVege);
            this.Controls.Add(this.InputKezdet);
            this.Controls.Add(this.InputJogsi);
            this.Controls.Add(this.InputRendszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Name = "UjBerles";
            this.Size = new System.Drawing.Size(690, 417);
            this.Load += new System.EventHandler(this.UjBerles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox InputRendszam;
        private System.Windows.Forms.ComboBox InputJogsi;
        private System.Windows.Forms.DateTimePicker InputKezdet;
        private System.Windows.Forms.DateTimePicker InputVege;
        private System.Windows.Forms.Button ButFelvetel;
        private System.Windows.Forms.Label ErrorKezdet;
        private System.Windows.Forms.Label ErrorVeg;
    }
}
