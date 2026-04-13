using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace brainblobbermain
{
   
    public class Program
    {

       
        // calls the GetName from Player.cs file
        static string GetName()
        {
            Console.WriteLine("Enter your player name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello, {name}");
            return name;
        }
       
     



        //********MAIN ENTRANCE OF THE PROGRAM********
        public static void Main(string[] args)
        {
            int choice;

            string soloButtonStart = "Welcome to BrainBlobber - Solo Mode!";
            Console.WriteLine(soloButtonStart);

            //instantiate player object . . . 

            Player playerOne = new Player(GetName());
            Console.WriteLine("Please select a category . . .");
            
            foreach (Question.Topics topic in Enum.GetValues(typeof(Question.Topics)))
            {
                Console.WriteLine($"{(int)topic}: {topic}");
            }

            while (!int.TryParse(Console.ReadLine(), out choice) 
                || choice <= 0 || choice > Enum.GetNames(typeof(Question.Topics)).Length)
            {
                Console.WriteLine("Error, please enter the category number!");
            }

            if (choice == 1)
            {
                Console.WriteLine($"You have chosen the category Video Games! ");
                
                Console.WriteLine("Lets begin . . .");
                Console.WriteLine();
                Console.WriteLine(ListQuestions.q1.GetQuestion());
                Console.WriteLine(ListQuestions.q1.GetAnswers());

                //**TODO: add error handling here, something to detect if
                //user didnt use a number or invalid entry...

                int answer_one;
                //****!!need to fix issue with user clicking twice to show right answer...
                while (!int.TryParse(Console.ReadLine(), out answer_one)
                || answer_one <= 0 || answer_one > 5)
                {
                    Console.WriteLine("Error, please enter the a valid number!");
                }

                if (answer_one == 1 || answer_one == 3 || answer_one == 4)
                { 
                    Console.WriteLine("Incorrect! The answer was Nintendo");
                    Console.WriteLine("On to the next question . . .");
                    playerOne.SetCurrentScore(0);
                }
                else if (answer_one == 2)
                {
                    Console.WriteLine("Correct! The answer is Nintendo!");
                    Console.WriteLine("Next question.");
                    playerOne.SetCurrentScore(10);
                    Console.WriteLine($"Current score: {playerOne.GetCurrentScore()}");

                }




                Console.WriteLine();
                Console.WriteLine(ListQuestions.q2.GetQuestion());
                Console.WriteLine(ListQuestions.q2.GetAnswers());

                int answer_two = ListQuestions.q1.GetCorrectAnswer();
                //****!!need to fix issue with user clicking twice to show right answer...
                while (!int.TryParse(Console.ReadLine(), out answer_two)
                || answer_two <= 0 || answer_two > 5)
                {
                    Console.WriteLine("Error, please enter the a valid number!");
                }

                if (answer_two == 1 || answer_two == 2 || answer_two == 4)
                {
                    Console.WriteLine("Incorrect! The answer was Nintendo");
                    Console.WriteLine("On to the next question . . .");
                    playerOne.SetCurrentScore(0);
                }
                else if (answer_two == 3)
                {
                    Console.WriteLine("Correct! The answer is Nintendo!");
                    Console.WriteLine("Next question.");
                    playerOne.SetCurrentScore(10);

                }

                Console.WriteLine();
                Console.WriteLine(ListQuestions.q3.GetQuestion());
                Console.WriteLine(ListQuestions.q3.GetAnswers());

                int answer_three = ListQuestions.q1.GetCorrectAnswer();
                //****!!need to fix issue with user clicking twice to show right answer...
                while (!int.TryParse(Console.ReadLine(), out answer_three)
                || answer_three <= 0 || answer_three > 5)
                {
                    Console.WriteLine("Error, please enter the a valid number!");
                }

                if (answer_three == 1 || answer_three == 2 || answer_three == 3)
                {
                    Console.WriteLine("Incorrect! The answer was Golden Eye");
                    Console.WriteLine("On to the next question . . .");
                    playerOne.SetCurrentScore(0);
                }
                else if (answer_three == 4)
                {
                    Console.WriteLine("Correct! The answer is Golden Eye!");
                    Console.WriteLine("Next question.");
                    playerOne.SetCurrentScore(10);

                }

                Console.WriteLine();
                Console.WriteLine(ListQuestions.q4.GetQuestion());
                Console.WriteLine(ListQuestions.q4.GetAnswers());

                int answer_four;
                    
                //****!!need to fix issue with user clicking twice to show right answer...
                while (!int.TryParse(Console.ReadLine(), out answer_four)
                || answer_four <= 0 || answer_four > 5)
                {
                    Console.WriteLine("Error, please enter the a valid number!");
                }

                if (answer_four == 1 || answer_four == 3 || answer_four == 4)
                {
                    Console.WriteLine("Incorrect! The answer was The Sims");
                    Console.WriteLine("On to the next question . . .");
                    playerOne.SetCurrentScore(0);
                }
                else if (answer_four == 2)
                {
                    Console.WriteLine("Correct! The answer is The Sims!");
                    Console.WriteLine("Next question.");
                    playerOne.SetCurrentScore(10);

                }

                Console.WriteLine();
                Console.WriteLine(ListQuestions.q5.GetQuestion());
                Console.WriteLine(ListQuestions.q5.GetAnswers());

                int answer_five;
                //****!!need to fix issue with user clicking twice to show right answer...
                while (!int.TryParse(Console.ReadLine(), out answer_five)
                || answer_five <= 0 || answer_five > 5)
                {
                    Console.WriteLine("Error, please enter the a valid number!");
                }

                if (answer_five == 1 || answer_five == 2 || answer_five == 4)
                {
                    Console.WriteLine("Incorrect! The answer was Waluigi");
                    Console.WriteLine("On to the next question . . .");
                    playerOne.SetCurrentScore(0);
                }
                else if (answer_five == 3)
                {
                    Console.WriteLine("Correct! The answer is Waluigi!");
                    Console.WriteLine("Next question.");
                    playerOne.SetCurrentScore(10);

                }

                Console.WriteLine($"Wow you finsihed with a score of {playerOne.GetCurrentScore()}");
                Console.WriteLine("To go back to main menu press M");


            }
            
        }

    }
}


 


