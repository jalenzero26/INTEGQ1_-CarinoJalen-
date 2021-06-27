using System;
using System.Collections.Generic;
using System.Text;
using DLayer;
namespace BusinessLogic
{
    public class FacultyD
    {
        public void Insert()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("        Facultuy Add        ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Faculty Member Name: ");
            string membername = Console.ReadLine();
            Console.WriteLine("Faculty ID: ");
            string facultyid = Console.ReadLine();
            SqlConnect.connect(membername, facultyid);

        }
    }
}
