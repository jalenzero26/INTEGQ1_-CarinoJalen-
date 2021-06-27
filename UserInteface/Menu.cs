using System;
using DataLayer;
using BusinessLogic;
using System.Collections.Generic;

namespace UserInterface
{
    public class Menu
    {

        public void shwMenu()
        {
            Console.Title = "Faculty Class Management Menu";
            Console.WriteLine("--------------------------------");
            Console.WriteLine("             MENU               ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("(1) [Create Course Schedule]");
            Console.WriteLine("(2) [Course Student List]");
            Console.WriteLine("(3) [Faculty Member List]");
            Console.WriteLine("(4) [My Schedule]");
            Console.WriteLine("(5) [Modify Students]");
            Console.WriteLine("(6) [FacultyAdd]");
            Console.WriteLine("(7) [About]");
            Console.WriteLine("(8) [Exit]");
            Console.WriteLine();
            Console.WriteLine("Select Choice: ");
            string load = Console.ReadLine();

            if (load == "1")
            {
                Scheduling shwsched = new Scheduling();
                shwsched.sched();
            }
            else if (load == "2")
            {
                CourseData shwcourse = new CourseData();
                shwcourse.course();
            }
            else if (load == "3")
            {
                FacultyData faculty = new FacultyData();
                faculty.shwFaculty();
            }
            else if (load == "4")
            {
                Schedule schedd = new Schedule();
                schedd.shwSched();
            }
            else if (load == "5")
            {
                ModifyStudent modify = new ModifyStudent();
                modify.modify();
            }
            else if (load == "6")
            {
                FacultyD faculty = new FacultyD();
                faculty.Insert();
            }
            else if (load == "7")
            {
                About shwabout = new About();
                shwabout.about();
            }
            
            else if (load == "8")
            {
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
            }
        }
    }
}
