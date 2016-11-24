using System;

namespace JiraApiConsumer.Models.Jira
{
    class Sprint
    {
        //public int id { get; set; }
        //public string start { get; set; }
        //public string end { get; set; }
        //public string name { get; set; }
        //public bool closed { get; set; }
        //public bool editable { get; set; }
        //public ProjectsAttr projects { get; set; }

        public static void Show(Sprint sprint)
        {
            //string valuesStr = "";
            //valuesStr += $"(\nid: {sprint.id}, \nself: {sprint.self}, \nstate: {sprint.state}, \nstartDate: {sprint.startDate}, \nendDate: {sprint.endDate}, \noriginBoardId: {sprint.originBoardId}, \ngoal: {sprint.goal}\n)";
            //Console.WriteLine(valuesStr);
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
