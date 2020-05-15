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
    public partial class formDashboard : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();
        public formDashboard()
        {
            InitializeComponent();
        }

        private void btnKreiranje_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEntiteti kreiranjeEntiteta = new formEntiteti();
            kreiranjeEntiteta.ShowDialog();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
            try
            {
                string sql = "SELECT p.naziv, s.količina, s.posljednja_promjena FROM \"Proizvod\" p INNER JOIN \"Skladište\" s ON p.\"ID_proizvod\" = s.\"ID_proizvod\" ORDER BY s.\"količina\" ASC";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                ds.Reset();
                da.Fill(ds);

                dt = ds.Tables[0];
                dgvSkladiste.DataSource = dt;
                dgvSkladiste.DefaultCellStyle.ForeColor = Color.Red;
                dgvSkladiste.Columns[0].HeaderText = "Naziv proizvoda";
                dgvSkladiste.Columns[1].HeaderText = "Količina";
                dgvSkladiste.Columns[2].HeaderText = "Posljednja promjena";

                dgvSkladiste.Columns[0].Width = 275;
                dgvSkladiste.Columns[1].Width = 102;
                dgvSkladiste.Columns[2].Width = 275;
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

            int suma = 0;
            for (int i = 0; i < dgvSkladiste.Rows.Count; i++)
            {
                suma += Convert.ToInt32(dgvSkladiste.Rows[i].Cells[1].Value);
            }
            progressSkladiste.Value = suma * 100 / 2000;

        }

        private void btnZaprimi_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPosiljke posiljke = new formPosiljke();
            posiljke.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            this.Hide();
            formStatistika statistika = new formStatistika();
            statistika.ShowDialog();
        }
    }
}
