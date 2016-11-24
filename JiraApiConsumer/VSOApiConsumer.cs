using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JiraApiConsumer.Models;

namespace JiraApiConsumer
{
    class VSOApiConsumer
    {
        HttpClient client = new HttpClient();
        string url = "";
        string username = "";
        string password = "";
        public VSOApiConsumer(string url, string username, string password)
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
    }
}
