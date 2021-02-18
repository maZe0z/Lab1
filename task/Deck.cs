using System;
using System.Collections.Generic;

namespace task
{
    public class Deck
    {
        private List<int> _cards = new List<int>()
        {
            2,2,2,2,
            3,3,3,3,
            4,4,4,4,
            6,6,6,6,
            7,7,7,7,
            8,8,8,8,
            9,9,9,9,
            10,10,10,10,
            11,11,11,11
        }; //creating an array which contains all the cards

        public List<int> Cards
        {
            get => _cards;
            set => _cards = value;
        }

        public void Shuffle(){  //function which shuffles the whole array 
            Random rand = new Random();
 
            for (int i = _cards.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                
                int tmp = _cards[j];
                _cards[j] = _cards[i];
                _cards[i] = tmp;
            }
        }
    }
}