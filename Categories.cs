using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Categories
    {
        public List<Deck> decks_category = new List<Deck>();

        public void AddDeckMenu()
        {
            Console.WriteLine("Enter name of the deck:");
            string newNameDeck = Console.ReadLine();
            AddDeck(newNameDeck);
            string word = "";
            while (word != "exit")
            {
                decks_category[decks_category.Count - 1].AddCard();
                Console.WriteLine("If you want one more word, write '+'.");
                Console.WriteLine("If you want exit, write 'exit'.");
                word = Console.ReadLine();
            }
        }
        public void ChooseCategory()
        {
            Console.WriteLine("\nChoose category");
            for (int i = 0; i < decks_category.Count; i++)
            {
                Console.WriteLine($"{decks_category[i].category}");
            }
            Console.WriteLine("To create new deck write 'add'.");
            Console.WriteLine("To exite game write 'exit game'.");
            Console.Write("\nYour choice:");
            string category = Console.ReadLine();
            if (category == "add")
            {
                AddDeckMenu();
            }
            else if (category == "exit game")
            {
                Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine("\nHow many cards you want?");
                Console.Write("\nYour number:");
                int num_cards = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < decks_category.Count; i++)
                {
                    if (decks_category[i].category == category)
                    {
                        decks_category[i].ShowCards(num_cards);
                    }
                }
            }
        }
        public void AddDeck(string deck_name)
        {
            Deck newDeck = new Deck(deck_name);
            decks_category.Add(newDeck);
        }
    }
}
