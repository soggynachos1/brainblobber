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
        private int id; // make all private
        private Topics topic;
        public string question;
        private List<string> answers;
        private int correctAnswer; // starts at 0

        public Question(int id, Topics topic, string question, 
            List<string> answers, int correctAnswer)
        {
            this.id = id;
            this.topic = topic;
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
        }

        // TODO: add getter and setter for each field
       
        public enum Topics 
        {
            VideoGames = 1, PopCulture = 2, Music = 3, SuperHeroes = 4, Movies_TVshows = 5, Math = 6

        }

    
    }
}
