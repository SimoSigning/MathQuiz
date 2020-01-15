using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiation af menu.
            Hovedmenu();
            Console.ReadLine();
        }
        static void Hovedmenu()
        {
            //Udskrivning af menuen.
            Console.WriteLine("Vælg opgavetype.");
            Console.WriteLine("Tast 1 for Addition.");
            Console.WriteLine("Tast 2 for Subtraktion.");
            Console.WriteLine("Tast 3 for Multiplikation.");
            Console.WriteLine("Tast 4 for Division.");
            //Quizvalg.
            string quizValg = Console.ReadLine();
            switch (quizValg)
            {
                case "1":
                    Quiz("+");
                    break;
                case "2":
                    Quiz("-");
                    break;
                case "3":
                    Quiz("*");
                    break;
                case "4":
                    Quiz("/");
                    break;
            }
        }
        static void Quiz(string taskType)
        {
            int counter = 0;
            int answer;
            int answerCalc = 0;
            int[] LeftSideNumbers = new int[10];
            int[] RightSideNumbers = new int[10];
            Random AdditionNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                int tempNumber = AdditionNumber.Next(0, 10);
                if (i < 10)
                {
                    LeftSideNumbers[i] = tempNumber;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                int tempNumber = AdditionNumber.Next(0, 10);
                if (i < 10)
                {
                    RightSideNumbers[i] = tempNumber;
                }
            }
            while (counter < 10)
            {
                switch (taskType)
                {
                    case "+":
                        Console.WriteLine("Add: " + LeftSideNumbers[counter].ToString() + " + " + RightSideNumbers[counter].ToString());
                        answerCalc = LeftSideNumbers[counter] + RightSideNumbers[counter];
                        break;
                    case "-":
                        Console.WriteLine("Subtract: " + LeftSideNumbers[counter].ToString() + " - " + RightSideNumbers[counter].ToString());
                        answerCalc = LeftSideNumbers[counter] - RightSideNumbers[counter];
                        break;
                    case "*":
                        Console.WriteLine("Multiply: " + LeftSideNumbers[counter].ToString() + " * " + RightSideNumbers[counter].ToString());
                        answerCalc = LeftSideNumbers[counter] * RightSideNumbers[counter];
                        break;
                    case "/":
                        Console.WriteLine("Divide: " + LeftSideNumbers[counter].ToString() + " / " + RightSideNumbers[counter].ToString());
                        answerCalc = LeftSideNumbers[counter] / RightSideNumbers[counter];
                        break;
                    default: //
                        break;
                }
                answer = int.Parse(Console.ReadLine());
                if (answer == answerCalc)
                {
                    Console.WriteLine("Correct, on to the next.");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Wrong answer, try again.");
                }
            }
            Console.Clear();
            Console.WriteLine("Congratulations, you have answered 10 questions.");
            Hovedmenu();
        }
    }
}
