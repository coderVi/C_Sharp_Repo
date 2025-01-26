using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndArrayStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*This project was written to understand the structure of lists and arrays. 
             It is a knowledge contest that performs random mathematical operations and transfers them to lists.
            The game will end when you reach 100 points.
             */
            Console.WriteLine("Welcome To Ari Quiz Show...");
            List<string> questions = new List<string>(); //It is Collection Generic.
            ArrayList correctAnswer = new ArrayList(); // This Method and the one below are just collections.
            ArrayList wrongAnsewr = new ArrayList();
            string[] process = { "+", "-", "*", "/" };
            
            Random r = new Random();
            int point = 0 , s1 , s2, result = 0, userAnswer;
            string operation;

            do
            {
                s1 = r.Next(1,100);
                s2 = r.Next(1,100);
                operation = process[r.Next(4)];

                switch (operation)
                {
                //Process query based on incoming signal and add to List.
                    case "+":
                        result = s1 + s2;
                        Console.WriteLine($"{s1} + {s2} : ?");
                        string questionSum = Convert.ToString($"{s1} + {s2}");
                        questions.Add(questionSum);
                    break;
                    case "-":
                        result = s1 - s2;
                        Console.WriteLine($"{s1} - {s2} : ?");
                        string questionExt = Convert.ToString($"{s1} - {s2}");
                        questions.Add(questionExt);
                    break;
                    case "*":
                        result = s1 * s2;
                        Console.WriteLine($"{s1} * {s2} : ?");
                        string questionImp = Convert.ToString($"{s1} * {s2}");
                        questions.Add (questionImp);
                        break;
                    case "/":
                        Console.WriteLine($"{s1} / {s2} : ?");
                        result = s1 + s2;
                        string questionDiv = Convert.ToString($"{s1} - {s2}");
                        questions.Add(questionDiv);
                        break;
                }
                string input = Console.ReadLine();
                if (!int.TryParse(input, out userAnswer))
                {
                    Console.WriteLine("Invalid entry. Please enter a number.");
                    continue;
                }

                if (userAnswer == result)
                {
                    Console.WriteLine("Nice Job! Correct Answer");
                    point += 10;
                    correctAnswer.Add($"{s1} {operation} {s2} = {result}");
                }
                else
                {
                    Console.WriteLine("Bad Job! Wrong Answer");
                    wrongAnsewr.Add($"{s1} {operation} {s2} = {result}");
                }

            } while (point <= 100);

            Console.WriteLine("Your victory point : " + point);
            //Check Point
            Console.WriteLine("Question List");
            foreach (var item in questions)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Wrong Answer");
            foreach (var item in wrongAnsewr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Correct Answer");
            foreach (string answer in correctAnswer)
            {
                Console.WriteLine(answer);
            }
            Console.ReadLine();
        }
    }
}
