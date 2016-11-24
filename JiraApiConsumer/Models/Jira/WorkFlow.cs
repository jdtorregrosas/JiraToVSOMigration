using Newtonsoft.Json;
using System;


namespace JiraApiConsumer.Models.Jira
{
    /// <summary>
    /// WorkFlow model from Jira Api
    /// </summary>
    class WorkFlow
    {
        public string name { get; set; }
        public string description { get; set; }
        public int steps { get; set; }
        [JsonProperty(PropertyName = "default")]
        public bool default_wf { get; set; }

        public static void Show(WorkFlow wf)
        {
            string valuesStr = "";
            valuesStr += $"(\nname: {wf.name}, \ndescription: {wf.description}, \nsteps: {wf.steps}, \ndefault: {wf.default_wf}\n)";
            Console.WriteLine(valuesStr);
        }
    }
}
