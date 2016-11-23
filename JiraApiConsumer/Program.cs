﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using JiraApiConsumer.Models;
using ServiceStack;

namespace JiraApiConsumer
{
    public class Program
    {
        static HttpClient client = new HttpClient();
        static void Main()
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {

            // Basic Auth
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();
            ApiConsumer apiConsumer = new ApiConsumer("https://testingvso.atlassian.net/", username, password);

            try
            {
                Console.WriteLine("------------ Boards:  ");
                Boards boards = new Boards { };
                boards = await apiConsumer.GetBoards();
                Boards.Show(boards);

                Console.WriteLine("------------ Board 1:  ");
                Board board = new Board { };
                board = await apiConsumer.GetBoard("1");
                Board.Show(board);

                Console.WriteLine("------------ Board 1 Backlog:  ");
                Issues backlog = new Issues { };
                backlog = await apiConsumer.GetBoardBacklog("1");
                Issues.Show(backlog);

                Console.WriteLine("------------ Board 1 Issues:  ");
                Issues boardIssues = new Issues { };
                boardIssues = await apiConsumer.GetBoardIssues("1");
                Issues.Show(boardIssues);

                Console.WriteLine("------------ Board 1 Sprints:  ");
                Sprints sprints = null;
                sprints = await apiConsumer.GetBoardSprints("1");
                Sprints.Show(sprints);

                Console.WriteLine("------------ Projects from board 1:  ");
                Projects projects = new Projects { };
                projects = await apiConsumer.GetBoardProjects("1");
                Projects.Show(projects);

                

                Console.WriteLine("------------ Current User:  ");
                User user = new User { };
                user = await apiConsumer.GetCurrentUser();
                User.Show(user);

                Console.WriteLine("------------ All Users:  ");
                User[] users = null;
                users = await apiConsumer.GetUsers();
                foreach (var i in users) {
                    User.Show(i);
                }

                Console.WriteLine("------------ Workflows:  ");
                WorkFlow[] workflows = null;
                workflows = await apiConsumer.GetWorkFlows();
                foreach (var i in workflows)
                {
                    WorkFlow.Show(i);
                }

                Console.WriteLine("------------ Issues:  ");
                Issues issues = null;
                issues = await apiConsumer.GetProjectIssues("10000");
                Issues.Show(issues);

                Console.WriteLine("------------ Permissions:  ");
                Permissions permissions = null;
                permissions = await apiConsumer.GetPermissions();
                Permissions.Show(permissions);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
