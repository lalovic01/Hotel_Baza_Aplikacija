
namespace ProjekatTVP
{
    partial class RezervacijaRecepForma
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
            this.rezervacijaPrikaz = new System.Windows.Forms.DataGridView();
            this.izmeniBtn = new System.Windows.Forms.Button();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cenaRez = new System.Windows.Forms.TextBox();
            this.imeRezervisaneSobe = new System.Windows.Forms.ComboBox();
            this.imeRezervisanogK = new System.Windows.Forms.ComboBox();
            this.tipRezervacije = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idRezervacije = new System.Windows.Forms.TextBox();
            this.Vreme = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.imeGosta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.datumGosta = new System.Windows.Forms.DateTimePicker();
            this.telefonGosta = new System.Windows.Forms.TextBox();
            this.prezimeGosta = new System.Windows.Forms.TextBox();
            this.dodajGostaIzRez = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.sobePrikaz = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaPrikaz)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobePrikaz)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1280, 98);
            this.panel1.TabIndex = 1;
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.ForeColor = System.Drawing.Color.White;
            this.izlaz.Location = new System.Drawing.Point(1239, 9);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(29, 29);
            this.izlaz.TabIndex = 71;
            this.izlaz.Text = "X";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // vremeLbl
            // 
            this.vremeLbl.AutoSize = true;
            this.vremeLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vremeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vremeLbl.Location = new System.Drawing.Point(1162, 72);
            this.vremeLbl.Name = "vremeLbl";
            this.vremeLbl.Size = new System.Drawing.Size(81, 26);
            this.vremeLbl.TabIndex = 2;
            this.vremeLbl.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(533, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervacija";
            // 
            // rezervacijaPrikaz
            // 
            this.rezervacijaPrikaz.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.rezervacijaPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervacijaPrikaz.Location = new System.Drawing.Point(539, 124);
            this.rezervacijaPrikaz.Name = "rezervacijaPrikaz";
            this.rezervacijaPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rezervacijaPrikaz.Size = new System.Drawing.Size(729, 474);
            this.rezervacijaPrikaz.TabIndex = 32;
            this.rezervacijaPrikaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rezervacijaPrikaz_CellContentClick);
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.izmeniBtn.FlatAppearance.BorderSize = 0;
            this.izmeniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izmeniBtn.ForeColor = System.Drawing.Color.Coral;
            this.izmeniBtn.Location = new System.Drawing.Point(96, 389);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(87, 57);
            this.izmeniBtn.TabIndex = 54;
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
            this.izbrisiBtn.Location = new System.Drawing.Point(189, 389);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(87, 57);
            this.izbrisiBtn.TabIndex = 53;
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
            this.dodajBtn.Location = new System.Drawing.Point(3, 389);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(87, 57);
            this.dodajBtn.TabIndex = 52;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(36, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 69;
            this.label8.Text = "Cena rezervacije:";
            // 
            // cenaRez
            // 
            this.cenaRez.Location = new System.Drawing.Point(39, 316);
            this.cenaRez.Name = "cenaRez";
            this.cenaRez.Size = new System.Drawing.Size(209, 20);
            this.cenaRez.TabIndex = 68;
            this.cenaRez.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cenaRezBrojF);
            // 
            // imeRezervisaneSobe
            // 
            this.imeRezervisaneSobe.FormattingEnabled = true;
            this.imeRezervisaneSobe.Location = new System.Drawing.Point(39, 174);
            this.imeRezervisaneSobe.Name = "imeRezervisaneSobe";
            this.imeRezervisaneSobe.Size = new System.Drawing.Size(209, 22);
            this.imeRezervisaneSobe.TabIndex = 67;
            // 
            // imeRezervisanogK
            // 
            this.imeRezervisanogK.FormattingEnabled = true;
            this.imeRezervisanogK.Location = new System.Drawing.Point(40, 112);
            this.imeRezervisanogK.Name = "imeRezervisanogK";
            this.imeRezervisanogK.Size = new System.Drawing.Size(208, 22);
            this.imeRezervisanogK.TabIndex = 66;
            // 
            // tipRezervacije
            // 
            this.tipRezervacije.FormattingEnabled = true;
            this.tipRezervacije.Items.AddRange(new object[] {
            "Pun pansion",
            "Polu pansion",
            "Samo doručak"});
            this.tipRezervacije.Location = new System.Drawing.Point(40, 361);
            this.tipRezervacije.Name = "tipRezervacije";
            this.tipRezervacije.Size = new System.Drawing.Size(208, 22);
            this.tipRezervacije.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(37, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tip rezervacije:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(35, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Datum do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(36, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "Datum od:";
            // 
            // datumDo
            // 
            this.datumDo.Location = new System.Drawing.Point(114, 256);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(134, 20);
            this.datumDo.TabIndex = 61;
            this.datumDo.ValueChanged += new System.EventHandler(this.datumDo_ValueChanged);
            // 
            // datumOd
            // 
            this.datumOd.Location = new System.Drawing.Point(114, 216);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(134, 20);
            this.datumOd.TabIndex = 60;
            this.datumOd.ValueChanged += new System.EventHandler(this.datumOd_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(39, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 59;
            this.label6.Text = "Ime gosta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ime sobe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "ID rezervacije:";
            // 
            // idRezervacije
            // 
            this.idRezervacije.Location = new System.Drawing.Point(40, 63);
            this.idRezervacije.Name = "idRezervacije";
            this.idRezervacije.Size = new System.Drawing.Size(208, 20);
            this.idRezervacije.TabIndex = 56;
            this.idRezervacije.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idRezervacije_KeyPress);
            // 
            // Vreme
            // 
            this.Vreme.Tick += new System.EventHandler(this.Vreme_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cenaRez);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dodajBtn);
            this.panel2.Controls.Add(this.izbrisiBtn);
            this.panel2.Controls.Add(this.imeRezervisaneSobe);
            this.panel2.Controls.Add(this.izmeniBtn);
            this.panel2.Controls.Add(this.imeRezervisanogK);
            this.panel2.Controls.Add(this.idRezervacije);
            this.panel2.Controls.Add(this.tipRezervacije);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.datumOd);
            this.panel2.Controls.Add(this.datumDo);
            this.panel2.Location = new System.Drawing.Point(233, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 474);
            this.panel2.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(92, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 70;
            this.label9.Text = "Postojeći gosti";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(34, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 19);
            this.label10.TabIndex = 80;
            this.label10.Text = "Ime:";
            // 
            // imeGosta
            // 
            this.imeGosta.Location = new System.Drawing.Point(37, 69);
            this.imeGosta.Name = "imeGosta";
            this.imeGosta.Size = new System.Drawing.Size(132, 20);
            this.imeGosta.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(31, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 19);
            this.label11.TabIndex = 78;
            this.label11.Text = "Telefon:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(33, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 19);
            this.label12.TabIndex = 77;
            this.label12.Text = "Datum rođenja:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(32, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 19);
            this.label13.TabIndex = 76;
            this.label13.Text = "Prezime:";
            // 
            // datumGosta
            // 
            this.datumGosta.Location = new System.Drawing.Point(37, 193);
            this.datumGosta.Name = "datumGosta";
            this.datumGosta.Size = new System.Drawing.Size(131, 20);
            this.datumGosta.TabIndex = 74;
            // 
            // telefonGosta
            // 
            this.telefonGosta.Location = new System.Drawing.Point(35, 258);
            this.telefonGosta.Name = "telefonGosta";
            this.telefonGosta.Size = new System.Drawing.Size(133, 20);
            this.telefonGosta.TabIndex = 73;
            this.telefonGosta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonRezBroj);
            // 
            // prezimeGosta
            // 
            this.prezimeGosta.Location = new System.Drawing.Point(36, 131);
            this.prezimeGosta.Name = "prezimeGosta";
            this.prezimeGosta.Size = new System.Drawing.Size(132, 20);
            this.prezimeGosta.TabIndex = 72;
            // 
            // dodajGostaIzRez
            // 
            this.dodajGostaIzRez.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dodajGostaIzRez.FlatAppearance.BorderSize = 0;
            this.dodajGostaIzRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajGostaIzRez.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajGostaIzRez.ForeColor = System.Drawing.Color.Coral;
            this.dodajGostaIzRez.Location = new System.Drawing.Point(58, 301);
            this.dodajGostaIzRez.Name = "dodajGostaIzRez";
            this.dodajGostaIzRez.Size = new System.Drawing.Size(87, 57);
            this.dodajGostaIzRez.TabIndex = 81;
            this.dodajGostaIzRez.Text = "DODAJ";
            this.dodajGostaIzRez.UseVisualStyleBackColor = false;
            this.dodajGostaIzRez.Click += new System.EventHandler(this.dodajGostaIzRez_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.dodajGostaIzRez);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.imeGosta);
            this.panel3.Controls.Add(this.prezimeGosta);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.telefonGosta);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.datumGosta);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(12, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 474);
            this.panel3.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Coral;
            this.label15.Location = new System.Drawing.Point(63, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 19);
            this.label15.TabIndex = 71;
            this.label15.Text = "Novi gost";
            // 
            // sobePrikaz
            // 
            this.sobePrikaz.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.sobePrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sobePrikaz.Location = new System.Drawing.Point(539, 464);
            this.sobePrikaz.Name = "sobePrikaz";
            this.sobePrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sobePrikaz.Size = new System.Drawing.Size(340, 134);
            this.sobePrikaz.TabIndex = 72;
            // 
            // RezervacijaRecepForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1280, 610);
            this.Controls.Add(this.sobePrikaz);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rezervacijaPrikaz);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezervacijaRecepForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervacijaRecepForma";
            this.Load += new System.EventHandler(this.RezervacijaRecepForma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaPrikaz)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobePrikaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label vremeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView rezervacijaPrikaz;
        private System.Windows.Forms.Button izmeniBtn;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cenaRez;
        private System.Windows.Forms.ComboBox imeRezervisaneSobe;
        private System.Windows.Forms.ComboBox imeRezervisanogK;
        private System.Windows.Forms.ComboBox tipRezervacije;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idRezervacije;
        private System.Windows.Forms.Timer Vreme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox imeGosta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker datumGosta;
        private System.Windows.Forms.TextBox telefonGosta;
        private System.Windows.Forms.TextBox prezimeGosta;
        private System.Windows.Forms.Button dodajGostaIzRez;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label izlaz;
        private System.Windows.Forms.DataGridView sobePrikaz;
    }
}