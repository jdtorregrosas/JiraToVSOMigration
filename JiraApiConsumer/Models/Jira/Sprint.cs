using System;

namespace JiraApiConsumer.Models.Jira
{
    class Sprint
    {
        public struct ProjectAttr
        {
            string key { get; set; }
            string name { get; set; }
        }
        public int id { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string name { get; set; }
        public bool closed { get; set; }
        public bool editable { get; set; }
        public ProjectAttr[] projects { get; set; }

        public static void Show(Sprint sprint)
        {
            string valuesStr = "";
            valuesStr += $"(\nid: {sprint.id}, \nstart: {sprint.start}, \nend: {sprint.end}, \nname: {sprint.name}\n)";
            Console.WriteLine(valuesStr);
        }
    }

    class Sprints
    {
        public Sprint[] sprints { get; set; }

        public static void Show(Sprints sprints) {
            if (sprints.sprints != null)
            {
                foreach (var i in sprints.sprints)
                {
                    Sprint.Show(i);
                }
            }
        }
    }
}
