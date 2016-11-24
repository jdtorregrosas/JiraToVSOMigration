using System;

namespace JiraApiConsumer.Models.Jira
{
    /// <summary>
    /// Issue Model from Jira API
    /// </summary>
    class Issue
    {
        public class IssueType
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public bool subtask { get; set; }
            public int avatarId{ get; set; }
        }
        public class Fields
        {
            public IssueType issuetype { get; set; }
            public Project project { get; set; }
            public string timespent { get; set; }
            public string lastViewed { get; set; }
            public string created { get; set; }
            public string updated { get; set; }
            public User assignee { get; set; }
            public string description { get; set; }
            public string summary { get; set; }
            public User creator { get; set; }
            public User reporter { get; set; }
        }
        public string id { get; set; }
        public string self { get; set; }
        public string key { get; set; }
        public Fields fields { get; set; }

        public static void Show(Issue issue)
        {
            string valuesStr = "";
            valuesStr += $"(\nid: {issue.id}, \nself: {issue.self}, \nkey: {issue.key}, \nfields:\n\tissuetype: {issue}, \n\tissuetype: {issue.fields.issuetype.name}, \n\tproject: {issue.fields.project.name}, \n\ttimespent: {issue.fields.timespent}, \n\tlastViewed: {issue.fields.lastViewed}, \n\tcreated: {issue.fields.updated}, \n\tassignee: , \n\tdescription: {issue.fields.description}\n)";
            Console.WriteLine(valuesStr);
        }
    }
    class Issues
    {
        public Issue[] issues { get; set; }
        public static void Show(Issues issues)
        {
            foreach (var i in issues.issues)
            {
                Issue.Show(i);
            }
        }
    }
}
