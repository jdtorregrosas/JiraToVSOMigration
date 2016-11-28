using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraApiConsumer.Models.Vso
{
    struct WorkItemProperty
    {
        public string op { get; set; }
        public string path { get; set; }
        public string value { get; set; }

        public WorkItemProperty(string path, string value) {
            op = "add";
            this.path = path;
            this.value = value;
        }
    }
}
