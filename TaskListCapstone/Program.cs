using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace TaskListCapstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to the Task Manager");

            bool loop = true;
            List<Task> taskList = Task.GetTaskList();
            while (loop)
            {
                Console.WriteLine();
                Console.WriteLine("options Menu:\n(Please choose one)");
                string userTask = GetUserInfo("1: List tasks\n2: Add task\n3: Delete task\n4: Mark task complete\n5: Quit");
                Console.WriteLine();
                if (userTask == "1")
                {
                    PrintListInfo(taskList);
                }
                else if (userTask == "2")
                {
                    string a = NewTaskName();
                    string b = NewTaskDescrition();
                    DateTime c = NewTaskDate();
                    taskList.Add(new Task(a, b, c));                
                    
                }
                else if (userTask == "3")
                {
                    while (true)
                    {                       
                            Console.WriteLine("please enter task number to delete: ");
                        string userNum = Console.ReadLine().Trim();                           
                            Console.WriteLine($"Are you sure you would like to delete task: {userNum}? y/n");
                        string answer = Console.ReadLine().Trim();
                        if (answer == "y")
                        {
                            try
                            {
                                int numDelete = int.Parse(userNum);
                                taskList.RemoveAt(numDelete - 1);
                                Console.WriteLine($"Task number:{userNum} has been deleted. ");
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Sorry that is not a valid number");
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("Sorry that number was not connected to one of our tasks");
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Sorry that number was not connected to one of our tasks");
                            }
                        }
                        else
                        {

                        }
                    }  
                }
                else if (userTask == "4")
                {
                    while (true)
                    {
                        Console.WriteLine("please enter task you would like to mark complete: ");
                        string userNum = Console.ReadLine().Trim();
                        Console.WriteLine($"Are you sure you would like to mark task: {userNum} complete? y/n");
                        string answer = Console.ReadLine().Trim();
                        if (answer == "y")
                        {
                            try
                            {
                                int taskComplete = int.Parse(userNum);
                                taskList[taskComplete - 1].Complete = true;
                                Console.WriteLine($"Task number:{userNum} has been marked complete. ");
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Sorry that is not a valid number");
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("Sorry that number was not connected to one of our tasks");
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Sorry that number was not connected to one of our tasks");
                            }
                        }
                        else
                        {

                        }
                    }
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
        public static void PrintListInfo(List<Task> taskList)
        {
           

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
            Console.WriteLine("Who would you like to assign a task to? (First and Last)");
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
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a due date (mm/dd/yyyy)");
                    string dateDue = Console.ReadLine();
                    DateTime date = DateTime.Parse(dateDue);
                    return date;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry that is not a valid Date");
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry that was not a Date");
                }
            }
        }


    }
}
