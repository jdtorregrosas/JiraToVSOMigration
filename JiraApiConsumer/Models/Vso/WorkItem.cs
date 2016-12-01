using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraApiConsumer.Models.Vso
{
    public struct WorkItem
    {
        public string type { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string reason { get; set; }
        public WorkItem(string type, string title, string description="", string status="", string reason="")
        {
            this.type = type;
            this.title = title;
            this.description = description;
            this.status = status;
            this.reason = reason;
        }
    }
}
