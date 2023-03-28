
namespace ProjekatTVP
{
    partial class GlavniMeni
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gosti = new System.Windows.Forms.Button();
            this.Soba = new System.Windows.Forms.Button();
            this.Rezervacija = new System.Windows.Forms.Button();
            this.Korisnici = new System.Windows.Forms.Button();
            this.Odjava = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Glavni meni";
            // 
            // Gosti
            // 
            this.Gosti.BackColor = System.Drawing.Color.Coral;
            this.Gosti.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gosti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gosti.Location = new System.Drawing.Point(165, 140);
            this.Gosti.Name = "Gosti";
            this.Gosti.Size = new System.Drawing.Size(172, 86);
            this.Gosti.TabIndex = 1;
            this.Gosti.Text = "Gosti";
            this.Gosti.UseVisualStyleBackColor = false;
            this.Gosti.Click += new System.EventHandler(this.button1_Click);
            // 
            // Soba
            // 
            this.Soba.BackColor = System.Drawing.Color.Coral;
            this.Soba.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Soba.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Soba.Location = new System.Drawing.Point(463, 140);
            this.Soba.Name = "Soba";
            this.Soba.Size = new System.Drawing.Size(172, 86);
            this.Soba.TabIndex = 2;
            this.Soba.Text = "Sobe";
            this.Soba.UseVisualStyleBackColor = false;
            this.Soba.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rezervacija
            // 
            this.Rezervacija.BackColor = System.Drawing.Color.Coral;
            this.Rezervacija.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rezervacija.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rezervacija.Location = new System.Drawing.Point(165, 307);
            this.Rezervacija.Name = "Rezervacija";
            this.Rezervacija.Size = new System.Drawing.Size(172, 86);
            this.Rezervacija.TabIndex = 3;
            this.Rezervacija.Text = "Rezervacija";
            this.Rezervacija.UseVisualStyleBackColor = false;
            this.Rezervacija.Click += new System.EventHandler(this.Rezervacija_Click);
            // 
            // Korisnici
            // 
            this.Korisnici.BackColor = System.Drawing.Color.Coral;
            this.Korisnici.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Korisnici.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Korisnici.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Korisnici.Location = new System.Drawing.Point(463, 307);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Size = new System.Drawing.Size(172, 86);
            this.Korisnici.TabIndex = 4;
            this.Korisnici.Text = "Korisnici";
            this.Korisnici.UseVisualStyleBackColor = false;
            this.Korisnici.Click += new System.EventHandler(this.Korisnici_Click);
            // 
            // Odjava
            // 
            this.Odjava.BackColor = System.Drawing.Color.Coral;
            this.Odjava.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Odjava.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odjava.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Odjava.Location = new System.Drawing.Point(657, 393);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(131, 45);
            this.Odjava.TabIndex = 5;
            this.Odjava.Text = "Odjava";
            this.Odjava.UseVisualStyleBackColor = false;
            this.Odjava.Click += new System.EventHandler(this.odjava_Click);
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.ForeColor = System.Drawing.Color.White;
            this.izlaz.Location = new System.Drawing.Point(759, 18);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(29, 29);
            this.izlaz.TabIndex = 6;
            this.izlaz.Text = "X";
            this.izlaz.Click += new System.EventHandler(this.label2_Click);
            // 
            // GlavniMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.Korisnici);
            this.Controls.Add(this.Rezervacija);
            this.Controls.Add(this.Soba);
            this.Controls.Add(this.Gosti);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GlavniMeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavniMeni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gosti;
        private System.Windows.Forms.Button Soba;
        private System.Windows.Forms.Button Rezervacija;
        private System.Windows.Forms.Button Korisnici;
        private System.Windows.Forms.Button Odjava;
        private System.Windows.Forms.Label izlaz;
    }
}