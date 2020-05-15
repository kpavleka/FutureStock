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
    
    public partial class formNovaKategorija : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();
        public formNovaKategorija()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
            try
            {
                string sql = "INSERT INTO \"Kategorija\" (naziv, opis) VALUES ('" + textbox1.Text + "', '" + textbox2.Text + "')";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                ds.Reset();
                da.Fill(ds);
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

            this.Hide();
            formEntiteti entiteti = new formEntiteti();
            entiteti.ShowDialog();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEntiteti entiteti = new formEntiteti();
            entiteti.ShowDialog();
        }
    }
}
