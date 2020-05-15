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
    public partial class formStatistika : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Konekcija konekcija = new Konekcija();
        public formStatistika()
        {
            InitializeComponent();
        }

        private void formStatistika_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();           
            try
            {
                string sql = "SELECT \"Proizvod\".naziv, \"Skladište\".količina FROM \"Proizvod\" JOIN \"Skladište\" ON \"Skladište\".\"ID_proizvod\" = \"Proizvod\".\"ID_proizvod\"";
                NpgsqlDataAdapter adapter0 = new NpgsqlDataAdapter(sql, konekcija.conn);
                adapter0.Fill(ds);
                graf.DataSource = ds.Tables[0];
                graf.Titles.Add("Odnos proizvoda na skladištu");
                graf.Series[0].XValueMember = "naziv";
                graf.Series[0].YValueMembers = "količina";
                graf.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                graf.DataBind();

            }
            catch (PostgresException msg)
            {
                MessageBox.Show(msg.MessageText, "Upozorenje");
            }
            
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDashboard dashboard = new formDashboard();
            dashboard.ShowDialog();
        }
       
    }
}
