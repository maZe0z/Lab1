using System;
using System.Collections.Generic;

namespace task
{
    public class Player
    {
        public int Score { get; set; }
        public string Name { get; set; }

        private List<int> playerCards = new List<int>();

        public void SetFirsCards(Deck deck)
        {
            playerCards.Add(deck.Cards[0]);
            playerCards.Add(deck.Cards[2]);
            deck.Cards.RemoveAt(0);
            deck.Cards.RemoveAt(2);
            
            Console.WriteLine("\nYou have two cards in your hand.");
        }

        public void ShowHand()
        {
            Console.WriteLine("Your hand is:");
            
            for (int i = 0; i < playerCards.Count; i++)
            {
                Console.WriteLine(playerCards[i]);
            }
        }
        
        public void DrawCard(Deck deck)
        {
            playerCards.Add(deck.Cards[0]);
            deck.Cards.RemoveAt(0);
        }

        public int CountScore()
        {
            Score = 0;
            
            foreach (var t in playerCards)
            {
                Score += t;
            }

            return Score;
        }
    }
}