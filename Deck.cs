using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Deck
    {
        public string category;

        public Deck(string deck_name)
        {
            category = deck_name;
        }

        public void ShowCards(int num_cards)
        {
            int i = 0;
            while (num_cards > 0 && i < card_set.Count)
            {
                if (card_set[i].isRemember)
                {
                    i++;
                    continue;
                }
                Console.WriteLine($"\n{card_set[i].GetWord()}");
                card_set[i].ChooseOperation();
                i++;
                num_cards--;
            }
        }

        List<Card> card_set = new List<Card>();
        public void AddCard()
        {
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();

            Console.WriteLine("Enter translation:");
            string translation = Console.ReadLine();

            Card newCard = new Card(word, translation);
            card_set.Add(newCard);
        }
        public void AddCard(string word, string translation)
        {
            Card newCard = new Card(word, translation);
            card_set.Add(newCard);
        }
    }
}
