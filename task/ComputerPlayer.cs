using System;
using System.Collections.Generic;

namespace task
{
    public class ComputerPlayer
    {
        private int Score { get; set; }
     
        private List<int> _botCards = new List<int>();
        
        public List<int> BotCards
        {
            get => _botCards;
            set => _botCards = value;
        }

        public string BotName { get; set; }
        
        public void DrawCard(Deck deck)
        {
            _botCards.Add(deck.Cards[0]);
            deck.Cards.RemoveAt(0);
        }
        
        public void SetFirsCards(Deck deck)
        {
            _botCards.Add(deck.Cards[1]);
            _botCards.Add(deck.Cards[3]);
            deck.Cards.RemoveAt(1);
            deck.Cards.RemoveAt(3);
            
            Console.WriteLine(BotName + " also has two cards\n");
        }
        
        public void ShowHand()
        {
            Console.WriteLine("\nBob's hand:\n");

            foreach (var t in _botCards)
            {
                switch (t)
                {
                    case 1:
                        Console.WriteLine("Card: Ace (1 point)");
                        break;
                    case 2:
                        Console.WriteLine("Card: Jack (2 points)");
                        break;
                    case 3:
                        Console.WriteLine("Card: Lady (3 points)");
                        break;
                    case 4:
                        Console.WriteLine("Card: King (4 points)");
                        break;
                    case 6:
                        Console.WriteLine("Card: Six (6 points)");
                        break;
                    case 7:
                        Console.WriteLine("Card: Seven (7 points)");
                        break;
                    case 8:
                        Console.WriteLine("Card: Eight (8 points)");
                        break;
                    case 9:
                        Console.WriteLine("Card: Nine (9 points)");
                        break;
                    case 10:
                        Console.WriteLine("Card: Ten (10 points)");
                        break;
                    case 11:
                        Console.WriteLine("Card: Ace (11 points)");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
        
        public int CountScore()
        {
            Score = 0;
            
            foreach (var t in _botCards)
            {
                Score += t;
            }

            return Score;
        }
    }
}