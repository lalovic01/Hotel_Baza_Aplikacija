using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class GlavniMeni : Form
    {
        public GlavniMeni()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void odjava_Click(object sender, EventArgs e)
        {
            Form1 prijava = new Form1();
            prijava.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GostiForma gostiForma = new GostiForma();
            gostiForma.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SobaForma sobaForma = new SobaForma();
            sobaForma.Show();
            this.Hide();
        }

        private void Rezervacija_Click(object sender, EventArgs e)
        {
            RezervacijaForma rezervacijaForma = new RezervacijaForma();
            rezervacijaForma.Show();
            this.Hide();
        }

        private void Korisnici_Click(object sender, EventArgs e)
        {
            KorisnikForma korisnikForma = new KorisnikForma();
            korisnikForma.Show();
            this.Hide();
        }
    }
}
