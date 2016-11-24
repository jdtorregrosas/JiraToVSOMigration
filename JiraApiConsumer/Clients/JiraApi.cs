using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JiraApiConsumer.Models.Jira;
// using JiraApiConsumer.Models.Vso;

namespace JiraApiConsumer.Clients
{
    class JiraApi
    {
        HttpClient client = new HttpClient();
        string url = "";
        string username = "";
        string password = "";
        public JiraApi(string url, string username, string password) {
            this.url = url;
            this.username = username;
            this.password = password;
            ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var authByteArray = System.Text.Encoding.ASCII.GetBytes($"{username}:{password}");
            var authString = Convert.ToBase64String(authByteArray);
            // var authString = "anVsaWFudDo2OVdhbHB1cmdpc05hY2h0Njk=";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authString);

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

        public async Task<Issues> GetBoardBacklog(string boardId)
        {
            Issues issues = null;
            var response = await client.GetAsync($"/rest/agile/1.0/board/{boardId}/backlog");
            if (response.IsSuccessStatusCode)
            {
                issues = await response.Content.ReadAsAsync<Issues>();
            }
            return issues;
        }

        public async Task<Issues> GetBoardIssues(string boardId)
        {
            Issues issues = null;

            var response = await client.GetAsync($"rest/agile/1.0/board/{boardId}/issue");
            if (response.IsSuccessStatusCode)
            {
                issues = await response.Content.ReadAsAsync<Issues>();
            }
            return issues;
        }

        public async Task<Sprints> GetBoardSprints(string boardId)
        {
            Sprints sprints = null;

            var response = await client.GetAsync($"/rest/agile/1.0/board/{boardId}/sprint");
            if (response.IsSuccessStatusCode)
            {
                sprints = await response.Content.ReadAsAsync<Sprints>();
            }
            return sprints;
        }

        public async Task<Projects> GetBoardProjects(string boardId)
        {
            Projects product = null;
            var response = await client.GetAsync($"rest/agile/1.0/board/{boardId}/project");
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Projects>();
            }
            return product;
        }

        public async Task<Permissions> GetPermissions()
        {
            Permissions permissions = null;

            var response = await client.GetAsync($"rest/api/2/mypermissions");
            if (response.IsSuccessStatusCode)
            {
                permissions = await response.Content.ReadAsAsync<Permissions>();
            }
            return permissions;
        }

        public async Task<User> GetCurrentUser()
        {
            User user = null;

            var response = await client.GetAsync("rest/api/2/myself");
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }
            return user;
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

        public async Task<Issues> GetProjectIssues(string projectId)
        {
            Issues issues = null;

            var response = await client.GetAsync($"rest/api/2/search?jql=project={projectId}");
            if (response.IsSuccessStatusCode)
            {
                issues = await response.Content.ReadAsAsync<Issues>();
            }
            return issues;
        }
    }
}
