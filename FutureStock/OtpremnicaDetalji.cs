using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace FutureStock
{
    public partial class formOtpremnicaDetalji : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();
        public static string vrijednost;
        public formOtpremnicaDetalji(string vrij)
        {
            vrijednost = vrij;
            InitializeComponent();
        }

        private void gumbPovratakOtp_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEntiteti entiteti = new formEntiteti();
            entiteti.ShowDialog();
        }

        private void formOtpremnicaDetalji_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
            try
            {
                string sql = "SELECT p.naziv, d.naziv, p.cijena, o.količina, p.cijena * o.količina FROM \"Dobavljač\" d INNER JOIN \"Proizvod\" p ON d.\"ID_dobavljač\" = p.\"ID_dobavljač\" INNER JOIN \"Otpremnica_detalji\" o ON p.\"ID_proizvod\" = o.\"ID_proizvod\" WHERE o.\"ID_otpremnica\" = " + vrijednost;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                ds.Reset();
                da.Fill(ds);

                dt = ds.Tables[0];
                dgvDetaljiOtpremnice.DataSource = dt;

                dgvDetaljiOtpremnice.Columns[0].HeaderText = "Proizvod";
                dgvDetaljiOtpremnice.Columns[1].HeaderText = "Dobavljač";
                dgvDetaljiOtpremnice.Columns[2].HeaderText = "Jedinična cijena (kn)";
                dgvDetaljiOtpremnice.Columns[3].HeaderText = "Količina";
                dgvDetaljiOtpremnice.Columns[4].HeaderText = "Ukupna cijena (kn)";

                dgvDetaljiOtpremnice.Columns[0].Width = 150;
                dgvDetaljiOtpremnice.Columns[1].Width = 130;
                dgvDetaljiOtpremnice.Columns[2].Width = 180;
                dgvDetaljiOtpremnice.Columns[3].Width = 70;
                dgvDetaljiOtpremnice.Columns[4].Width = 180;
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }
        }
    }
}
