using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2TaskList
{
    class Task
    {
        public string TaskOwner { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completion { get; set; }

        public Task(bool completion, string taskOwner, string taskName, double dueDate)
        {
            Completion = completion;
            TaskOwner = taskOwner;
            TaskName = taskName;
            DueDate = DateTime.Now.AddDays(14);

        }
    }
}
