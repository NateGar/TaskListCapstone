using System;
using System.Collections.Generic;
using System.Text;

namespace TaskListCapstone
{
    class Task
    {
        private string name;
        private string description;
        private DateTime dueDate;
        private bool complete;

        #region properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }
        public bool Complete
        {
            get
            {
                return complete;
            }
            set
            {
                complete = value;
            }
        }
        #endregion
        #region constructors
        public Task()
        {

        }
        public Task(bool _complete)
        {
            complete = true;
        }
        public Task(string _name, string _description, DateTime _dueDate)
        {
            name = _name;
            description = _description;
            dueDate = _dueDate;
            complete = false;
        }
        public Task(string _name, string _description, DateTime _dueDate, bool _complete)
        {
            name = _name;
            description = _description;
            dueDate = _dueDate;
            complete = _complete;
        }
        #endregion


        public static List<Task> GetTaskList()
        {
            List<Task> taskList = new List<Task>
            {
                new Task("Robert Moon", "Make Coffee", DateTime.Parse("5/4/2020")),
                new Task("Anna Baseley", "Drink Coffee", DateTime.Parse("5/4/2020")),
                new Task("Johnny Doe", "Set up Zoom meeting for 9AM", DateTime.Parse("5/4/2020")),
                new Task("The Brain", "Take over the World!", DateTime.Parse("1/1/3000")),
                new Task("Nate Gardner", "Be Awesome!", DateTime.Parse("5/25/2020"), true),
            };
            return taskList;
        }

        

        
        
    }
}
