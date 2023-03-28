
namespace ProjekatTVP
{
    partial class GostiForma
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
            this.imeGosta = new System.Windows.Forms.TextBox();
            this.telefonGosta = new System.Windows.Forms.TextBox();
            this.datumGosta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gostiPrikaz = new System.Windows.Forms.DataGridView();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.izmeniBtn = new System.Windows.Forms.Button();
            this.Vreme = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.prezimeGosta = new System.Windows.Forms.TextBox();
            this.nazad = new System.Windows.Forms.Button();
            this.idGosta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gostiPrikaz)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(958, 98);
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
            this.vremeLbl.Location = new System.Drawing.Point(848, 72);
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
            this.label1.Location = new System.Drawing.Point(312, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informacije o gostima";
            // 
            // imeGosta
            // 
            this.imeGosta.Location = new System.Drawing.Point(83, 211);
            this.imeGosta.Name = "imeGosta";
            this.imeGosta.Size = new System.Drawing.Size(132, 20);
            this.imeGosta.TabIndex = 2;
            // 
            // telefonGosta
            // 
            this.telefonGosta.Location = new System.Drawing.Point(83, 404);
            this.telefonGosta.Name = "telefonGosta";
            this.telefonGosta.Size = new System.Drawing.Size(133, 20);
            this.telefonGosta.TabIndex = 3;
            this.telefonGosta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unosBroja);
            // 
            // datumGosta
            // 
            this.datumGosta.Location = new System.Drawing.Point(85, 339);
            this.datumGosta.Name = "datumGosta";
            this.datumGosta.Size = new System.Drawing.Size(131, 20);
            this.datumGosta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(80, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID gosta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(80, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(81, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum rođenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(79, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon:";
            // 
            // gostiPrikaz
            // 
            this.gostiPrikaz.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gostiPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gostiPrikaz.Location = new System.Drawing.Point(318, 147);
            this.gostiPrikaz.Name = "gostiPrikaz";
            this.gostiPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gostiPrikaz.Size = new System.Drawing.Size(534, 409);
            this.gostiPrikaz.TabIndex = 9;
            this.gostiPrikaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gostiPrikaz_CellContentClick);
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dodajBtn.FlatAppearance.BorderSize = 0;
            this.dodajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBtn.ForeColor = System.Drawing.Color.Coral;
            this.dodajBtn.Location = new System.Drawing.Point(12, 430);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(87, 57);
            this.dodajBtn.TabIndex = 10;
            this.dodajBtn.Text = "DODAJ";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.izbrisiBtn.FlatAppearance.BorderSize = 0;
            this.izbrisiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izbrisiBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izbrisiBtn.ForeColor = System.Drawing.Color.Coral;
            this.izbrisiBtn.Location = new System.Drawing.Point(201, 430);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(87, 57);
            this.izbrisiBtn.TabIndex = 11;
            this.izbrisiBtn.Text = "IZBRIŠI";
            this.izbrisiBtn.UseVisualStyleBackColor = false;
            this.izbrisiBtn.Click += new System.EventHandler(this.izbrisiBtn_Click);
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.izmeniBtn.FlatAppearance.BorderSize = 0;
            this.izmeniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izmeniBtn.ForeColor = System.Drawing.Color.Coral;
            this.izmeniBtn.Location = new System.Drawing.Point(105, 430);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(87, 57);
            this.izmeniBtn.TabIndex = 12;
            this.izmeniBtn.Text = "IZMENI";
            this.izmeniBtn.UseVisualStyleBackColor = false;
            this.izmeniBtn.Click += new System.EventHandler(this.izmeniBtn_Click);
            // 
            // Vreme
            // 
            this.Vreme.Tick += new System.EventHandler(this.Vreme_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(82, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ime:";
            // 
            // prezimeGosta
            // 
            this.prezimeGosta.Location = new System.Drawing.Point(83, 273);
            this.prezimeGosta.Name = "prezimeGosta";
            this.prezimeGosta.Size = new System.Drawing.Size(132, 20);
            this.prezimeGosta.TabIndex = 13;
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nazad.FlatAppearance.BorderSize = 0;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazad.ForeColor = System.Drawing.Color.Coral;
            this.nazad.Location = new System.Drawing.Point(105, 483);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(87, 57);
            this.nazad.TabIndex = 15;
            this.nazad.Text = "NAZAD";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // idGosta
            // 
            this.idGosta.AutoSize = true;
            this.idGosta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idGosta.Location = new System.Drawing.Point(150, 162);
            this.idGosta.Name = "idGosta";
            this.idGosta.Size = new System.Drawing.Size(0, 17);
            this.idGosta.TabIndex = 16;
            // 
            // GostiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(958, 600);
            this.Controls.Add(this.idGosta);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prezimeGosta);
            this.Controls.Add(this.izmeniBtn);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.gostiPrikaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datumGosta);
            this.Controls.Add(this.telefonGosta);
            this.Controls.Add(this.imeGosta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GostiForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GostiForma";
            this.Load += new System.EventHandler(this.GostiForma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gostiPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vremeLbl;
        private System.Windows.Forms.TextBox imeGosta;
        private System.Windows.Forms.TextBox telefonGosta;
        private System.Windows.Forms.DateTimePicker datumGosta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gostiPrikaz;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.Button izmeniBtn;
        private System.Windows.Forms.Timer Vreme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prezimeGosta;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label idGosta;
        private System.Windows.Forms.Label izlaz;
    }
}