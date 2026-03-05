using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP03
{
    internal class Ticket
    {
        public string MovieName { get; set; }

        protected decimal price;
        public decimal Price
        {  get { return price; }

           set {  if (value > 0) price = value; } }
        public int TicketId { get; set; }
        private static int counter = 0;
        public Ticket(string movieName  , decimal price)
        {
            MovieName = movieName;
            Price = price;
            counter++;
            TicketId = counter;
        }
        public Decimal PriceAfterTax
        {
            get { return Price + (Price * 0.14m); }
        }
        public static int GetTotalTickets()
        {
            return counter;
        }
        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
    }
}
