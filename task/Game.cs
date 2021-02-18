using System;

namespace task
{
    public class Game
    {
        public void CheckWinCondition (Player player, ComputerPlayer bot)
        {

            int playerFinalScore = player.CountScore();
            int botFinalScore = bot.CountScore();

            if (playerFinalScore > 21 && botFinalScore <= 21)
            {
                Console.WriteLine(bot.BotName + " wins!");
            }

            else if (playerFinalScore == botFinalScore && playerFinalScore <= 21 && botFinalScore <= 21)
            {
                Console.WriteLine("That's a tie");
            }
            
            else if (botFinalScore > 21 &&  playerFinalScore <= 21)
            {
                Console.WriteLine(player.Name + " wins!");
            }
            else if (botFinalScore>playerFinalScore && botFinalScore <=21)
            {
                Console.WriteLine(bot.BotName + " wins!");
            }
            else if(playerFinalScore>botFinalScore && playerFinalScore <=21)
            {
                Console.WriteLine(player.Name + " wins!");
            }
            else
            {
                Console.WriteLine("Both players lost!");
            }
        }
    }
}