using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace brainblobbermain
{
    internal class Question
    {
        string question_topic; 
        int correct_answer;
       
        public enum Topics : int
        {
            VideoGames = 1, PopCulture = 2, Music = 3, SuperHeroes = 4, Movies_TVshows = 5

        }

    
    }
}
