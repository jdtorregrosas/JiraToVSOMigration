using JiraApiConsumer.Clients;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Threading.Tasks;
using JiraApiConsumer.Models.Jira;
using JiraApiConsumer.Models;

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
        int totalProccesses = 0;
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

        private void btnStartMigration_Click(object sender, EventArgs e)
        {
            progressBarMigration.Value = 0;
            progressBarMigration.Show();
            progressBarMigration.Maximum = totalProgress;

            JiraApi jiraClient = new JiraApi(jiraUrl, jiraUsername, jiraPassword);
            VSOApi vsoClient = new VSOApi(vsoUrl, vsoUsername, vsoPassword);
            if (cbProjects.Checked) {
                var migrateProjects = MigrateProjects(jiraClient, vsoClient);
                Task.WhenAll(migrateProjects);
            }
            lblInfo.Hide();
            lblInfo.Text = "";
            txtDetails.Text = "";

            //for (int i = 0; i < 50; i++) {

            //    progressBarMigration.Value += 1;
            //}
            
            if (totalProccesses == 0)
            {
                lblInfo.Text = "Nothing to Migrate";
            }
            lblInfo.Show();
            lblDetails.Show();
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

        private async Task MigrateProjects(JiraApi jiraClient, VSOApi vsoClient)
        {
            Console.WriteLine("------------ Projects from board 1:  ");
            Models.Jira.Project[] projects = null;
            projects = await jiraClient.GetProjects();
            int migratedProjects = 0;
            foreach (var i in projects)
            {
                Models.Jira.Project.Show(i);
                Response response = await vsoClient.createProject(new Models.Vso.Project(i.name, i.description, "Git", "6b724908-ef14-45cf-84f8-768b5384da45"));
                if (response.success)
                {
                    migratedProjects++;
                }
                response.message = "Migrated Projects:" + migratedProjects + "/" + projects.Length;
                showResponse(response);
            }
        }
        private void showResponse(Response response) {
            if (response.success)
            {
                progressBarMigration.Value = totalProgress / totalProccesses;
                txtDetails.Text += "\n\r   (Success: )  " + response.message + "\n\r";
            }
            else
            {
                progressBarMigration.Value = totalProgress / (2 * totalProccesses);
                txtDetails.Text += "\n\r   (ERROR: )  " + response.message + "\n\r";
                lblInfo.Text ="Migration Error!";
            }
            if (progressBarMigration.Value == totalProgress)
            {
                lblInfo.Text = "Migration Successful";
            }
        }
        static async Task RunAsync()
        {

            try
            {
                //Console.WriteLine("------------ Boards:  ");
                //Boards boards = new Boards { };
                //boards = await apiConsumer.GetBoards();
                //Boards.Show(boards);

                //Console.WriteLine("------------ Board 1:  ");
                //Board board = new Board { };
                //board = await apiConsumer.GetBoard("1");
                //Board.Show(board);

                //Console.WriteLine("------------ Board 1 Backlog:  ");
                //Issues backlog = new Issues { };
                //backlog = await apiConsumer.GetBoardBacklog("1");
                //Issues.Show(backlog);

                //Console.WriteLine("------------ Board 1 Issues:  ");
                //Issues boardIssues = new Issues { };
                //boardIssues = await apiConsumer.GetBoardIssues("1");
                //Issues.Show(boardIssues);

                //Console.WriteLine("------------ Board 1 Sprints:  ");
                //Sprints sprints = null;
                //sprints = await apiConsumer.GetBoardSprints("1");
                //Sprints.Show(sprints);



                //Console.WriteLine("------------ Sprints from Project 10000:  ");
                //Sprints sprints = null;
                //sprints = await apiConsumer.GetProjectSprints("10000");
                //Sprints.Show(sprints);

                //Console.WriteLine("------------ Current User:  ");
                //User user = new User { };
                //user = await apiConsumer.GetCurrentUser();
                //User.Show(user);

                //Console.WriteLine("------------ All Users:  ");
                //User[] users = null;
                //users = await apiConsumer.GetUsers();
                //foreach (var i in users)
                //{
                //    User.Show(i);
                //}

                //Console.WriteLine("------------ Workflows:  ");
                //WorkFlow[] workflows = null;
                //workflows = await apiConsumer.GetWorkFlows();
                //foreach (var i in workflows)
                //{
                //    WorkFlow.Show(i);
                //}

                //Console.WriteLine("------------ Issues:  ");
                //Issues issues = null;
                //issues = await apiConsumer.GetProjectIssues("10000");
                //Issues.Show(issues);

                //Console.WriteLine("------------ Permissions:  ");
                //Permissions permissions = null;
                //permissions = await apiConsumer.GetPermissions();
                //Permissions.Show(permissions);

                
                //vsoApiConsumer.getProjects();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }

        private void cbProjects_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProjects.Checked)
            {
                totalProccesses++;
            }
            else {
                totalProccesses--;
            }
        }
    }
}
