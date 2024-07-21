using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;
using ReadFromJSONFile.Tasks;

namespace ReadFromJSONFile
{
    internal class Program
    {
        public Action TaskAction { get; set; }

        public Program(Action action)
        {
            TaskAction = action;
        }
        public void ExecuteTask()
        {
            TaskAction.Invoke();
        }

        static void Main(string[] args)
        {
            DelegateInvoker();
        }
        public static void DelegateInvoker()
        {
            bool TryAgain = true;
            while (TryAgain)
            {
                Console.WriteLine("1 - Show Diltered Destinations\n2 - Show Longest Duration\n3 - Sort destinations by Name\n4 - Show Top 3 Durtion");
                Console.WriteLine("please choose Your");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Program program = new Program(FilterDestinations.filterDestinations);
                    program.ExecuteTask();
                    Console.ResetColor();
                }
                else if (option == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Program program2 = new Program(LongestDuration.longestDeuration);
                    program2.ExecuteTask();
                    Console.ResetColor();
                }
                else if (option == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Program program3 = new Program(SortByName.sortByName);
                    program3.ExecuteTask();
                    Console.ResetColor();
                }
                else if (option == "4")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Program program4 = new Program(Top3Duration.top3Duration);
                    program4.ExecuteTask();
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Invaled Input , please try again");
                }
                Console.WriteLine();
                Console.WriteLine("Would you want to exit Y/N");
                string tttt = Console.ReadLine().ToUpper();
                if (tttt == "Y")
                {
                    TryAgain = false;
                    Environment.Exit(0);
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        
    }
}
