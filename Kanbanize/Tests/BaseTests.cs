using Kanbanize.Builders;
using Kanbanize.DTOs;
using Kanbanize.DTOs.Boards;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Xml.Linq;

namespace Kanbanize
{
    public class BaseTests
    {
        public KanbanizeRestClient _client;
        public List <KanbanizeTask> _allTasks = new List<KanbanizeTask>();
        public KanbanizeTask _task = new KanbanizeTask();
        public RestResponse _response;
        public Board _board;
        public string _apiKey;
        //tester2001in2022@email.com
        //Password123!
        [SetUp]
        public void Setup()
        {
            _client = new KanbanizeRestClient();
            _apiKey = _client.GetApiKey();
        }

        

        //[TearDown]
        //public void TearDown()
        //{
        //    foreach (KanbanizeTask task in _allTasks)
        //    {
        //        _response = _client.DeleteTask(_apiKey, task);
        //        Assert.That(_response.StatusCode == System.Net.HttpStatusCode.OK);
        //    }
        //}


    }
}