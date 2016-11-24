using Newtonsoft.Json;
using System;

namespace JiraApiConsumer.Models.Jira
{
    /// <summary>
    /// Board model from Jira Api
    /// </summary>
    public class Board
    {
        public string id { get; set; }
        public string self { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        public static void Show(Board board)
        {
            string valuesStr = "";
            valuesStr += $"(\nid: {board.id}, \nself: {board.self}, \nname: {board.name}, \ntype: {board.type}\n)";
            Console.WriteLine(valuesStr);
        }
    }

    /// <summary>
    /// Boards model from Jira Api
    /// </summary>
    public class Boards
    {
        public int maxResults { get; set; }
        public int startAt { get; set; }
        public bool isLast { get; set; }
        public Board[] values { get; set; }

        public static void Show(Boards board)
        {
            string valuesStr = "";
            for (int i = 0; i < board.values.Length; i++)
            {
                valuesStr += $"(\nid: {board.values[i].id}, \nself: {board.values[i].self}, \nname: {board.values[i].name}, \ntype: {board.values[i].type}\n)";
            }
            Console.WriteLine(valuesStr);
        }
    }


}