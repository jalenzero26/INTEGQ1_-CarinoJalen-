using System;
using System.Collections.Generic;
using System.Text;

namespace UserInterface
{
    public class About
    {
        public void about()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("             ABOUT              ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("This is a simple class management system. \nGenerate flexible and reliable reports to \nmanage faculty and staff effectively.");

            Console.WriteLine("Back to Main Menu?");
            Console.WriteLine("Y/N?");
            string back = Console.ReadLine();
            bool y = true;
            bool Y = true;
            if (y && Y)
            {
                Menu menu = new Menu();
                Console.Clear();
                menu.shwMenu();
                
            }
            else
            {
                Environment.Exit(0);
            }
            
            
        }
    }
}
