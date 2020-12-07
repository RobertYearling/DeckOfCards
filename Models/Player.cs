using System;
using System.Collections.Generic;

namespace DeckOfCards.Models
{
    public class Player
    {
        public string Name;
        List<Card> Hand;

        public Player(string Name)
        {
            this.Name = Name;
            Hand = new List<Card>();
        }
        public Card Draw(Deck name)
        {
            Card SelectedCard = name.Deal();
            Console.WriteLine($"{Name} Drew: {SelectedCard.Val} of {SelectedCard.Suit}.");
            Hand.Add(SelectedCard);
            return SelectedCard;
        }

        public Card Discard(int index)
        {
            if(index > Hand.Count || index < 0)
            {
                Console.WriteLine("There is not enough cards.");
                return null;
            }
            else
            {
                Card removedCard = Hand[index];
                Console.WriteLine($"{Name} removed {removedCard.Val} of {removedCard.Suit} at the {index} position.");
                Hand.RemoveAt(index);
                return removedCard;
            }
        }

        public void Display()
        {
            foreach(var beetle in Hand)
            {
                Console.WriteLine($"Cards in Hand {beetle.Val} of {beetle.Suit}.");
            };
        }

    }
}