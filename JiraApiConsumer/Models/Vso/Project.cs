using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraApiConsumer.Models.Vso
{
    public struct Project
    {
       
        public struct Capabilities
        {
            public Versioncontrol versioncontrol { get; set; }
            public ProcessTemplate processTemplate { get; set; }

            public struct Versioncontrol
            {
                public string sourceControlType { get; set; }

                public Versioncontrol(string sourceControlType)
                {
                    this.sourceControlType = sourceControlType;
                }
            }

            public struct ProcessTemplate
            {
                public string templateTypeId { get; set; }

                public ProcessTemplate(string templateTypeId)
                {
                    this.templateTypeId = templateTypeId;
                }
            }
            
            public Capabilities(string sourceControlType, string templateTypeId) {
                versioncontrol = new Versioncontrol(sourceControlType);
                processTemplate = new ProcessTemplate(templateTypeId);
            }
        }
        
        public string name { get; set; }
        public string description { get; set; }
        public Capabilities capabilities { get; set; }

        public Project(string name, string description, string sourceControlType, string templateTypeId)
        {
            this.name = name;
            this.description = description;
            capabilities = new Capabilities(sourceControlType, templateTypeId);
        }
    }
}
