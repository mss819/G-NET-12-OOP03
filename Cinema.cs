using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP03
{
    internal class Cinema
    {

        public string CinemaName { get; set; }
        private Projector projector;
        private Ticket[] tickets = new Ticket[20];

        public Cinema(string name)
        {
            CinemaName = name;
            projector = new Projector();
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    break;
                }
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========== All Tickets ==========\n");

            foreach (var t in tickets)
            {
                if (t != null)
                    Console.WriteLine(t);
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n========== Cinema Closed ==========");
            projector.Stop();
        }

       
    }
}
