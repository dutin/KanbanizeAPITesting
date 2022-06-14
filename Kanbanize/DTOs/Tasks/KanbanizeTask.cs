using System;
using System.Collections.Generic;
using System.Text;

namespace Kanbanize.DTOs
{
    public class KanbanizeTask
    {
        public string boardid { get; set; }
        public string taskid { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string assignee { get; set; }
        public string color { get; set; }
        public string priority { get; set; }
        public string size { get; set; }

        public string deadline { get; set; }
        public string extlink { get; set; }
        public string type { get; set; }
        public string template { get; set; }
        public string[] subtasks { get; set; }
        public string column { get; set; }
        public string lane { get; set; }
        public string position { get; set; }
        public string exceedingReason { get; set; }
        public string returnedTaskDetails { get; set; }
    }
}
