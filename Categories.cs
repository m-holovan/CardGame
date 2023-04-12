using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Categories
    {
        //create list of decks category
        public List<Deck> decks_category = new List<Deck>();

        //method to add new deck by player
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

        //method for player`s choice of category
        public void ChooseCategory()
        {
            Console.WriteLine("\nChoose category");
            //this loop show all decks category
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
                Environment.Exit(0);//if player want to close the game
            }
            else
            {
                Console.WriteLine("\nHow many cards you want?");
                Console.Write("\nYour number:");
                int num_cards = Convert.ToInt32(Console.ReadLine());
                //here player can choose how many cards he want to see
                for (int i = 0; i < decks_category.Count; i++)
                {
                    if (decks_category[i].category == category)
                    {
                        decks_category[i].ShowCards(num_cards);
                    }
                }
            }
        }
        //constructor to add new deck
        public void AddDeck(string deck_name)
        {
            Deck newDeck = new Deck(deck_name);
            decks_category.Add(newDeck);
        }
    }
}
