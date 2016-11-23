using System;
using System.Net.Http;
using System.Threading.Tasks;

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
            ApiConsumer apiConsumer = new ApiConsumer("http://testingvso.atlassian.net/", username, password);

            try
            {
                Projects projects = new Projects { };
                Boards boards = new Boards { };
                Board board = new Board { };
                projects = await apiConsumer.GetProjects();
                boards = await apiConsumer.GetBoards();
                board = await apiConsumer.GetBoard("1");
                Projects.Show(projects);
                Boards.Show(boards);
                Board.Show(board);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
