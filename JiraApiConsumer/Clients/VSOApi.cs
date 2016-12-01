using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using JiraApiConsumer.Models.Vso;
using System.Threading.Tasks;
using JiraApiConsumer.Models;
using Newtonsoft.Json;
using System.Threading;
using System.Collections.Generic;
using System.Text;

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
                Thread.Sleep(4000);
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
            var response = await client.PostAsJsonAsync($"DefaultCollection/{project.name}/_apis/wit/classificationNodes/iterations?api-version=1.0", iteration);

            if (response.IsSuccessStatusCode)
            {
                responseBody = await response.Content.ReadAsStringAsync();
                var responseJson = JsonConvert.DeserializeObject<IterationNode>(responseBody);

                string responseBody2 = "";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var body = new { id = responseJson.identifier };
                var response2 = await client.PostAsJsonAsync($"DefaultCollection/{project.name}/_apis/work/teamsettings/iterations?api-version=v2.0-preview", body);
                if (response2.IsSuccessStatusCode)
                {
                    responseBody2 = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody2);
                    success = true;
                    return new Response(responseBody2, success);
                }
                else
                {
                    responseBody = await response2.Content.ReadAsStringAsync();
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

        public async Task<Response> createIterationWorkItem(Project project, Iteration iteration, string wiTitle)
        {
            bool success = false;
            string responseBody = "";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json-patch+json"));

            List<WorkItemProperty> workItemProperties = new List<WorkItemProperty>();
            WorkItemProperty title = new WorkItemProperty("/fields/System.Title", wiTitle);
            WorkItemProperty iterationPath = new WorkItemProperty("/fields/System.IterationPath", $"{project.name}\\\\{iteration.name}");
            workItemProperties.Add(title);
            workItemProperties.Add(iterationPath);

            var response = await client.PatchAsJsonAsync($"DefaultCollection/{project.name}/_apis/wit/workitems/$User Story?api-version=1.0", workItemProperties);

            if (response.IsSuccessStatusCode)
            {
                responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                success = true;
                return new Response(responseBody, success);
            }
            else
            {
                responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                success = false;
                return new Response(responseBody, success);
            }
        }

        public async Task<Response> createWorkItem(Project project, WorkItem workItem)
        {
            bool success = false;
            string responseBody = "";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json-patch+json"));

            List<WorkItemProperty> workItemProperties = new List<WorkItemProperty>();
            WorkItemProperty title = new WorkItemProperty("/fields/System.Title", workItem.title);
            WorkItemProperty description = new WorkItemProperty("/fields/System.Description", workItem.description);
            WorkItemProperty status = new WorkItemProperty("/fields/System.State", workItem.status);
            WorkItemProperty reason = new WorkItemProperty("/fields/System.Reason", workItem.reason);
            workItemProperties.Add(title);
            if(workItem.status != "") {
                workItemProperties.Add(status);
                workItemProperties.Add(reason);
            }
            if (workItem.description != null)
            {
                workItemProperties.Add(description);
            }
            var response = await client.PatchAsJsonAsync($"DefaultCollection/{project.name}/_apis/wit/workitems/${workItem.type}?api-version=1.0", workItemProperties);

            if (response.IsSuccessStatusCode)
            {
                responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                success = true;
                return new Response(responseBody, success);
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

    public static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> PatchAsJsonAsync(this HttpClient client, string requestUri, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json-patch+json");

            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, client.BaseAddress + requestUri)
            {
                Content = httpContent
            };

            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                response = await client.SendAsync(request);
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
            }

            return response;
        }
    }

}
