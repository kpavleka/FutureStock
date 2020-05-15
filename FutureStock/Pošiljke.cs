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
    public partial class formPosiljke : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable();
        Konekcija konekcija = new Konekcija();
        public formPosiljke()
        {
            InitializeComponent();
        }

        private void Pošiljke_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
            try
            {
                string sql = "SELECT \"ID_narudžbenica\", datum_nastanka, ukupan_iznos FROM \"Narudžbenica\" WHERE datum_zaprimanja IS NULL ORDER BY \"ID_narudžbenica\" ASC";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                ds.Reset();
                da.Fill(ds);

                dt = ds.Tables[0];
                dgvNezaprimljene.DataSource = dt;
                dgvNezaprimljene.Columns[0].HeaderText = "Šifra";
                dgvNezaprimljene.Columns[1].HeaderText = "Nastalo";
                dgvNezaprimljene.Columns[2].HeaderText = "Ukupan iznos (kn)";

                dgvNezaprimljene.Columns[0].Width = 70;
                dgvNezaprimljene.Columns[1].Width = 350;
                dgvNezaprimljene.Columns[2].Width = 283;


                string sql2 = "SELECT * FROM \"Narudžbenica\" WHERE datum_zaprimanja IS NOT NULL ORDER BY \"ID_narudžbenica\" ASC";
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sql2, konekcija.conn);

                ds2.Reset();
                da2.Fill(ds2);

                dt2 = ds2.Tables[0];
                dgvZaprimljene.DataSource = dt2;
                dgvZaprimljene.Columns[0].HeaderText = "Šifra";
                dgvZaprimljene.Columns[1].HeaderText = "Nastalo";
                dgvZaprimljene.Columns[2].HeaderText = "Ukupan iznos (kn)";
                dgvZaprimljene.Columns[3].HeaderText = "Zaprimljeno";

                dgvZaprimljene.Columns[0].Width = 70;
                dgvZaprimljene.Columns[1].Width = 220;
                dgvZaprimljene.Columns[2].Width = 193;
                dgvZaprimljene.Columns[3].Width = 220;
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }
        }

        private void gumbPovratakPos_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDashboard dashboard = new formDashboard();
            dashboard.ShowDialog();
        }

        private void gumbZaprimi_Click(object sender, EventArgs e)
        {
            string vrijednost = dgvNezaprimljene.SelectedRows[0].Cells[0].Value.ToString();
            int rowIndex = dgvNezaprimljene.CurrentCell.RowIndex;
            dgvNezaprimljene.Rows.RemoveAt(rowIndex);

            try
            {
                string sql = "UPDATE \"Narudžbenica\" SET datum_zaprimanja = date_trunc('second'::text, CURRENT_TIMESTAMP) WHERE \"ID_narudžbenica\" = " + vrijednost;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                ds.Reset();
                da.Fill(ds);
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

            try
            {
                string sql2 = "SELECT \"ID_narudžbenica\", datum_nastanka, ukupan_iznos FROM \"Narudžbenica\" WHERE datum_zaprimanja IS NULL ORDER BY \"ID_narudžbenica\" ASC";
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sql2, konekcija.conn);

                ds2.Reset();
                da2.Fill(ds2);

                dt2 = ds2.Tables[0];
                dgvNezaprimljene.DataSource = dt2;

                dgvNezaprimljene.Columns[0].HeaderText = "Šifra";
                dgvNezaprimljene.Columns[1].HeaderText = "Nastalo";
                dgvNezaprimljene.Columns[2].HeaderText = "Ukupan iznos (kn)";

                dgvNezaprimljene.Columns[0].Width = 70;
                dgvNezaprimljene.Columns[1].Width = 350;
                dgvNezaprimljene.Columns[2].Width = 283;

                string sql3 = "SELECT * FROM \"Narudžbenica\" WHERE datum_zaprimanja IS NOT NULL ORDER BY \"ID_narudžbenica\" ASC";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql3, konekcija.conn);

                ds.Reset();
                da.Fill(ds);

                dt = ds.Tables[0];
                dgvZaprimljene.DataSource = dt;
                dgvZaprimljene.Columns[0].HeaderText = "Šifra";
                dgvZaprimljene.Columns[1].HeaderText = "Nastalo";
                dgvZaprimljene.Columns[2].HeaderText = "Ukupan iznos (kn)";
                dgvZaprimljene.Columns[3].HeaderText = "Zaprimljeno";

                dgvZaprimljene.Columns[0].Width = 70;
                dgvZaprimljene.Columns[1].Width = 220;
                dgvZaprimljene.Columns[2].Width = 193;
                dgvZaprimljene.Columns[3].Width = 220;
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

        }
    }
}
