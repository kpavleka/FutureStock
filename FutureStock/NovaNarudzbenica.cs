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
    public partial class formNovaNarudzbenica : Form
    {
        bool stvorenPredlozak;
        string vrijednost;
        string vrijednostIdNarudzbenica;
        string vrijednostIdProizvod;
        float sumaUkupno;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();

        public formNovaNarudzbenica()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEntiteti entiteti = new formEntiteti();
            entiteti.ShowDialog();
        }


        private void formNovaNarudzbenica_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
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
                try
                {
                    string sql = "INSERT INTO \"Narudžbenica_detalji\" (\"ID_narudžbenica\", \"ID_proizvod\", količina) VALUES (" + vrijednostIdNarudzbenica + ", " + vrijednostIdProizvod + ", " + Convert.ToInt32(textbox2.Text) + ")";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                    ds.Reset();
                    da.Fill(ds);

                    MessageBox.Show("Uspješno dodan proizvod na narudžbenicu br." + vrijednostIdNarudzbenica + "!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sumaUkupno += float.Parse(textbox4.Text);
                    textbox1.Text = "";
                    textbox2.Text = "";
                    textbox3.Text = "";
                    textbox4.Text = "";
                }
                catch (PostgresException msg)
                {
                    MessageBox.Show(msg.MessageText, "Upozorenje");
                }

            }
            else
            {
                MessageBox.Show("Morate prvo stvoriti prazan predložak narudžbenice!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrazna_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Želite li stvoriti prazan predložak narudžbenice?", "Novi predložak", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = "INSERT INTO \"Narudžbenica\" (datum_nastanka) VALUES (date_trunc('second'::text, CURRENT_TIMESTAMP))";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                    ds.Reset();
                    da.Fill(ds);


                    NpgsqlDataReader reader;
                    NpgsqlCommand read_command = new NpgsqlCommand("SELECT \"ID_narudžbenica\" FROM \"Narudžbenica\" ORDER BY \"ID_narudžbenica\" DESC LIMIT 1", konekcija.conn);
                    reader = read_command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            vrijednostIdNarudzbenica = reader.GetInt32(0).ToString();
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
                if (MessageBox.Show("Želite li potvrditi sadržaj narudžbenice br. " + vrijednostIdNarudzbenica + "?", "Završi narudžbenicu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "UPDATE \"Narudžbenica\" SET ukupan_iznos =" + sumaUkupno + " WHERE \"ID_narudžbenica\" = " + vrijednostIdNarudzbenica + "";
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

        private void btnPopisProizvoda_Click(object sender, EventArgs e)
        {
            formPopisProizvoda popis = new formPopisProizvoda();
            popis.Show();
        }
    }
}