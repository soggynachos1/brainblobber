using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainblobbermain
{
    internal class ListQuestions
    {

        //ALL THE VIDEO GAME QUESTIONS
        public static Question q1 = new Question(
           1,
           Question.Topics.VideoGames,
           "Which game system is known to have a character named Mario?",
           new List<string> { "1: Playstation", "2: Nintendo", "3: Xbox", "4: Sega" },
           1
           );

        public static Question q2 = new Question(
            2,
            Question.Topics.VideoGames,
            "What was the popular fighting game created in 1987 called??",
            new List<string> { "1: Mortal Combat", "2: Tekken", "3: Street Fighter", "4: Super Smash Bros" },
            2
            );
        public static Question q3 = new Question(
           3,
           Question.Topics.VideoGames,
           "1. What 1997 N64 video game, widely cited as one of the greatest of all time, features James Bond up" 
            + "against a criminal syndicate and is named after the 1995 film in the Bond franchise?",
           new List<string> { "1: GoldFinger", "2:SkyFall ", "3: NightFire", "4: Golden Eye" },
           3
           );
        public static Question q4 = new Question(
           1,
           Question.Topics.VideoGames,
           "7. What Will Wright created video game series, released in 2000 (with sequels in 2004, 2009, and 2014), saw players watching and directing characters to " +
            "mundane things like eating, sleeping, and cleaning their houses?",
           new List<string> { "1: The Urbz", "2: The Sims", "3: Stardew Valley", "4: Animal Crossing" },
           1
           );
        public static Question q5 = new Question(
           2,
           Question.Topics.VideoGames,
           " Dressed in purple and black with an upside-down \"L\" on his cap, what skinny and mustachioed character made his debut in" +
            " the 2000 Nintendo 64 game, \"Mario Tennis?\"",
           new List<string> { "1: Eggman", "2: Wario", "3: Waluigi", "4: Toad" },
           2
           );

        //All the 

    }
}
