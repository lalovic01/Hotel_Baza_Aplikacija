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
    public partial class RezervacijaRecepForma : Form
    {
        public RezervacijaRecepForma()
        {
            InitializeComponent();
        }
        public void populacija()
        {
            Con.Open();
            string Myquery = "select * from Rez_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbGradnja = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            rezervacijaPrikaz.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void polulacijaS()
        {
            Con.Open();
            string Myquery = "select SobeId, SobaTip, SobaKreveti from Soba_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbGradnja = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            sobePrikaz.DataSource = ds.Tables[0];
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Nova Konekcija\HotelSistemDB.mdf;Integrated Security=True;Connect Timeout=30");
        DateTime danas;
        public void punjenjeGosta()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select GostIme from Gost_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("GostIme", typeof(string));
            dt.Load(rdr);
            imeRezervisanogK.ValueMember = "GostIme";
            imeRezervisanogK.DataSource = dt;
            Con.Close();
        }
        public void punjenjeSobe()
        {
            Con.Open();
            string sobaStatus = "Slobodna";
            SqlCommand cmd = new SqlCommand("select SobeId from Soba_tbl where SobaRaspolozivost='" + sobaStatus + "'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SobeId", typeof(int));
            dt.Load(rdr);
            imeRezervisaneSobe.ValueMember = "SobeId";
            imeRezervisaneSobe.DataSource = dt;
            Con.Close();
        }
        private void RezervacijaRecepForma_Load(object sender, EventArgs e)
        {
            vremeLbl.Text = DateTime.Now.ToLongTimeString();
            Vreme.Start();
            danas = datumOd.Value;
            populacija();
            punjenjeSobe();
            punjenjeGosta();
            populacija();
            polulacijaS();
        }

        private void datumOd_ValueChanged(object sender, EventArgs e)
        {
            int rez = DateTime.Compare(datumOd.Value, danas);
            if (rez < 0)
                MessageBox.Show("Nevažeći datum rezervacije!");
        }

        private void datumDo_ValueChanged(object sender, EventArgs e)
        {
            int rez = DateTime.Compare(datumDo.Value, datumOd.Value);
            if (rez < 0)
                MessageBox.Show("Nevažeći datum rezervacije!");
        }
        public void azuriranjeSoba()
        {
            Con.Open();
            string novStatus = "Zauzeta";
            string myquery = "UPDATE Soba_tbl set SobaRaspolozivost='" + novStatus + "' where SobeId=" + Convert.ToInt32(imeRezervisaneSobe.SelectedValue.ToString()) + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Rezervacija je uspešno izmenjena!");
            Con.Close();
            punjenjeSobe();
        }
        public void azuriranjeSobaNaBrisanje()
        {
            Con.Open();
            string novStatus = "Slobodna";
            int sobaId = Convert.ToInt32(rezervacijaPrikaz.SelectedRows[0].Cells[2].Value.ToString());
            string myquery = "UPDATE Soba_tbl set SobaRaspolozivost='" + novStatus + "' where SobeId = " + sobaId + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Rezervacija je uspešno izmenjena!");
            Con.Close();
            punjenjeSobe();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (imeRezervisanogK.Text != "" && imeRezervisaneSobe.Text != "" && tipRezervacije.Text != "")
            {
                int rez = DateTime.Compare(datumOd.Value, danas);
                if (rez > 0)
                {
                    int rez1 = DateTime.Compare(datumDo.Value, datumOd.Value);
                    if (rez1 > 0)
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Rez_tbl values('" + imeRezervisanogK.SelectedValue.ToString() + "','" + imeRezervisaneSobe.SelectedValue.ToString() + "','" + datumOd.Text + "','" + datumDo.Text + "','" + cenaRez.Text + "','" + tipRezervacije.SelectedItem.ToString() + "')", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Rezervacija je upešno napravljena!");
                        Con.Close();
                        azuriranjeSoba();
                        populacija();
                    }
                    else
                        MessageBox.Show("Nevažeći datum rezervacije!");
                }
                else
                    MessageBox.Show("Nevažeći datum rezervacije!");
            }
            else
            {
                MessageBox.Show("Popunite sva polja", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rezervacijaPrikaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idRezervacije.Text = rezervacijaPrikaz.SelectedRows[0].Cells[0].Value.ToString();
            imeRezervisanogK.Text = rezervacijaPrikaz.SelectedRows[0].Cells[1].Value.ToString();
            imeRezervisaneSobe.Text = rezervacijaPrikaz.SelectedRows[0].Cells[2].Value.ToString();
            datumOd.Text = rezervacijaPrikaz.SelectedRows[0].Cells[3].Value.ToString();
            datumDo.Text = rezervacijaPrikaz.SelectedRows[0].Cells[4].Value.ToString();
            cenaRez.Text = rezervacijaPrikaz.SelectedRows[0].Cells[5].Value.ToString();
            tipRezervacije.Text = rezervacijaPrikaz.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            if (idRezervacije.Text == "")
            {
                MessageBox.Show("Unesite rezervaciju kako bi bila izbrisana!", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Con.Open();
                string query = "delete from Rez_tbl where RezId= " + idRezervacije.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezervacija je uspešno izbrisana!");
                Con.Close();
                azuriranjeSobaNaBrisanje();
                populacija();
            }
        }

        private void izmeniBtn_Click(object sender, EventArgs e)
        {
            if (idRezervacije.Text == "")
            {
                MessageBox.Show("Unesite ID rezervacije kako bi bila izmenjena!", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Con.Open();
                string myquery = "UPDATE Rez_tbl set Gost='" + imeRezervisanogK.SelectedValue.ToString() + "',Soba='" + imeRezervisaneSobe.SelectedValue.ToString() + "',DatumOd='" + datumOd.Text.ToString() + "',DatumDo='" + datumDo.Text.ToString() + "',Cena='" + cenaRez.Text + "',TipRezervacije='" + tipRezervacije.SelectedItem.ToString() + "' where RezId=" + idRezervacije.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezervacija je uspešno izmenjena!");
                Con.Close();
                azuriranjeSoba();
                azuriranjeSobaNaBrisanje();
                populacija();
            }
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            GlavniMeni glavniMeni = new GlavniMeni();
            glavniMeni.Show();
            this.Hide();
        }

        private void Vreme_Tick(object sender, EventArgs e)
        {
            vremeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void dodajGostaIzRez_Click(object sender, EventArgs e)
        {
            if (prezimeGosta.Text != "" && imeGosta.Text != "" && telefonGosta.Text != "")
            {
                var datumGostaRodjenje = Convert.ToDateTime(datumGosta.Text);
                var ts = DateTime.Today - datumGostaRodjenje;
                var godina = DateTime.MinValue.Add(ts).Year - 1;
                if (godina >= 18)
                {
                    if (telefonGosta.TextLength == 10)
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Gost_tbl values('" + imeGosta.Text + "','" + prezimeGosta.Text + "','" + datumGosta.Text + "','" + telefonGosta.Text + "')", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Uspešno je dodat gost!");
                        RezervacijaRecepForma rezervacijaRecepForma = new RezervacijaRecepForma();
                        rezervacijaRecepForma.Show();
                        this.Hide();
                        Con.Close();
                        populacija();
                    }
                    else
                        MessageBox.Show("Broj treba da ima 10 brojeva", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                    MessageBox.Show("Korisnik je maloletan, nije moguće dodavanje!", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Popunite sva polja", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void idRezGostaBroj(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void telefonRezBroj(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void idRezervacije_KeyPress(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void cenaRezBrojF(object sender, KeyPressEventArgs e)
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
