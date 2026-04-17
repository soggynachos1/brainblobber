using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace brainblobbermain
{
    internal class Question
    {
        private int id; // make all private
        private Topics topic;
        public string question;
        private List<string> answers;
        private int correctAnswer; // starts at 0

        //Constructor of Question
        public Question(int CurrentId, Topics CurrentTopic, string CurrentQuestion, 
            List<string> CurrentAnswers, int CurrentCorrectAnswer)
        {
            id = CurrentId;
            topic = CurrentTopic;
            question = CurrentQuestion;
            answers = CurrentAnswers;
            correctAnswer = CurrentCorrectAnswer;
        }

        //getter and setter for all attributes
        public int GetId()
        {
            return id;
        }

        public void SetId(int CurrentId)
        {
            id = CurrentId;
        }
        public Topics GetTopic()
        {
        return topic;
        }
        public void SetTopic(Topics CurrentTopic)
        {
        topic = CurrentTopic;
        }

        public string GetQuestion()
        {
            return question;
        }
        public void SetQuestion(string CurrentQuestion)
        {
            question = CurrentQuestion;
        }

        public List<string> GetAnswers()
        {
         
           foreach (var item in answers)
            {
              Console.WriteLine(item);
            }
        return null;
            
        }

        public void SetAnswers(List<string> CurrentAnswers)
        {
            answers = CurrentAnswers;
        }

        public int GetCorrectAnswer()
        {
            
            return correctAnswer;
        }

        public void SetCorrectAnswer(int CurrentCorrectAnswer)  //remember this starts at 0...
        {
            correctAnswer = CurrentCorrectAnswer;
        }


        //listed enum topics
        public enum Topics 
        {
            VideoGames = 1, PopCulture = 2, Music = 3, SuperHeroes = 4, Movies = 5, TVShows = 6

        }

    
    }
}
