using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class Form1 : Form
    {
        public static string a, b;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Nova Konekcija\HotelSistemDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Korisnik_tbl where KorisnikIme='" + imeTb.Text + "' and KorisnikLozinka='" + lozinkaTb.Text + "' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            a = imeTb.Text;
            b = lozinkaTb.Text;
            string username, pass;
            TextReader tr;
            using (tr = new StreamReader("Admin.txt"))
            {
                username = tr.ReadLine();
                pass = tr.ReadLine();
            }
            if (Form1.a == username && Form1.b == pass)
            {
                GlavniMeni gm = new GlavniMeni();
                gm.Show();
                this.Hide();
            }
            else if (Form1.a == "" && Form1.b == "")
            {
                MessageBox.Show("Niste uneli ime i sifru korisnika!");
                imeTb.Focus();
            }
            else if (Form1.a == "" && Form1.b == pass)
            {
                MessageBox.Show("Niste uneli ime korisnika!");
                imeTb.Focus();
            }
            else if (Form1.a == username && Form1.b == "")
            {
                MessageBox.Show("Niste uneli sifru korisnika!");
                lozinkaTb.Focus();
            }
            else if (Form1.a != username && Form1.b == pass)
            {
                MessageBox.Show("Pogresno ime korisnika!");
                imeTb.Clear();
                imeTb.Focus();
            }
            else if (Form1.a == username && Form1.b != pass)
            {
                MessageBox.Show("Pogresna sifra korisnika!");
                lozinkaTb.Clear();
                lozinkaTb.Focus();
            }
            else if (Form1.a != username && Form1.b != pass)
            {
                using (tr = new StreamReader("Recepcioner.txt"))
                {
                    username = tr.ReadLine();
                    pass = tr.ReadLine();
                    if (Form1.a == username && Form1.b == pass)
                    {
                        RezervacijaRecepForma rezervacijaRecepForma = new RezervacijaRecepForma();
                        rezervacijaRecepForma.Show();
                        this.Hide();
                    }
                    else if (Form1.a == "" && Form1.b == "")
                    {
                        MessageBox.Show("Niste uneli ime i sifru korisnika!");
                        imeTb.Focus();
                    }
                    else if (Form1.a == "" && Form1.b == pass)
                    {
                        MessageBox.Show("Niste uneli ime korisnika!");
                        imeTb.Focus();
                    }
                    else if (Form1.a == username && Form1.b == "")
                    {
                        MessageBox.Show("Niste uneli sifru korisnika!");
                        lozinkaTb.Focus();
                    }
                    else if (Form1.a != username && Form1.b == pass)
                    {
                        MessageBox.Show("Pogresno ime korisnika!");
                        imeTb.Clear();
                        imeTb.Focus();
                    }
                    else if (Form1.a == username && Form1.b != pass)
                    {
                        MessageBox.Show("Pogresna sifra korisnika!");
                        lozinkaTb.Clear();
                        lozinkaTb.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Korisnik ne postoji!");
                        imeTb.Clear();
                        lozinkaTb.Clear();
                        imeTb.Focus();
                    }
                }  
            }
            else
            {
                MessageBox.Show("Korisnik ne postoji!");
                imeTb.Clear();
                lozinkaTb.Clear();
                imeTb.Focus();
            }
            Con.Close();
        }
    }
}
