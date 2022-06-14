using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Kanbanize.DTOs;

namespace Kanbanize.Builders
{
    public class TaskBuilder
    {
        private KanbanizeTask _task;

        public TaskBuilder()
        {
            _task = new KanbanizeTask();
        }

        public TaskBuilder DefaultTask()
        {
            _task = new KanbanizeTask();
            _task.boardid = "2";
            return this;
        }

        public KanbanizeTask Build()
        {
            return _task;
        }

    }
}
