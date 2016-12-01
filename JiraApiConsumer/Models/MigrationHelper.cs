using JiraApiConsumer.Clients;
using JiraApiConsumer.Models.Jira;
using System;
using System.Threading.Tasks;

namespace JiraApiConsumer.Models
{
    class MigrationHelper
    {
        JiraApi jiraClient;
        VSOApi vsoClient;

        public MigrationHelper(JiraApi jiraClient, VSOApi vsoClient)
        {
            this.jiraClient = jiraClient;
            this.vsoClient = vsoClient;
        }

        public async Task<string> MigrateStories()
        {
            string message = "";
            Project[] projects = null;
            projects = await jiraClient.GetProjects();
            foreach (var i in projects)
            {
                Sprints sprints = null;
                sprints = await jiraClient.GetProjectSprints(i.id);
                foreach (var j in sprints.sprints)
                {
                    Issues issues = null;
                    issues = await jiraClient.GetProjectIssues(i.id);
                    var migratedStories = 0;
                    foreach (var k in issues.issues)
                    {
                        string workItemType = "";
                        switch (k.fields.issuetype.name)
                        {
                            case "Story":
                                workItemType = "User Story";
                                break;
                            default:
                                workItemType = k.fields.issuetype.name;
                                break;
                        }
                        string reason = "";
                        string status = "";
                        switch (k.fields.status.statusCategory.key)
                        {
                            case "indeterminate":
                                status = "Active";
                                reason = "Implementation started";
                                break;
                            case "done":
                                status = "Resolved";
                                reason = "Code complete and unit tests pass";
                                break;
                            default:
                                break;
                        }
                       
                        Response response = await vsoClient.createWorkItem(new Vso.Project(i.name, i.description, "Git", "adcc42ab-9882-485e-a3ed-7678f01f66bc"), new Vso.WorkItem(workItemType, k.fields.summary, k.fields.description, status, reason));
                        if (response.success)
                        {
                            migratedStories++;
                            response.message = $"Story '{k.fields.summary}' migrated...";
                        }
                        else
                        {
                            response.message = $"Story '{k.fields.summary}' not migrated...";
                        }
                        response.message += "\n\r    Migrated Stories:" + migratedStories + "/" + issues.issues.Length;
                        message += showResponse(response);
                    }
                }
            }
            return message;
        }
        public async Task<string> MigrateSprintsStories()
        {
            string message = "";
            Project[] projects = null;
            projects = await jiraClient.GetProjects();
            foreach (var i in projects)
            {
                Sprints sprints = null;
                sprints = await jiraClient.GetProjectSprints(i.id);
                foreach (var j in sprints.sprints)
                {
                    Issues issues = null;
                    issues = await jiraClient.GetProjectSprintIssues(j.id);
                    var migratedStories = 0;
                    foreach (var k in issues.issues)
                    {
                        Response response = await vsoClient.createIterationWorkItem(new Vso.Project(i.name, i.description, "Git", "adcc42ab-9882-485e-a3ed-7678f01f66bc"), new Vso.Iteration(j.name, j.start, j.end), k.fields.summary);
                        if (response.success)
                        {
                            migratedStories++;
                            response.message = $"Story '{k.fields.summary}' migrated...";
                        }
                        else
                        {
                            response.message = $"Story '{k.fields.summary}' not migrated...";
                        }
                        response.message += "\n\r    Migrated Sprint Stories:" + migratedStories + "/" + issues.issues.Length;
                        message += showResponse(response);
                    }
                }
            }
            return message;
        }
        public async Task<string> MigrateSprints()
        {
            string message = "";
            Project[] projects = null;
            projects = await jiraClient.GetProjects();
            foreach (var i in projects)
            {
                Sprints sprints = null;
                sprints = await jiraClient.GetProjectSprints(i.id);
                int migratedSprints = 0;
                foreach (var j in sprints.sprints)
                {
                    Response response = await vsoClient.createIteration(new Vso.Project(i.name, i.description, "Git", "adcc42ab-9882-485e-a3ed-7678f01f66bc"), new Vso.Iteration(j.name, j.start, j.end));
                    if (response.success)
                    {
                        migratedSprints++;
                        response.message = $"Sprint '{j.name}' migrated...";
                    }
                    else
                    {
                        response.message = $"Sprint '{j.name}' not migrated...";
                    }
                    response.message += "\n\r    Migrated Sprints:" + migratedSprints + "/" + sprints.sprints.Length;
                    message += showResponse(response);
                }
            }
            return message;
        }
        public async Task<string> MigrateProjects()
        {
            string message = "";
            Project[] projects = null;
            projects = await jiraClient.GetProjects();
            int migratedProjects = 0;
            foreach (var i in projects)
            {
                Project.Show(i);
                Response response = await vsoClient.createProject(new Vso.Project(i.name, i.description, "Git", "adcc42ab-9882-485e-a3ed-7678f01f66bc"));
                if (response.success)
                {
                    migratedProjects++;
                    response.message = $"Project '{i.name}' migrated...";
                }
                else
                {
                    response.message = $"Project '{i.name}' not migrated...";
                }
                response.message += "\n\r   Migrated Projects:" + migratedProjects + "/" + projects.Length;
                message += showResponse(response);
            }
            return message;
        }

        public static string showResponse(Response response)
        {
            string message = "";
            // progressBarMigration.Value = (completedProcesses * totalProgress) / totalProcesses;
            if (response.success)
            {
                message = "\n\r\n\r   SUCCESS:   " + response.message + "\n\r";
            }
            else
            {
                message = "\n\r\n\r   ERROR:   " + response.message + "\n\r";
            }
            return message;
        }
    }
}
