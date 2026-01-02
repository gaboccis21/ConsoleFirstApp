using System;
using System.Collections.Generic;

namespace SimpleTaskManager
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Task Manager ===\n");

            bool running = true;
            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("\nGoodbye!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please try again.\n");
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View all tasks");
            Console.WriteLine("3. Remove a task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
        }

        static void AddTask()
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added!\n");
        }

        static void ViewTasks()
        {
            Console.WriteLine("\n=== Your Tasks ===");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.\n");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
                Console.WriteLine();
            }
        }

        static void RemoveTask()
        {
            ViewTasks();
            if (tasks.Count > 0)
            {
                Console.Write("Enter task number to remove: ");
                if (int.TryParse(Console.ReadLine(), out int taskNum) && taskNum > 0 && taskNum <= tasks.Count)
                {
                    tasks.RemoveAt(taskNum - 1);
                    Console.WriteLine("Task removed!\n");
                }
                else
                {
                    Console.WriteLine("Invalid task number.\n");
                }
            }
        }
    }
}

