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
    public partial class GostiForma : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Nova Konekcija\HotelSistemDB.mdf;Integrated Security=True;Connect Timeout=30");
        public void populacija()
        {
            Con.Open();
            string Myquery = "select * from Gost_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbGradnja = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gostiPrikaz.DataSource = ds.Tables[0];
            Con.Close();
        }
        public GostiForma()
        {
            InitializeComponent();
        }
        private void Vreme_Tick(object sender, EventArgs e)
        {
            vremeLbl.Text = DateTime.Now.ToLongTimeString();
        }
        private void GostiForma_Load(object sender, EventArgs e)
        {
            vremeLbl.Text=DateTime.Now.ToLongTimeString();
            Vreme.Start();
            populacija();
            ActiveControl = null;
        }
        private void dodajBtn_Click(object sender, EventArgs e)
        {
            
            if (prezimeGosta.Text != "" && imeGosta.Text != "" && telefonGosta.Text != "")
            {
                var datumGostaRodjenje = Convert.ToDateTime(datumGosta.Text);
                var ts = DateTime.Today - datumGostaRodjenje;
                var godina = DateTime.MinValue.Add(ts).Year - 1;
                if (godina >= 18)
                {
                    if(telefonGosta.TextLength==10)
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Gost_tbl values('" + imeGosta.Text + "','" + prezimeGosta.Text + "','" + datumGosta.Text + "','" + telefonGosta.Text + "')", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Uspešno je dodat gost!");
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

        private void gostiPrikaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idGosta.Text = gostiPrikaz.SelectedRows[0].Cells[0].Value.ToString();
            imeGosta.Text = gostiPrikaz.SelectedRows[0].Cells[1].Value.ToString();
            prezimeGosta.Text = gostiPrikaz.SelectedRows[0].Cells[2].Value.ToString();
            datumGosta.Text = gostiPrikaz.SelectedRows[0].Cells[3].Value.ToString();
            telefonGosta.Text = gostiPrikaz.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void izmeniBtn_Click(object sender, EventArgs e)
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
                        string myquery = "UPDATE Gost_tbl set GostIme='" + imeGosta.Text + "',GostPrezime='" + prezimeGosta.Text + "',GostDatum='" + datumGosta.Text + "',GostTelefon='" + telefonGosta.Text + "' where GostId=" + idGosta.Text + ";";
                        SqlCommand cmd = new SqlCommand(myquery, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Gost je uspešno izmenjen!");
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

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Gost_tbl where GostId= " + idGosta.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Gost je uspešno izbrisan!");
            Con.Close();
            populacija();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            GlavniMeni glavniMeni = new GlavniMeni();
            glavniMeni.Show();
            this.Hide();
        }

        private void unosBroja(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if(!Char.IsDigit(karakter) && karakter !=8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void unosId(object sender, KeyPressEventArgs e)
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
