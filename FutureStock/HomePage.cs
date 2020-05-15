using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureStock
{
    public partial class formHomePage : Form
    {
        Konekcija konekcija = new Konekcija();
        public formHomePage()
        {
            InitializeComponent();
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDashboard dashboard = new formDashboard();
            dashboard.ShowDialog();
        }

        private void formHomePage_Load(object sender, EventArgs e)
        {
            konekcija.OtvoriVezu();
        }

    }
}
