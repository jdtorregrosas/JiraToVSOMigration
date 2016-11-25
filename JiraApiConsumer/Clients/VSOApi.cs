using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using JiraApiConsumer.Models.Vso;
using System.Threading.Tasks;
using JiraApiConsumer.Models;
using Newtonsoft.Json;

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

        public async Task<Response> createProject(Project project)
        {
            bool success = false;
            string responseBody = "";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.PostAsJsonAsync("defaultcollection/_apis/projects?api-version=1.0", project);
            
            if (response.IsSuccessStatusCode)
            {
                responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                success = true;
                return new Response(responseBody, success);
            } else
            {
                responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                success = false;
                return new Response(responseBody, success);
            }
        }

        //TODO creating iterations

        public async Task<Response> createIteration(Project project, Iteration iteration)
        {
            bool success = false;
            string responseBody = "";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.PostAsJsonAsync($"DefaultCollection/{project.name}/_apis/wit/classificationNodes/iterations?api-version=1.0", project);

            if (response.IsSuccessStatusCode)
            {
                string responseBody2 = "";
                responseBody = await response.Content.ReadAsStringAsync();
                var jsonProject = JsonConvert.DeserializeObject(responseBody);

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response2 = await client.PostAsJsonAsync($"DefaultCollection/{project.name}/_apis/work/teamsettings/iterations?api-version=v2.0-preview", project);
                if (response2.IsSuccessStatusCode)
                {
                    responseBody2 = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody2);
                    success = true;
                    return new Response(responseBody2, success);
                }
                else
                {
                    responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                    success = false;
                    return new Response(responseBody, success);
                }
            }
            else
            {
                responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                success = false;
                return new Response(responseBody, success);
            }
        }
    }
    
}
