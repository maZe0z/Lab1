using System;
using System.Collections.Generic;

namespace task
{
    public class Deck
    {
        private List<int> cards = new List<int>()
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
            get => cards;
            set => cards = value;
        }

        public void Shuffle(){  //function which shuffles the whole array 
            Random rand = new Random();
 
            for (int i = cards.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                
                int tmp = cards[j];
                cards[j] = cards[i];
                cards[i] = tmp;
            }
        }
    }
}