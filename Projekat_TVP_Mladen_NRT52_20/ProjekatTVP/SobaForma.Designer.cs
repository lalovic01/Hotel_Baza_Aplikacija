
namespace ProjekatTVP
{
    partial class SobaForma
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
            this.vremeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sobePrikaz = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cenaSobe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipSobe = new System.Windows.Forms.ComboBox();
            this.izmeniBtn = new System.Windows.Forms.Button();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.slobodnaSoba = new System.Windows.Forms.RadioButton();
            this.zauzetaSoba = new System.Windows.Forms.RadioButton();
            this.brojSobe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.brojKreveta = new System.Windows.Forms.ComboBox();
            this.Vreme = new System.Windows.Forms.Timer(this.components);
            this.NAZAD = new System.Windows.Forms.Button();
            this.idSobe = new System.Windows.Forms.Label();
            this.izlaz = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(942, 100);
            this.panel1.TabIndex = 0;
            // 
            // vremeLbl
            // 
            this.vremeLbl.AutoSize = true;
            this.vremeLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vremeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vremeLbl.Location = new System.Drawing.Point(829, 74);
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
            this.label1.Location = new System.Drawing.Point(286, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informacije o sobama";
            // 
            // sobePrikaz
            // 
            this.sobePrikaz.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.sobePrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sobePrikaz.Location = new System.Drawing.Point(286, 134);
            this.sobePrikaz.Name = "sobePrikaz";
            this.sobePrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sobePrikaz.Size = new System.Drawing.Size(644, 409);
            this.sobePrikaz.TabIndex = 26;
            this.sobePrikaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sobePrikaz_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(70, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cena:";
            // 
            // cenaSobe
            // 
            this.cenaSobe.Location = new System.Drawing.Point(74, 352);
            this.cenaSobe.Name = "cenaSobe";
            this.cenaSobe.Size = new System.Drawing.Size(132, 20);
            this.cenaSobe.TabIndex = 35;
            this.cenaSobe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cenaSobeCifra);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Raspoloživost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(71, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Broj sobe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(70, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tip sobe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(70, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID sobe:";
            // 
            // tipSobe
            // 
            this.tipSobe.FormattingEnabled = true;
            this.tipSobe.Items.AddRange(new object[] {
            "standard",
            "lux"});
            this.tipSobe.Location = new System.Drawing.Point(74, 295);
            this.tipSobe.Name = "tipSobe";
            this.tipSobe.Size = new System.Drawing.Size(137, 22);
            this.tipSobe.TabIndex = 38;
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.izmeniBtn.FlatAppearance.BorderSize = 0;
            this.izmeniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izmeniBtn.ForeColor = System.Drawing.Color.Coral;
            this.izmeniBtn.Location = new System.Drawing.Point(97, 415);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(87, 57);
            this.izmeniBtn.TabIndex = 41;
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
            this.izbrisiBtn.Location = new System.Drawing.Point(193, 415);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(87, 57);
            this.izbrisiBtn.TabIndex = 40;
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
            this.dodajBtn.Location = new System.Drawing.Point(4, 415);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(87, 57);
            this.dodajBtn.TabIndex = 39;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // slobodnaSoba
            // 
            this.slobodnaSoba.AutoSize = true;
            this.slobodnaSoba.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slobodnaSoba.Location = new System.Drawing.Point(127, 388);
            this.slobodnaSoba.Name = "slobodnaSoba";
            this.slobodnaSoba.Size = new System.Drawing.Size(79, 21);
            this.slobodnaSoba.TabIndex = 42;
            this.slobodnaSoba.TabStop = true;
            this.slobodnaSoba.Text = "Slobodna";
            this.slobodnaSoba.UseVisualStyleBackColor = true;
            // 
            // zauzetaSoba
            // 
            this.zauzetaSoba.AutoSize = true;
            this.zauzetaSoba.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zauzetaSoba.Location = new System.Drawing.Point(212, 388);
            this.zauzetaSoba.Name = "zauzetaSoba";
            this.zauzetaSoba.Size = new System.Drawing.Size(73, 21);
            this.zauzetaSoba.TabIndex = 43;
            this.zauzetaSoba.TabStop = true;
            this.zauzetaSoba.Text = "Zauzeta";
            this.zauzetaSoba.UseVisualStyleBackColor = true;
            this.zauzetaSoba.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // brojSobe
            // 
            this.brojSobe.Location = new System.Drawing.Point(75, 189);
            this.brojSobe.Name = "brojSobe";
            this.brojSobe.Size = new System.Drawing.Size(136, 20);
            this.brojSobe.TabIndex = 44;
            this.brojSobe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.brojSobeCifra);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(70, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Broj kreveta:";
            // 
            // brojKreveta
            // 
            this.brojKreveta.FormattingEnabled = true;
            this.brojKreveta.Items.AddRange(new object[] {
            "jednokrevetna",
            "dvokrevetna",
            "trokrevetna",
            "cetvorokrevtna"});
            this.brojKreveta.Location = new System.Drawing.Point(75, 240);
            this.brojKreveta.Name = "brojKreveta";
            this.brojKreveta.Size = new System.Drawing.Size(136, 22);
            this.brojKreveta.TabIndex = 46;
            // 
            // Vreme
            // 
            this.Vreme.Tick += new System.EventHandler(this.Vreme_Tick);
            // 
            // NAZAD
            // 
            this.NAZAD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NAZAD.FlatAppearance.BorderSize = 0;
            this.NAZAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAZAD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NAZAD.ForeColor = System.Drawing.Color.Coral;
            this.NAZAD.Location = new System.Drawing.Point(97, 469);
            this.NAZAD.Name = "NAZAD";
            this.NAZAD.Size = new System.Drawing.Size(87, 57);
            this.NAZAD.TabIndex = 47;
            this.NAZAD.Text = "NAZAD";
            this.NAZAD.UseVisualStyleBackColor = false;
            this.NAZAD.Click += new System.EventHandler(this.NAZAD_Click);
            // 
            // idSobe
            // 
            this.idSobe.AutoSize = true;
            this.idSobe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idSobe.Location = new System.Drawing.Point(140, 137);
            this.idSobe.Name = "idSobe";
            this.idSobe.Size = new System.Drawing.Size(0, 17);
            this.idSobe.TabIndex = 48;
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.ForeColor = System.Drawing.Color.White;
            this.izlaz.Location = new System.Drawing.Point(901, 9);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(29, 29);
            this.izlaz.TabIndex = 72;
            this.izlaz.Text = "X";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // SobaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(942, 600);
            this.Controls.Add(this.idSobe);
            this.Controls.Add(this.NAZAD);
            this.Controls.Add(this.brojKreveta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.brojSobe);
            this.Controls.Add(this.zauzetaSoba);
            this.Controls.Add(this.slobodnaSoba);
            this.Controls.Add(this.izmeniBtn);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.tipSobe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cenaSobe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sobePrikaz);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SobaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SobaForma";
            this.Load += new System.EventHandler(this.SobaForma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobePrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vremeLbl;
        private System.Windows.Forms.DataGridView sobePrikaz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cenaSobe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipSobe;
        private System.Windows.Forms.Button izmeniBtn;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.RadioButton slobodnaSoba;
        private System.Windows.Forms.RadioButton zauzetaSoba;
        private System.Windows.Forms.TextBox brojSobe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox brojKreveta;
        private System.Windows.Forms.Timer Vreme;
        private System.Windows.Forms.Button NAZAD;
        private System.Windows.Forms.Label idSobe;
        private System.Windows.Forms.Label izlaz;
    }
}