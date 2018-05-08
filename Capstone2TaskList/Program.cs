using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> TaskList = new List<Task>();
            TaskList.Add (new Task (false,"Charizard", "Clean Bathroom", 5));
            TaskList.Add (new Task(false, "Pikachu", "Chop Parsley", 6));
            TaskList.Add (new Task(false, "Charmander", "Slice Garlic", 3));
            TaskList.Add (new Task(false, "Bulbasaur", "Filet Salmon", 9));
            TaskList.Add (new Task(false, "Geodude", "Dice Onion", 5));
            Console.WriteLine("Welcome to the Task Manager!");

            bool whileBool = true;
            string response = "";
            while (whileBool)
            {
                Console.WriteLine("1.List Task \n2.Add Task \n3.Delete Task \n4.Mark Task Complete \n5.Quit");
                response = Console.ReadLine();
                bool statement = int.TryParse(response, out int input);

                if (input == 1)
                {
                    Console.WriteLine("Done? \t Team Member \t Description \t Due Date");
                    foreach (Task item in TaskList)
                    {
                        
                        Console.WriteLine(item.Completion + "  " + item.TaskOwner + "        " + item.TaskName + "\t   " + item.DueDate);
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("Please enter a new task!");
                    Console.WriteLine("Please enter Team Members Name: ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Please enter Task Description: ");
                    string Chore = Console.ReadLine();
                    Console.WriteLine("Staring today, how many days are needed to complete this task: ");
                    string Date = Console.ReadLine();
                    bool statement1 = double.TryParse(Date, out double Date1);
                    TaskList.Add(new Task(false, Name, Chore, Date1));
                }
                else if (input == 3)
                {
                    Console.WriteLine($"Which task would you like to delete?(Enter a number 1-{TaskList.Count})!");
                    string ask = Console.ReadLine();
                    bool statement2 = int.TryParse(ask, out int ask1);
                    ask1--;
                    Console.WriteLine($"You are going to delete {TaskList[ask1].TaskOwner} {TaskList[ask1].TaskName} {TaskList[ask1].DueDate} ");
                    Console.WriteLine($"Are you sure you would like to delete task {ask1+1}? y/n");
                    string yesNo = Console.ReadLine().ToLower();
                    if (yesNo == "y")
                    {
                        Console.WriteLine($"You have deleted {TaskList[ask1].TaskOwner} {TaskList[ask1].TaskName} {TaskList[ask1].DueDate}!");
                        TaskList.RemoveAt(ask1);
                    }
                    else 
                    {
                        whileBool = true;
                    }
                }
                else if (input == 4)
                {
                    Console.WriteLine($"Which task has been completed? 1-{TaskList.Count}?");
                    string ask2 = Console.ReadLine();
                    Console.WriteLine("Are you sure you have completed this task? y/n?");
                    string yesNo = Console.ReadLine();
                    bool statement3 = int.TryParse(yesNo, out int ask3);
                    TaskList[ask3].Completion = true;
                    if (yesNo != "y")
                    {
                        whileBool = false;
                    }
                    else
                    {
                        Console.WriteLine($"{TaskList[ask3].TaskName} has been completed! Hooray!");
                        whileBool = true;
                    }

                }
                else if (input==5)
                {
                    whileBool = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number from 1-5!");
                    whileBool = true;
                }
            }
            Console.WriteLine("Have a great day!");
        }
    }
}
