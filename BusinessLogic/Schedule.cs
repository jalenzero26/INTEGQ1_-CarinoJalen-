using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace BusinessLogic
{
    public class Schedule
    {
        public void shwSched()
        {
            Console.Title = "Showing Schedule";
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("        LIST OF SCHEDULE        ");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("[My Schedule]");
            Console.WriteLine("--------------------------------");

            //assuming we have a current course
            Console.WriteLine("List of Sched\n");
            Console.WriteLine("(1) [Object Oriented Programming]");
            Console.WriteLine("(2) [Human Computer Interaction]");
            Console.WriteLine("(3) Add Schedule");
            Console.WriteLine();
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\n-----------------------------------------------------------------");
                Console.WriteLine("Subject Code: RES00021");
                Console.WriteLine("Subject     : [Quantitative Method with Modeling and Simulation]");
                Console.WriteLine("Day         : Monday" );
                Console.WriteLine("Time        : 8AM - 11AM" );
                Console.WriteLine("Room        : ROOM 403" );
                Console.WriteLine("Professor   : Jalen Carino" );
                Console.WriteLine("Course      : BSIT");
                Console.WriteLine("\n-----------------------------------------------------------------");
            }
            if (choice == 2)
            {
                Console.WriteLine("\n-----------------------------------------------------------------");
                Console.WriteLine("Subject Code: COMP0021");
                Console.WriteLine("Subject     : [Object Oriented Programming]");
                Console.WriteLine("Day         : Saturday");
                Console.WriteLine("Time        : 2PM - 5PM");
                Console.WriteLine("Room        : ROOM 201");
                Console.WriteLine("Professor   : Jalen Carino");
                Console.WriteLine("Course      : DICT");
                Console.WriteLine("\n-----------------------------------------------------------------");
            }
            if (choice == 3)
            {
                Scheduling createSched = new Scheduling();
                createSched.sched();

            }
                Console.WriteLine();


        }

    }
}
