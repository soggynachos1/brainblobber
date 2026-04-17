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
           "1. What 1997 N64 video game features James Bond up against a" +
            " criminal syndicate and is named after the 1995 film in the Bond franchise?",
           new List<string> { "1: GoldFinger", "2: SkyFall ", "3: NightFire", "4: Golden Eye" },
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

        public static Question q6 = new Question(
         3,
         Question.Topics.VideoGames,
          "What is the main resource players must collect in Stardew Valley?" ,
          new List<string> { "1: Copper and Diamonds ", "2: Tacos and burgers", "3: Dragons and rocks ", "4: Crops and Materials" },
         3
         );

        public static Question q7 = new Question(
        0,
        Question.Topics.VideoGames,
         "In The Legend of Zelda: Ocarina of Time, what is Zelda’s alter ego?",
         new List<string> { "1: Sheik ", "2: Bleik", "3: Danaerys", "4: Ragnor " },
        0
        );


        public static Question q8 = new Question(
        3,
        Question.Topics.VideoGames,
         "What is the best selling video games of all the time, with 176 " +
            "billon copies sold?",
         new List<string> { "1: Elden Ring", "2: Call of Duty", "3: Grand Theft Auto (GTA)","4: Minecraft" },
        3
        );


        public static Question q9 = new Question(
        0,
        Question.Topics.VideoGames,
         "What was the first video game ever sold in 1972?",
         new List<string> { "1:Magnavox Odyssey", "2:Nintendo Gameboy", "3:Nintendo 64", "4: Playstation 1" },
        0
        );


        public static Question q10 = new Question(
        1,
        Question.Topics.VideoGames,
         "What is the giant tree called in Elden Ring?",
         new List<string> { "1:The Holy Tree", "2: Elden Tree", "3:Ancient Tree ", "4: Old wise tree" },
        1
        );
    }
}
