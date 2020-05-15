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
    public partial class formEntiteti : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();
        public formEntiteti()
        {
            InitializeComponent();
        }

        

        private void dgvDobavljaci_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

        }

            private void tabKompletno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabKompletno.SelectedTab == tabKompletno.TabPages["tabDobavljaci"])             
            {
                try
                {
                    string sql = "SELECT * FROM \"Dobavljač\" ORDER BY \"ID_dobavljač\" ASC";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                    ds.Reset();
                    da.Fill(ds);

                    dt = ds.Tables[0];
                    dgvDobavljaci.DataSource = dt;
                    dgvDobavljaci.Columns[0].HeaderText = "Šifra";
                    dgvDobavljaci.Columns[1].HeaderText = "Naziv";
                    dgvDobavljaci.Columns[2].HeaderText = "Mjesto";
                    dgvDobavljaci.Columns[3].HeaderText = "Adresa";
                    dgvDobavljaci.Columns[4].HeaderText = "Telefon";
                    dgvDobavljaci.Columns[5].HeaderText = "Opis";

                    dgvDobavljaci.Columns[0].Width = 50;
                    dgvDobavljaci.Columns[3].Width = 175;
                    dgvDobavljaci.Columns[5].Width = 200;
                }
                catch (PostgresException msg)
                {
                    MessageBox.Show(msg.MessageText, "Upozorenje");
                }
            }
            else if (tabKompletno.SelectedTab == tabKompletno.TabPages["tabProizvodi"])
            {
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
                    dgvProizvodi.Columns[4].Width = 160;

                }
                catch (PostgresException msg)
                {
                    MessageBox.Show(msg.MessageText, "Upozorenje");
                }
            }
            else if (tabKompletno.SelectedTab == tabKompletno.TabPages["tabKategorije"])
            {
                try
                {
                    string sql = "SELECT * FROM \"Kategorija\" ORDER BY \"ID_kategorija\" ASC";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                    ds.Reset();
                    da.Fill(ds);

                    dt = ds.Tables[0];
                    dgvKategorije.DataSource = dt;

                    dgvKategorije.Columns[0].HeaderText = "Šifra";
                    dgvKategorije.Columns[1].HeaderText = "Naziv";
                    dgvKategorije.Columns[2].HeaderText = "Opis";

                    dgvKategorije.Columns[0].Width = 50;
                    dgvKategorije.Columns[1].Width = 275;
                    dgvKategorije.Columns[2].Width = 400;
                }
                catch (PostgresException msg)
                {
                    MessageBox.Show(msg.MessageText, "Upozorenje");
                }
            }
            else if (tabKompletno.SelectedTab == tabKompletno.TabPages["tabNarudzbenice"])
            {
                try
                {
                    string sql = "SELECT * FROM \"Narudžbenica\" ORDER BY \"ID_narudžbenica\" ASC";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                    ds.Reset();
                    da.Fill(ds);

                    dt = ds.Tables[0];
                    dgvNarudzbenice.DataSource = dt;

                    dgvNarudzbenice.Columns[0].HeaderText = "Šifra";
                    dgvNarudzbenice.Columns[1].HeaderText = "Datum nastanka";
                    dgvNarudzbenice.Columns[2].HeaderText = "Ukupan iznos (kn)";
                    dgvNarudzbenice.Columns[3].HeaderText = "Datum zaprimanja";

                    dgvNarudzbenice.Columns[0].Width = 50;
                    dgvNarudzbenice.Columns[1].Width = 250;
                    dgvNarudzbenice.Columns[2].Width = 175;
                    dgvNarudzbenice.Columns[3].Width = 250;
                }
                catch (PostgresException msg)
                {
                    MessageBox.Show(msg.MessageText, "Upozorenje");
                }
            }
            else if (tabKompletno.SelectedTab == tabKompletno.TabPages["tabOtpremnice"])
            {
                try
                {
                    string sql = "SELECT * FROM \"Otpremnica\" ORDER BY \"ID_otpremnica\" ASC";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                    ds.Reset();
                    da.Fill(ds);

                    dt = ds.Tables[0];
                    dgvOtpremnice.DataSource = dt;

                    dgvOtpremnice.Columns[0].HeaderText = "Šifra";
                    dgvOtpremnice.Columns[1].HeaderText = "Datum nastanka";
                    dgvOtpremnice.Columns[2].HeaderText = "Ukupan iznos (kn)";

                    dgvOtpremnice.Columns[0].Width = 50;
                    dgvOtpremnice.Columns[1].Width = 340;
                    dgvOtpremnice.Columns[2].Width = 335;

                }
                catch (PostgresException msg)
                {
                    MessageBox.Show(msg.MessageText, "Upozorenje");
                }
            }
        }

        private void formEntiteti_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
            try
            {
                string sql = "SELECT * FROM \"Dobavljač\" ORDER BY \"ID_dobavljač\" ASC";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);

                ds.Reset();
                da.Fill(ds);

                dt = ds.Tables[0];
                dgvDobavljaci.DataSource = dt;

                dgvDobavljaci.Columns[0].HeaderText = "Šifra";
                dgvDobavljaci.Columns[1].HeaderText = "Naziv";
                dgvDobavljaci.Columns[2].HeaderText = "Mjesto";
                dgvDobavljaci.Columns[3].HeaderText = "Adresa";
                dgvDobavljaci.Columns[4].HeaderText = "Telefon";
                dgvDobavljaci.Columns[5].HeaderText = "Opis";

                dgvDobavljaci.Columns[0].Width = 50;
                dgvDobavljaci.Columns[3].Width = 175;
                dgvDobavljaci.Columns[5].Width = 200;

            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }
        }

        private void gumbBrisiDob_Click(object sender, EventArgs e)
        {
            string vrijednost = dgvDobavljaci.SelectedRows[0].Cells[0].Value.ToString();
            int rowIndex = dgvDobavljaci.CurrentCell.RowIndex;
            dgvDobavljaci.Rows.RemoveAt(rowIndex);

            try
            {               
                string sql = "DELETE FROM \"Dobavljač\" WHERE \"ID_dobavljač\" = " + vrijednost;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                ds.Reset();
                da.Fill(ds);
         
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

            string sql2 = "SELECT * FROM \"Dobavljač\" ORDER BY \"ID_dobavljač\" ASC";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sql2, konekcija.conn);

            ds.Reset();
            da2.Fill(ds);

            dt = ds.Tables[0];
            dgvDobavljaci.DataSource = dt;


        }

        private void gumbBrisiKat_Click(object sender, EventArgs e)
        {
            string vrijednost = dgvKategorije.SelectedRows[0].Cells[0].Value.ToString();
            int rowIndex = dgvKategorije.CurrentCell.RowIndex;
            dgvKategorije.Rows.RemoveAt(rowIndex);

            try
            {
                string sql = "DELETE FROM \"Kategorija\" WHERE \"ID_kategorija\" = " + vrijednost;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                ds.Reset();
                da.Fill(ds);

            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

            string sql2 = "SELECT * FROM \"Kategorija\" ORDER BY \"ID_kategorija\" ASC";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sql2, konekcija.conn);

            ds.Reset();
            da2.Fill(ds);

            dt = ds.Tables[0];
            dgvKategorije.DataSource = dt;

            dgvKategorije.Columns[0].HeaderText = "Šifra";
            dgvKategorije.Columns[1].HeaderText = "Naziv";
            dgvKategorije.Columns[2].HeaderText = "Opis";

            dgvKategorije.Columns[0].Width = 50;
            dgvKategorije.Columns[1].Width = 275;
            dgvKategorije.Columns[2].Width = 400;
        }

        private void gumbBrisiNar_Click(object sender, EventArgs e)
        {
            string vrijednost = dgvNarudzbenice.SelectedRows[0].Cells[0].Value.ToString();
            int rowIndex = dgvNarudzbenice.CurrentCell.RowIndex;
            dgvNarudzbenice.Rows.RemoveAt(rowIndex);

            try
            {
                string sql = "DELETE FROM \"Narudžbenica\" WHERE \"ID_narudžbenica\" = " + vrijednost;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                ds.Reset();
                da.Fill(ds);            
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

            string sql2 = "SELECT * FROM \"Narudžbenica\" ORDER BY \"ID_narudžbenica\" ASC";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sql2, konekcija.conn);

            ds.Reset();
            da2.Fill(ds);

            dt = ds.Tables[0];
            dgvNarudzbenice.DataSource = dt;

            dgvNarudzbenice.Columns[0].HeaderText = "Šifra";
            dgvNarudzbenice.Columns[1].HeaderText = "Datum nastanka";
            dgvNarudzbenice.Columns[2].HeaderText = "Ukupan iznos (kn)";
            dgvNarudzbenice.Columns[3].HeaderText = "Datum zaprimanja";

            dgvNarudzbenice.Columns[0].Width = 50;
            dgvNarudzbenice.Columns[1].Width = 250;
            dgvNarudzbenice.Columns[2].Width = 175;
            dgvNarudzbenice.Columns[3].Width = 250;
        }

        private void gumbBrisiOtp_Click(object sender, EventArgs e)
        {
            string vrijednost = dgvOtpremnice.SelectedRows[0].Cells[0].Value.ToString();
            int rowIndex = dgvOtpremnice.CurrentCell.RowIndex;
            dgvOtpremnice.Rows.RemoveAt(rowIndex);

            try
            {
                string sql = "DELETE FROM \"Otpremnica\" WHERE \"ID_otpremnica\" = " + vrijednost;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                ds.Reset();
                da.Fill(ds);       
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

            string sql2 = "SELECT * FROM \"Otpremnica\" ORDER BY \"ID_otpremnica\" ASC";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sql2, konekcija.conn);

            ds.Reset();
            da2.Fill(ds);

            dt = ds.Tables[0];
            dgvOtpremnice.DataSource = dt;

            dgvOtpremnice.Columns[0].HeaderText = "Šifra";
            dgvOtpremnice.Columns[1].HeaderText = "Datum nastanka";
            dgvOtpremnice.Columns[2].HeaderText = "Ukupan iznos (kn)";

            dgvOtpremnice.Columns[0].Width = 50;
            dgvOtpremnice.Columns[1].Width = 340;
            dgvOtpremnice.Columns[2].Width = 335;
        }

        private void gumbBrisiPro_Click(object sender, EventArgs e)
        {
            string vrijednost = dgvProizvodi.SelectedRows[0].Cells[0].Value.ToString();
            int rowIndex = dgvProizvodi.CurrentCell.RowIndex;
            dgvProizvodi.Rows.RemoveAt(rowIndex);

            try
            {
                string sql = "DELETE FROM \"Proizvod\" WHERE \"ID_proizvod\" = " + vrijednost;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                ds.Reset();
                da.Fill(ds);          
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

            string sql2 = "SELECT * FROM \"Proizvod\" ORDER BY \"ID_proizvod\" ASC";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sql2, konekcija.conn);

            ds.Reset();
            da2.Fill(ds);

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
            dgvProizvodi.Columns[4].Width = 160;
        }

        private void gumbPovratakNar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDashboard dashboard = new formDashboard();
            dashboard.ShowDialog();
        }

        private void gumbPovratakDob_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDashboard dashboard = new formDashboard();
            dashboard.ShowDialog();
        }

        private void gumbPovratakKat_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDashboard dashboard = new formDashboard();
            dashboard.ShowDialog();
        }

        private void gumbPovratakOtp_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDashboard dashboard = new formDashboard();
            dashboard.ShowDialog();
        }

        private void gumbPovratakPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDashboard dashboard = new formDashboard();
            dashboard.ShowDialog();
        }

        private void gumbKreirajDob_Click(object sender, EventArgs e)
        {
            this.Hide();
            formNoviDobavljac dobavljac = new formNoviDobavljac();
            dobavljac.ShowDialog();
        }

        private void gumbKreirajKat_Click(object sender, EventArgs e)
        {
            this.Hide();
            formNovaKategorija kategorija = new formNovaKategorija();
            kategorija.ShowDialog();
        }

        private void gumbKreirajPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            formNoviProizvod proizvod = new formNoviProizvod();
            proizvod.ShowDialog();
        }

        private void gumbDetalji_Click(object sender, EventArgs e)
        {
            string vrijednost = dgvNarudzbenice.SelectedRows[0].Cells[0].Value.ToString();
            this.Hide();
            formNarudzbenicaDetalji narudzbenicaDetalji = new formNarudzbenicaDetalji(vrijednost);
            narudzbenicaDetalji.ShowDialog();

        }

        private void gumbDetalji2_Click(object sender, EventArgs e)
        {
            string vrijednost = dgvOtpremnice.SelectedRows[0].Cells[0].Value.ToString();
            this.Hide();
            formOtpremnicaDetalji otpremnicaDetalji = new formOtpremnicaDetalji(vrijednost);
            otpremnicaDetalji.ShowDialog();
        }

        private void gumbKreirajNar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formNovaNarudzbenica novaNarudzbenica = new formNovaNarudzbenica();
            novaNarudzbenica.ShowDialog();
        }

        private void gumbKreirajOtp_Click(object sender, EventArgs e)
        {
            this.Hide();
            formNovaOtpremnica novaOtpremnica = new formNovaOtpremnica();
            novaOtpremnica.ShowDialog();
        }
    }
}
