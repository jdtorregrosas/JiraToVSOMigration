using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace JiraApiConsumer.Views
{
    public partial class Config : Form
    {
        string jiraUrl;
        string jiraUsername;
        string jiraPassword;
        string vsoUrl;
        string vsoUsername;
        string vsoPassword;

        public Config()
        {
            InitializeComponent();
        }
        

        private void Config_Load(object sender, EventArgs e)
        {
            jiraUrl = ConfigurationManager.AppSettings["jiraUrl"];
            jiraUsername = ConfigurationManager.AppSettings["jiraUsername"];
            jiraPassword = ConfigurationManager.AppSettings["jiraPassword"];

            vsoUrl = ConfigurationManager.AppSettings["vsoUrl"];
            vsoUsername = ConfigurationManager.AppSettings["vsoUsername"];
            vsoPassword = ConfigurationManager.AppSettings["vsoPassword"];

            txtJiraUrl.Text = jiraUrl;
            txtJiraUsername.Text = jiraUsername;
            txtJiraPwd.Text = jiraPassword;

            txtVsoUrl.Text = vsoUrl;
            txtVsoUsername.Text = vsoUsername;
            txtVsoPwd.Text = vsoPassword;


        }

        private void btnApplyConfig_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["jiraUrl"].Value = txtJiraUrl.Text;
            config.AppSettings.Settings["jiraUsername"].Value = txtJiraUsername.Text;
            config.AppSettings.Settings["jiraPassword"].Value = txtJiraPwd.Text;
            config.AppSettings.Settings["vsoUrl"].Value = txtVsoUrl.Text;
            config.AppSettings.Settings["vsoUsername"].Value = txtVsoUsername.Text;
            config.AppSettings.Settings["vsoPassword"].Value = txtVsoPwd.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Console.WriteLine("Config Saved!");
            this.Hide();
        }
    }
}
