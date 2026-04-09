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
        private string name;
        private int currentScore;
        private int numOfCorrect;

        //constructor player (name of class followed by info needed to create itself)
        public Player(string playerName, int score = 0, int correct = 0)
        {
            name = playerName;
            currentScore = score;
            numOfCorrect = correct;

        }

       ///when name is initialized returns name....
        public string GetName()
        {
            return name;
        }
        public void SetName(string playerName)
        {
            name = playerName;
        }

        public int GetCurrentScore()
        {
            return currentScore;
        }

        public void SetCurrentScore(int score)
        {
            currentScore = score;
        }

        public int GetNumOfCorrect()
        {
            return numOfCorrect;
        }

        public void SetNumOfCorrect(int correct)
        {
            numOfCorrect = correct;
        }
    }
}

