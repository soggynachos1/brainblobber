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
                //****TODO: Want to add multiplayer option soon...

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




                    //**TODO: add more error handling here, something to detect if
                    //user didnt use a number or invalid entry...
                    //This is where all the question objects are stored and given
                    //conditional statements...

                    int answer_one;

                    while (!int.TryParse(Console.ReadLine(), out answer_one)
                    || answer_one <= 0 || answer_one > 5)
                    {
                        Console.WriteLine("Error, please enter the a valid number!");
                    }

                    if (answer_one == 1 || answer_one == 3 || answer_one == 4)
                    {
                        Console.WriteLine("Incorrect! The answer was Nintendo");
                        Console.WriteLine("On to the next question . . .");
                        playerOne.GetCurrentScore();
                    }
                    else if (answer_one == 2)
                    {
                        Console.WriteLine("Correct! The answer is Nintendo!");
                        Console.WriteLine("Next question.");
                        playerOne.AddCorrect();

                    }

                    Console.WriteLine();
                    Console.WriteLine(ListQuestions.q2.GetQuestion());
                    Console.WriteLine(ListQuestions.q2.GetAnswers());

                    int answer_two;

                    while (!int.TryParse(Console.ReadLine(), out answer_two)
                    || answer_two <= 0 || answer_two > 5)
                    {
                        Console.WriteLine("Error, please enter the a valid number!");
                    }

                    if (answer_two == 1 || answer_two == 2 || answer_two == 4)
                    {
                        Console.WriteLine("Incorrect! The answer was Street Fighter");
                        Console.WriteLine("On to the next question . . .");
                        playerOne.GetCurrentScore();
                    }
                    else if (answer_two == 3)
                    {
                        Console.WriteLine("Correct! The answer is Street Fighter");
                        Console.WriteLine("Next question.");
                        playerOne.AddCorrect();

                    }

                    Console.WriteLine();
                    Console.WriteLine(ListQuestions.q3.GetQuestion());
                    Console.WriteLine(ListQuestions.q3.GetAnswers());


                    int answer_three;
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
                        playerOne.GetCurrentScore();
                    }
                    else if (answer_three == 4)
                    {
                        Console.WriteLine("Correct! The answer is Golden Eye!");
                        Console.WriteLine("Next question.");
                        playerOne.AddCorrect();

                    }

                    Console.WriteLine();
                    Console.WriteLine(ListQuestions.q4.GetQuestion());
                    Console.WriteLine(ListQuestions.q4.GetAnswers());




                    int answer_four;

                    while (!int.TryParse(Console.ReadLine(), out answer_four)
                    || answer_four <= 0 || answer_four > 5)
                    {
                        Console.WriteLine("Error, please enter the a valid number!");
                    }

                    if (answer_four == 1 || answer_four == 3 || answer_four == 4)
                    {
                        Console.WriteLine("Incorrect! The answer was The Sims");
                        Console.WriteLine("On to the next question . . .");
                        playerOne.GetCurrentScore();
                    }
                    else if (answer_four == 2)
                    {
                        Console.WriteLine("Correct! The answer is The Sims!");
                        Console.WriteLine("Next question.");
                        playerOne.AddCorrect();

                    }

                    Console.WriteLine();
                    Console.WriteLine(ListQuestions.q5.GetQuestion());
                    Console.WriteLine(ListQuestions.q5.GetAnswers());



                    int answer_five;

                    while (!int.TryParse(Console.ReadLine(), out answer_five)
                    || answer_five <= 0 || answer_five > 5)
                    {
                        Console.WriteLine("Error, please enter the a valid number!");
                    }

                    if (answer_five == 1 || answer_five == 2 || answer_five == 4)
                    {
                        Console.WriteLine("Incorrect! The answer was Waluigi");
                        Console.WriteLine("On to the next question . . .");
                        playerOne.GetCurrentScore();
                    }
                    else if (answer_five == 3)
                    {
                        Console.WriteLine("Correct! The answer is Waluigi!");
                        Console.WriteLine("Next question.");
                        playerOne.AddCorrect();

                    }

                    Console.WriteLine();
                    Console.WriteLine(ListQuestions.q6.GetQuestion());
                    Console.WriteLine(ListQuestions.q6.GetAnswers());



                    int answer_six;

                    while (!int.TryParse(Console.ReadLine(), out answer_six)
                    || answer_six <= 0 || answer_six > 5)
                    {
                        Console.WriteLine("Error, please enter the a valid number!");
                    }

                    if (answer_six == 1 || answer_six == 2 || answer_six == 3)
                    {
                        Console.WriteLine("Incorrect! The answer was Crops and Materials");
                        Console.WriteLine("On to the next question . . .");
                        playerOne.GetCurrentScore();
                    }
                    else if (answer_six == 4)
                    {
                        Console.WriteLine("Correct! The answer is Crops and Materials");
                        Console.WriteLine("Next question.");
                        playerOne.AddCorrect();

                    }

                    Console.WriteLine();
                    Console.WriteLine(ListQuestions.q7.GetQuestion());
                    Console.WriteLine(ListQuestions.q7.GetAnswers());



                    int answer_seven;

                    while (!int.TryParse(Console.ReadLine(), out answer_seven)
                    || answer_seven <= 0 || answer_seven > 5)
                    {
                        Console.WriteLine("Error, please enter the a valid number!");
                    }

                    if (answer_seven == 3 || answer_seven == 2 || answer_seven == 4)
                    {
                        Console.WriteLine("Incorrect! The answer was Sheik");
                        Console.WriteLine("On to the next question . . .");
                        playerOne.GetCurrentScore();
                    }
                    else if (answer_seven == 1)
                    {
                        Console.WriteLine("Correct! The answer is Sheik");
                        Console.WriteLine("Next question.");
                        playerOne.AddCorrect();

                    }

                    Console.WriteLine();
                    Console.WriteLine(ListQuestions.q8.GetQuestion());
                    Console.WriteLine(ListQuestions.q8.GetAnswers());



                    int answer_eight;

                    while (!int.TryParse(Console.ReadLine(), out answer_eight)
                    || answer_eight <= 0 || answer_eight > 5)
                    {
                        Console.WriteLine("Error, please enter the a valid number!");
                    }

                    if (answer_eight == 1 || answer_eight == 2 || answer_eight == 3)
                    {
                        Console.WriteLine("Incorrect! The answer was Minecraft");
                        Console.WriteLine("On to the next question . . .");
                        playerOne.GetCurrentScore();
                    }
                    else if (answer_eight == 4)
                    {
                        Console.WriteLine("Correct! The answer is Minecraft");
                        Console.WriteLine("Next question.");
                        playerOne.AddCorrect();

                    }

                    Console.WriteLine();
                    Console.WriteLine(ListQuestions.q9.GetQuestion());
                    Console.WriteLine(ListQuestions.q9.GetAnswers());



                    int answer_nine;

                    while (!int.TryParse(Console.ReadLine(), out answer_nine)
                    || answer_nine <= 0 || answer_nine > 5)
                    {
                        Console.WriteLine("Error, please enter the a valid number!");
                    }

                    if (answer_nine == 3 || answer_nine == 2 || answer_nine == 4)
                    {
                        Console.WriteLine("Incorrect! The answer was Magnavox Odyssey ");
                        Console.WriteLine("On to the next question . . .");
                        playerOne.GetCurrentScore();
                    }
                    else if (answer_nine == 1)
                    {
                        Console.WriteLine("Correct! The answer is Magnavox Odyssey");
                        Console.WriteLine("Next question.");
                        playerOne.AddCorrect();


                        Console.WriteLine();
                        Console.WriteLine(ListQuestions.q10.GetQuestion());
                        Console.WriteLine(ListQuestions.q10.GetAnswers());


                        int answer_ten;

                        while (!int.TryParse(Console.ReadLine(), out answer_ten)
                        || answer_ten <= 0 || answer_ten > 5)
                        {
                            Console.WriteLine("Error, please enter the a valid number!");
                        }

                        if (answer_ten == 3 || answer_ten == 1 || answer_ten == 4)
                        {
                            Console.WriteLine("Incorrect! The answer was Elden Tree ");
                            Console.WriteLine("On to the next question . . .");
                            playerOne.GetCurrentScore();
                        }
                        else if (answer_ten == 2)
                        {
                            Console.WriteLine("Correct! The answer is Elden Tree");
                            playerOne.AddCorrect();

                            Console.WriteLine($"Your score is {playerOne.GetCurrentScore()}");
                        }

                    }
                }

        }
    }

 }



 


