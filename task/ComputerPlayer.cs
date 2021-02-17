using System;
using System.Collections.Generic;

namespace task
{
    public class ComputerPlayer
    {
        public int Score { get; set; }
     
        private List<int> botCards = new List<int>();

        public string BotName { get; set; }
        
        public void DrawCard(Deck deck)
        {
            botCards.Add(deck.Cards[0]);
            deck.Cards.RemoveAt(0);
        }
        
        public void SetFirsCards(Deck deck)
        {
            botCards.Add(deck.Cards[1]);
            botCards.Add(deck.Cards[3]);
            deck.Cards.RemoveAt(1);
            deck.Cards.RemoveAt(3);
        }
        
        public int CountScore()
        {
            Score = 0;
            
            foreach (var t in botCards)
            {
                Score += t;
            }

            return Score;
        }
    }
}