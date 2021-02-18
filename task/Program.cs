using System;

namespace task
{
    static class Program
    {
        static void Main()
        {
            Game game = new Game();
            
            Deck deck = new Deck();
            deck.Shuffle();
            
            Player player = new Player();
            
            Console.Write("Enter a player's name:");
            player.Name = Console.ReadLine();
            player.SetFirsCards(deck);

            ComputerPlayer computerPlayer = new ComputerPlayer {BotName = "Bob"};
            computerPlayer.SetFirsCards(deck);
            
            string keepPlaying = "Y";

            while (keepPlaying == "Y")
            {
                player.ShowHand();
                
                Console.WriteLine("\n" + player.Name + " has scored " + player.CountScore() + " in total");
                
                Console.WriteLine(computerPlayer.BotName + " has scored " + computerPlayer.CountScore() + " in total\n");
                
                if (player.CountScore() > 21)
                {
                    break;
                }

                if (computerPlayer.CountScore() < 17)
                {
                    computerPlayer.DrawCard(deck);
                }

                Console.Write("Would you like to draw another card? ");

                keepPlaying = Console.ReadLine();

                if (keepPlaying == "Y")
                {
                    player.DrawCard(deck);
                }
                
            }

            while (computerPlayer.CountScore() < 17)
            {
                computerPlayer.DrawCard(deck);
            }
            
            game.ChangeElevens(player);
            game.ChangeElevens(player, computerPlayer);

            computerPlayer.ShowHand();
            
            Console.WriteLine("\nYour final score is: " + player.CountScore());
            Console.WriteLine(computerPlayer.BotName + "'s final score is: " + computerPlayer.CountScore());
            
            game.CheckWinCondition(player,computerPlayer);
        }
    }
}