using System;
using System.Net.NetworkInformation;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();
            
            Deck deck = new Deck();
            deck.Shuffle();
            
            Player player = new Player();
            
            Console.Write("Enter a player's name:");
            player.Name = Console.ReadLine();
            player.SetFirsCards(deck);
            
            ComputerPlayer computerPlayer = new ComputerPlayer();
            computerPlayer.BotName = "Bob";
            computerPlayer.SetFirsCards(deck);
            
            string keepPlaying = "Y";

            while (keepPlaying == "Y")
            {
                player.ShowHand();
                Console.WriteLine("Your current score is: " + player.CountScore());
                
                if (player.CountScore() > 21)
                {
                    break;
                }
                
                Console.WriteLine(computerPlayer.BotName + " has scored " + computerPlayer.CountScore() + " in total");

                if (computerPlayer.CountScore() < 17)
                {
                    computerPlayer.DrawCard(deck);
                }
                else
                {
                    Console.WriteLine(computerPlayer.BotName + " has stopped drawing cards");
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
            Console.WriteLine(computerPlayer.BotName + " has scored " + computerPlayer.CountScore() + " in total");
            
            computerPlayer.ShowHand();
            
            game.CheckWinCondition(player,computerPlayer);
            
        }
    }
}