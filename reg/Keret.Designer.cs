namespace reg
{
    partial class Keret
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
            this.Nev = new System.Windows.Forms.TextBox();
            this.Szuldatum = new System.Windows.Forms.TextBox();
            this.Ferfi = new System.Windows.Forms.RadioButton();
            this.No = new System.Windows.Forms.RadioButton();
            this.NevLab = new System.Windows.Forms.Label();
            this.SzulDatLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Hobbik = new System.Windows.Forms.ListBox();
            this.HobbiPlus = new System.Windows.Forms.Label();
            this.Hobbi = new System.Windows.Forms.TextBox();
            this.HozzaAd = new System.Windows.Forms.Button();
            this.Betoltes = new System.Windows.Forms.Button();
            this.Mentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nev
            // 
            this.Nev.Location = new System.Drawing.Point(88, 12);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(100, 20);
            this.Nev.TabIndex = 0;
            this.Nev.TextChanged += new System.EventHandler(this.Nev_TextChanged);
            // 
            // Szuldatum
            // 
            this.Szuldatum.Location = new System.Drawing.Point(88, 38);
            this.Szuldatum.Name = "Szuldatum";
            this.Szuldatum.Size = new System.Drawing.Size(100, 20);
            this.Szuldatum.TabIndex = 1;
            this.Szuldatum.TextChanged += new System.EventHandler(this.Szuldatum_TextChanged);
            // 
            // Ferfi
            // 
            this.Ferfi.AutoSize = true;
            this.Ferfi.Location = new System.Drawing.Point(88, 65);
            this.Ferfi.Name = "Ferfi";
            this.Ferfi.Size = new System.Drawing.Size(31, 17);
            this.Ferfi.TabIndex = 2;
            this.Ferfi.TabStop = true;
            this.Ferfi.Text = "F";
            this.Ferfi.UseVisualStyleBackColor = true;
            this.Ferfi.CheckedChanged += new System.EventHandler(this.Ferfi_CheckedChanged);
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(126, 65);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(33, 17);
            this.No.TabIndex = 3;
            this.No.TabStop = true;
            this.No.Text = "N";
            this.No.UseVisualStyleBackColor = true;
            this.No.CheckedChanged += new System.EventHandler(this.No_CheckedChanged);
            // 
            // NevLab
            // 
            this.NevLab.AutoSize = true;
            this.NevLab.Location = new System.Drawing.Point(13, 12);
            this.NevLab.Name = "NevLab";
            this.NevLab.Size = new System.Drawing.Size(30, 13);
            this.NevLab.TabIndex = 4;
            this.NevLab.Text = "Név:";
            // 
            // SzulDatLab
            // 
            this.SzulDatLab.AutoSize = true;
            this.SzulDatLab.Location = new System.Drawing.Point(13, 38);
            this.SzulDatLab.Name = "SzulDatLab";
            this.SzulDatLab.Size = new System.Drawing.Size(59, 13);
            this.SzulDatLab.TabIndex = 5;
            this.SzulDatLab.Text = "Szül.dátum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kedvenc hobbi:";
            // 
            // Hobbik
            // 
            this.Hobbik.FormattingEnabled = true;
            this.Hobbik.Items.AddRange(new object[] {
            "Focizás",
            "Uszás",
            "Golfozás"});
            this.Hobbik.Location = new System.Drawing.Point(198, 29);
            this.Hobbik.Name = "Hobbik";
            this.Hobbik.Size = new System.Drawing.Size(79, 82);
            this.Hobbik.TabIndex = 7;
            this.Hobbik.SelectedIndexChanged += new System.EventHandler(this.Hobbik_SelectedIndexChanged);
            // 
            // HobbiPlus
            // 
            this.HobbiPlus.AutoSize = true;
            this.HobbiPlus.Location = new System.Drawing.Point(13, 89);
            this.HobbiPlus.Name = "HobbiPlus";
            this.HobbiPlus.Size = new System.Drawing.Size(49, 13);
            this.HobbiPlus.TabIndex = 8;
            this.HobbiPlus.Text = "Új hobbi:";
            // 
            // Hobbi
            // 
            this.Hobbi.Location = new System.Drawing.Point(88, 89);
            this.Hobbi.Name = "Hobbi";
            this.Hobbi.Size = new System.Drawing.Size(100, 20);
            this.Hobbi.TabIndex = 9;
            this.Hobbi.TextChanged += new System.EventHandler(this.Hobbi_TextChanged);
            // 
            // HozzaAd
            // 
            this.HozzaAd.Location = new System.Drawing.Point(16, 114);
            this.HozzaAd.Name = "HozzaAd";
            this.HozzaAd.Size = new System.Drawing.Size(75, 23);
            this.HozzaAd.TabIndex = 10;
            this.HozzaAd.Text = "Hozzáad";
            this.HozzaAd.UseVisualStyleBackColor = true;
            this.HozzaAd.Click += new System.EventHandler(this.HozzaAd_Click);
            // 
            // Betoltes
            // 
            this.Betoltes.Location = new System.Drawing.Point(113, 115);
            this.Betoltes.Name = "Betoltes";
            this.Betoltes.Size = new System.Drawing.Size(75, 23);
            this.Betoltes.TabIndex = 11;
            this.Betoltes.Text = "Betöltés";
            this.Betoltes.UseVisualStyleBackColor = true;
            this.Betoltes.Click += new System.EventHandler(this.Betoltes_Click);
            // 
            // Mentes
            // 
            this.Mentes.Location = new System.Drawing.Point(202, 114);
            this.Mentes.Name = "Mentes";
            this.Mentes.Size = new System.Drawing.Size(75, 23);
            this.Mentes.TabIndex = 12;
            this.Mentes.Text = "Mentés";
            this.Mentes.UseVisualStyleBackColor = true;
            this.Mentes.Click += new System.EventHandler(this.Mentes_Click);
            // 
            // Keret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 144);
            this.Controls.Add(this.Mentes);
            this.Controls.Add(this.Betoltes);
            this.Controls.Add(this.HozzaAd);
            this.Controls.Add(this.Hobbi);
            this.Controls.Add(this.HobbiPlus);
            this.Controls.Add(this.Hobbik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SzulDatLab);
            this.Controls.Add(this.NevLab);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Ferfi);
            this.Controls.Add(this.Szuldatum);
            this.Controls.Add(this.Nev);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Keret";
            this.Text = "Regisztráció";
            this.Load += new System.EventHandler(this.Keret_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nev;
        private System.Windows.Forms.TextBox Szuldatum;
        private System.Windows.Forms.RadioButton Ferfi;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.Label NevLab;
        private System.Windows.Forms.Label SzulDatLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Hobbik;
        private System.Windows.Forms.Label HobbiPlus;
        private System.Windows.Forms.TextBox Hobbi;
        private System.Windows.Forms.Button HozzaAd;
        private System.Windows.Forms.Button Betoltes;
        private System.Windows.Forms.Button Mentes;
    }
}

