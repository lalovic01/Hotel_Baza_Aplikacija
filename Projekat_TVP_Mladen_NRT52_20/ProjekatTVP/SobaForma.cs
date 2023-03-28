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
    public partial class SobaForma : Form
    {
        public SobaForma()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Nova Konekcija\HotelSistemDB.mdf;Integrated Security=True;Connect Timeout=30");
        public void populacija()
        {
            Con.Open();
            string Myquery = "select * from Soba_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbGradnja = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            sobePrikaz.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (brojSobe.Text != "" && brojKreveta.Text != "" && tipSobe.Text != "" && cenaSobe.Text != "" && (slobodnaSoba.Text != "" || zauzetaSoba.Text!=""))
            {
                string jeSlobodna;
                if (slobodnaSoba.Checked == true)
                    jeSlobodna = "Slobodna";
                else
                    jeSlobodna = "Zauzeta";
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Soba_tbl values(" + brojSobe.Text + ",'" + brojKreveta.SelectedItem.ToString() + "','" + tipSobe.SelectedItem.ToString() + "','" + cenaSobe.Text + "','" + jeSlobodna + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Uspešno je dodata soba!");
                Con.Close();
                populacija();
            }
            else
            {
                MessageBox.Show("Popunite sva polja", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SobaForma_Load(object sender, EventArgs e)
        {
            populacija();
            vremeLbl.Text = DateTime.Now.ToLongTimeString();
            Vreme.Start();
        }

        private void sobePrikaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idSobe.Text = sobePrikaz.SelectedRows[0].Cells[0].Value.ToString();
            brojSobe.Text = sobePrikaz.SelectedRows[0].Cells[1].Value.ToString();
            brojKreveta.Text = sobePrikaz.SelectedRows[0].Cells[2].Value.ToString();
            tipSobe.Text = sobePrikaz.SelectedRows[0].Cells[3].Value.ToString();
            cenaSobe.Text = sobePrikaz.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
                Con.Open();
                string query = "delete from Soba_tbl where SobeId= " + idSobe.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soba je uspešno izbrisana!");
                Con.Close();
                populacija();
        }

        private void izmeniBtn_Click(object sender, EventArgs e)
        {
            if (brojSobe.Text != "" && brojKreveta.Text != "" && tipSobe.Text != "" && cenaSobe.Text != "" && (slobodnaSoba.Checked != true || zauzetaSoba.Checked != true))
            {
                string jeSlobodna;
                if (slobodnaSoba.Checked == true)
                    jeSlobodna = "Slobodna";
                else
                    jeSlobodna = "Zauzeta";
                Con.Open();
                string myquery = "UPDATE Soba_tbl set SobaBroj='" + brojSobe.Text + "',SobaKreveti='" + brojKreveta.Text + "',SobaTip='" + tipSobe.Text + "',SobaCena='" + cenaSobe.Text + "',SobaRaspolozivost='" + jeSlobodna + "' where SobeId=" + idSobe.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soba je uspešno izmenjena!");
                Con.Close();
                populacija();
            }
            else
            {
                MessageBox.Show("Popunite sva polja", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Vreme_Tick(object sender, EventArgs e)
        {
            vremeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void NAZAD_Click(object sender, EventArgs e)
        {
            GlavniMeni glavniMeni = new GlavniMeni();
            glavniMeni.Show();
            this.Hide();
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void brojSobeCifra(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void cenaSobeCifra(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }
    }
}
