using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Card
    {
        public Card(string word, string translation)
        {
            Word = word;
            Translation = translation;
        }
        public string GetWord()
        {
            return this.Word;
        }
        public void ChooseOperation()
        {
            Console.WriteLine("\nChoose operation:");
            Console.WriteLine("1.I remember");
            Console.WriteLine("2.Show translation");
            Console.Write("Your choice:");

            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                isRemember = true;
            }
            else if (operation == 2)
            {
                isRemember = false;
                Console.WriteLine("\nTranslation of this word");
                Console.WriteLine(GetTranslation());
            }
        }
        public string GetTranslation()
        {
            return this.Translation;
        }

        public bool isRemember = false;
        public string Word;
        public string Translation;
    }
}
