using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiraApiConsumer.Views
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            (new Config()).Show();
        }

        private void btnStartMigration_Click(object sender, EventArgs e)
        {
            progressBarMigration.Show();
            progressBarMigration.Maximum = 100;
            for (int i = 0; i < 50; i++) {
                progressBarMigration.Value += 2;
            }
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
