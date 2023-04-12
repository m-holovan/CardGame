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

        //method to show cards
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

        //create list of cards
        List<Card> card_set = new List<Card>();
        //add card from keyboard by user
        public void AddCard()
        {
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();

            Console.WriteLine("Enter translation:");
            string translation = Console.ReadLine();

            Card newCard = new Card(word, translation);
            card_set.Add(newCard);
        }
        //add new card in deck from constructor
        public void AddCard(string word, string translation)
        {
            Card newCard = new Card(word, translation);
            card_set.Add(newCard);
        }
    }
}
