using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JiraApiConsumer.Models;

namespace JiraApiConsumer
{
    class ApiConsumer
    {
        HttpClient client = new HttpClient();
        string url = "";
        string username = "";
        string password = "";
        public ApiConsumer(string url, string username, string password) {
            this.url = url;
            this.username = username;
            this.password = password;
            ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var authByteArray = System.Text.Encoding.ASCII.GetBytes($"{username}:{password}");
            //var authString = Convert.ToBase64String(authByteArray);
            var authString = "anVsaWFudDo2OVdhbHB1cmdpc05hY2h0Njk=";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authString);

        }

        public async Task<User[]> GetUsers()
        {
            User[] users = null;

            var response = await client.GetAsync("rest/api/2/user/search?username=%");
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsAsync<User[]>();
            }
            return users;
        }

        public async Task<User> GetCurrentUser()
        {
            User user= null;

            var response = await client.GetAsync("rest/api/2/myself");
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }
            return user;
        }

        public async Task<Board> GetBoard(string id)
        {
            Board board = null;

            var response = await client.GetAsync($"rest/agile/1.0/board/{id}");
            if (response.IsSuccessStatusCode)
            {
                board = await response.Content.ReadAsAsync<Board>();
            }
            return board;
        }

        public async Task<Projects> GetProjects()
        {
            Projects product = null;
            var response = await client.GetAsync("rest/agile/1.0/board/1/project");
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Projects>();
            }
            return product;
        }

        public async Task<Boards> GetBoards()
        {
            Boards board = null;
            var response = await client.GetAsync("rest/agile/1.0/board");
            if (response.IsSuccessStatusCode)
            {
                board = await response.Content.ReadAsAsync<Boards>();
            }
            return board;
        }

        public async Task<WorkFlow[]> GetWorkFlows()
        {
            WorkFlow[] wf = null;

            var response = await client.GetAsync("rest/api/2/workflow");
            if (response.IsSuccessStatusCode)
            {
                wf = await response.Content.ReadAsAsync<WorkFlow[]>();
            }
            return wf;
        }

        public async Task<Issues> GetIssues()
        {
            Issues issues = null;

            var response = await client.GetAsync("rest/api/2/search?jql=project=10000");
            if (response.IsSuccessStatusCode)
            {
                issues = await response.Content.ReadAsAsync<Issues>();
            }
            return issues;
        }
    }
}
