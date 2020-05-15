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
    public partial class formNarudzbenicaDetalji : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();
        public static string vrijednost;
        public formNarudzbenicaDetalji(string vrij)
        {
            vrijednost = vrij;
            InitializeComponent();
        }

        private void gumbPovratakNar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEntiteti entiteti = new formEntiteti();
            entiteti.ShowDialog();
        }

        private void formNarudzbenicaDetalji_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
            try
            {
                string sql = "SELECT p.naziv, d.naziv, p.cijena, n.količina, p.cijena * n.količina FROM \"Dobavljač\" d INNER JOIN \"Proizvod\" p ON d.\"ID_dobavljač\" = p.\"ID_dobavljač\" INNER JOIN \"Narudžbenica_detalji\" n ON p.\"ID_proizvod\" = n.\"ID_proizvod\" WHERE n.\"ID_narudžbenica\" = " + vrijednost;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                ds.Reset();
                da.Fill(ds);

                dt = ds.Tables[0];
                dgvDetaljiNarudzbenice.DataSource = dt;

                dgvDetaljiNarudzbenice.Columns[0].HeaderText = "Proizvod";
                dgvDetaljiNarudzbenice.Columns[1].HeaderText = "Dobavljač";
                dgvDetaljiNarudzbenice.Columns[2].HeaderText = "Jedinična cijena (kn)";
                dgvDetaljiNarudzbenice.Columns[3].HeaderText = "Količina";
                dgvDetaljiNarudzbenice.Columns[4].HeaderText = "Ukupna cijena (kn)";

                dgvDetaljiNarudzbenice.Columns[0].Width = 150;
                dgvDetaljiNarudzbenice.Columns[1].Width = 130;
                dgvDetaljiNarudzbenice.Columns[2].Width = 180;
                dgvDetaljiNarudzbenice.Columns[3].Width = 70;
                dgvDetaljiNarudzbenice.Columns[4].Width = 180;
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

           

        }
    }
}
