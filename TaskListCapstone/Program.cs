using System;
using System.Collections.Generic;

namespace TaskListCapstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to the Task Manager");
            Console.WriteLine();

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("options Menu:\n(Please choose one)");
                string userTask = GetUserInfo("1: List tasks\n2: Add task\n3: Delete task\n4: Mark task complete\n5: Quit");
                Console.WriteLine();
                if (userTask == "1")
                {
                    PrintListInfo();
                }
                else if (userTask == "2")
                {
                    string a = NewTaskName();
                    string b = NewTaskDescrition();
                    DateTime c = NewTaskDate();
                    List<Task> taskList = new List<Task>
                    {


                    new Task(a, b, c)
                    };
                    PrintListInfo();



                }
                else if (userTask == "3")
                {
                    Console.WriteLine("please enter task number to delete: ");
                    string userNum = Console.ReadLine().Trim();
                    int numDelete = int.Parse(userNum);
                    Console.WriteLine($"Are you sure you would like to delete task: {userNum}? y/n");
                    string answer = Console.ReadLine().Trim();
                    if(answer == "y")
                    {
                        Console.WriteLine("cool");
                        //taskList.RemoveAt(numDelete - 1);
                    }
                    else
                    {

                    }
                }
                else if (userTask == "4")
                {

                }
                else if (userTask == "5")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("That was not a valid entry");
                }
                
            }
            
        }
        public static string GetUserInfo(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().Trim();
            return input;
        }
        public static void PrintListInfo()
        {
            List<Task> taskList = Task.GetTaskList();

            Console.WriteLine("\tTeam Member\tDue Date\tcompleted\tTask Description");
            Console.WriteLine("\t___________\t________\t_________\t________________");
            int i = 1;
            foreach (Task todo in taskList)
            {

                Console.WriteLine($"{i}\t{todo.Name}\t{todo.DueDate.ToShortDateString()}\t{todo.Complete}\t\t{todo.Description}");
                i++;
            }
        }
        public static string NewTaskName()
        {
            Console.WriteLine("Who would you like to assign a task to?");
            string person = Console.ReadLine().Trim();
            return person;
        }
        public static string NewTaskDescrition()
        {
            Console.WriteLine("Please enter a brief description of the task");
            string taskDescription = Console.ReadLine().Trim();
            return taskDescription;
        }
        public static DateTime NewTaskDate()
        {
            Console.WriteLine("Please enter a due date (mm/dd/yyyy)");
            string dateDue = Console.ReadLine();
            DateTime date = DateTime.Parse(dateDue);
            return date;
        }


    }
}
