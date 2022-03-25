using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            Console.Write("Enter the number of cards to pick: ");

            line = Console.ReadLine();

            if(int.TryParse(line, out int numberOfCards))
            {
                string[] allTheCards = CardPicker.PickSomeCards(numberOfCards);

                foreach(string card in allTheCards)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("welp, that isn't a number");
            }
        }
    }
}
