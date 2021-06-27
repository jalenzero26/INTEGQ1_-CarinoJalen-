using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using System.Threading;
namespace BusinessLogic
{
    public class ModifyStudent
    {
        public void modify()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("        MODIFY STUDENTS        ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("(1) Add Student");
            Console.WriteLine("(2) Remove Student \n");
            Console.WriteLine("Enter your choice: ");
            string load = Console.ReadLine();
            if (load == "1")
            {
                add();
            }
            else if (load == "2")
            {
                remove();
            }
        }
        public void add()
        {
            List<string> StudentList = new List<string>() {"CASPAR NEAL", "CORRINA BLANCHARD", "KUNAL HOGG",
                "NETTIE MILLINGTON", "RHYDIAN MCCLAIN", "SHAQUILLE EASTWOOD", "THALIA BOWDEN",
                "TIFFANY JARVIS"};

            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[Adding Students]");
            Console.WriteLine("--------------------------------");


            Console.WriteLine("How Many Students Want To Add?");
            int studentplus = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentplus; i++)
            {
                Console.WriteLine("Enter Student Name: ");
                string add = Console.ReadLine().ToUpper();
                // Add student inside the list 
                StudentList.Add(add);

            }
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("       SUCESSFULLY ADDED!");
            Console.WriteLine("          Please Wait");
            Console.WriteLine("--------------------------------");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[List of Students]");
            Console.WriteLine("--------------------------------");

            int day = 1;
            foreach (var Bsit in StudentList)
            {

                Console.WriteLine(day + " -- " + Bsit);
                day++;
            }


        }

        public void remove()
        {
            List<string> StudentList = new List<string>() {"CASPAR NEAL", "CORRINA BLANCHARD", "KUNAL HOGG",
                "NETTIE MILLINGTON", "RHYDIAN MCCLAIN", "SHAQUILLE EASTWOOD", "THALIA BOWDEN",
                "TIFFANY JARVIS"};

            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[List of Students]");
            Console.WriteLine("--------------------------------");
            int Day = 1;
            foreach (var Bsit in StudentList)
            {

                Console.WriteLine(Day + " -- " + Bsit);
                Day++;
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[Removing Students]");
            Console.WriteLine("--------------------------------");


            Console.WriteLine("How Many Students Want To Remove?");
            int studentminus = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentminus; i++)
            {
                Console.WriteLine("Select you want to remove: ");
                int minus = int.Parse(Console.ReadLine());
                // Add student inside the list 
                StudentList.RemoveAt(minus - 1);

            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("       SUCESSFULLY REMOVED!");
            Console.WriteLine("          Please Wait");
            Console.WriteLine("--------------------------------");
            Thread.Sleep(1500);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("[List of Students Updated]");
            Console.WriteLine("--------------------------------");

            int Days = 1;
            foreach (var Bsit in StudentList)
            {

                Console.WriteLine(Days + " -- " + Bsit);
                Days++;
            }


        }
        
    }
}
