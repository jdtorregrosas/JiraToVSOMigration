using JiraApiConsumer.Clients;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Threading.Tasks;
using JiraApiConsumer.Models.Jira;
using JiraApiConsumer.Models;
using System.Threading;

namespace JiraApiConsumer.Views
{
    public partial class Mainmenu : Form
    {
        string jiraUrl;
        string jiraUsername;
        string jiraPassword;
        string vsoUrl;
        string vsoUsername;
        string vsoPassword;
        int totalProgress = 100;
        int totalProcesses = 0;
        int completedProcesses = 0;
        JiraApi jiraClient;
        VSOApi vsoClient;
        MigrationHelper migration;
        public Mainmenu()
        {
            InitializeComponent();

            jiraUrl = ConfigurationManager.AppSettings["jiraUrl"];
            jiraUsername = ConfigurationManager.AppSettings["jiraUsername"];
            jiraPassword = ConfigurationManager.AppSettings["jiraPassword"];

            vsoUrl = ConfigurationManager.AppSettings["vsoUrl"];
            vsoUsername = ConfigurationManager.AppSettings["vsoUsername"];
            vsoPassword = ConfigurationManager.AppSettings["vsoPassword"];
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            (new Config()).Show();
        }

        private async void btnStartMigration_Click(object sender, EventArgs e)
        {
            completedProcesses = 0;
            progressBarMigration.Value = 0;
            progressBarMigration.Show();
            progressBarMigration.Maximum = totalProcesses;
            lblInfo.Hide();
            lblInfo.Text = "";
            txtDetails.Text = "";

            
            lblInfo.Show();
            lblDetails.Show();

            jiraClient = new JiraApi(jiraUrl, jiraUsername, jiraPassword);
            vsoClient = new VSOApi(vsoUrl, vsoUsername, vsoPassword);
            migration = new MigrationHelper(jiraClient, vsoClient);
            if (cbProjects.Checked) {
                lblInfo.Text = "Migrating projects...";
                txtDetails.Text += await migration.MigrateProjects();
                progressBarMigration.Value++;
            }
            if (cbSprints.Checked)
            {
                lblInfo.Text = "Migrating sprints...";
                txtDetails.Text +=  await migration.MigrateSprints();
                progressBarMigration.Value++;
            }
            if (cbStories.Checked)
            {
                lblInfo.Text = "Migrating stories...";
                txtDetails.Text += await migration.MigrateStories();
                progressBarMigration.Value++;
            }
            if (cbSprintStories.Checked) {
                lblInfo.Text = "Migrating sprint stories...";
                txtDetails.Text += await migration.MigrateSprintsStories();
                progressBarMigration.Value++;
            }
            if (totalProcesses == 0)
            {
                lblInfo.Text = "Nothing to Migrate";
            }
            if (totalProcesses == progressBarMigration.Value && totalProcesses != 0)
            {
                lblInfo.Text = "Migration Finished, see details >>";
            }
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {
            this.Width = 455;
        }
        
        private void lblDetails_Click(object sender, EventArgs e)
        {
            if (lblDetails.Text == "Show details >>")
            {
                lblDetails.Text = "Hide details <<";
                this.Width = 864;
            }
            else if (lblDetails.Text == "Hide details <<")
            {
                lblDetails.Text = "Show details >>";
                this.Width = 455;
            }
        }

        private void cbProjects_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProjects.Checked)
            {
                totalProcesses++;
            }
            else
            {
                totalProcesses--;
            }
        }

        private void cbSprints_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSprints.Checked)
            {
                totalProcesses++;
            }
            else
            {
                totalProcesses--;
            }
        }

        private void cbSprintStories_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSprintStories.Checked)
            {
                totalProcesses++;
            }
            else
            {
                totalProcesses--;
            }
        }

        private void cbStories_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStories.Checked)
            {
                totalProcesses++;
            }
            else
            {
                totalProcesses--;
            }
        }
    }
}
