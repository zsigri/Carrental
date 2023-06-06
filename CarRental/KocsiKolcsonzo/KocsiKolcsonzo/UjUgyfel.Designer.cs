
namespace KocsiKolcsonzo
{
    partial class UjUgyfel
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
            this.InputJogsi = new System.Windows.Forms.TextBox();
            this.InputNev = new System.Windows.Forms.TextBox();
            this.InputAnyaNev = new System.Windows.Forms.TextBox();
            this.InputDatum = new System.Windows.Forms.DateTimePicker();
            this.InputLakcim = new System.Windows.Forms.TextBox();
            this.ButFelvetel = new System.Windows.Forms.Button();
            this.ErrorJogsi = new System.Windows.Forms.Label();
            this.ErrorNev = new System.Windows.Forms.Label();
            this.ErrorAnya = new System.Windows.Forms.Label();
            this.ErrorDatum = new System.Windows.Forms.Label();
            this.ErrorLakcim = new System.Windows.Forms.Label();
            this.ErrorTel = new System.Windows.Forms.Label();
            this.InputTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új Ügyfél felvétele";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ügyfél jogosítvány azonosítója:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ügyfél neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ügyfél anyja neve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ügyfél születési dátuma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ügyfél lakcíme:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ügyfél telefonszáma:";
            // 
            // InputJogsi
            // 
            this.InputJogsi.Location = new System.Drawing.Point(210, 92);
            this.InputJogsi.Name = "InputJogsi";
            this.InputJogsi.Size = new System.Drawing.Size(200, 20);
            this.InputJogsi.TabIndex = 7;
            this.InputJogsi.TextChanged += new System.EventHandler(this.InputJogsi_TextChanged);
            // 
            // InputNev
            // 
            this.InputNev.Location = new System.Drawing.Point(210, 125);
            this.InputNev.Name = "InputNev";
            this.InputNev.Size = new System.Drawing.Size(200, 20);
            this.InputNev.TabIndex = 8;
            this.InputNev.TextChanged += new System.EventHandler(this.InputNev_TextChanged);
            // 
            // InputAnyaNev
            // 
            this.InputAnyaNev.Location = new System.Drawing.Point(210, 158);
            this.InputAnyaNev.Name = "InputAnyaNev";
            this.InputAnyaNev.Size = new System.Drawing.Size(200, 20);
            this.InputAnyaNev.TabIndex = 9;
            this.InputAnyaNev.TextChanged += new System.EventHandler(this.InputAnyaNev_TextChanged);
            // 
            // InputDatum
            // 
            this.InputDatum.Location = new System.Drawing.Point(210, 191);
            this.InputDatum.Name = "InputDatum";
            this.InputDatum.Size = new System.Drawing.Size(200, 20);
            this.InputDatum.TabIndex = 10;
            this.InputDatum.ValueChanged += new System.EventHandler(this.InputDatum_ValueChanged);
            // 
            // InputLakcim
            // 
            this.InputLakcim.Location = new System.Drawing.Point(210, 229);
            this.InputLakcim.Name = "InputLakcim";
            this.InputLakcim.Size = new System.Drawing.Size(200, 20);
            this.InputLakcim.TabIndex = 11;
            this.InputLakcim.TextChanged += new System.EventHandler(this.InputLakcim_TextChanged);
            // 
            // ButFelvetel
            // 
            this.ButFelvetel.Enabled = false;
            this.ButFelvetel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButFelvetel.Location = new System.Drawing.Point(210, 332);
            this.ButFelvetel.Name = "ButFelvetel";
            this.ButFelvetel.Size = new System.Drawing.Size(154, 47);
            this.ButFelvetel.TabIndex = 13;
            this.ButFelvetel.Text = "Felvétel";
            this.ButFelvetel.UseVisualStyleBackColor = true;
            this.ButFelvetel.Click += new System.EventHandler(this.ButFelvetel_Click);
            // 
            // ErrorJogsi
            // 
            this.ErrorJogsi.AutoSize = true;
            this.ErrorJogsi.Location = new System.Drawing.Point(451, 95);
            this.ErrorJogsi.Name = "ErrorJogsi";
            this.ErrorJogsi.Size = new System.Drawing.Size(0, 13);
            this.ErrorJogsi.TabIndex = 14;
            // 
            // ErrorNev
            // 
            this.ErrorNev.AutoSize = true;
            this.ErrorNev.Location = new System.Drawing.Point(451, 128);
            this.ErrorNev.Name = "ErrorNev";
            this.ErrorNev.Size = new System.Drawing.Size(0, 13);
            this.ErrorNev.TabIndex = 15;
            // 
            // ErrorAnya
            // 
            this.ErrorAnya.AutoSize = true;
            this.ErrorAnya.Location = new System.Drawing.Point(451, 161);
            this.ErrorAnya.Name = "ErrorAnya";
            this.ErrorAnya.Size = new System.Drawing.Size(0, 13);
            this.ErrorAnya.TabIndex = 16;
            // 
            // ErrorDatum
            // 
            this.ErrorDatum.AutoSize = true;
            this.ErrorDatum.Location = new System.Drawing.Point(451, 197);
            this.ErrorDatum.Name = "ErrorDatum";
            this.ErrorDatum.Size = new System.Drawing.Size(0, 13);
            this.ErrorDatum.TabIndex = 17;
            // 
            // ErrorLakcim
            // 
            this.ErrorLakcim.AutoSize = true;
            this.ErrorLakcim.Location = new System.Drawing.Point(451, 232);
            this.ErrorLakcim.Name = "ErrorLakcim";
            this.ErrorLakcim.Size = new System.Drawing.Size(0, 13);
            this.ErrorLakcim.TabIndex = 18;
            // 
            // ErrorTel
            // 
            this.ErrorTel.AutoSize = true;
            this.ErrorTel.Location = new System.Drawing.Point(451, 268);
            this.ErrorTel.Name = "ErrorTel";
            this.ErrorTel.Size = new System.Drawing.Size(0, 13);
            this.ErrorTel.TabIndex = 19;
            // 
            // InputTel
            // 
            this.InputTel.Location = new System.Drawing.Point(210, 265);
            this.InputTel.Name = "InputTel";
            this.InputTel.Size = new System.Drawing.Size(200, 20);
            this.InputTel.TabIndex = 20;
            this.InputTel.TextChanged += new System.EventHandler(this.InputTel_TextChanged);
            // 
            // UjUgyfel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputTel);
            this.Controls.Add(this.ErrorTel);
            this.Controls.Add(this.ErrorLakcim);
            this.Controls.Add(this.ErrorDatum);
            this.Controls.Add(this.ErrorAnya);
            this.Controls.Add(this.ErrorNev);
            this.Controls.Add(this.ErrorJogsi);
            this.Controls.Add(this.ButFelvetel);
            this.Controls.Add(this.InputLakcim);
            this.Controls.Add(this.InputDatum);
            this.Controls.Add(this.InputAnyaNev);
            this.Controls.Add(this.InputNev);
            this.Controls.Add(this.InputJogsi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UjUgyfel";
            this.Size = new System.Drawing.Size(598, 489);
            this.Load += new System.EventHandler(this.UjUgyfel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InputJogsi;
        private System.Windows.Forms.TextBox InputNev;
        private System.Windows.Forms.TextBox InputAnyaNev;
        private System.Windows.Forms.DateTimePicker InputDatum;
        private System.Windows.Forms.TextBox InputLakcim;
        private System.Windows.Forms.Button ButFelvetel;
        private System.Windows.Forms.Label ErrorJogsi;
        private System.Windows.Forms.Label ErrorNev;
        private System.Windows.Forms.Label ErrorAnya;
        private System.Windows.Forms.Label ErrorDatum;
        private System.Windows.Forms.Label ErrorLakcim;
        private System.Windows.Forms.Label ErrorTel;
        private System.Windows.Forms.TextBox InputTel;
    }
}
