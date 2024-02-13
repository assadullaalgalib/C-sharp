using System;

namespace exercise_106
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // Constructor to initialize the balance with the opening balance
            balance = openingBalance;
        }

        public override string ToString()
        {
            // Override the ToString method to return the card's balance
            return "The card has a balance of " + balance + " euros";
        }

        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card);
        }
    }
}
