using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TaskStatus
{
    Waiting,
    Progress,
    Done,
    Rejected
}

namespace la2
{
    class Task
    {

        private string name;
        private TaskStatus status;

        public string getName(string name)
        {
            return name;
        }

        public TaskStatus getTaskStatus(TaskStatus st)
        {
            return st;
        }

        public void setTaskStatus(TaskStatus st)
        {
            status = st;
        }

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public Task(string taskName, System.Threading.Tasks.TaskStatus ts)
        {
        }

        public bool Equals(Task other)
        {
            if (other == null)
                return false;

            if (this.name == other.name && this.status == other.status)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"Name: {name}, status: {status}";
        }
    }
}
