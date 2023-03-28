
namespace ProjekatTVP
{
    partial class RezervacijaForma
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.izlaz = new System.Windows.Forms.Label();
            this.vremeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rezervacijaPrikaz = new System.Windows.Forms.DataGridView();
            this.izmeniBtn = new System.Windows.Forms.Button();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.tipRezervacije = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imeRezervisanogK = new System.Windows.Forms.ComboBox();
            this.imeRezervisaneSobe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cenaRez = new System.Windows.Forms.TextBox();
            this.nazad = new System.Windows.Forms.Button();
            this.Vreme = new System.Windows.Forms.Timer(this.components);
            this.idRezervacije = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.izlaz);
            this.panel1.Controls.Add(this.vremeLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 100);
            this.panel1.TabIndex = 1;
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.ForeColor = System.Drawing.Color.White;
            this.izlaz.Location = new System.Drawing.Point(1059, 9);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(29, 29);
            this.izlaz.TabIndex = 54;
            this.izlaz.Text = "X";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // vremeLbl
            // 
            this.vremeLbl.AutoSize = true;
            this.vremeLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vremeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vremeLbl.Location = new System.Drawing.Point(985, 74);
            this.vremeLbl.Name = "vremeLbl";
            this.vremeLbl.Size = new System.Drawing.Size(81, 26);
            this.vremeLbl.TabIndex = 4;
            this.vremeLbl.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(370, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informacije o rezervaciji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(55, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ime gosta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(55, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ime sobe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID rezervacije:";
            // 
            // datumOd
            // 
            this.datumOd.Location = new System.Drawing.Point(132, 307);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(134, 20);
            this.datumOd.TabIndex = 27;
            this.datumOd.ValueChanged += new System.EventHandler(this.datumOd_ValueChanged);
            // 
            // datumDo
            // 
            this.datumDo.Location = new System.Drawing.Point(132, 347);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(134, 20);
            this.datumDo.TabIndex = 28;
            this.datumDo.ValueChanged += new System.EventHandler(this.datumDo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(54, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Datum od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(53, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Datum do:";
            // 
            // rezervacijaPrikaz
            // 
            this.rezervacijaPrikaz.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.rezervacijaPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervacijaPrikaz.Location = new System.Drawing.Point(325, 125);
            this.rezervacijaPrikaz.Name = "rezervacijaPrikaz";
            this.rezervacijaPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rezervacijaPrikaz.Size = new System.Drawing.Size(741, 409);
            this.rezervacijaPrikaz.TabIndex = 31;
            this.rezervacijaPrikaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rezervacijaPrikaz_CellContentClick);
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.izmeniBtn.FlatAppearance.BorderSize = 0;
            this.izmeniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izmeniBtn.ForeColor = System.Drawing.Color.Coral;
            this.izmeniBtn.Location = new System.Drawing.Point(114, 480);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(87, 57);
            this.izmeniBtn.TabIndex = 44;
            this.izmeniBtn.Text = "IZMENI";
            this.izmeniBtn.UseVisualStyleBackColor = false;
            this.izmeniBtn.Click += new System.EventHandler(this.izmeniBtn_Click);
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.izbrisiBtn.FlatAppearance.BorderSize = 0;
            this.izbrisiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izbrisiBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izbrisiBtn.ForeColor = System.Drawing.Color.Coral;
            this.izbrisiBtn.Location = new System.Drawing.Point(210, 480);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(87, 57);
            this.izbrisiBtn.TabIndex = 43;
            this.izbrisiBtn.Text = "IZBRIŠI";
            this.izbrisiBtn.UseVisualStyleBackColor = false;
            this.izbrisiBtn.Click += new System.EventHandler(this.izbrisiBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dodajBtn.FlatAppearance.BorderSize = 0;
            this.dodajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBtn.ForeColor = System.Drawing.Color.Coral;
            this.dodajBtn.Location = new System.Drawing.Point(21, 480);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(87, 57);
            this.dodajBtn.TabIndex = 42;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // tipRezervacije
            // 
            this.tipRezervacije.FormattingEnabled = true;
            this.tipRezervacije.Items.AddRange(new object[] {
            "Pun pansion",
            "Polu pansion",
            "Samo doručak"});
            this.tipRezervacije.Location = new System.Drawing.Point(58, 452);
            this.tipRezervacije.Name = "tipRezervacije";
            this.tipRezervacije.Size = new System.Drawing.Size(208, 22);
            this.tipRezervacije.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(55, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tip rezervacije:";
            // 
            // imeRezervisanogK
            // 
            this.imeRezervisanogK.FormattingEnabled = true;
            this.imeRezervisanogK.Location = new System.Drawing.Point(58, 203);
            this.imeRezervisanogK.Name = "imeRezervisanogK";
            this.imeRezervisanogK.Size = new System.Drawing.Size(208, 22);
            this.imeRezervisanogK.TabIndex = 47;
            // 
            // imeRezervisaneSobe
            // 
            this.imeRezervisaneSobe.FormattingEnabled = true;
            this.imeRezervisaneSobe.Location = new System.Drawing.Point(57, 265);
            this.imeRezervisaneSobe.Name = "imeRezervisaneSobe";
            this.imeRezervisaneSobe.Size = new System.Drawing.Size(209, 22);
            this.imeRezervisaneSobe.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(54, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Cena rezervacije:";
            // 
            // cenaRez
            // 
            this.cenaRez.Location = new System.Drawing.Point(57, 407);
            this.cenaRez.Name = "cenaRez";
            this.cenaRez.Size = new System.Drawing.Size(209, 20);
            this.cenaRez.TabIndex = 49;
            this.cenaRez.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cenaRezervacijeBroj);
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nazad.FlatAppearance.BorderSize = 0;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazad.ForeColor = System.Drawing.Color.Coral;
            this.nazad.Location = new System.Drawing.Point(114, 541);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(87, 57);
            this.nazad.TabIndex = 51;
            this.nazad.Text = "NAZAD";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // Vreme
            // 
            this.Vreme.Tick += new System.EventHandler(this.Vreme_Tick);
            // 
            // idRezervacije
            // 
            this.idRezervacije.AutoSize = true;
            this.idRezervacije.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idRezervacije.Location = new System.Drawing.Point(157, 159);
            this.idRezervacije.Name = "idRezervacije";
            this.idRezervacije.Size = new System.Drawing.Size(0, 17);
            this.idRezervacije.TabIndex = 52;
            // 
            // RezervacijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.idRezervacije);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cenaRez);
            this.Controls.Add(this.imeRezervisaneSobe);
            this.Controls.Add(this.imeRezervisanogK);
            this.Controls.Add(this.tipRezervacije);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.izmeniBtn);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.rezervacijaPrikaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumDo);
            this.Controls.Add(this.datumOd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezervacijaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervacijaForma";
            this.Load += new System.EventHandler(this.RezervacijaForma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label vremeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView rezervacijaPrikaz;
        private System.Windows.Forms.Button izmeniBtn;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.ComboBox tipRezervacije;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox imeRezervisanogK;
        private System.Windows.Forms.ComboBox imeRezervisaneSobe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cenaRez;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Timer Vreme;
        private System.Windows.Forms.Label idRezervacije;
        private System.Windows.Forms.Label izlaz;
    }
}