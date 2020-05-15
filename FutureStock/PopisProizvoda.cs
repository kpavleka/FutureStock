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
    public partial class formPopisProizvoda : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();
        public formPopisProizvoda()
        {
            InitializeComponent();
        }

        private void gumbZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formPopisProizvoda_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
            try
            {
                string sql = "SELECT p.\"ID_proizvod\", p.naziv, p.cijena, k.naziv, d.naziv FROM \"Kategorija\" k INNER JOIN \"Proizvod\" p ON k.\"ID_kategorija\" = p.\"ID_kategorija\" INNER JOIN \"Dobavljač\" d ON p.\"ID_dobavljač\" = d.\"ID_dobavljač\" ORDER BY p.\"ID_proizvod\" ASC";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                ds.Reset();
                da.Fill(ds);

                dt = ds.Tables[0];
                dgvProizvodi.DataSource = dt;

                dgvProizvodi.Columns[0].HeaderText = "Šifra";
                dgvProizvodi.Columns[1].HeaderText = "Naziv";
                dgvProizvodi.Columns[2].HeaderText = "Cijena (kn)";
                dgvProizvodi.Columns[3].HeaderText = "Kategorija";
                dgvProizvodi.Columns[4].HeaderText = "Dobavljač";

                dgvProizvodi.Columns[0].Width = 50;
                dgvProizvodi.Columns[1].Width = 220;
                dgvProizvodi.Columns[2].Width = 120;
                dgvProizvodi.Columns[3].Width = 175;
                dgvProizvodi.Columns[4].Width = 145;

            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }
        }
    }
}
