using System;
using System.Collections.Generic;

namespace task
{
    public class Player
    {
        private int Score { get; set; }
        public string Name { get; set; }

        private List<int> _playerCards = new List<int>();
        
        public List<int> PlayerCards
        {
            get => _playerCards;
            set => _playerCards = value;
        }

        public void SetFirsCards(Deck deck)
        {
            _playerCards.Add(deck.Cards[0]);
            _playerCards.Add(deck.Cards[2]);
            deck.Cards.RemoveAt(0);
            deck.Cards.RemoveAt(2);
            
            Console.WriteLine("\nYou have two cards in your hand");
        }

        public void ShowHand()
        {
            Console.WriteLine("Your hand is:\n");

            foreach (var t in _playerCards)
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
        
        public void DrawCard(Deck deck)
        {
            _playerCards.Add(deck.Cards[0]);
            deck.Cards.RemoveAt(0);
        }

        public int CountScore()
        {
            Score = 0;
            
            foreach (var t in _playerCards)
            {
                Score += t;
            }

            return Score;
        }
    }
}