using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class CourseData
    {
        public void course()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("            COURSE              ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("(A) BSIT 2-1");
                Console.WriteLine("(B) DICT 2-1");
                Console.WriteLine("Enter your choice: ");
                string course = Console.ReadLine();



                if (course == "a")
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("         BSIT STUDENTS          ");
                    Console.WriteLine("--------------------------------");

                    var bsit = new List<string>
                {"Anabelle Cox", "Brody Jacobson", "Caspar Neal", "Corrina Blanchard", "Kunal Hogg",
                "Nettie Millington", "Rhydian Mcclain", "Shaquille Eastwood", "Thalia Bowden",
                "Tiffany Jarvis"};

                    foreach (var showStudent in bsit)
                    {
                        Console.WriteLine(showStudent);
                    }

                    Console.WriteLine("\n Press any key to back or ee to exit \n");
                    string loo = Console.ReadLine();

                    if (loo == "ee")
                    {

                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                    }


                }

                if (course == "b")
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("         DICT STUDENTS          ");
                    Console.WriteLine("--------------------------------");

                    var dict = new List<string>
                {"Alessandra Lees", "Amit Aldred", "Axel Cope", "Claudia Mccullough", "Ewen Bowden",
                 "Manveer Gilbert", "Mike Barry", "Piper Lott", "Rachael Mccartney", "Rajan Lowe", "Roman Lee", "Rzayjan Lewse"};

                    foreach (var showStudent in dict)
                    {
                        Console.WriteLine(showStudent);
                    }
                    Console.WriteLine("\n Type any key to back or ee to exit \n");
                    string loo = Console.ReadLine();

                    if (loo == "ee")
                    {

                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                    }

                }

            }
        }
    }
}
