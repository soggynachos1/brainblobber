using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainblobbermain
{
   
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Trivia Game!");
            
            //instantiate player object . . . 
            Player player_one = new Player();
            

            player_one.get_Name();

            Console.WriteLine("Please select a category . . .");
            Console.WriteLine($"1: {Question.Topics.VideoGames}");
            Console.WriteLine($"2: {Question.Topics.PopCulture}");
            Console.WriteLine($"3: {Question.Topics.Music}");
            Console.WriteLine($"4: {Question.Topics.SuperHeroes}");
            Console.WriteLine($"5: {Question.Topics.Movies_TVshows}");

        }

    }
}


 


