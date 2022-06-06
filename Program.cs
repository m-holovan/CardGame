using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Categories category = new Categories();

            category.AddDeck("Animals");
            category.AddDeck("Professions");
            category.AddDeck("Vegetables");

            category.decks_category[0].AddCard("Giraffe", "Жираф");
            category.decks_category[0].AddCard("Zebra", "Зебра");
            category.decks_category[0].AddCard("Reh", "Лось");
            category.decks_category[0].AddCard("Elch", "Олень");
            category.decks_category[0].AddCard("Hase", "Заяц");

            category.decks_category[1].AddCard("Schlosser", "Слесарь");
            category.decks_category[1].AddCard("Klempner", "Сантехник");
            category.decks_category[1].AddCard("Baumeister", "Строитель");
            category.decks_category[1].AddCard("Mason", "Каменщик");
            category.decks_category[1].AddCard("Programmierer", "Программист");

            category.decks_category[2].AddCard("Kartoffeln", "Картошка");
            category.decks_category[2].AddCard("Kohl", "Капуста");
            category.decks_category[2].AddCard("Eine Tomate", "Помидор");
            category.decks_category[2].AddCard("Zwiebel", "Лук");
            category.decks_category[2].AddCard("Rote Bete", "Свекла");

           
            while (true)
            {
                category.ChooseCategory();
            }
        }
    }
}
