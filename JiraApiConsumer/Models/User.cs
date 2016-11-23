using Newtonsoft.Json;
using System;

namespace JiraApiConsumer.Models
{
    /// <summary>
    /// User model from Jira Api
    /// </summary>
    class User
    {
        public string self { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string emailAddress   { get; set; }
        public string displayName { get; set; }
        public string active { get; set; }
        public string timeZone { get; set; }
        public string locale { get; set; }

        public static void Show(User user)
        {
            string valuesStr = "";
            valuesStr += $"(\nself: {user.self}, \nkey: {user.key}, \nname: {user.name}, \nemailAddress: {user.emailAddress}, \ndisplayName: {user.displayName}, \nactive: {user.active}, \ntimeZone: {user.timeZone}, \nlocale: {user.locale}\n)";
            Console.WriteLine(valuesStr);
        }
    }
}
