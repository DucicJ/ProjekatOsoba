using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjekatOsoba
{
    public partial class fmOsoba : Form 
    {
        public fmOsoba()
        {
            InitializeComponent();
        }

        private void NovaTabela()
        {
            Tabela = new DataTable();
            SqlConnection Veza = Povezivanje.Konekcija();
            SqlDataAdapter Komanda = new SqlDataAdapter("SELECT * FROM Osoba", Veza);
            Komanda.Fill(Tabela);
            PopulateTable();
        }

        DataTable Tabela;
        int Univerzalni_ID = 0;

        private void PopulateTable()
        {
            if (Tabela.Rows.Count == 0)
            {
                tbID.Text = "";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbAdresa.Text = "";
                tbJMBG.Text = "";
                tbEmail.Text = "";
                tbPASS.Text = "";
                cbUloga.Text = "";
            }
            else
            {
                tbID.Text = Tabela.Rows[Univerzalni_ID][0].ToString();
                tbIme.Text = Tabela.Rows[Univerzalni_ID][1].ToString();
                tbPrezime.Text = Tabela.Rows[Univerzalni_ID][2].ToString();
                tbAdresa.Text = Tabela.Rows[Univerzalni_ID][3].ToString();
                tbJMBG.Text = Tabela.Rows[Univerzalni_ID][4].ToString();
                tbEmail.Text = Tabela.Rows[Univerzalni_ID][5].ToString();
                tbPASS.Text = Tabela.Rows[Univerzalni_ID][6].ToString();
                if (Tabela.Rows[Univerzalni_ID][7].ToString() == "1")
                    cbUloga.Text = "Ucenik";
                else if (Tabela.Rows[Univerzalni_ID][7].ToString() == "2")
                    cbUloga.Text = "Profesor";
                else cbUloga.Text = "";
                if (Tabela.Rows.Count - 1 == Univerzalni_ID)
                {
                    btNext.Enabled = false;
                    btNext.BackColor = Color.Gray;
                    btLast.Enabled = false;
                    btLast.BackColor = Color.Gray;
                }
                else
                {
                    btNext.Enabled = true;
                    btNext.BackColor = Color.RoyalBlue;
                    btLast.Enabled = true;
                    btLast.BackColor = Color.RoyalBlue;
                }
                if (Univerzalni_ID == 0)
                {
                    btFirst.Enabled = false;
                    btFirst.BackColor = Color.Gray;
                    btPrevious.Enabled = false;
                    btPrevious.BackColor = Color.Gray;
                }
                else
                {
                    btFirst.Enabled = true;
                    btFirst.BackColor = Color.RoyalBlue;
                    btPrevious.Enabled = true;
                    btPrevious.BackColor = Color.RoyalBlue;
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NovaTabela();
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            Univerzalni_ID = 0;
            PopulateTable();
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            Univerzalni_ID--;
            PopulateTable();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            Univerzalni_ID++;
            PopulateTable();
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            Univerzalni_ID = Tabela.Rows.Count - 1;
            PopulateTable();
        }

        private void btTrazi_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbSearch.Text) - 1 < 0 || int.Parse(tbSearch.Text) > Tabela.Rows.Count)
                MessageBox.Show("ID je van dostupnih vrednosti!");
            else
            {
                Univerzalni_ID = int.Parse(tbSearch.Text) - 1;
                PopulateTable();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string uloga;
            string TekstNaredbe = "INSERT INTO Osoba VALUES ('";
            TekstNaredbe = TekstNaredbe + tbIme.Text + "', '";
            TekstNaredbe = TekstNaredbe + tbPrezime.Text + "', '";
            TekstNaredbe = TekstNaredbe + tbAdresa.Text + "', '";
            TekstNaredbe = TekstNaredbe + tbJMBG.Text + "', '";
            TekstNaredbe = TekstNaredbe + tbEmail.Text + "', '";
            TekstNaredbe = TekstNaredbe + tbPASS.Text + "', ";
            if (cbUloga.Text == "Nastavnik") uloga = "2";
            else uloga = "1";
            TekstNaredbe = TekstNaredbe + uloga + ")";
            SqlConnection veza = Povezivanje.Konekcija();
            SqlCommand Naredba = new SqlCommand(TekstNaredbe, veza);
            try
            {
                veza.Open();
                Naredba.ExecuteNonQuery();
                veza.Close();
            }
            catch(Exception Greska) { MessageBox.Show(Greska.GetType().ToString()); }
            NovaTabela();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string TekstNaredbe = "DELETE FROM osoba WHERE id = " + tbID.Text;
            SqlConnection veza = Povezivanje.Konekcija();
            SqlCommand Naredba = new SqlCommand(TekstNaredbe, veza);
            if (Univerzalni_ID == Tabela.Rows.Count - 1)
                Univerzalni_ID--;
            if (Univerzalni_ID < 0)
                Univerzalni_ID = 0;
            try
            {
                veza.Open();
                Naredba.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska) { MessageBox.Show(Greska.GetType().ToString()); }
            NovaTabela();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            string uloga;
            if (cbUloga.Text == "Nastavnik") uloga = "2";
            else uloga = "1";
            string TekstNaredbe = "UPDATE Osoba SET ";
            TekstNaredbe = TekstNaredbe + "ime = '" + tbIme.Text + "', ";
            TekstNaredbe = TekstNaredbe +  "prezime = '" + tbPrezime.Text + "', ";
            TekstNaredbe = TekstNaredbe + "adresa = '" + tbAdresa.Text + "', ";
            TekstNaredbe = TekstNaredbe + "jmbg = '" + tbJMBG.Text + "', ";
            TekstNaredbe = TekstNaredbe + "email = '" + tbEmail.Text + "', ";
            TekstNaredbe = TekstNaredbe + "pass = '" + tbPASS.Text + "', ";
            TekstNaredbe = TekstNaredbe + "uloga = " + uloga;
            TekstNaredbe = TekstNaredbe + "WHERE id = " + tbID.Text;
            SqlConnection veza = Povezivanje.Konekcija();
            SqlCommand Naredba = new SqlCommand(TekstNaredbe, veza);
            try
            {
                veza.Open();
                Naredba.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska) { MessageBox.Show(Greska.GetType().ToString()); }
            NovaTabela();
        }
    }
}
