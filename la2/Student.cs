using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la2
{
    class Student : Person
    {
        string _group;
        List<Task> _tasks = new List<Task>(); 

        public Student(string name, int age, string group) : base(name, age)
        {
            _name = name;
            _age = age;
            _group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            _name = name;
            _age = age;
            _group = group;
            _tasks = tasks;
        }

        public string getGroup(string group)
        {
            return group;
        }

        public int listSize()
        {
            return _tasks.Count;
        }

        public void AddTask(string taskName, TaskStatus ts)
        {
            Task task = new Task(taskName, ts);
            _tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            _tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus task)
        {
            _tasks[index].setTaskStatus(task);
        }

        public void RenderTasks(string s = "\t")
        {

        }

        public bool Equals(Student other)
        {
            if (other == null)
                return false;

            if (this._name == other._name && this._age == other._age)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"Name: {_name}, age: {_age}, group: {_group}";
        }


    }
}
