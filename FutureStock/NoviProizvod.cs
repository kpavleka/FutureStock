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
    public partial class formNoviProizvod : Form
    {
        bool ostaviOtvorenu;
        string vrijednost;
        string vrijednost2;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();
        public formNoviProizvod()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEntiteti entiteti = new formEntiteti();
            entiteti.ShowDialog();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
            try
            {               
                NpgsqlDataReader reader;
                NpgsqlCommand read_command = new NpgsqlCommand("SELECT \"ID_kategorija\" FROM \"Kategorija\" WHERE naziv = '" + textbox3.Text + "'", konekcija.conn);
                reader = read_command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        vrijednost = reader.GetInt32(0).ToString();
                        reader.Close();
                        ostaviOtvorenu = true;
                    }
                }
                else
                {
                    reader.Close();
                    ostaviOtvorenu = false;
                    MessageBox.Show("Kategorija " + textbox3.Text + " ne postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);                 
                }
               
                NpgsqlDataReader reader2;
                NpgsqlCommand read_command2 = new NpgsqlCommand("SELECT \"ID_dobavljač\" FROM \"Dobavljač\" WHERE naziv = '" + textbox4.Text + "'", konekcija.conn);
                reader2 = read_command2.ExecuteReader();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        vrijednost2 = reader2.GetInt32(0).ToString();
                        reader2.Close();
                        ostaviOtvorenu = true;
                    }
                }
                else
                {
                    reader2.Close();
                    ostaviOtvorenu = false;
                    MessageBox.Show("Dobavljač " + textbox4.Text + " ne postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (ostaviOtvorenu == true)
                {
                    string sql = "INSERT INTO \"Proizvod\" (naziv, cijena, \"ID_kategorija\", \"ID_dobavljač\") VALUES ('" + textbox1.Text + "', '" + textbox2.Text + "', '" + vrijednost + "', '" + vrijednost2 + "')";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, konekcija.conn);
                    ds.Reset();
                    da.Fill(ds);

                    this.Hide();
                    formEntiteti entiteti = new formEntiteti();
                    entiteti.ShowDialog();
                }
                
            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }

        }
    }
}
