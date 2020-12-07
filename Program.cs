using System;
using DeckOfCards.Models;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck poker = new Deck();
            // foreach(var bus in poker.Look)
            // {
            //     Console.WriteLine(bus.Val);
            // };
            Console.WriteLine(poker);
            Player Adam = new Player("Adam");
            Console.WriteLine(Adam.Name);
            poker.Shuffle();
            // var these = poker.Look;
            // foreach(var bus in poker.Look)
            // {
            //     Console.WriteLine(bus.Val);
            // };
            Adam.Draw(poker);
            Adam.Draw(poker);
            Adam.Draw(poker);
            Adam.Discard(0);
            Adam.Display();
        }
    }
}
