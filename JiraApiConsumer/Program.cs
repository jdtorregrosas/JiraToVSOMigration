using System;
using System.Net.Http;
using System.Threading.Tasks;
using JiraApiConsumer.Models.Jira;
using JiraApiConsumer.Models.Vso;
using JiraApiConsumer.Clients;
using System.Configuration;

namespace JiraApiConsumer
{
    public class Program
    {
        static HttpClient client = new HttpClient();
        static void Main()
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            string jiraUrl = ConfigurationManager.AppSettings["jiraUrl"];
            string jiraUsername = ConfigurationManager.AppSettings["jiraUsername"];
            string jiraPassword = ConfigurationManager.AppSettings["jiraPassword"];

            string vsoUrl = ConfigurationManager.AppSettings["vsoUrl"];
            string vsoUsername = ConfigurationManager.AppSettings["vsoUsername"];
            string vsoPassword = ConfigurationManager.AppSettings["vsoPassword"];
            // Basic Auth
            JiraApi apiConsumer = new JiraApi(jiraUrl, jiraUsername, jiraPassword);
            VSOApi vsoApiConsumer = new VSOApi(vsoUrl, vsoUsername, vsoPassword);

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

                Console.WriteLine("------------ Projects from board 1:  ");
                Models.Jira.Project[] projects = null;
                projects = await apiConsumer.GetProjects();
                foreach (var i in projects)
                {
                    Models.Jira.Project.Show(i);
                }

                Console.WriteLine("------------ Sprints from Project 10000:  ");
                Sprints sprints = null;
                sprints = await apiConsumer.GetProjectSprints("10000");
                Sprints.Show(sprints);

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
                //vsoApiConsumer.createProject(new Models.Vso.Project("Fager Prject!", "project 2", "Git", "6b724908-ef14-45cf-84f8-768b5384da45"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
