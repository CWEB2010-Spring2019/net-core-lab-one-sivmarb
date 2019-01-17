using System;
using System.Collections.Generic;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] correctAnswers = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] quizQuestions = new string[]
                    {"1. When was .NET core released?","2. What is the current version of .NET core?","3. Is .NET core compatible with Windows, Linux, and macOS?",
                    "4. What is .NET core written in?", "5. Who developed .NET core?", "6. What is the type of .NET core?", "7. What does coreCLR mean in .NET core?" ,
                    "8. Which of these does .NET core support?", "9. As of October 2018, what does .NET core not support?", "10. Finally, how awesome is .NET core?"};
            string[,] quizQuestionOptions = new string[10, 4] {
                                                {" A) 2019 ", " B) 2014 ", " C) 2003 ", " D) 1990 "},
                                                {" A) 1.0 ", " B) 2.2", " C) 10.0 ", " D) 3.0 "},
                                                {" A) Windows Only "," B) Linux and macOS only "," C) All three are compatible ", " D) None of the above "},
                                                {" A) F# and C# "," B) F# only "," C) C# only "," D) None of the above "},
                                                {" A) .NET Company "," B) .NET Works "," C) .NET Group "," D) .NET Foundation "},
                                                {" A) Software framework "," B) Design framework "," C) Database framework ", " D) None of the above "},
                                                {" A) Common Language Runtime ", "B) Corresponding Language Route ", "C) Context Language Rank ", "D) Cropping Language Ring "},
                                                {" A) NuGet ", " B) RyuJIT ", " C) ASP.NET CORE web apps ", " D) WPF "},
                                                {" A) C++ ", " B) CLI ", " C) JavaScript ", " D) Both A & B "},
                                                {" A) Very awesome ", " B) Cool ", " C) Not my thing ", " D) No comment "},
                                                };
            string selection = "";
            string EXIT = "";

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

            housekeeping();

            while (EXIT != "Q")
            {
                for (int x = 0; x < quizQuestions.Length; x++)
                {
                    Console.WriteLine(quizQuestions[x]);
                    for (int i = 0; i < quizQuestionOptions.GetLength(1); i++)
                    {
                        Console.WriteLine(quizQuestionOptions[x, i]);
                    }
                    Console.WriteLine("Please enter an option: ");
                    selection = Console.ReadLine();
                    selection = selection.ToUpper();

                    if (selection == correctAnswers[x])
                    {
                        correct.Add(selection);
                    }
                    else
                    {
                        wrong.Add("Question: " + (x + 1) + ")" + selection);
                    }
                }
                Console.WriteLine("You answered " + correct.Count + " out of " + quizQuestions.Length);
                if (wrong.Count > 0)
                {
                    Console.WriteLine("Listed below are the questions you got wrong: ");
                    wrong.ForEach(x => { Console.WriteLine(x); });
                    Console.WriteLine("Thanks for taking this quiz!");
                    Console.WriteLine("If you'd like to take this quiz again, please press <ENTER>.");
                    Console.WriteLine("To quit, please enter 'Q' to exit the program.");
                    EXIT = Console.ReadLine();
                    EXIT = EXIT.ToUpper();
                }
                else
                {
                    Console.WriteLine("Congratulations! You passed the .NET core quiz!");
                    Console.WriteLine("If you'd like to take this quiz again, please press <ENTER>.");
                    Console.WriteLine("To quit, please enter 'Q' to exit the program.");
                    EXIT = Console.ReadLine();
                    EXIT = EXIT.ToUpper();
                }
                wrong.Clear();
                correct.Clear();
            }
        }

        public static void housekeeping()
        {
            Console.WriteLine("Welcome to the .NET core quiz! To take the quiz, please press <ENTER> to start.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
