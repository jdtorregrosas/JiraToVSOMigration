using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraApiConsumer.Models.Vso
{
    public struct Iteration
    {

        public struct Attributes
        {
            public string startDate { get; set; }
            public string finishDate { get; set; }

            public Attributes(string startDate, string finishDate)
            {
                this.startDate = startDate;
                this.finishDate = finishDate;
            }
        }

        public string name { get; set; }
        public Attributes attributes { get; set; }

        public Iteration(string name, string startDate, string finishDate)
        {
            this.name = name;
            attributes = new Attributes(startDate, finishDate);
        }
    }

    public struct IterationNode
    {
        public int id { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        public string structType { get; set; }
    }
}
