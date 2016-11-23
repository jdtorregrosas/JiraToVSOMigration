using System;

namespace JiraApiConsumer.Models
{
    class Sprint
    {
        public int id { get; set; }
        public string self { get; set; }
        public string state { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int originBoardId { get; set; }
        public string goal { get; set; }

        public static void Show(Sprint sprint)
        {
            string valuesStr = "";
            valuesStr += $"(\nid: {sprint.id}, \nself: {sprint.self}, \nstate: {sprint.state}, \nstartDate: {sprint.startDate}, \nendDate: {sprint.endDate}, \noriginBoardId: {sprint.originBoardId}, \ngoal: {sprint.goal}\n)";
            Console.WriteLine(valuesStr);
        }
    }

    class Sprints
    {
        public Sprint[] values { get; set; }

        public static void Show(Sprints sprints) {
            foreach (var i in sprints.values) {
                Sprint.Show(i);
            }
        }
    }
}
