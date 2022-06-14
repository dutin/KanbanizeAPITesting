using NUnit.Framework;
using System;
using System.Linq;
namespace Kanbanize.Tests
{
    public class TestCRUDOperations: BaseTests
    {

        [Test, Description("Test Zero - to confirm that apiKey is received")]
        public void VerifyApiKeyIsReturned()
        {
            //Basic assertion to make sure that prequisite for the tests is present.
            Assert.IsTrue(_apiKey != null);
        }
        [Test, Description("To verify that user can create new Task using only the required properties")]
        public void VerifyNewTaskIsCreated()
        {
            _client = new KanbanizeRestClient();
            _task = _client.CreateNewDefaultTask();
            _response = _client.PostNewTask(_apiKey, _task);
            Assert.That(_response.StatusCode == System.Net.HttpStatusCode.OK);
            _allTasks.Add(_task);
        }
        [Test, Description("To verify that user can access existing Tast by using valid board and task IDs")]
        public void VerifyUserCanGetTaskDetails()
        {
            _client = new KanbanizeRestClient();
            _board = _client.CreateBoard();
            _task.boardid = _board.boardid;
            _response = _client.GetTaskDetails(_apiKey, _task);
            Assert.That(_response.StatusCode == System.Net.HttpStatusCode.OK);
        }
        [Test, Description("To verify that user can get all Tasks per board using valid boardId")]
        public void VerifyUserCanGetAllTasks()
        {
            _client = new KanbanizeRestClient();
            var currentId = _response.Content.Split(':', StringSplitOptions.None).Last().Trim('}');
            _task.taskid = currentId;
            _response = _client.GetAllTasks(_apiKey, _task);
            Assert.That(_response.StatusCode == System.Net.HttpStatusCode.OK);
        }
        [Test, Description("User can delete existing Task, by providing valid taskId")]
        public void DeleteTaskById()
        {
            _client = new KanbanizeRestClient();
            _task = _client.CreateNewDefaultTask();
            _response = _client.PostNewTask(_apiKey, _task);
            var currentId = _response.Content.Split(':', StringSplitOptions.None).Last().Trim('}');
            _task.taskid = currentId;
            _response = _client.DeleteTask(_apiKey, _task);
            Assert.That(_response.StatusCode == System.Net.HttpStatusCode.OK);
        }
    }
}
