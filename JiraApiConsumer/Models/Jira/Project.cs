using Newtonsoft.Json;
using System;

namespace JiraApiConsumer.Models.Jira
{
    public class Project
    {
        public class MyAvatars
        {
            [JsonProperty(PropertyName = "48x48")]
            public string x48 { get; set; }
            [JsonProperty(PropertyName = "24x24")]
            public string x24 { get; set; }
            [JsonProperty(PropertyName = "16x16")]
            public string x16 { get; set; }
            [JsonProperty(PropertyName = "32x32")]
            public string x32 { get; set; }
        }
        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public MyAvatars avatarUrls { get; set; }

        public static void Show(Project project)
        {
            string valuesStr = "";
            valuesStr += $"(\nself: {project.self}, \nid: {project.id}, \nkey: {project.key}, \nname: {project.name}, \navatarUrls: \n\t48x48: {project.avatarUrls.x48} \n\t24x24: {project.avatarUrls.x24} \n\t16x16: {project.avatarUrls.x16} \n\t32x32: {project.avatarUrls.x32}\n)";
            Console.WriteLine(valuesStr);
        }
    }

    public class Projects
    {
        //public int maxResults { get; set; }
        //public int startAt { get; set; }
        //public int total { get; set; }
        //public bool isLast { get; set; }
        public Project[] values { get; set; }

        public static void Show(Projects projects)
        {
            string valuesStr = "";
            for (int i = 0; i < projects.values.Length; i++)
            {
                valuesStr += $"(\nself: {projects.values[i].self}, \nid: {projects.values[i].id}, \nkey: {projects.values[i].key}, \nname: {projects.values[i].name}, \navatarUrls: \n\t48x48: {projects.values[i].avatarUrls.x48} \n\t24x24: {projects.values[i].avatarUrls.x24} \n\t16x16: {projects.values[i].avatarUrls.x16} \n\t32x32: {projects.values[i].avatarUrls.x32}\n)";
            }
            Console.WriteLine(valuesStr);
        }

    }

    
}