using System.Collections;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace G_NET_12_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            #region Question 1

            //a) A University has Departments. If the university is closed,
            //the departments no longer exist.
            //the answer : composition

            #endregion

            #region Question 2

            //b) A Driver uses a Car.The driver does not own the car.
            //the Answer : Association

            #endregion

            #region Question 3

            //c) A Dog is an Animal
            //the answer : Inheritance

            #endregion

            #region Question 4

            //d) A Team has Players. If the team is deleted, the players still exist.
            //the Answer : Aggregation

            #endregion

            #region Question 5

            //e) A method receives a Logger as a parameter and calls it inside the method only.
            //the answer : Dependency
            #endregion

            #endregion

            #region Part 2

            //a) A parent class has a protected field.Can a child class in a different assembly
            //access it? What about through an object instance from outside?
            //Answer : yes the child can Access it And Can Take A instance 

            //b) What is the difference between protected internal and private protected?
            //Answer : Protected Internal ==> Accessiable anywhere in The Same Assembly or different
            //         private Protected ==> Accessable in the same Assembly and the same class Only

            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            //answer : When applyed to class cannot innherit from this class
            //And when on the method if you inherit from this class the method doesnot inherit

            //d) Can you create an object from a sealed class using new? Why or why not?
            //Answer : yes you can sealed Prevent inherit only

            #endregion

            #region Part 3
            Cinema cinema = new Cinema("Galaxy");

            cinema.OpenCinema();

            StandardTicket t1 = new StandardTicket("Inception", 120, "A-5");
            VIPTicket t2 = new VIPTicket("Avengers", 150, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            Console.WriteLine("\n========== Statistics ==========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

            Console.WriteLine("\nBooking Ref 1: BK-1");
            Console.WriteLine("Booking Ref 2: BK-2");

            Console.WriteLine("\nGroup Discount (5 × 100 EGP): 450 EGP (10% off)");

            cinema.CloseCinema();
        }

            #endregion
    }
}

