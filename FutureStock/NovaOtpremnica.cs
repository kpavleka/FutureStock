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
    public partial class formNovaOtpremnica : Form
    {
        bool stvorenPredlozak;
        string vrijednost;
        string vrijednostIdOtpremnica;
        string vrijednostIdProizvod;
        int vrijednostKolSkladiste;
        float sumaUkupno;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();
        public formNovaOtpremnica()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEntiteti entiteti = new formEntiteti();
            entiteti.ShowDialog();
        }

        private void textbox1_Leave(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataReader reader;
                NpgsqlCommand read_command = new NpgsqlCommand("SELECT cijena FROM \"Proizvod\" WHERE naziv = '" + textbox1.Text + "'", konekcija.conn);
                reader = read_command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        vrijednost = reader.GetFloat(0).ToString();
                        textbox3.Text = vrijednost;
                        reader.Close();
                    }
                }

            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }
        }

        private void textbox2_Leave(object sender, EventArgs e)
        {
            int kolicina = Convert.ToInt32(textbox2.Text);
            float cijena = Convert.ToInt32(textbox3.Text);
            textbox4.Text = (kolicina * cijena).ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (stvorenPredlozak == true)
            {
                try
                {
                    NpgsqlDataReader reader;
                    NpgsqlCommand read_command = new NpgsqlCommand("SELECT \"ID_proizvod\" FROM \"Proizvod\" WHERE naziv = '" + textbox1.Text + "'", konekcija.conn);
                    reader = read_command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            vrijednostIdProizvod = reader.GetInt32(0).ToString();
                            reader.Close();
                        }
                    }
                }
                catch (PostgresException msg)
                {
                    MessageBox.Show(msg.MessageText, "Upozorenje");
                }                

                try
                {
                    NpgsqlDataReader reader;
                    NpgsqlCommand read_command = new NpgsqlCommand("SELECT količina FROM \"Skladište\" WHERE \"ID_proizvod\" = " + vrijednostIdProizvod + "", konekcija.conn);
                    reader = read_command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            vrijednostKolSkladiste = reader.GetInt32(0);
                            reader.Close();
                        }
                    }

                    if ((vrijednostKolSkladiste - Convert.ToInt32(textbox4.Text) < 10) && (vrijednostKolSkladiste - Convert.ToInt32(textbox4.Text) > -1))
                    {
                        MessageBox.Show("Kritično niske zalihe proizvoda \"" + textbox1.Text + "\"! Automatsko naručivanje 50 komada navedenog proizvoda!", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    string sql = "INSERT INTO \"Otpremnica_detalji\" (\"ID_otpremnica\", \"ID_proizvod\", količina) VALUES (" + vrijednostIdOtpremnica + ", " + vrijednostIdProizvod + ", " + Convert.ToInt32(textbox2.Text) + ")";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
            
                    ds.Reset();
                    da.Fill(ds);

                    MessageBox.Show("Uspješno dodan proizvod na otpremnicu br." + vrijednostIdOtpremnica + "!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sumaUkupno += float.Parse(textbox4.Text);

                }
                catch (PostgresException msg)
                {
                    MessageBox.Show(msg.MessageText, "Upozorenje");
                }

                textbox1.Text = "";
                textbox2.Text = "";
                textbox3.Text = "";
                textbox4.Text = "";

            }
            else
            {
                MessageBox.Show("Morate prvo stvoriti prazan predložak otpremnice!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrazna_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li stvoriti prazan predložak otpremnice?", "Novi predložak", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = "INSERT INTO \"Otpremnica\" (datum_nastanka) VALUES (date_trunc('second'::text, CURRENT_TIMESTAMP))";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                    ds.Reset();
                    da.Fill(ds);


                    NpgsqlDataReader reader;
                    NpgsqlCommand read_command = new NpgsqlCommand("SELECT \"ID_otpremnica\" FROM \"Otpremnica\" ORDER BY \"ID_otpremnica\" DESC LIMIT 1", konekcija.conn);
                    reader = read_command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            vrijednostIdOtpremnica = reader.GetInt32(0).ToString();
                            reader.Close();
                        }
                    }
                    stvorenPredlozak = true;
                }
                catch (PostgresException msg)
                {
                    MessageBox.Show(msg.MessageText, "Upozorenje");
                }

            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (stvorenPredlozak == true)
            {
                if (MessageBox.Show("Želite li potvrditi sadržaj otpremnice br. " + vrijednostIdOtpremnica + "?", "Završi narudžbenicu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "UPDATE \"Otpremnica\" SET ukupan_iznos =" + sumaUkupno + " WHERE \"ID_otpremnica\" = " + vrijednostIdOtpremnica + "";
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                        ds.Reset();
                        da.Fill(ds);

                    }
                    catch (PostgresException msg)
                    {
                        MessageBox.Show(msg.MessageText, "Upozorenje");
                    }

                }
            }
            else
            {
                MessageBox.Show("Morate prvo stvoriti prazan predložak narudžbenice!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formNovaOtpremnica_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
        }

        private void btnPopisProizvoda_Click(object sender, EventArgs e)
        {
            formPopisProizvoda popis = new formPopisProizvoda();
            popis.Show();
        }
    }
}
