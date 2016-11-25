using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraApiConsumer.Models
{
    struct Response
    {
        public string message { get; set; }
        public bool success { get; set; }

        public Response(string message, bool success)
        {
            this.message = message;
            this.success = success;
        }
    }
    
}
