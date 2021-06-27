using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BusinessLogic
{
    public class Scheduling
    {
        public static List<string> chosenDays = new List<string>();
        public static List<string> chosenHour = new List<string>();

        List<int> RoomAv = new List<int>() { 100, 101, 102, };

        List<string> _profName = new List<string>() { "admin", "user", "default" };
        public void sched()
        {
            chosenDays.Clear();
            //Schedule,'
            Console.WriteLine();
            string prof = "Jalen Carino";

            Console.Title = "Creating Schedule";
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("       CREATING SCHEDULE        ");
            Console.WriteLine("--------------------------------");
            Thread.Sleep(1000);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("[Course]");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("SELECT COURSE\n");
            Console.WriteLine("(1) BSIT");
            Console.WriteLine("(2) DICT");
            Console.WriteLine();
            Console.WriteLine("Select your choice: ");
            string sect = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[Subjects]");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("SELECT SUBJECT\n");
            Console.WriteLine("(3) Quantitative Method with Modeling and Simulation");
            Console.WriteLine("(4) Object Oriented Programming");
            Console.WriteLine("(5) Human Computer Interactions");
            Console.WriteLine("(6) Network Administration");
            Console.WriteLine("(7) Information Management");
            Console.WriteLine();
            Console.WriteLine("Select your choice: ");
            string choice = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[Room]");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Available Rooms \n");
            Console.WriteLine("(1) Room 201");
            Console.WriteLine("(2) Room 202");
            Console.WriteLine("(3) Room 303");
            Console.WriteLine("(4) Room 304");
            Console.WriteLine("(5) Room 403");
            Console.WriteLine("(6) Room 404");
            Console.WriteLine("(7) Room 505");
            Console.WriteLine();
            Console.WriteLine("Select your choice: ");
            
            //List room available
            var listRoom = new List<string>
                {"ROOM 201", "ROOM 202", "ROOM 303", "ROOM 304", "ROOM 403", "ROOM 404", "ROOM 505"};
            int room = Convert.ToInt32(Console.ReadLine());


            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[Time]");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("SELECT TIME\n");
            Console.WriteLine("Format Time [Hours (AM/PM)]");

            var listTime = new List<string>
                {"8AM - 11AM", "11AM - 2PM", "2PM - 5PM", "5PM - 8PM"};
            Console.Clear();
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[Time]");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("List of Available Time \n");
            Console.WriteLine(listTime[0]);
            Console.WriteLine(listTime[1]);
            Console.WriteLine(listTime[2]);
            Console.WriteLine(listTime[3]);
            Console.WriteLine();


            Console.WriteLine();

            int numHours = 1;
            Console.WriteLine("SELECT TIME\n");
            foreach (var time in listTime)
            {
                Console.WriteLine("(" + numHours + ")" + time);
                numHours++;
            }


            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter your choice: ");
                int inputNum2 = Convert.ToInt32(Console.ReadLine());
                string Hour = listTime[inputNum2 - 1];

                chosenHour.Add(Hour);
            }



            //List of days
            var listDays = new List<string>
            {"Monday", "Tuesday", "Wednesday", "Thursday", "Frieday",
            "Saturday", "Sunday"};

            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("[Day]");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("SELECT DAY");
            Console.WriteLine();

            //Entering Number of days
            Console.WriteLine("How many days you want?");
            int NumberofDays = Convert.ToInt32(Console.ReadLine());

            int numDay = 1;
            Console.WriteLine("Choices\n");
            foreach (var day in listDays)
            {
                Console.WriteLine("(" + numDay + ")" + " - " + day);
                numDay++;
            }


            for (int i = 0; i < NumberofDays; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Select your day:");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                string days = listDays[inputNum - 1];

                chosenDays.Add(days);
            }

            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("          THANK YOU!");
            Console.WriteLine("----------------------------------");
            Thread.Sleep(800);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" WE ARE GENERATING YOUR SCHEDULE!");
            Console.WriteLine("          Please Wait...   ");
            Console.WriteLine("----------------------------------");
            Thread.Sleep(5000);

            Console.Clear();
            if (choice == "3")
            {
                summ();

                Console.WriteLine("\n-----------------------------------------------------------------");
                Console.WriteLine("Subject Code: RES00021");
                Console.WriteLine("Subject     : [Quantitative Method with Modeling and Simulation]");
                foreach (var displayDays in chosenDays)
                {
                    Console.WriteLine("Day         : " + displayDays);
                }
                    foreach (var displayHour in chosenHour)
                {
                    Console.WriteLine("Time        : " + displayHour);
                }
                Console.WriteLine("Room        : " + listRoom[room - 1]);
                Console.WriteLine("Professor   : " + prof);
                if (sect == "1")
                {
                    Console.WriteLine("Course      : BSIT");
                }
                else
                {
                    Console.WriteLine("Course      : DICT");
                }

                Console.WriteLine("\n-----------------------------------------------------------------");
                
            }

            if (choice == "4")
            {
                summ();
                Console.WriteLine("\n-----------------------------------------------------------------");
                Console.WriteLine("Subject Code: COMP0021");
                Console.WriteLine("Subject     : [Object Oriented Programming]");
                foreach (var displayDays in chosenDays)
                {
                    Console.WriteLine("Day         : " + displayDays);
                }
                foreach (var displayHour in chosenHour)
                {
                    Console.WriteLine("Time        : " + displayHour);
                }
                Console.WriteLine("Room        : " + listRoom[room - 1]);
                Console.WriteLine("Professor   : " + prof);
                if (sect == "1")
                {
                    Console.WriteLine("Course      : BSIT");
                }
                else
                {
                    Console.WriteLine("Course      : DICT");
                }
                
                Console.WriteLine("\n-----------------------------------------------------------------");

            }


            if (choice == "5")
            {
                summ();
                Console.WriteLine("\n-----------------------------------------------------------------");
                Console.WriteLine("Subject Code: HUMC0021");
                Console.WriteLine("Subject     : [Human Computer Interaction]");
                foreach (var displayDays in chosenDays)
                {
                    Console.WriteLine("Day         : " + displayDays);
                }
                foreach (var displayHour in chosenHour)
                {
                    Console.WriteLine("Time        : " + displayHour);
                }
                Console.WriteLine("Room        : " + listRoom[room - 1]);
                Console.WriteLine("Professor   : " + prof);
                if (sect == "1")
                {
                    Console.WriteLine("Course      : BSIT");
                }
                else
                {
                    Console.WriteLine("Course      : DICT");
                }
                
                Console.WriteLine("\n-----------------------------------------------------------------");

            }
            if (choice == "6")
            {
                summ();
                Console.WriteLine("\n-----------------------------------------------------------------");
                Console.WriteLine("Subject Code: NETA0119");
                Console.WriteLine("Subject     : [Network Administration]");
                foreach (var displayDays in chosenDays)
                {
                    Console.WriteLine("Day         : " + displayDays);
                }
                foreach (var displayHour in chosenHour)
                {
                    Console.WriteLine("Time        : " + displayHour);
                }
                Console.WriteLine("Room        : " + listRoom[room - 1]);
                Console.WriteLine("Professor   : " + prof);
                if (sect == "1")
                {
                    Console.WriteLine("Course      : BSIT");
                }
                else
                {
                    Console.WriteLine("Course      : DICT");
                }
                
                Console.WriteLine("\n-----------------------------------------------------------------");

            }
            if (choice == "7")
            {
                summ();
                Console.WriteLine("\n-----------------------------------------------------------------");
                Console.WriteLine("Subject Code: INFM3287");
                Console.WriteLine("Subject     : [Information Management]");
                foreach (var displayDays in chosenDays)
                {
                    Console.WriteLine("Day         : " + displayDays);
                }
                foreach (var displayHour in chosenHour)
                {
                    Console.WriteLine("Time        : " + displayHour);
                }
                Console.WriteLine("Room        : " + listRoom[room - 1]);
                Console.WriteLine("Professor   : " + prof);
                if (sect == "1")
                {
                    Console.WriteLine("Course      : BSIT");
                }
                else
                {
                    Console.WriteLine("Course      : DICT");
                }

                Console.WriteLine("\n-----------------------------------------------------------------");

            }
            
          
        }

        public static void summ()
        {
            Console.WriteLine("____ 	   ___ ___ ___ ___   ____  ____       ");
            Console.WriteLine("|    | 	 | |  |  | |  |  |  |    | |   | |   |");
            Console.WriteLine("|__  |	 | |  |  | |  |  |  |    | |___| |___|");
            Console.WriteLine("   | |	 | |     | |     |  |====| | |      |");
            Console.WriteLine("___| |___| |     | |     |  |    | |  |  ___|");
        }



        



    }
}
