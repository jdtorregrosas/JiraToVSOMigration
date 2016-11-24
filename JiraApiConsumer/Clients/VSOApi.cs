using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using JiraApiConsumer.Models.Vso;


namespace JiraApiConsumer.Clients
{
    class VSOApi
    {
        HttpClient client = new HttpClient();
        string url = "";
        string username = "";
        string password = "";
        public VSOApi(string url, string username, string password)
        {
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

        public async void getProjects() {
            var response = await client.GetAsync("DefaultCollection/_apis/projects?api-version=1.0");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
        }

        public async void createProject(Project project)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.PostAsJsonAsync("defaultcollection/_apis/projects?api-version=1.0", project);
            
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            } else
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
        }
    }
}
