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
                Console.WriteLine("\n" + bot.BotName + " wins!");
            }

            else if (playerFinalScore == botFinalScore && playerFinalScore <= 21 && botFinalScore <= 21)
            {
                Console.WriteLine("\n" + "That's a tie");
            }
            
            else if (botFinalScore > 21 &&  playerFinalScore <= 21)
            {
                Console.WriteLine("\n" + player.Name + " wins!");
            }
            else if (botFinalScore>playerFinalScore && botFinalScore <=21)
            {
                Console.WriteLine("\n" + bot.BotName + " wins!");
            }
            else if(playerFinalScore>botFinalScore && playerFinalScore <=21)
            {
                Console.WriteLine("\n" + player.Name + " wins!");
            }
            else
            {
                Console.WriteLine("\nBoth players lost!");
            }
        }

        public void ChangeElevens(Player player)
        {
            if (player.PlayerCards.Contains(11))
            {
                Console.WriteLine("\n" + "Would you like to change aces' value to 1? (Y : N)");

                var userAnswer = Console.ReadLine();

                if (userAnswer == "Y")
                {
                    for (int i = 0; i < player.PlayerCards.Count; i++)
                    {
                        if (player.PlayerCards[i] == 11)
                        {
                            player.PlayerCards[i] = 1;
                        }
                    }
                }
            }
        }

        public void ChangeElevens(Player player, ComputerPlayer computerPlayer)
        {
            int counter = 0;

            if (computerPlayer.CountScore() > player.CountScore() && computerPlayer.CountScore() <= 21)
            {
                return;
            }
            
            else if (computerPlayer.BotCards.Contains(11))
            {
                foreach (var t in computerPlayer.BotCards)
                {
                    if (t == 11)
                    {
                        counter++;
                    }
                }

                if (computerPlayer.CountScore() - 11 * counter + 1 * counter > player.CountScore() && computerPlayer.CountScore() - 11 * counter + 1 * counter <= 21)
                {
                    Console.WriteLine("\n" + computerPlayer.BotName + " has decided to change his aces' value\n");
                    
                    for (int i = 0; i < computerPlayer.BotCards.Count; i++)
                    {
                        if (computerPlayer.BotCards[i] == 11)
                        {
                            computerPlayer.BotCards[i] = 1;
                        }
                    }
                }
            }
        }
    }
}