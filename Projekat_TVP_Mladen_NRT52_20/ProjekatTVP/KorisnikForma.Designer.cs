
namespace ProjekatTVP
{
    partial class KorisnikForma
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
            this.prezimeKorisnika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lozinkaKorisnika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.korisniciPrikaz = new System.Windows.Forms.DataGridView();
            this.izmeniBtn = new System.Windows.Forms.Button();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.Vreme = new System.Windows.Forms.Timer(this.components);
            this.nazad = new System.Windows.Forms.Button();
            this.idKorisnika = new System.Windows.Forms.Label();
            this.imeKorisnika = new System.Windows.Forms.TextBox();
            this.vrstaKorisnika = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciPrikaz)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(958, 100);
            this.panel1.TabIndex = 0;
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.ForeColor = System.Drawing.Color.White;
            this.izlaz.Location = new System.Drawing.Point(917, 9);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(29, 29);
            this.izlaz.TabIndex = 55;
            this.izlaz.Text = "X";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // vremeLbl
            // 
            this.vremeLbl.AutoSize = true;
            this.vremeLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vremeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vremeLbl.Location = new System.Drawing.Point(855, 74);
            this.vremeLbl.Name = "vremeLbl";
            this.vremeLbl.Size = new System.Drawing.Size(81, 26);
            this.vremeLbl.TabIndex = 3;
            this.vremeLbl.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(275, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informacije o korisnicima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(93, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ime:";
            // 
            // prezimeKorisnika
            // 
            this.prezimeKorisnika.Location = new System.Drawing.Point(97, 268);
            this.prezimeKorisnika.Name = "prezimeKorisnika";
            this.prezimeKorisnika.Size = new System.Drawing.Size(132, 20);
            this.prezimeKorisnika.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(91, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(91, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID korisnika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(92, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Lozinka:";
            // 
            // lozinkaKorisnika
            // 
            this.lozinkaKorisnika.Location = new System.Drawing.Point(95, 334);
            this.lozinkaKorisnika.Name = "lozinkaKorisnika";
            this.lozinkaKorisnika.Size = new System.Drawing.Size(132, 20);
            this.lozinkaKorisnika.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(90, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Vrsta korisnika:";
            // 
            // korisniciPrikaz
            // 
            this.korisniciPrikaz.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.korisniciPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciPrikaz.Location = new System.Drawing.Point(371, 150);
            this.korisniciPrikaz.Name = "korisniciPrikaz";
            this.korisniciPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisniciPrikaz.Size = new System.Drawing.Size(534, 409);
            this.korisniciPrikaz.TabIndex = 25;
            this.korisniciPrikaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisniciPrikaz_CellContentClick);
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.izmeniBtn.FlatAppearance.BorderSize = 0;
            this.izmeniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izmeniBtn.ForeColor = System.Drawing.Color.Coral;
            this.izmeniBtn.Location = new System.Drawing.Point(108, 430);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(87, 57);
            this.izmeniBtn.TabIndex = 28;
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
            this.izbrisiBtn.Location = new System.Drawing.Point(204, 430);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(87, 57);
            this.izbrisiBtn.TabIndex = 27;
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
            this.dodajBtn.Location = new System.Drawing.Point(15, 430);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(87, 57);
            this.dodajBtn.TabIndex = 26;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // Vreme
            // 
            this.Vreme.Tick += new System.EventHandler(this.Vreme_Tick);
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nazad.FlatAppearance.BorderSize = 0;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazad.ForeColor = System.Drawing.Color.Coral;
            this.nazad.Location = new System.Drawing.Point(108, 493);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(87, 57);
            this.nazad.TabIndex = 29;
            this.nazad.Text = "NAZAD";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // idKorisnika
            // 
            this.idKorisnika.AutoSize = true;
            this.idKorisnika.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idKorisnika.Location = new System.Drawing.Point(184, 159);
            this.idKorisnika.Name = "idKorisnika";
            this.idKorisnika.Size = new System.Drawing.Size(0, 17);
            this.idKorisnika.TabIndex = 30;
            // 
            // imeKorisnika
            // 
            this.imeKorisnika.Location = new System.Drawing.Point(94, 206);
            this.imeKorisnika.Name = "imeKorisnika";
            this.imeKorisnika.Size = new System.Drawing.Size(132, 20);
            this.imeKorisnika.TabIndex = 16;
            // 
            // vrstaKorisnika
            // 
            this.vrstaKorisnika.FormattingEnabled = true;
            this.vrstaKorisnika.Items.AddRange(new object[] {
            "Administrator",
            "Recepcioner"});
            this.vrstaKorisnika.Location = new System.Drawing.Point(94, 392);
            this.vrstaKorisnika.Name = "vrstaKorisnika";
            this.vrstaKorisnika.Size = new System.Drawing.Size(132, 22);
            this.vrstaKorisnika.TabIndex = 31;
            // 
            // KorisnikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(958, 600);
            this.Controls.Add(this.vrstaKorisnika);
            this.Controls.Add(this.idKorisnika);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.izmeniBtn);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.korisniciPrikaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lozinkaKorisnika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prezimeKorisnika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeKorisnika);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KorisnikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KorisnikForma";
            this.Load += new System.EventHandler(this.KorisnikForma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vremeLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prezimeKorisnika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lozinkaKorisnika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView korisniciPrikaz;
        private System.Windows.Forms.Button izmeniBtn;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Timer Vreme;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label idKorisnika;
        private System.Windows.Forms.TextBox imeKorisnika;
        private System.Windows.Forms.ComboBox vrstaKorisnika;
        private System.Windows.Forms.Label izlaz;
    }
}