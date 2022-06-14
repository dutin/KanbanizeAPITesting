using Kanbanize.Builders;
using Kanbanize.DTOs;
using Kanbanize.DTOs.Boards;
using RestSharp;
using System;
using System.Linq;
using Kanbanize.Helper;

namespace Kanbanize
{
    public class KanbanizeRestClient
    {
        public string GetApiKey()
        {
            RestClient client = new RestClient(TestConstants.BaseUrl + TestConstants.Login);
            var request = new RestRequest();
            var currentUser = CreateNewUser();
            request.AddBody(currentUser);
            request.Method = Method.Post;
            RestResponse rest = client.Execute(request);
            var apiKey = rest.Content.Split(new string[] { "\":\"" }, StringSplitOptions.None).Last().Split("\"").First();
            return apiKey;
        }
        public RestResponse PostNewTask(string apiKey, object currentTask)
        {
            var client = new RestClient(TestConstants.BaseUrl + TestConstants.CreateTask);
            var request = new RestRequest();
            request.AddHeader("apiKey", apiKey);
            request.AddJsonBody(currentTask);
            var response = client.Execute(request,Method.Post);
            return response;
        }
        public RestResponse GetTaskDetails(string apiKey, object task)
        {
            var client = new RestClient("https://thetestingcompany.kanbanize.com/index.php/api/kanbanize/get_task_details//format/json");
            var request = new RestRequest();
            request.AddHeader("apiKey", apiKey);
            request.AddJsonBody(task);
            var response = client.Execute(request, Method.Post);
            return response;
        }
        public RestResponse GetAllTasks(string apiKey, object task)
        {
            var client = new RestClient("https://thetestingcompany.kanbanize.com/index.php/api/kanbanize/get_all_tasks//format/json");
            var request = new RestRequest();
            request.AddHeader("apiKey", apiKey);
            request.AddJsonBody(task);
            var response = client.Execute(request, Method.Post);
            return response;
        }
        public RestResponse DeleteTask(string apiKey, object task)
        {
            var client = new RestClient("https://thetestingcompany.kanbanize.com/index.php/api/kanbanize/delete_task//format/json");
            var request = new RestRequest();
            var currentTask = CreateNewDefaultTask();
            request.AddHeader("apiKey", apiKey);
            request.AddJsonBody(task);
            var response = client.Execute(request, Method.Post);
            return response;
        }
        public KanbanizeTask CreateNewDefaultTask()
        {
            var builder = new TaskBuilder();
            var task = builder.DefaultTask().Build();
            return task;
        }
        public User CreateNewUser()
        {
            var builder = new UserBuilder();
            var user = builder.DefaultUser().Build();
            return user;
        }
        public Board CreateBoard()
        {
            var builder = new BoardBuilder();
            var board = builder.DefaultBoard().Build();
            return board;
        }

    }
    
}
