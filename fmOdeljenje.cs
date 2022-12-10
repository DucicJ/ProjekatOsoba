using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatOsoba
{
    public partial class fmOdeljenje : Form
    {
        public fmOdeljenje()
        {
            InitializeComponent();
        }

        DataTable Tabela;
        int Univerzalni_ID = 0;
        SqlConnection Veza = Povezivanje.Konekcija();

        private void NovaTabela(string a)
        {
            Tabela = new DataTable();
            SqlDataAdapter Komanda = new SqlDataAdapter(a, Veza);
            Komanda.Fill(Tabela);
        }

        private void PopulateTable()
        {
            if (Tabela.Rows.Count == 0)
            {
                tbID.Text = "";
                tbRazred.Text = "";
                tbIndex.Text = "";
                cbSmer.Text = "";
                cbRazredni.Text = "";
                cbGodina.Text = "";
            }
            else
            {
                string komanda = "SELECT * FROM smer";
                NovaTabela(komanda);

                cbSmer.DataSource = Tabela;
                cbSmer.ValueMember = "ID";
                cbSmer.DisplayMember = "naziv";

                komanda = "SELECT id, ime + ' ' + prezime AS ImePrezime FROM osoba WHERE uloga = 2";
                NovaTabela(komanda);

                cbRazredni.DataSource = Tabela;
                cbRazredni.ValueMember = "ID";
                cbRazredni.DisplayMember = "ImePrezime";

                komanda = "SELECT * FROM skolska_godina";
                NovaTabela(komanda);

                cbGodina.DataSource = Tabela;
                cbGodina.ValueMember= "ID";
                cbGodina.DisplayMember= "naziv";

                komanda = "SELECT * FROM Odeljenje";
                NovaTabela(komanda);

                tbID.Text = Tabela.Rows[Univerzalni_ID][0].ToString();
                tbRazred.Text = Tabela.Rows[Univerzalni_ID][1].ToString();
                tbIndex.Text = Tabela.Rows[Univerzalni_ID][2].ToString();
                cbSmer.SelectedValue = (int) Tabela.Rows[Univerzalni_ID][3];
                cbRazredni.SelectedValue = (int)Tabela.Rows[Univerzalni_ID][4];
                cbGodina.SelectedValue = (int)Tabela.Rows[Univerzalni_ID][5];

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
                    btNext.BackColor = Color.OliveDrab;
                    btLast.Enabled = true;
                    btLast.BackColor = Color.OliveDrab;
                }
                if (Univerzalni_ID == 0)
                {
                    btFirst.Enabled = false;
                    btFirst.BackColor = Color.Gray;
                    btPrev.Enabled = false;
                    btPrev.BackColor = Color.Gray;
                }
                else
                {
                    btFirst.Enabled = true;
                    btFirst.BackColor = Color.OliveDrab;
                    btPrev.Enabled = true;
                    btPrev.BackColor = Color.OliveDrab;
                }

            }
        }

        private void fmOdeljenje_Load(object sender, EventArgs e)
        {
            PopulateTable();
        }
    }
}
