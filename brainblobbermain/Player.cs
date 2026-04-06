using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace brainblobbermain
{
    public class Player
    {
        /// <summary>
        /// Initialize attributes/fields
        /// </summary>
        public string name;
        public int current_score;
        public int no_of_correct;

        /// <summary>
        /// listing some methods for this class
        /// </summary>
        public void get_Name()
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello, {name}");
        }
        public void current_Score()
        {
            int score = 0;
            Console.WriteLine();
            Console.WriteLine($"Your current score is: {score}");

        }

    }
}

