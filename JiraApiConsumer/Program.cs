using System;
using System.Net.Http;
using System.Threading.Tasks;
using JiraApiConsumer.Models;

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

            // Basic Auth
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();
            ApiConsumer apiConsumer = new ApiConsumer("https://testingvso.atlassian.net/", username, password);

            try
            {
                Console.WriteLine("------------ Projects:  ");
                Projects projects = new Projects { };
                projects = await apiConsumer.GetProjects();
                Projects.Show(projects);

                Console.WriteLine("------------ Boards:  ");
                Boards boards = new Boards { };
                boards = await apiConsumer.GetBoards();
                Boards.Show(boards);

                Console.WriteLine("------------ Board 1:  ");
                Board board = new Board { };
                board = await apiConsumer.GetBoard("1");
                Board.Show(board);

                Console.WriteLine("------------ Current User:  ");
                User user = new User { };
                user = await apiConsumer.GetCurrentUser();
                User.Show(user);

                Console.WriteLine("------------ All Users:  ");
                User[] users = null;
                users = await apiConsumer.GetUsers();
                foreach (var i in users) {
                    User.Show(i);
                }

                Console.WriteLine("------------ Workflows:  ");
                WorkFlow[] workflows = null;
                workflows = await apiConsumer.GetWorkFlows();
                foreach (var i in workflows)
                {
                    WorkFlow.Show(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
