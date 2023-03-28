using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class KorisnikForma : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Nova Konekcija\HotelSistemDB.mdf;Integrated Security=True;Connect Timeout=30");
        public void populacija()
        {
            Con.Open();
            string Myquery = "select * from Korisnik_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbGradnja = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            korisniciPrikaz.DataSource = ds.Tables[0];
            Con.Close();
        }
        public KorisnikForma()
        {
            InitializeComponent();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (/*idKorisnika.Text != "" &&*/ prezimeKorisnika.Text != "" && imeKorisnika.Text != "" && lozinkaKorisnika.Text != "" && vrstaKorisnika.SelectedItem != null)
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Korisnik_tbl values('" + imeKorisnika.Text + "','" + prezimeKorisnika.Text + "','" + lozinkaKorisnika.Text + "','" + vrstaKorisnika.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Uspešno je dodat korisnik!");
                Con.Close();
                populacija();
            }
            else
            {
                MessageBox.Show("Popunite sva polja", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KorisnikForma_Load(object sender, EventArgs e)
        {
            populacija();
            vremeLbl.Text = DateTime.Now.ToLongTimeString();
            Vreme.Start();
        }

        private void izmeniBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Korisnik_tbl set KorisnikIme='" + imeKorisnika.Text + "',KorisnikPrezime='" + prezimeKorisnika.Text + "',KorisnikLozinka='" + lozinkaKorisnika.Text + "',KorisnikVrsta='" + vrstaKorisnika.SelectedItem.ToString() + "' where KorisnikId=" + idKorisnika.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Gost je uspešno izmenjen!");
            Con.Close();
            populacija();
        }

        private void korisniciPrikaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idKorisnika.Text = korisniciPrikaz.SelectedRows[0].Cells[0].Value.ToString();
            imeKorisnika.Text = korisniciPrikaz.SelectedRows[0].Cells[1].Value.ToString();
            prezimeKorisnika.Text = korisniciPrikaz.SelectedRows[0].Cells[2].Value.ToString();
            lozinkaKorisnika.Text = korisniciPrikaz.SelectedRows[0].Cells[3].Value.ToString();
            vrstaKorisnika.Text = korisniciPrikaz.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Korisnik_tbl where KorisnikId= " + idKorisnika.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Korisnik je uspešno izbrisan!");
            Con.Close();
            populacija();
        }

        private void Vreme_Tick(object sender, EventArgs e)
        {
            vremeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            GlavniMeni glavniMeni = new GlavniMeni();
            glavniMeni.Show();
            this.Hide();
        }

        private void idKorisnikaBroj(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
