using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP03
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50;

        public VIPTicket(string movie, decimal price, bool lounge) : base(movie, price + 50)
        {
            LoungeAccess = lounge;
        }

        public override string ToString()
        {
            string loungeText = LoungeAccess ? "Yes" : "No";
            return base.ToString() + $" | Lounge: {loungeText} | Service Fee: 50 EGP";
        }
    }
}
