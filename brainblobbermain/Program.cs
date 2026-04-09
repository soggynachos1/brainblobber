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

        static Question q1 = new Question(
            1,
            Question.Topics.VideoGames,
            "Which game system is known to have a character named Mario?",
            new List<string> { "Nintendo", "Playstation", "Xbox", "Wii"},
            0
            );
        static Question q2 = new Question(
            2,
            Question.Topics.VideoGames,
            "What was the popular fighting game created in 1987 called??",
            new List<string> { "Mortal Combat", "Street Fighter", "Tekken", "Super Smash Bros" },
            1
            );


        public static string GetName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello, {name}");
            return name;
        }



        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to the Trivia Game!");

            //instantiate player object . . . 

            Player player_one = new Player(GetName());
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
                Console.WriteLine(q1.question);
        }

    }
}


 


